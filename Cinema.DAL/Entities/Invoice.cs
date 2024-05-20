using System.ComponentModel.DataAnnotations;
using Cinema.DAL.Utilities.Interfaces.TrackChanges;

namespace Cinema.DAL.Entities
{
    public class Invoice : ICreatedBy
    {
        [Key]
        public Guid Id { get; set; }
        public Guid CreatedById { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime CreatedOnUtc { get; set; }
        public string CreatedByName { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public AspNetUser CreatedBy { get; set; }
    }
}
