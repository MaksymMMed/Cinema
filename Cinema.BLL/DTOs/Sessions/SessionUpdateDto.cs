namespace Cinema.BLL.DTOs.Sessions;

public class SessionUpdateDto
{
    public Guid Id { get; set; }
    public Guid HallId { get; set; }
    public Guid MovieId { get; set; }
    public DateTime DateUtc { get; set; }
}
