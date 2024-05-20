using System.ComponentModel.DataAnnotations;

namespace Cinema.DAL.Entities
{
    public class Invoice
    {
        [Key]
        public Guid Id { get; set; }
        public Guid UserId { get; set; }
        public decimal Amount { get; set; }
        public bool IsPaid { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
        public AspNetUser User { get; set; }
    }
}
