using Cinema.DAL.Entities;

namespace Cinema.DAL.Interfaces.Movies;

public interface IMoviesActorsRepository
{
    Task<bool> AnyByMovieIdAndActorId(Guid movieId, Guid actorId);
    
    Task Add(ActorMovie movieGenre);

    Task AddRange(IEnumerable<ActorMovie> entities);

    Task Delete(ActorMovie entityToDelete);
}