using AutoMapper;
using Cinema.BLL.DTOs.Tickets;
using Cinema.DAL.Entities;

namespace Cinema.BLL.MapperProfiles.Tickets;

public class TicketsProfile : Profile
{
    public TicketsProfile()
    {
        CreateMap<Ticket, TicketReadDto>()
            .ForMember(dst => dst.SessionDateUtc, opt =>
                opt.MapFrom(src => src.Session.DateUtc))
            .ForMember(dst => dst.Movie, opt =>
                opt.MapFrom(src => src.Session.Movie))
            .ForMember(dst => dst.HallId, opt =>
                opt.MapFrom(src => src.Session.Hall.Id))
            .ForMember(dst => dst.HallName, opt =>
                opt.MapFrom(src => src.Session.Hall.Name))
            .ForMember(dst => dst.PurchasedById, opt =>
                opt.MapFrom(src => src.Invoice.CreatedBy.Id))
            .ForMember(dst => dst.PurchasedByName, opt =>
                opt.MapFrom(src => src.Invoice.CreatedBy.UserName));
        
        CreateMap<Ticket, SessionTicketDto>();
    }
}
