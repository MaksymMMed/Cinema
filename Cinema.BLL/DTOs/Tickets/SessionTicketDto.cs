namespace Cinema.BLL.DTOs.Tickets;

public class SessionTicketDto
{
    public Guid Id { get; set; }
    public Guid SessionId { get; set; }
    public int RowIndex { get; set; }
    public int SeatIndex { get; set; }
}