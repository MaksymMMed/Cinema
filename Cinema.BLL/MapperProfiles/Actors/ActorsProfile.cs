using AutoMapper;
using Cinema.BLL.DTOs.Actors;
using Cinema.DAL.Entities;

namespace Cinema.BLL.MapperProfiles.Actors
{
    public class ActorsProfile:Profile
    {
        public ActorsProfile()
        {
            CreateMap<Actor, ActorReadDto>();
            CreateMap<ActorCreateDto,Actor>();
            CreateMap<ActorUpdateDto,Actor>();
        }
    }
}
