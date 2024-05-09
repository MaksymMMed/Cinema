namespace Cinema.BLL.DTOs.Halls;

public class HallReadDto
{
    public Guid Id { get; set; }
    public int Capacity { get; set; }
    public int SessionsCount { get; set; }
    public int TicketsCount { get; set; }

}
