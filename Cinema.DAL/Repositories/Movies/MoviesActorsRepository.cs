using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Movies;
using Microsoft.EntityFrameworkCore;

namespace Cinema.DAL.Repositories.Movies;

public class MoviesActorsRepository : IMoviesActorsRepository
{
    private readonly AppDbContext _dbContext;
    private readonly DbSet<ActorMovie> _moviesActors;

    public MoviesActorsRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        _moviesActors = dbContext.Set<ActorMovie>();
    }
    
    public async Task<bool> AnyByMovieIdAndActorId(Guid movieId, Guid actorId)
    {
        return await _moviesActors.AnyAsync(mg => mg.MovieId == movieId && mg.ActorId == actorId);
    }

    public async Task Add(ActorMovie movieGenre)
    {
        await _moviesActors.AddAsync(movieGenre);
        await _dbContext.SaveChangesAsync();
    }

    public async Task AddRange(IEnumerable<ActorMovie> entities)
    {
        await _moviesActors.AddRangeAsync(entities);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task Delete(ActorMovie entityToDelete)
    {
        if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
        {
            _dbContext.Attach(entityToDelete);
        }
        _dbContext.Remove(entityToDelete);
        await _dbContext.SaveChangesAsync();
    }
}