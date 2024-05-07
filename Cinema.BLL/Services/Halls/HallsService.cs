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
        return Result<HallReadDto>.Success(mappedHall);
    }

    public async Task<Result<EntitiesWithTotalCount<HallReadDto>>> Get(HallsFilteringModel model)
    {
        var query = _repository.GetQuery(include: q => q
            .Include(s => s.Sessions)
            .Include(t => t.Tickets));

        var totalCount = query.Count();
        query = query.SortByField(model).Paginate(model);

        var mappedHalls = await query.ProjectTo<HallReadDto>(_mapper.ConfigurationProvider).ToListAsync();

        var result = new EntitiesWithTotalCount<HallReadDto> { Items = mappedHalls, TotalCount = totalCount };
        return Result<EntitiesWithTotalCount<HallReadDto>>.Success(result);
    }

    public async Task<Result<HallDetailReadDto>> GetById(Guid id)
    {
        // should getByIdWithInclude be used here? but it's throws an error
        var hall = await _repository.GetQuery(include: q => q
                   .Include(s => s.Sessions)
                   .Include(t => t.Tickets))
            .FirstOrDefaultAsync(h => h.Id == id);

        if (hall == null)
            return Result<HallDetailReadDto>.Fail($"Hall with id {id} not found");

        var mappedHall = _mapper.Map<HallDetailReadDto>(hall);
        return Result<HallDetailReadDto>.Success(mappedHall);
    }

    public async Task<Result<HallReadDto>> Update(Guid id, HallUpdateDto dto)
    {
        var hall = await _repository.GetQuery().FirstOrDefaultAsync(h => h.Id == id);

        if (hall == null)
            return Result<HallReadDto>.Fail($"Hall with id {id} not found");

        _mapper.Map(dto, hall);

        var newHall = _repository.Update(hall).Result;

        var mappedHall = _mapper.Map<HallReadDto>(newHall);
        return Result<HallReadDto>.Success(mappedHall);
    }
}
