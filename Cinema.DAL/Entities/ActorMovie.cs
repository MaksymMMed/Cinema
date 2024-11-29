    namespace Cinema.DAL.Entities
{
    public class ActorMovie
    {
        public Guid ActorId { get; set; }
        public Guid MovieId { get; set; }
        public Actor Actor { get; set; }
        public Movie Movie { get; set; }
    }
}
