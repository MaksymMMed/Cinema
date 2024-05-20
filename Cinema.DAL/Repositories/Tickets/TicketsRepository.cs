using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Reviews;
using Cinema.DAL.Interfaces.Tickets;

namespace Cinema.DAL.Repositories.Tickets
{
    public class TicketsRepository(AppDbContext appDbContext) : GenericRepository<Ticket, Guid>(appDbContext), ITicketsRepository;
}
