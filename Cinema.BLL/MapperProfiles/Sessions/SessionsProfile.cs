using AutoMapper;
using Cinema.BLL.DTOs.Sessions;
using Cinema.DAL.Entities;
using System.Text.Json;

namespace Cinema.BLL.MapperProfiles.Sessions;

public class SessionsProfile : Profile
{
    private static List<List<bool>> GetSeatsLayout(IEnumerable<Ticket> tickets, Hall hall)
    {
        var hallSeats = JsonSerializer.Deserialize<List<int>>(hall.RowsData) ?? [];
        var seats = new List<List<bool>>();
        for (int i = 0; i < hallSeats.Count; i++)
        {
            var row = new List<bool>();
            for (int j = 0; j < hallSeats[i]; j++)
            {
                row.Add(false);
            }
            seats.Add(row);
        }
        foreach (var ticket in tickets)
        {
            seats[ticket.RowIndex][ticket.SeatIndex] = true;
        }
        return seats;
    }
    public SessionsProfile()
    {
        CreateMap<Session, SessionReadDto>()
            .ForMember(dst => dst.Movie, opt => 
                opt.MapFrom(src => src.Movie))
            .ForMember(dst => dst.StartDateUtc, opt =>
                opt.MapFrom(src => src.DateUtc))
            .ForMember(dst => dst.EndDateUtc, opt =>
                opt.MapFrom(src => src.DateUtc.AddMinutes(src.Movie.Duration)))
            .ForMember(dst => dst.TicketsCount, opt =>
                opt.MapFrom(src => src.Tickets.Count()))
            .ForMember(dst => dst.HallCapacity, opt =>
                opt.MapFrom(src => src.Hall.Capacity));

        CreateMap<Session, SessionDetailsDto>()
            .ForMember(dst => dst.Movie, opt => 
                opt.MapFrom(src => src.Movie))
            .ForMember(dst => dst.StartDateUtc, opt =>
                opt.MapFrom(src => src.DateUtc))
            .ForMember(dst => dst.EndDateUtc, opt =>
                opt.MapFrom(src => src.DateUtc.AddMinutes(src.Movie.Duration)))
            .ForMember(dst => dst.TicketsCount, opt =>
                opt.MapFrom(src => src.Tickets.Count()))
            .ForMember(dst => dst.HallCapacity, opt =>
                opt.MapFrom(src => src.Hall.Capacity))
            .ForMember(dst => dst.Seats, opt => 
                opt.MapFrom(src => GetSeatsLayout(src.Tickets, src.Hall)));

        CreateMap<SessionCreateDto, Session>();

        CreateMap<SessionUpdateDto, Session>();
    }
}
