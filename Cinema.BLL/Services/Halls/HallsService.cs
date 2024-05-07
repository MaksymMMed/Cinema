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

    public async Task<Result<HallDetailReadDto>> Create(HallCreateDto dto)
    {
        var hall = _mapper.Map<Hall>(dto);

        await _repository.Add(hall);

        var mappedHall = _mapper.Map<HallDetailReadDto>(hall);
        return Result<HallDetailReadDto>.Success(mappedHall);
    }

    public async Task<Result<HallDetailReadDto>> Delete(Guid id)
    {
        var hall = await _repository.GetById(id);

        if (hall == null)
            return Result<HallDetailReadDto>.Fail($"Hall with id {id} not found");

        await _repository.Delete(hall);

        var mappedHall = _mapper.Map<HallDetailReadDto>(hall);
        return Result<HallDetailReadDto>.Success(mappedHall);
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
        var hall = await _repository.GetByIdWithInclude(id, include: q => q
                   .Include(s => s.Sessions)
                   .Include(t => t.Tickets));

        if (hall == null)
            return Result<HallDetailReadDto>.Fail($"Hall with id {id} not found");

        var mappedHall = _mapper.Map<HallDetailReadDto>(hall);
        return Result<HallDetailReadDto>.Success(mappedHall);
    }

    public async Task<Result<HallDetailReadDto>> Update(HallUpdateDto dto)
    {
        var hall = await _repository.GetById(dto.Id);

        if (hall == null)
            return Result<HallDetailReadDto>.Fail($"Hall with id {dto.Id} not found");

        _mapper.Map(dto, hall);

        var newHall = _repository.Update(hall).Result;

        var mappedHall = _mapper.Map<HallDetailReadDto>(newHall);
        return Result<HallDetailReadDto>.Success(mappedHall);
    }
}
