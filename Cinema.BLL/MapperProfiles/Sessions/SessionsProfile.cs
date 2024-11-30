using AutoMapper;
using Cinema.BLL.DTOs.Sessions;
using Cinema.DAL.Entities;
using System.Text.Json;

namespace Cinema.BLL.MapperProfiles.Sessions;

public class SessionsProfile : Profile
{
    private static List<List<bool>> GetSeatsLayout(IEnumerable<Ticket> tickets, Hall hall)
    {
        // Parse RowsData as JSON and extract capacities
        var seats = new List<List<bool>>();
        try
        {
            using (var document = JsonDocument.Parse(hall.RowsData))
            {
                foreach (var rowElement in document.RootElement.EnumerateArray())
                {
                    if (rowElement.TryGetProperty("Capacity", out var capacityProperty) &&
                        capacityProperty.TryGetInt32(out var capacity))
                    {
                        // Initialize the row with the specified capacity
                        seats.Add(new List<bool>(new bool[capacity]));
                    }
                }
            }
        }
        catch (JsonException ex)
        {
            throw new InvalidOperationException("Invalid JSON in RowsData", ex);
        }

        // Mark occupied seats based on tickets
        foreach (var ticket in tickets)
        {
            if (ticket.RowIndex >= 0 && ticket.RowIndex < seats.Count &&
                ticket.SeatIndex >= 0 && ticket.SeatIndex < seats[ticket.RowIndex].Count)
            {
                seats[ticket.RowIndex][ticket.SeatIndex] = true;
            }
            else
            {
                throw new IndexOutOfRangeException($"Invalid ticket indices: Row {ticket.RowIndex}, Seat {ticket.SeatIndex}");
            }
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
            .ForMember(dst => dst.HallName, opt =>
                opt.MapFrom(src => src.Hall.Name))
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
