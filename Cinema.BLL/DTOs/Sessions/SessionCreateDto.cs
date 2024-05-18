namespace Cinema.BLL.DTOs.Sessions;

public class SessionCreateDto
{
    public Guid HallId { get; set; }
    public Guid MovieId { get; set; }
    public DateTime DateUtc { get; set; }
    public decimal BasePrice { get; set; }
}
