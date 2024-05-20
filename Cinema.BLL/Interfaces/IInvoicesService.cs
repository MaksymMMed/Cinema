using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Invoices;
using Cinema.BLL.Filtering.Invoices;

namespace Cinema.BLL.Interfaces;

public interface IInvoicesService
{
    Task<Result<EntitiesWithTotalCount<InvoiceReadDto>>> Get(InvoicesFilteringModel model);
    
    Task<Result<InvoiceDetailsReadDto>> GetById(Guid id);
    
    Task<Result<InvoiceReadDto>> Create(InvoiceCreateDto model);

    Task<Result<InvoiceReadDto>> UpdatePaymentStatus(Guid id, bool isPaid);

    Task<Result<bool>> Delete(Guid id);

    Task DeleteInvoiceIfUnpaid(Guid id);
}