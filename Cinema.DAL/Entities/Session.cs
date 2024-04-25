using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Entities
{
    public class Session
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public Guid HallId { get; set; }
        public DateTime DateUtc { get; set; }
        public Hall Hall { get; set; }
        public Movie Movie { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
