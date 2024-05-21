using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Invoices;
using Cinema.BLL.DTOs.Payments;
using Cinema.BLL.DTOs.Tickets;
using Cinema.BLL.Interfaces;
using Hangfire;
using Microsoft.Extensions.Configuration;
using Stripe;
using Stripe.Checkout;

namespace Cinema.BLL.Services.Purchase;

public class PurchaseService : IPurchaseService
{
    private readonly IInvoicesService _invoicesService;
    private readonly ITicketsService _ticketsService;
    private readonly IConfiguration _configuration;

    public PurchaseService(
        IInvoicesService invoicesService, 
        ITicketsService ticketsService, 
        IConfiguration configuration
    )
    {
        _invoicesService = invoicesService;
        _ticketsService = ticketsService;
        _configuration = configuration;
    }

    public async Task<Result<string>> PurchaseTickets(CreateTicketsDto model)
    {
        var calculationResult = await _ticketsService.CalculateTicketsPricesAndValidate(model);
        if (!calculationResult.IsSuccess)
            return Result<string>.Fail(calculationResult.Error!)!;
        var productPrices = calculationResult.Value.ToList();
        var totalPrice = productPrices.Sum(p => p.UnitPrice * p.Quantity);
        
        var invoiceDto = new InvoiceCreateDto
        {
            Amount = Convert.ToDecimal(totalPrice),
            IsPaid = false
        };
        var invoiceResult = await _invoicesService.Create(invoiceDto);
        if (!invoiceResult.IsSuccess)
            return Result<string>.Fail(invoiceResult.Error!)!;
        var createdInvoice = invoiceResult.Value;

        var ticketsResult = await _ticketsService.Create(model, createdInvoice.Id, bypassValidation: true);
        if(!ticketsResult.IsSuccess)
            return Result<string>.Fail(ticketsResult.Error!)!;

        // In case user won't pay tickets in 15 minutes the invoice and the tickets will be removed.
        BackgroundJob.Schedule(() => _invoicesService.DeleteInvoiceIfUnpaid(createdInvoice.Id),
            TimeSpan.FromMinutes(15));

        var checkout = new CheckoutDto
        {
            Products = productPrices,
            InvoiceId = createdInvoice.Id
        };
        var link = await CreateCheckoutSession(checkout);
        return Result<string>.Success(link);
    }
    
    private async Task<string> CreateCheckoutSession(CheckoutDto model)
    {
        var lineItems = model.Products.Select(product => new SessionLineItemOptions
        {
            PriceData = new SessionLineItemPriceDataOptions
            {
                UnitAmount = product.UnitPrice * 100,
                Currency = "uah",
                ProductData = new SessionLineItemPriceDataProductDataOptions
                {
                    Name = product.ProductName,
                },
            },
            Quantity = product.Quantity,
        }).ToList();
        
        var options = new SessionCreateOptions
        {
            LineItems = lineItems,
            Metadata = new Dictionary<string, string>{ {"invoiceId", model.InvoiceId.ToString()} },
            Mode = "payment",
            SuccessUrl = _configuration["Payments:SuccessPaymentUrl"],
            CancelUrl = _configuration["Payments:CanceledPaymentUrl"],
        };
        
        var service = new SessionService();
        var session = await service.CreateAsync(options);
        return session.Url;
    }

    private async Task HandleSuccessfulPayment(Session paymentIntent)
    {
        if (paymentIntent.Metadata.TryGetValue("invoiceId", out var invoiceId))
        {
            await _invoicesService.UpdatePaymentStatus(new Guid(invoiceId), true);
        }
    }

    public async Task<Result<string>> HandleStripeWebhookEvent(Event stripeEvent)
    {
        switch (stripeEvent.Type)
        {
            case Events.CheckoutSessionCompleted:
            {
                var paymentIntent = stripeEvent.Data.Object as Session;
                await HandleSuccessfulPayment(paymentIntent!);
                break;
            }
        }

        return Result<string>.Success(string.Empty);
    }
}