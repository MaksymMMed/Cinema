using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Entities
{
    public class Images
    {
        public Guid MovieId { get; set; }
        public string ImagesUrl { get; set; }
        public Movie Movie { get; set; }
    }
}
