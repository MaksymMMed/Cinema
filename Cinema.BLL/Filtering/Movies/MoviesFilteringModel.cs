using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cinema.BLL.Filtering.Movies;

public class MoviesFilteringModel : FilteringModel<Movie>, IFilter<Movie>
{
    public string? Name { get; set; }

    public IQueryable<Movie> Filter(IQueryable<Movie> source)
    {
        if (!string.IsNullOrEmpty(Name))
            source = source.Where(v => EF.Functions.Like(v.Name, "%a%"));
            
        return source;
    }
}