namespace Cinema.BLL.DTOs;

public class EntitiesWithTotalCount<T> where T : class
{
    public IEnumerable<T> Items { get; set; } = null!;
    public int TotalCount { get; set; }
}