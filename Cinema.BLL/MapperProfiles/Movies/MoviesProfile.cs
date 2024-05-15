using AutoMapper;
using Cinema.BLL.DTOs.Movies;
using Cinema.BLL.DTOs.Sessions;
using Cinema.DAL.Entities;
using Newtonsoft.Json;

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

    private static double CalculateAvgMark(ICollection<Review> movieReviews) =>
        movieReviews.Count != 0 ? movieReviews.Average(mr => mr.Rank) : 0;

    private static List<string> DeserializeImageSet(MovieImageSet imageSet)
    {
        return (!string.IsNullOrEmpty(imageSet.ImagesUrl)
            ? JsonConvert.DeserializeObject<List<string>>(imageSet.ImagesUrl)
            : new List<string>())!;
    }
    
    private static string SerializeImageSet(IEnumerable<string> imagesUrls) => JsonConvert.SerializeObject(imagesUrls);
        
    public MoviesProfile()
    {
        CreateMap<Movie, MovieReadDto>()
            .ForMember(dst => dst.DirectorName, opt =>
                opt.MapFrom(src => src.Director.Name))
            .ForMember(dst => dst.Genres, opt =>
                opt.MapFrom(src => src.MovieGenres.Select(mg => mg.Genre.Name)))
            .ForMember(dst => dst.AvgMark, opt =>
                opt.MapFrom(src => CalculateAvgMark(src.MovieReviews)))
            .ForMember(dst => dst.FiveClosestSessions, opt =>
                opt.MapFrom(src => GetClosestSessions(src.Sessions)));

        CreateMap<Movie, MovieDetailsDto>()
            .ForMember(dst => dst.DirectorName, opt =>
                opt.MapFrom(src => src.Director.Name))
            .ForMember(dst => dst.ImagesUrls, opt => 
                opt.MapFrom(src => DeserializeImageSet(src.ImageSet)))
            .ForMember(dst => dst.Genres, opt => 
                opt.MapFrom(src => src.MovieGenres.Select(mg => mg.Genre)))
            .ForMember(dst => dst.Actors, opt => 
                opt.MapFrom(src => src.MovieActors.Select(mg => mg.Actor)))
            .ForMember(dst => dst.AvgMark, opt =>
                opt.MapFrom(src => CalculateAvgMark(src.MovieReviews)));

        CreateMap<Movie, MoviePreviewDto>()
            .ForMember(dst => dst.DirectorName, opt =>
                opt.MapFrom(src => src.Director.Name))
            .ForMember(dst => dst.AvgMark, opt =>
                opt.MapFrom(src => CalculateAvgMark(src.MovieReviews)));

        CreateMap<MovieCreateDto, Movie>();
        
        CreateMap<MovieUpdateDto, Movie>();

        CreateMap<UpdateMovieImageSetDto, MovieImageSet>()
            .ForMember(dst => dst.ImagesUrl, opt => 
                opt.MapFrom(src => SerializeImageSet(src.ImagesUrls)));

        CreateMap<MovieGenreDto, MovieGenre>();
        
        CreateMap<MovieActorDto, ActorMovie>();
    }
}