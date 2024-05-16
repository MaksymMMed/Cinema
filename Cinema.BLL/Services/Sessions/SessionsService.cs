using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Sessions;
using Cinema.BLL.Extensions;
using Cinema.BLL.Filtering.Sessions;
using Cinema.BLL.Interfaces;
using Cinema.BLL.Services.Core;
using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Movies;
using Cinema.DAL.Interfaces.Sessions;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Cinema.BLL.Services.Sessions;

public class SessionsService : BaseBusinessService, ISessionsService
{
    private readonly ISessionsRepository _sessionRepository;
    private readonly IMoviesRepository _moviesRepository;
    private readonly IMapper _mapper;

    public SessionsService(
         IHttpContextAccessor httpContextAccessor,
         ISessionsRepository sessionRepository,
         IMoviesRepository moviesRepository,
         IMapper mapper
           ) : base(httpContextAccessor)
    {
        _sessionRepository = sessionRepository;
        _moviesRepository = moviesRepository;
        _mapper = mapper;
    }

    public async Task<Result<EntitiesWithTotalCount<SessionReadDto>>> Get(SessionsFilteringModel model)
    {
        var query = _sessionRepository.GetQuery(include: q => q
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
        var session = await _sessionRepository.GetByIdWithInclude(id, include: q => q
                   .Include(h => h.Hall)
                   .Include(m => m.Movie)
                   .ThenInclude(d => d.Director)
                   .Include(s => s.Tickets));

        if (session == null)
            return Result<SessionDetailsDto>.Fail($"Session with id {id} not found")!;

        var mappedSession = _mapper.Map<SessionDetailsDto>(session);
        return Result<SessionDetailsDto>.Success(mappedSession);
    }

    public async Task<Result<SessionReadDto>> Create(SessionCreateDto dto)
    {
        var session = _mapper.Map<Session>(dto);

        var sessionMovie = await _moviesRepository.GetById(session.MovieId);

        if (sessionMovie == null)
            return Result<SessionReadDto>.Fail($"Movie with id {session.MovieId} not found")!;

        // Check if hall is available
        var hasCollisionSessions = await _sessionRepository.AnyAsync(q =>
            q.HallId == session.HallId &&
            (
                // Check if session starts before q ends and ends after q starts
                (session.DateUtc < q.DateUtc.AddMinutes(q.Movie.Duration) && session.DateUtc.AddMinutes(sessionMovie.Duration) > q.DateUtc) ||
                // Check if q starts before session ends and ends after session starts
                (q.DateUtc < session.DateUtc.AddMinutes(sessionMovie.Duration) && q.DateUtc.AddMinutes(q.Movie.Duration) > session.DateUtc)
            )
        );

        if (hasCollisionSessions)
            return Result<SessionReadDto>.Fail("Hall is already booked for this time")!;

        await _sessionRepository.Add(session);

        session = await _sessionRepository.GetByIdWithInclude(session.Id, include: q => q
                          .Include(h => h.Hall)
                          .Include(m => m.Movie)
                          .ThenInclude(d => d.Director)
                          .Include(s => s.Tickets));

        var mappedSession = _mapper.Map<SessionReadDto>(session);
        return Result<SessionReadDto>.Success(mappedSession);
    }

    public async Task<Result<SessionReadDto>> Update(SessionUpdateDto dto)
    {
        var session = await _sessionRepository.GetById(dto.Id);

        if (session == null)
            return Result<SessionReadDto>.Fail($"Session with id {dto.Id} not found")!;

        var sessionMovie = await _moviesRepository.GetById(session.MovieId);

        if (sessionMovie == null)
            return Result<SessionReadDto>.Fail($"Movie with id {session.MovieId} not found")!;

        // Check if hall is available
        var hasCollisionSessions = await _sessionRepository.AnyAsync(q =>
            q.HallId == session.HallId && q.Id != session.Id &&
            (
                // Check if session starts before q ends and ends after q starts
                (session.DateUtc < q.DateUtc.AddMinutes(q.Movie.Duration) && session.DateUtc.AddMinutes(sessionMovie.Duration) > q.DateUtc) ||
                // Check if q starts before session ends and ends after session starts
                (q.DateUtc < session.DateUtc.AddMinutes(sessionMovie.Duration) && q.DateUtc.AddMinutes(q.Movie.Duration) > session.DateUtc)
            )
        );

        if (hasCollisionSessions)
            return Result<SessionReadDto>.Fail("Hall is already booked for this time")!;

        _mapper.Map(dto, session);

        await _sessionRepository.Update(session);

        session = await _sessionRepository.GetByIdWithInclude(session.Id, include: q => q
                                 .Include(h => h.Hall)
                                 .Include(m => m.Movie)
                                 .ThenInclude(d => d.Director)
                                 .Include(s => s.Tickets));

        var mappedSession = _mapper.Map<SessionReadDto>(session);
        return Result<SessionReadDto>.Success(mappedSession);
    }

    public async Task<Result<bool>> Delete(Guid id)
    {
        var session = await _sessionRepository.GetById(id);

        if (session == null)
            return Result<bool>.Fail($"Session with id {id} not found")!;

        await _sessionRepository.Delete(session);

        return Result<bool>.Success(true);
    }
}