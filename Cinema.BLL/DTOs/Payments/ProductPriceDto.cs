namespace Cinema.BLL.DTOs.Payments;

public class ProductPriceDto
{
    public long UnitPrice { get; set; }
    public string ProductName { get; set; }
    public long? Quantity { get; set; }
}