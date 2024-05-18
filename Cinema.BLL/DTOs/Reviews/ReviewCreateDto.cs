namespace Cinema.BLL.DTOs.Reviews
{
    public class ReviewCreateDto
    {
        public Guid MovieId { get; set; }
        public string Comment { get; set; }
        public int Rank { get; set; }
    }
}
