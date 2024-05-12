using System.ComponentModel.DataAnnotations;

namespace Cinema.DAL.Entities
{
    public class Director
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<Movie> Movies { get; set; }
    }
}
