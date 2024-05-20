using AutoMapper;
using Cinema.BLL.DTOs.Halls;
using Cinema.BLL.DTOs.Sessions;
using Cinema.DAL.Entities;
using System.Text.Json;
using Cinema.BLL.Utils;

namespace Cinema.BLL.MapperProfiles.Halls;

public class HallsProfile : Profile
{
    public HallsProfile()
    {
        CreateMap<Hall, HallReadDto>()
            .ForMember(dst => dst.SessionsCount, opt =>
                opt.MapFrom(src => src.Sessions.Count))
            .ForMember(dst => dst.TicketsCount, opt =>
                opt.MapFrom(src => src.Tickets.Count));

        CreateMap<Hall, HallDetailReadDto>()
            .ForMember(dst => dst.RowsData, opt =>
                           opt.MapFrom(src => HallUtils.DeserializeRowsData(src.RowsData)));

        CreateMap<HallCreateDto, Hall>()
            .ForMember(dst => dst.Capacity, opt =>
                           opt.MapFrom(src => src.RowsData.Sum(rd => rd.Capacity)))
            .ForMember(dst => dst.RowsData, opt =>
                           opt.MapFrom(src => HallUtils.SerializeRowsData(src.RowsData)));

        CreateMap<HallUpdateDto, Hall>()
            .ForMember(dst => dst.Capacity, opt =>
                           opt.MapFrom(src => src.RowsData.Sum(rd => rd.Capacity)))
            .ForMember(dst => dst.RowsData, opt =>
                           opt.MapFrom(src => HallUtils.SerializeRowsData(src.RowsData)));
    }
}
