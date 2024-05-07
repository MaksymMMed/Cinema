namespace Cinema.BLL.DTOs.Halls;

public class HallUpdateDto
{
    public Guid Id { get; set; }
    public IEnumerable<int> RowsCapacity { get; set; }
}
