using System.ComponentModel.DataAnnotations;

namespace Cinema.DAL.Entities
{
    public class Genre
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MovieGenre> MoviesGenre { get; set; }
    }
}
