namespace Cinema.BLL.DTOs.Halls;

public class HallCreateDto
{
    public string Name { get; set; }
    public IEnumerable<HallRowDataDto> RowsData { get; set; }
}
