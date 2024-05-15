using System.ComponentModel.DataAnnotations;

namespace Cinema.DAL.Entities
{
    public class Session
    {
        [Key]
        public Guid Id { get; set; }
        public Guid HallId { get; set; }
        public Guid MovieId { get; set; }
        public DateTime DateUtc { get; set; }
        public Hall Hall { get; set; }
        public Movie Movie { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
