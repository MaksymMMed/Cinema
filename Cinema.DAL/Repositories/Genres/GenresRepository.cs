using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Genres;

namespace Cinema.DAL.Repositories.Genres
{
    public class GenresRepository(AppDbContext dbContext) : GenericRepository<Genre, Guid>(dbContext), IGenresRepository;
}
