using Cinema.BLL.DTOs.Movies;
using Cinema.BLL.DTOs;
using Microsoft.AspNetCore.Identity;
using Cinema.BLL.Services.Core;
using Cinema.DAL.Entities;
using Microsoft.AspNetCore.Http;
using Cinema.DAL.Interfaces.Tickets;
using Microsoft.EntityFrameworkCore;
using AutoMapper.QueryableExtensions;
using AutoMapper;
using Cinema.BLL.Interfaces;
using Cinema.RecomendationSystem;
using System.Reflection;
using Cinema.DAL.Interfaces.Movies;
using Cinema.DAL.Interfaces.Sessions;
using System.Linq;

namespace Cinema.BLL.Services.Recomendations
{
    public class RecomendationsService : BaseBusinessService, IRecomendationsService
    {
        private readonly UserManager<AspNetUser> _userManager;
        private readonly ITicketsRepository _ticketsRepository;
        private readonly IMoviesRepository _moviesRepository;
        private readonly ISessionsRepository _sessionsRepository;
        private readonly IMapper _mapper;

        public RecomendationsService(
        UserManager<AspNetUser> userManager,
        ISessionsRepository sessionsRepository,
        IMoviesRepository moviesRepository,
        IMapper mapper,
        ITicketsRepository ticketsRepository,
        IHttpContextAccessor httpContextAccessor
    ) : base(httpContextAccessor)
        {
            _sessionsRepository = sessionsRepository;
            _moviesRepository = moviesRepository;
            _ticketsRepository = ticketsRepository;
            _userManager = userManager;
            _mapper = mapper;
        }

        private async Task<List<string[]>> GetGenresFromUserMoviesAsync(Guid userId)
        {
            var tickets = _ticketsRepository.GetQuery(include: q => q
                .Include(s => s.Session)
                .ThenInclude(m => m.Movie)
                .Include(x=>x.Invoice))
                .Where(x => x.Invoice.CreatedById == userId)
                .OrderBy(x => x.Session.DateUtc)
                .Take(10);

            var movies = tickets.Select(t => t.Session.Movie).Distinct();

            var mappedMovies = await movies.ProjectTo<MovieReadDto>(_mapper.ConfigurationProvider).ToListAsync();
            var genres = mappedMovies.Select(x => x.Genres.ToArray()).ToList();

            return genres;
        }

        private async Task<List<string[]>> GetGenresFromActiveSessionsAsync()
        {
            var sessions = _sessionsRepository.GetQuery(include: q => q
                .Include(s => s.Movie))
                .Where(x => x.DateUtc > DateTime.UtcNow);

            var movies = sessions.Select(t => t.Movie).Distinct();

            var mappedMovies = await movies.ProjectTo<MovieReadDto>(_mapper.ConfigurationProvider).ToListAsync();
            var genres = mappedMovies.Select(x => x.Genres.ToArray()).ToList();

            return genres;
        }

        public async Task<Result<List<MovieReadDto>>> GetRecommendedMovies()
        {
            var user = await _userManager.FindByIdAsync(CurrentUserId!);
            if (user == null)
                return Result<List<MovieReadDto>>.Fail("User not found")!;

            Guid userId = Guid.Parse(CurrentUserId!);
            var userGenres = await GetGenresFromUserMoviesAsync(userId);
            var sessionGenres = await GetGenresFromActiveSessionsAsync();

            AssociativeRuleBuilder ruleBuilder = new AssociativeRuleBuilder();
            var rules = ruleBuilder.GetHighConfAssociativeRules(sessionGenres, userGenres);

            var sessions = _sessionsRepository.GetQuery(include: q => q.Include(s => s.Movie)
                .ThenInclude(m => m.MovieGenres).ThenInclude(x => x.Genre).Include(x => x.Movie).ThenInclude(x => x.Director))
                .Where(x => x.DateUtc > DateTime.UtcNow)
                .ToList();

            var matchSessions = sessions.Where(t => rules.Any(rule => rule.consequent.All(a => t.Movie.MovieGenres.Any(g => g.Genre.Name == a))))
                                        .ToList();

            var sortedSessions = matchSessions.SelectMany(t => rules.Where(rule => rule.consequent.All(a => t.Movie.MovieGenres.Any(g => g.Genre.Name == a)))
                .Select(rule => new { Session = t, Rule = rule }))
                .OrderByDescending(x => x.Rule.confidence)
                .Select(x => x.Session)
                .Distinct()
                .Take(15)
                .ToList();

            var movies = sortedSessions.Select(x=>x.Movie).Distinct().ToList();

            var mappedMovies = _mapper.Map<List<MovieReadDto>>(movies);

            return Result<List<MovieReadDto>>.Success(mappedMovies)!;
        }
    }
}
