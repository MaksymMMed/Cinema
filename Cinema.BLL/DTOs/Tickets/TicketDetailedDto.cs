using Cinema.BLL.DTOs.Halls;
using Cinema.BLL.DTOs.Movies;
using Cinema.BLL.DTOs.Sessions;
using Cinema.DAL.Entities;

namespace Cinema.BLL.DTOs.Tickets
{
    public class TicketDetailedDto
    {
        public Guid Id { get; set; }
        public Guid SessionId { get; set; }
        public DateTime SessionDateUtc { get; set; }
        public TicketMovieDto Movie { get; set; }
        public Guid HallId { get; set; }
        public string HallName { get; set; }
        public Guid PurchasedById { get; set; }
        public string PurchasedByName { get; set; }
        public int RowIndex { get; set; }
        public int SeatIndex { get; set; }
        public Guid InvoiceId { get; set; }
    }
}
