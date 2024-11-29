namespace Cinema.BLL.DTOs.Halls;

public class HallDetailReadDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public int Capacity { get; set; }
    public IEnumerable<HallRowDataDto> RowsData { get; set; }
}