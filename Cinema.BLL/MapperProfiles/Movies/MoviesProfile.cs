using AutoMapper;
using Cinema.BLL.DTOs.Movies;
using Cinema.BLL.DTOs.Sessions;
using Cinema.DAL.Entities;

namespace Cinema.BLL.MapperProfiles.Movies;

public class MoviesProfile : Profile
{
    private static IEnumerable<SessionDateTimeReadDto> GetClosestSessions(IEnumerable<Session> sessions)
    {
        return sessions.OrderByDescending(s => s.DateUtc).Take(5).Select(s => new SessionDateTimeReadDto
        {
            SessionId = s.Id,
            DateUtc = s.DateUtc
        });
    }
        
    public MoviesProfile()
    {
        CreateMap<Movie, MovieReadDto>()
            .ForMember(dst => dst.DirectorName, opt =>
                opt.MapFrom(src => src.Director.Name))
            .ForMember(dst => dst.Genres, opt =>
                opt.MapFrom(src => src.MovieGenres.Select(mg => mg.Genre.Name)))
            .ForMember(dst => dst.AvgMark, opt =>
                opt.MapFrom(src => src.MovieReviews.Average(mr => mr.Rank)))
            .ForMember(dst => dst.FiveClosestSessions, opt =>
                opt.MapFrom(src => GetClosestSessions(src.Sessions)));
    }
}