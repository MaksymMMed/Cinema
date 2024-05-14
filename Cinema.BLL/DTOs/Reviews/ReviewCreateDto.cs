namespace Cinema.BLL.DTOs.Reviews
{
    public class ReviewCreateDto
    {
        public Guid CreatedById { get; set; }
        public Guid MovieId { get; set; }
        public string Comment { get; set; }
        public int Rank { get; set; }
        public string CreatedByName { get; set; }
    }
}
