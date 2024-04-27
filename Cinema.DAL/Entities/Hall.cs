namespace Cinema.DAL.Entities
{
    public class Hall
    {
        public Guid Id { get; set; }
        public int Capacity{ get; set; }
        public string RowsCapacity { get; set; }
        public virtual ICollection<Session> Sessions { get; set; }
        public virtual ICollection<Ticket> Tickets { get; set; }
    }
}
