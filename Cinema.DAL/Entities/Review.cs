using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Entities
{
    public class Review
    {
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public Guid MovieId { get; set; }
        public string Comment { get; set; }
        public int Rank { get; set; }
        public DateTime CreateDateTimeUtc { get; set; }
        public Movie Movie { get; set; }
        public AspNetUser User { get; set; }

    }
}
