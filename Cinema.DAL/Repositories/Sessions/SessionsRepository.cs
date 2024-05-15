using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Sessions;

namespace Cinema.DAL.Repositories.Sessions;

public class SessionsRepository(AppDbContext dbContext) : GenericRepository<Session, Guid>(dbContext), ISessionsRepository
{

}

