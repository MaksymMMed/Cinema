using System.ComponentModel.DataAnnotations;

namespace Cinema.DAL.Entities
{
    public class MovieImageSet
    {
        [Key]
        public Guid MovieId { get; set; }
        public string ImagesUrl { get; set; }
        public Movie Movie { get; set; }
    }
}
