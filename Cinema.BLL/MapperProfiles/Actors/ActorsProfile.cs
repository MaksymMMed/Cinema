using AutoMapper;
using Cinema.BLL.DTOs.Actors;
using Cinema.DAL.Entities;

namespace Cinema.BLL.MapperProfiles.Actors
{
    public class ActorsProfile:Profile
    {
        public ActorsProfile()
        {
            CreateMap<Actor,ActorReadDto>()
                .ForMember(dst => dst.Movies, opt =>
                opt.MapFrom(src => src.ActorMovies.Select(x=>x.Movie)));

            CreateMap<ActorCreateDto,Actor>();
            CreateMap<ActorUpdateDto,Actor>();
        }
    }
}
