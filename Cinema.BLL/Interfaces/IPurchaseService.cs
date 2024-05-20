using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Tickets;
using Stripe;

namespace Cinema.BLL.Interfaces;

public interface IPurchaseService
{
    Task<Result<string>> PurchaseTickets(CreateTicketsDto model);

    Task<Result<string>> HandleStripeWebhookEvent(Event stripeEvent);
}