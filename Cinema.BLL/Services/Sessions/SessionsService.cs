using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Sessions;
using Cinema.BLL.Extensions;
using Cinema.BLL.Filtering.Sessions;
using Cinema.BLL.Interfaces;
using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Sessions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Cinema.BLL.Services.Sessions;

public class SessionsService(
   IHttpContextAccessor httpContextAccessor,
   ISessionsRepository repository,
   IMapper mapper
   ) : BusinessService<Session, Guid>(httpContextAccessor, repository, mapper), ISessionsService
{
    public async Task<Result<EntitiesWithTotalCount<SessionReadDto>>> Get(SessionsFilteringModel model)
    {
        var query = _repository.GetQuery(include: q => q
                    .Include(h => h.Hall)
                    .Include(m => m.Movie)
                    .Include(s => s.Tickets))
                    .Filter(model);

        var totalCount = query.Count();
        query = query.SortByField(model).Paginate(model);

        var mappedSessions = await query.ProjectTo<SessionReadDto>(_mapper.ConfigurationProvider).ToListAsync();

        var result = new EntitiesWithTotalCount<SessionReadDto> { Items = mappedSessions, TotalCount = totalCount };

        return Result<EntitiesWithTotalCount<SessionReadDto>>.Success(result);
    }

    public async Task<Result<SessionDetailsDto>> GetById(Guid id)
    {
        var session = await _repository.GetByIdWithInclude(id, include: q => q
                   .Include(h => h.Hall)
                   .Include(m => m.Movie)
                   .ThenInclude(d=>d.Director)
                   .Include(s => s.Tickets));

        if (session == null)
            return Result<SessionDetailsDto>.Fail($"Session with id {id} not found")!;

        var mappedSession = _mapper.Map<SessionDetailsDto>(session);
        return Result<SessionDetailsDto>.Success(mappedSession);
    }

    public async Task<Result<SessionReadDto>> Create(SessionCreateDto dto)
    {
        var session = _mapper.Map<Session>(dto);

        await _repository.Add(session);

        session = await _repository.GetByIdWithInclude(session.Id, include: q => q
                          .Include(h => h.Hall)
                          .Include(m => m.Movie)
                          .ThenInclude(d => d.Director)
                          .Include(s => s.Tickets));

        var mappedSession = _mapper.Map<SessionReadDto>(session);
        return Result<SessionReadDto>.Success(mappedSession);
    }

    public async Task<Result<SessionReadDto>> Update(SessionUpdateDto dto)
    {
        var session = await _repository.GetById(dto.Id);

        if (session == null)
            return Result<SessionReadDto>.Fail($"Session with id {dto.Id} not found")!;

        mapper.Map(dto, session);

        await _repository.Update(session);

        session = await _repository.GetByIdWithInclude(session.Id, include: q => q
                                 .Include(h => h.Hall)
                                 .Include(m => m.Movie)
                                 .ThenInclude(d => d.Director)
                                 .Include(s => s.Tickets));

        var mappedSession = _mapper.Map<SessionReadDto>(session);
        return Result<SessionReadDto>.Success(mappedSession);
    }

    public async Task<Result<bool>> Delete(Guid id)
    {
        var session = await _repository.GetById(id);

        if (session == null)
            return Result<bool>.Fail($"Session with id {id} not found")!;

        await _repository.Delete(session);

        return Result<bool>.Success(true);
    }
}