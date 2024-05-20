namespace Cinema.BLL.DTOs.Reviews
{
    public class ReviewUpdateDto
    {
        public Guid Id { get; set; }
        public string Comment { get; set; }
        public int Rank {  get; set; }
    }
}
