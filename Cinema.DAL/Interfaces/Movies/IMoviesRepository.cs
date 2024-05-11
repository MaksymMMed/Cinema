using Cinema.DAL.Entities;

namespace Cinema.DAL.Interfaces.Movies;

public interface IMoviesRepository : IGenericRepository<Movie, Guid>
{
    Task<MovieImageSet?> GetImageSet(Guid movieId);
    
    Task<MovieImageSet> UpdateImageSet(MovieImageSet imageSet);

    Task<MovieImageSet> AddImageSet(MovieImageSet imageSet);
}