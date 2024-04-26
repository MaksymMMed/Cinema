namespace Cinema.DAL.Entities
{
    public class Actor
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public virtual ICollection<ActorMovie> ActorMovies { get; set; }
    }
}
