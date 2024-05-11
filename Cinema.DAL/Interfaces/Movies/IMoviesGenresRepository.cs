using Cinema.DAL.Entities;

namespace Cinema.DAL.Interfaces.Movies;

public interface IMoviesGenresRepository : IGenericRepository<MovieGenre, Guid>
{
    
}