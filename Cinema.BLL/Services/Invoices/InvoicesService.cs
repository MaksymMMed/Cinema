using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Invoices;
using Cinema.BLL.Extensions;
using Cinema.BLL.Filtering.Invoices;
using Cinema.BLL.Interfaces;
using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Invoices;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace Cinema.BLL.Services.Invoices;

public class InvoicesService : BusinessService<Invoice, Guid>, IInvoicesService
{
    private readonly UserManager<AspNetUser> _userManager;
    
    public InvoicesService(
        IHttpContextAccessor httpContextAccessor,
        IInvoicesRepository invoicesRepository,
        UserManager<AspNetUser> userManager,
        IMapper mapper
    ) : base(httpContextAccessor, invoicesRepository, mapper)
    {
        _userManager = userManager;
    }

    public async Task<Result<EntitiesWithTotalCount<InvoiceReadDto>>> Get(InvoicesFilteringModel model)
    {
        var query = _repository
            .GetQuery()
            .Filter(model);
        
        var totalCount = query.Count();
        query = query.SortByField(model).Paginate(model);

        var mappedInvoices = await query.ProjectTo<InvoiceReadDto>(_mapper.ConfigurationProvider).ToListAsync();
        
        var result = new EntitiesWithTotalCount<InvoiceReadDto> { Items = mappedInvoices, TotalCount = totalCount };
        return Result<EntitiesWithTotalCount<InvoiceReadDto>>.Success(result);
    }
    
    public async Task<Result<InvoiceDetailsReadDto>> GetById(Guid id)
    {
        var invoice = await _repository
            .GetQuery(include: q => q
                .Include(i => i.Tickets)
                .ThenInclude(t => t.Session))
            .ProjectTo<InvoiceDetailsReadDto>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(m => m.Id == id);
        
        return invoice == null 
            ? Result<InvoiceDetailsReadDto>.Fail($"Invoice with id {id} not found")! 
            : Result<InvoiceDetailsReadDto>.Success(invoice);
    }

    public async Task<Result<InvoiceReadDto>> Create(InvoiceCreateDto model)
    {
        var invoice = _mapper.Map<Invoice>(model);
        
        var user = await _userManager.FindByIdAsync(CurrentUserId!);
        if (user == null)
        {
            return Result<InvoiceReadDto>.Fail("User was not found")!;
        }
        
        invoice.RegisterCreation(user);
        await _repository.Add(invoice);
        var mappedInvoice = _mapper.Map<InvoiceReadDto>(invoice);
        return Result<InvoiceReadDto>.Success(mappedInvoice);
    }
    
    public async Task<Result<InvoiceReadDto>> UpdatePaymentStatus(Guid id, bool isPaid)
    {
        var invoice = await _repository.GetById(id);
        if(invoice == null)
            return Result<InvoiceReadDto>.Fail($"Invoice with id {id} not found")!;
        
        invoice.IsPaid = isPaid;
        await _repository.Update(invoice);
        var mappedInvoice = _mapper.Map<InvoiceReadDto>(invoice);
        return Result<InvoiceReadDto>.Success(mappedInvoice);
    }

    public async Task<Result<bool>> Delete(Guid id)
    {
        var invoice = await _repository.GetById(id);
        if(invoice == null)
            return Result<bool>.Fail($"Invoice with id {id} does not exist.");
            
        await _repository.Delete(invoice);
        return Result<bool>.Success(true);
    }
}