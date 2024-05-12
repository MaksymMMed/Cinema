using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Movies;
using Microsoft.EntityFrameworkCore;

namespace Cinema.DAL.Repositories.Movies;

public class MoviesRepository(AppDbContext dbContext) : GenericRepository<Movie, Guid>(dbContext), IMoviesRepository
{
    public async Task<MovieImageSet?> GetImageSet(Guid movieId)
    {
        return await DbContext.MovieImageSet.FindAsync(movieId);
    }
    
    public async Task<MovieImageSet> UpdateImageSet(MovieImageSet imageSet)
    {
        var existingEntity = await GetImageSet(imageSet.MovieId);
        if (existingEntity != null)
        {
            DbContext.Entry(existingEntity).State = EntityState.Detached;
        }
        DbContext.Update(imageSet);
        await DbContext.SaveChangesAsync();
        return imageSet;
    }
    
    public async Task<MovieImageSet> AddImageSet(MovieImageSet imageSet)
    {
        await DbContext.AddAsync(imageSet);
        await DbContext.SaveChangesAsync();
        return imageSet;
    }
}