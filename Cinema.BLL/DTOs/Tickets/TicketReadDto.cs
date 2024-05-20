using Cinema.BLL.DTOs.Movies;

namespace Cinema.BLL.DTOs.Tickets;

public class TicketReadDto
{
    public Guid Id { get; set; }
    public Guid SessionId { get; set; }
    public DateTime SessionDateUtc { get; set; }
    public TicketMovieDto Movie { get; set; }
    public Guid HallId { get; set; }
    public string HallName { get; set; }
    public Guid PurchasedById { get; set; }
    public string PurchasedByName { get; set; }
    public int RowIndex { get; set; }
    public int SeatIndex { get; set; }
    public Guid InvoiceId { get; set; }
}
