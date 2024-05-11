using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Directors;

namespace Cinema.DAL.Repositories.Directors
{
    public class DirectorsRepository(AppDbContext dbContext) : GenericRepository<Director, Guid>(dbContext), IDirectorsRepository;
}
