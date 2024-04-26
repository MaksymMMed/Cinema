namespace Cinema.DAL.Entities
{
    public class Genre
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<MovieGenre> MoviesGenre { get; set; }
    }
}
