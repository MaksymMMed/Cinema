namespace Cinema.BLL.DTOs.Tickets;

public class TicketReadDto
{
    public Guid Id { get; set; }
    public Guid SessionId { get; set; }
    public Guid UserId { get; set; }
    public int RowIndex { get; set; }
    public int PlaceIndex { get; set; }
}
