using AutoMapper;
using Cinema.BLL.DTOs.Invoices;
using Cinema.BLL.DTOs.Tickets;
using Cinema.DAL.Entities;

namespace Cinema.BLL.MapperProfiles.Invoices;

public class InvoicesProfile : Profile
{
    public InvoicesProfile()
    {
        CreateMap<Invoice, InvoiceReadDto>();
        
        CreateMap<Invoice, InvoiceDetailsReadDto>()
            .ForMember(dst => dst.Tickets, opt => 
                opt.MapFrom(src => src.Tickets));


        CreateMap<InvoiceCreateDto, Invoice>();
        
        CreateMap<Ticket, InvoiceTicketDto>()
            .ForMember(dst => dst.SessionDateUtc, opt => 
                opt.MapFrom(src => src.Session.DateUtc));
    }
}
