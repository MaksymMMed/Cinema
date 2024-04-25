using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Entities
{
    public class AspNetUser:IdentityUser<Guid>
    {
        public virtual ICollection<Review> Reviews { get; set;}
        public virtual ICollection<Invoice> Invoices { get; set;}
        public virtual ICollection<Ticket> Tickets { get; set;}
    }
}
