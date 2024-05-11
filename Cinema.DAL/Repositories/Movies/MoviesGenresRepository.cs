using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Movies;

namespace Cinema.DAL.Repositories.Movies;

public class MoviesGenresRepository(AppDbContext dbContext)
    : GenericRepository<MovieGenre, Guid>(dbContext), IMoviesGenresRepository;