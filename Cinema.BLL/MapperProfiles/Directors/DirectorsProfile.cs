using AutoMapper;
using Cinema.BLL.DTOs.Directors;
using Cinema.DAL.Entities;

namespace Cinema.BLL.MapperProfiles.Directors
{
    public class DirectorsProfile :Profile
    {
        public DirectorsProfile() 
        {
            CreateMap<Director, DirectorReadDto>();
            CreateMap<DirectorCreateDto, Director>();
            CreateMap<DirectorUpdateDto, Director>();
        }
    }
}
