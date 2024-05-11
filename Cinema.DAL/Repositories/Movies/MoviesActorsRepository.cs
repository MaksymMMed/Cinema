using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Movies;

namespace Cinema.DAL.Repositories.Movies;

public class MoviesActorsRepository(AppDbContext dbContext)
    : GenericRepository<ActorMovie, Guid>(dbContext), IMoviesActorsRepository;