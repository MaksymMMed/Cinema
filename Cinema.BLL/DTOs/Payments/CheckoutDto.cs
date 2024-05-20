namespace Cinema.BLL.DTOs.Payments;

public class CheckoutDto
{
    public IEnumerable<ProductPriceDto> Products { get; set; } 
    public Guid InvoiceId { get; set; }
}