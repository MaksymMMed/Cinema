namespace Cinema.BLL.DTOs.Tickets;

public class InvoiceTicketDto
{
    public Guid Id { get; set; }
    public Guid SessionId { get; set; }
    public DateTime SessionDateUtc { get; set; }
    public Guid HallId { get; set; }
    public int RowIndex { get; set; }
    public int SeatIndex { get; set; }
}
