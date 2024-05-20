using System.ComponentModel.DataAnnotations;

namespace Cinema.DAL.Entities
{
    public class Hall
    {
        [Key]
        public Guid Id { get; set; }
        public string Name { get; set; }
        public int Capacity{ get; set; }
        public string RowsData { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
