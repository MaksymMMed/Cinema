namespace Cinema.BLL.DTOs.Halls;

public class HallUpdateDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public IEnumerable<HallRowDataDto> RowsData { get; set; }
}
