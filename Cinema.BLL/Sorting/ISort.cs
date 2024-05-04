namespace Cinema.BLL.Sorting;

public interface ISort<T> where T : class
{
    IQueryable<T> Sort(IQueryable<T> source);
}