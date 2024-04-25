using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Entities
{
    public class MovieGenre
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public Guid GenreId { get; set; }
        public Genre Genre { get; set; }
        public Movie Movie { get; set; }
    }
}
