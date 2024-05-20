using Cinema.DAL.Entities;

namespace Cinema.DAL.Interfaces.Invoices;

public interface IInvoicesRepository : IGenericRepository<Invoice, Guid>
{
}