namespace Cinema.DAL.Entities
{
    public class Invoice
    {
        public Guid Id { get; set; }
        public Guid TicketId { get; set; }
        public Guid UserId { get; set; }
        public int Amount { get; set; }
        public bool Status { get; set; }
        public DateTime CreateDateUtc { get; set; }
        public Ticket Ticket { get; set; }
        public User User { get; set; }
    }
}
