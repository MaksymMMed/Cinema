using System.ComponentModel.DataAnnotations;

namespace Cinema.DAL.Entities
{
    public class Actor
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ActorMovie> ActorMovies { get; set; }
    }
}
