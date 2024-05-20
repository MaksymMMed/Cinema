using Cinema.DAL.Entities;

namespace Cinema.DAL.Interfaces.Tickets;

public interface ITicketsRepository : IGenericRepository<Ticket, Guid>
{
}
