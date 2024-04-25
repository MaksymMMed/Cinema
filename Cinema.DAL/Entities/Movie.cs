using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema.DAL.Entities
{
    public class Movie
    {
        public Guid Id { get; set; }
        public Guid DirectorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageUrl { get; set; }
        public string TrailerUrl { get; set; }
        public string AgeRestriction { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Director Director { get; set; }
        public Images Images { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<MovieGenre> MovieGenres { get; set; }
        public virtual ICollection<ActorMovie> MovieActors { get; set; }
        public virtual ICollection<Review> MovieReviews { get; set; }
    }
}
