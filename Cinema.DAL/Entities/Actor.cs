using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Entities
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ActorsMovies> ActorMovies { get; set; }
    }
}
