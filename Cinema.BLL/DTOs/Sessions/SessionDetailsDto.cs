using Cinema.BLL.DTOs.Movies;
using Cinema.BLL.DTOs.Tickets;

namespace Cinema.BLL.DTOs.Sessions;

public class SessionDetailsDto
{
    public Guid Id { get; set; }
    public MoviePreviewDto Movie { get; set; }
    public Guid HallId { get; set; }
    public string HallName { get; set; }
    public DateTime StartDateUtc { get; set; }
    public DateTime EndDateUtc { get; set; }
    public decimal BasePrice { get; set; }
    public int TicketsCount { get; set; }
    public int HallCapacity { get; set; }
    public IEnumerable<SessionTicketDto> Tickets { get; set; }
    public IEnumerable<IEnumerable<bool>> Seats { get; set; }

}
