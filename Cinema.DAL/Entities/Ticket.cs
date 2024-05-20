using System.ComponentModel.DataAnnotations;

namespace Cinema.DAL.Entities
{
    public class Ticket
    {
        [Key]
        public Guid Id { get; set; }
        public Guid SessionId { get; set; }
        public Guid InvoiceId { get; set; }
        public int RowIndex { get; set; }
        public int SeatIndex { get; set; }
        public Session Session { get; set; }
        public Invoice Invoice { get; set; }
    }
}
