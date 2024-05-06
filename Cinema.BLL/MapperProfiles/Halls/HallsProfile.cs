using AutoMapper;
using Cinema.BLL.DTOs.Halls;
using Cinema.BLL.DTOs.Sessions;
using Cinema.DAL.Entities;
using System.Text.Json;

namespace Cinema.BLL.MapperProfiles.Halls;

public class HallsProfile : Profile
{
    private static IEnumerable<int> ConvertRowsCapacity(string rowsCapacity)
    {
        return JsonSerializer.Deserialize<IEnumerable<int>>(rowsCapacity) ?? [];
    }
    private static IEnumerable<SessionDateTimeReadDto> GetSessions(IEnumerable<Session> sessions)
    {
        return sessions.OrderByDescending(s => s.DateUtc).Select(s => new SessionDateTimeReadDto
        {
            SessionId = s.Id,
            DateUtc = s.DateUtc
        });
    }

    public HallsProfile()
    {
        CreateMap<Hall, HallReadDto>()
            .ForMember(dst => dst.RowsCapacity, opt =>
                opt.MapFrom(src => ConvertRowsCapacity(src.RowsCapacity)))
            .ForMember(dst => dst.SessionsCount, opt =>
                opt.MapFrom(src => src.Sessions.Count()))
            .ForMember(dst => dst.TicketsCount, opt =>
                opt.MapFrom(src => src.Tickets.Count()));

        CreateMap<Hall, HallDetailReadDto>()
            .ForMember(dst => dst.RowsCapacity, opt =>
                           opt.MapFrom(src => ConvertRowsCapacity(src.RowsCapacity)))
            .ForMember(dst => dst.Sessions, opt =>
                           opt.MapFrom(src => GetSessions(src.Sessions)));
    }
}
