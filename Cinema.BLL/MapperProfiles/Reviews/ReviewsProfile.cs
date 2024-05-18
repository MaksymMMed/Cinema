using AutoMapper;
using Cinema.BLL.DTOs.Reviews;
using Cinema.DAL.Entities;

namespace Cinema.BLL.MapperProfiles.Reviews
{
    public class ReviewsProfile : Profile
    {
        public ReviewsProfile() 
        {
            CreateMap<Review,ReviewReadDto>();
            CreateMap<ReviewCreateDto, Review>()
                .ForMember(dest => dest.CreatedOnUtc, opt => opt.MapFrom(_ => DateTime.UtcNow));
            CreateMap<ReviewUpdateDto,Review>();
        }
    }
}
