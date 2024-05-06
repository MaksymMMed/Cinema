using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Halls;

namespace Cinema.DAL.Repositories.Halls;

public class HallsRepository(AppDbContext dbContext) : GenericRepository<Hall, Guid>(dbContext), IHallsRepository;
