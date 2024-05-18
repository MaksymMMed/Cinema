namespace Cinema.BLL.DTOs.Reviews
{
    public class ReviewReadDto
    {
        public Guid Id { get; set; }
        public Guid MovieId { get; set; }
        public Guid CreatedById { get; set; }
        public string Comment { get; set; }
        public string CreatedByName { get; set; }
        public int Rank { get; set; }
        public DateTime CreatedOnUtc { get; set; }
    }
}