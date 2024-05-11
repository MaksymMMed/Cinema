using AutoMapper;
using Cinema.BLL.DTOs.Genres;
using Cinema.DAL.Entities;

namespace Cinema.BLL.MapperProfiles.Genres
{
    public class GenresProfile:Profile
    {
        public GenresProfile() 
        {
            CreateMap<Genre, GenreReadDto>();
            CreateMap<Genre, GenreDetailReadDto>()
                .ForMember(dest => dest.Movies, opt => opt.MapFrom(src => src.MoviesGenre.Select(x => x.Movie)));
            CreateMap<GenreCreateDto, Genre>();
            CreateMap<GenreUpdateDto, Genre>();
        }
    }
}
