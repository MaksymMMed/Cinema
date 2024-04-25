using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Entities
{
    public class Hall
    {
        public Guid Id { get; set; }
        public int Capacity{ get; set; }
        public int[] RowsCapacity {  get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
