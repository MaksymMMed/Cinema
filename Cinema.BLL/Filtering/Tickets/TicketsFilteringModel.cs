using Cinema.DAL.Entities;
using Microsoft.EntityFrameworkCore;

namespace Cinema.BLL.Filtering.Tickets;

public class TicketsFilteringModel : FilteringModel<Ticket>, IFilter<Ticket>
{
    public string? MovieName { get; set; }
    
    public DateTime? FromSessionDate { get; set; }
    
    public DateTime? ToSessionDate { get; set; }
    
    public Guid? SessionId { get; set; }
    
    public Guid? HallId { get; set; }
    
    public Guid? PurchasedByUserId { get; set; }
    
    public Guid? InvoiceId { get; set; }
    
    public IQueryable<Ticket> Filter(IQueryable<Ticket> source)
    {
        if (!string.IsNullOrEmpty(MovieName))
            source = source.Where(t => EF.Functions.Like(t.Session.Movie.Name, $"%{MovieName}%"));

        if (FromSessionDate != null)
            source = source.Where(t => t.Session.DateUtc >= FromSessionDate);
        
        if (ToSessionDate != null)
            source = source.Where(t => t.Session.DateUtc <= ToSessionDate);
        
        if (SessionId != null)
            source = source.Where(t => t.SessionId == SessionId);
        
        if (HallId != null)
            source = source.Where(t => t.Session.HallId == HallId);
        
        if (PurchasedByUserId != null)
            source = source.Where(t => t.Invoice.User.Id == PurchasedByUserId);
        
        if (InvoiceId != null)
            source = source.Where(t => t.InvoiceId == InvoiceId);
        
        return source;
    }
}