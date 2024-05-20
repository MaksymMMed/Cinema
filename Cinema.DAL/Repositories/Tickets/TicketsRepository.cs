using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Movies;
using Cinema.DAL.Interfaces.Tickets;
using Microsoft.EntityFrameworkCore;

namespace Cinema.DAL.Repositories.Tickets;

public class TicketsRepository(AppDbContext dbContext) : GenericRepository<Ticket, Guid>(dbContext), ITicketsRepository
{
    public class TicketsRepository(AppDbContext appDbContext) : GenericRepository<Ticket, Guid>(appDbContext), ITicketsRepository;
}
