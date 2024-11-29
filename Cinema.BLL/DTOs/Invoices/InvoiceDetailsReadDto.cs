using Cinema.BLL.DTOs.Tickets;

namespace Cinema.BLL.DTOs.Invoices;

public class InvoiceDetailsReadDto
{
    public Guid Id { get; set; }
    public Guid CreatedById { get; set; }
    public decimal Amount { get; set; }
    public bool IsPaid { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    public string CreatedByName { get; set; }
    public ICollection<TicketDetailedDto> Tickets { get; set; }
}