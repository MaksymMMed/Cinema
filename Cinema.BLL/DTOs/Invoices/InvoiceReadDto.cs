using Cinema.BLL.DTOs.Tickets;
using Cinema.DAL.Entities;
using System.ComponentModel.DataAnnotations;

namespace Cinema.BLL.DTOs.Invoices;

public class InvoiceReadDto
{
    public Guid Id { get; set; }
    public Guid CreatedById { get; set; }
    public decimal Amount { get; set; }
    public bool IsPaid { get; set; }
    public DateTime CreatedOnUtc { get; set; }
    public string CreatedByName { get; set; }
    public ICollection<InvoiceTicketDto> Tickets { get; set; }

}