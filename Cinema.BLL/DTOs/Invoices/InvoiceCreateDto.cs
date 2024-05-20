namespace Cinema.BLL.DTOs.Invoices;

public class InvoiceCreateDto
{
    public decimal Amount { get; set; }
    public bool IsPaid { get; set; }
}