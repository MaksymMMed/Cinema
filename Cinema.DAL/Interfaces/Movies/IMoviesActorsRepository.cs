using Cinema.DAL.Entities;

namespace Cinema.DAL.Interfaces.Movies;

public interface IMoviesActorsRepository : IGenericRepository<ActorMovie, Guid>
{
    
}