using Cinema.BLL.DTOs.Movies;

namespace Cinema.BLL.DTOs.Sessions;

public class SessionReadDto
{
    public Guid Id { get; set; }
    public MoviePreviewDto Movie { get; set; }
    public Guid HallId { get; set; }
    public DateTime StartDateUtc { get; set; }
    public DateTime EndDateUtc { get; set; }
    public decimal BasePrice { get; set; }
    public int TicketsCount { get; set; }
    public int HallCapacity { get; set; }
}
