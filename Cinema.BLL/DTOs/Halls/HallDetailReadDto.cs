namespace Cinema.BLL.DTOs.Halls;

public class HallDetailReadDto
{
    public Guid Id { get; set; }
    public int Capacity { get; set; }
    public IEnumerable<int> RowsCapacity { get; set; }
}
