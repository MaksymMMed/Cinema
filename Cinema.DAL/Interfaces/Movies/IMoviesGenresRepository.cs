using Cinema.DAL.Entities;

namespace Cinema.DAL.Interfaces.Movies;

public interface IMoviesGenresRepository
{
    Task<bool> AnyByMovieIdAndGenreId(Guid movieId, Guid genreId);
    
    Task Add(MovieGenre movieGenre);

    Task AddRange(IEnumerable<MovieGenre> entities);

    Task Delete(MovieGenre entityToDelete);
}