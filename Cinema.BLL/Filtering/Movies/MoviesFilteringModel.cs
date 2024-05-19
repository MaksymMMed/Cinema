using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cinema.BLL.Filtering.Movies;

public class MoviesFilteringModel : FilteringModel<Movie>, IFilter<Movie>
{
    public string? Name { get; set; }
    
    public Guid? DirectorId { get; set; }
    
    public DateTime? FromReleaseDate { get; set; }
    
    public DateTime? ToReleaseDate { get; set; }
    
    public IEnumerable<Guid>? GenresIds { get; set; }

    public IQueryable<Movie> Filter(IQueryable<Movie> source)
    {
        if (!string.IsNullOrEmpty(Name))
            source = source.Where(v => EF.Functions.Like(v.Name, $"%{Name}%"));
        
        if (DirectorId != null)
            source = source.Where(v => v.DirectorId == DirectorId);
        
        if (FromReleaseDate != null)
            source = source.Where(v => v.ReleaseDate >= FromReleaseDate);
        
        if (ToReleaseDate != null)
            source = source.Where(v => v.ReleaseDate <= ToReleaseDate);
        
        if (GenresIds != null && GenresIds.Any())
            source = source.Where(v => v.MovieGenres.Any(mg => GenresIds.Contains(mg.GenreId)));
        
        return source;
    }
}