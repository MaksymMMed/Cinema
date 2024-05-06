using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Halls;
using Cinema.BLL.Extensions;
using Cinema.BLL.Filtering.Halls;
using Cinema.BLL.Interfaces;
using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Halls;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Cinema.BLL.Services.Halls;
public class HallsService : BusinessService<Hall, Guid>, IHallsService
{
    public HallsService(IHttpContextAccessor httpContextAccessor, IHallsRepository repository, IMapper mapper
        ) : base(httpContextAccessor, repository, mapper)
    {
    }

    public async Task<Result<HallReadDto>> Create(HallCreateDto dto)
    {
        var hall = _mapper.Map<Hall>(dto);

        await _repository.Add(hall);
        
        var mappedHall = _mapper.Map<HallReadDto>(hall);
        return await Task.FromResult(Result<HallReadDto>.Success(mappedHall));
    }

    public Task<Result<EntitiesWithTotalCount<HallReadDto>>> Get(HallsFilteringModel model)
    {
        var query = _repository.GetQuery(include: q => q
            .Include(s => s.Sessions)
            .Include(t => t.Tickets));

        var totalCount = query.Count();
        query = query.SortByField(model).Paginate(model);

        var mappedHalls = query.ProjectTo<HallReadDto>(_mapper.ConfigurationProvider).ToList();

        var result = new EntitiesWithTotalCount<HallReadDto> { Items = mappedHalls, TotalCount = totalCount };
        return Task.FromResult(Result<EntitiesWithTotalCount<HallReadDto>>.Success(result));
    }

    public Task<Result<HallDetailReadDto>> GetById(Guid id)
    {
        // should getByIdWithInclude be used here? but it's throws an error
        var hall = _repository.GetQuery(include: q => q
                   .Include(s => s.Sessions)
                   .Include(t => t.Tickets))
            .FirstOrDefaultAsync(h => h.Id == id).Result;

        if (hall == null)
            return Task.FromResult(Result<HallDetailReadDto>.Fail($"Hall with id {id} not found"));

        var mappedHall = _mapper.Map<HallDetailReadDto>(hall);
        return Task.FromResult(Result<HallDetailReadDto>.Success(mappedHall));
    }
}
