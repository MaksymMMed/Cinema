using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Payments;
using Cinema.BLL.DTOs.Tickets;
using Cinema.BLL.Filtering.Tickets;

namespace Cinema.BLL.Interfaces;

public interface ITicketsService
{
    Task<Result<EntitiesWithTotalCount<TicketReadDto>>> Get(TicketsFilteringModel model);

    Task<Result<TicketReadDto>> GetById(Guid id);

    Task<Result<IEnumerable<ProductPriceDto>>> CalculateTicketsPricesAndValidate(CreateTicketsDto model);

    Task<Result<bool>> Create(CreateTicketsDto model, Guid? invoiceId = null, bool bypassValidation = false);

    Task<Result<bool>> Delete(Guid id);
}