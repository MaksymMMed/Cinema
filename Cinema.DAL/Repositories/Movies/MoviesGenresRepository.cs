using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Movies;
using Microsoft.EntityFrameworkCore;

namespace Cinema.DAL.Repositories.Movies;

public class MoviesGenresRepository : IMoviesGenresRepository
{
    private readonly AppDbContext _dbContext;
    private readonly DbSet<MovieGenre> _moviesGenres;

    public MoviesGenresRepository(AppDbContext dbContext)
    {
        _dbContext = dbContext;
        _moviesGenres = dbContext.Set<MovieGenre>();
    }

    public async Task<bool> AnyByMovieIdAndGenreId(Guid movieId, Guid genreId)
    {
        return await _moviesGenres.AnyAsync(mg => mg.MovieId == movieId && mg.GenreId == genreId);
    }

    public async Task Add(MovieGenre movieGenre)
    {
        await _moviesGenres.AddAsync(movieGenre);
        await _dbContext.SaveChangesAsync();
    }

    public async Task AddRange(IEnumerable<MovieGenre> entities)
    {
        await _moviesGenres.AddRangeAsync(entities);
        await _dbContext.SaveChangesAsync();
    }
    
    public async Task Delete(MovieGenre entityToDelete)
    {
        if (_dbContext.Entry(entityToDelete).State == EntityState.Detached)
        {
            _dbContext.Attach(entityToDelete);
        }
        _dbContext.Remove(entityToDelete);
        await _dbContext.SaveChangesAsync();
    }
}