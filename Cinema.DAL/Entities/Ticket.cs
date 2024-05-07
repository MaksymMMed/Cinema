﻿namespace Cinema.DAL.Entities
{
    public class Ticket
    {
        public Guid Id { get; set; }
        public Guid SessionId { get; set; }
        public Guid HallId { get; set; }
        public Guid UserId { get; set; }
        public int RowIndex { get; set; }
        public int PlaceIndex { get; set; }
        public Session Session { get; set; }
        public Hall Hall { get; set; }
        public User User { get; set; }
        public Invoice Invoice { get; set; }
    }
}