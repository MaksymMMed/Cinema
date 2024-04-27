namespace Cinema.DAL.Entities
{
    public class MovieImageSet
    {
        public Guid MovieId { get; set; }
        public string ImagesUrl { get; set; }
        public Movie Movie { get; set; }
    }
}
