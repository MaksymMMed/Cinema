using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Movies;

namespace Cinema.DAL.Repositories.Movies;

public class MoviesRepository(AppDbContext dbContext) : GenericRepository<Movie, Guid>(dbContext), IMoviesRepository;