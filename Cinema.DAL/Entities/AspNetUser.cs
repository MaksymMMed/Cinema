using Microsoft.AspNetCore.Identity;

namespace Cinema.DAL.Entities
{
    public class AspNetUser : IdentityUser<Guid>
    {
        public virtual ICollection<Review> Reviews { get; set;}
        public virtual ICollection<Invoice> Invoices { get; set;}
        public virtual ICollection<Ticket> Tickets { get; set;}
    }
}
