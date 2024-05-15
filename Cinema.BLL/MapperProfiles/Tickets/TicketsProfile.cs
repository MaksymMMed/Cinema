using AutoMapper;
using Cinema.BLL.DTOs.Tickets;
using Cinema.DAL.Entities;

namespace Cinema.BLL.MapperProfiles.Tickets;

public class TicketsProfile : Profile
{
    public TicketsProfile()
    {
        CreateMap<Ticket, TicketReadDto>();
    }
}
