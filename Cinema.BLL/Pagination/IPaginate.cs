namespace Cinema.BLL.Pagination;

public interface IPaginate<T> where T : class
{
    IQueryable<T> Paginate(IQueryable<T> source);
}