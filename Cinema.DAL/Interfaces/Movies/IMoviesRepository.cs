using Cinema.DAL.Entities;

namespace Cinema.DAL.Interfaces.Movies;

public interface IMoviesRepository : IGenericRepository<Movie, Guid>
{
    
}