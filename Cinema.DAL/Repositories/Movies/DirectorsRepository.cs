using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Movies;

namespace Cinema.DAL.Repositories.Movies;

public class DirectorsRepository(AppDbContext dbContext)
    : GenericRepository<Director, Guid>(dbContext), IDirectorsRepository;