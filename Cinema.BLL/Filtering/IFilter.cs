namespace Cinema.BLL.Filtering;

public interface IFilter<T> where T : class
{
    IQueryable<T> Filter(IQueryable<T> source);
}