using System.ComponentModel.DataAnnotations;

namespace Cinema.DAL.Entities
{
    public class Movie
    {
        [Key]
        public Guid Id { get; set; }
        public Guid DirectorId { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string LargePosterImageUrl {  get; set; }
        public string SmallPosterImageUrl { get; set; }
        public string TrailerUrl { get; set; }
        public string AgeRestriction { get; set; }
        public int Duration { get; set; }
        public DateTime ReleaseDate { get; set; }
        public Director Director { get; set; }
        public MovieImageSet ImageSet { get; set; }
        public virtual ICollection<Session> Sessions { get; set; } = new List<Session>();
        public virtual ICollection<MovieGenre> MovieGenres { get; set; } = new List<MovieGenre>();
        public virtual ICollection<ActorMovie> MovieActors { get; set; } = new List<ActorMovie>();
        public virtual ICollection<Review> MovieReviews { get; set; } = new List<Review>();
    }
}
