using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Invoices;

namespace Cinema.DAL.Repositories.Invoices;

public class InvoicesRepository(AppDbContext dbContext) : GenericRepository<Invoice, Guid>(dbContext), IInvoicesRepository
{
}