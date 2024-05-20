using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Tickets;
using Cinema.BLL.Extensions;
using Cinema.BLL.Filtering.Tickets;
using Cinema.BLL.Interfaces;
using Cinema.BLL.Utils;
using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Invoices;
using Cinema.DAL.Interfaces.Sessions;
using Cinema.DAL.Interfaces.Tickets;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;

namespace Cinema.BLL.Services.Tickets;

public class TicketsService : BusinessService<Ticket, Guid>, ITicketsService
{
    private readonly IInvoicesRepository _invoicesRepository;
    private readonly ISessionsRepository _sessionsRepository;
    private readonly UserManager<AspNetUser> _userManager;
    
    public TicketsService(
        IHttpContextAccessor httpContextAccessor, 
        ITicketsRepository ticketsRepository,
        IInvoicesRepository invoicesRepository,
        ISessionsRepository sessionsRepository,
        UserManager<AspNetUser> userManager,
        IMapper mapper
    ) : base(httpContextAccessor, ticketsRepository, mapper)
    {
        _invoicesRepository = invoicesRepository;
        _sessionsRepository = sessionsRepository;
        _userManager = userManager;
    }

    public async Task<Result<EntitiesWithTotalCount<TicketReadDto>>> Get(TicketsFilteringModel model)
    {
        var query = _repository
            .GetQuery(include: q => q
                .Include(t => t.Session)
                .ThenInclude(mg => mg.Movie)
                .Include(t => t.Session)
                .ThenInclude(mg => mg.Hall)
                .Include(t => t.Invoice)
                .ThenInclude(i => i.CreatedBy))
            .Filter(model);
        
        var totalCount = query.Count();
        query = query.SortByField(model).Paginate(model);

        var mappedMovies = await query.ProjectTo<TicketReadDto>(_mapper.ConfigurationProvider).ToListAsync();
        
        var result = new EntitiesWithTotalCount<TicketReadDto> { Items = mappedMovies, TotalCount = totalCount };
        return Result<EntitiesWithTotalCount<TicketReadDto>>.Success(result);
    }
    
    public async Task<Result<TicketReadDto>> GetById(Guid id)
    {
        var ticket = await _repository
            .GetQuery(include: q => q
                .Include(t => t.Session)
                .ThenInclude(mg => mg.Movie)
                .Include(t => t.Session)
                .ThenInclude(mg => mg.Hall)
                .Include(t => t.Invoice)
                .ThenInclude(i => i.CreatedBy))
            .ProjectTo<TicketReadDto>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(m => m.Id == id);
        
        return ticket == null 
            ? Result<TicketReadDto>.Fail($"Ticket with id {id} not found")! 
            : Result<TicketReadDto>.Success(ticket);
    }

    private async Task<Guid> CreateEmptyInvoice(string userId)
    {
        var emptyInvoice = new Invoice
        {
            Amount = 0,
            IsPaid = true
        };
        
        var user = await _userManager.FindByIdAsync(userId);
        if (user == null)
        {
            throw new Exception("User was not found");
        }
        
        emptyInvoice.RegisterCreation(user);
        await _invoicesRepository.Add(emptyInvoice);
        return emptyInvoice.Id;
    }

    private async Task<Result<bool>> ValidateTicketsToCreate(CreateTicketsDto model)
    {
        var sessionWithHall = await _sessionsRepository.GetByIdWithInclude(model.SessionId, include: q => q
            .Include(s => s.Hall));
        
        if (sessionWithHall == null)
            return Result<bool>.Fail("The session hall was not found.");

        var rowsData = HallUtils.DeserializeRowsData(sessionWithHall.Hall.RowsData);
        foreach (var seat in model.HallSeats)
        {
            try
            {
                var rowData = rowsData[seat.RowIndex];
                if(seat.Index < 0 || seat.Index >= rowData.Capacity)
                    return Result<bool>.Fail($"The hall's({sessionWithHall.HallId}) Row({seat.RowIndex}) " +
                                             $"does not contain Seat index: {seat.Index}.");
            }
            catch (IndexOutOfRangeException)
            {
                return Result<bool>.Fail(
                    $"The hall {sessionWithHall.HallId} does not contain Row with index: {seat.RowIndex}");
            }
        }
        
        return Result<bool>.Success(true);
    }
    
    private static bool IsCollisionConstraintViolation(DbUpdateException ex)
    {
        if (ex.InnerException is SqlException sqlEx)
        {
            // Returns true in case the collision constraint was violated
            return sqlEx.Number is 2601 or 2627;
        }

        return false;
    }

    public async Task<Result<bool>> Create(CreateTicketsDto model)
    {
        var validationResult = await ValidateTicketsToCreate(model);
        if (!validationResult.IsSuccess)
            return validationResult;
            
        var validInvoiceId = model.InvoiceId ?? await CreateEmptyInvoice(CurrentUserId!);
        
        var tickets = model.HallSeats.Select(m => new Ticket
            {
                SeatIndex = m.Index,
                RowIndex = m.RowIndex,
                SessionId = model.SessionId,
                InvoiceId = validInvoiceId
            })
            .ToList();

        try
        {
            await _repository.AddRange(tickets);
        }
        catch (DbUpdateException ex)
        {
            // Check if the exception is due to tickets collision
            if (IsCollisionConstraintViolation(ex))
                return Result<bool>.Fail(
                    "Tickets can not be created, as one or more of the desired seats are already booked.");
        }

        return Result<bool>.Success(true);
    }

    public async Task<Result<bool>> Delete(Guid id)
    {
        var ticket = await _repository.GetById(id);
        if(ticket == null)
            return Result<bool>.Fail($"Ticket with id {id} does not exist.");
            
        await _repository.Delete(ticket);
        return Result<bool>.Success(true);
    }
}