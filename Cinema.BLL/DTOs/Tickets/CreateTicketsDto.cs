using Cinema.BLL.DTOs.Halls;

namespace Cinema.BLL.DTOs.Tickets;

public class CreateTicketsDto
{
    public Guid SessionId { get; set; }
    public IEnumerable<HallSeatDto> HallSeats { get; set; }
}