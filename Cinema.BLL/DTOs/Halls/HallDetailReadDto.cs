using Cinema.BLL.DTOs.Sessions;
using Cinema.DAL.Entities;

namespace Cinema.BLL.DTOs.Halls;

public class HallDetailReadDto
{
    public Guid Id { get; set; }
    public int Capacity { get; set; }
    public IEnumerable<int> RowsCapacity { get; set; }
    public IEnumerable<SessionDateTimeReadDto> Sessions { get; set; }
    //public IEnumerable<Ticket> Tickets { get; set; }
}
