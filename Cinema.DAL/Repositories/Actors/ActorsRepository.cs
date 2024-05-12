using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Actors;

namespace Cinema.DAL.Repositories.Actors
{
    public class ActorsRepository(AppDbContext dbContext) : GenericRepository<Actor, Guid>(dbContext), IActorsRepository;
}
