namespace Cinema.BLL.DTOs.Movies;

public class MovieCreateDto
{
    public Guid DirectorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public required IEnumerable<string> ImagesUrls { get; set; }
    public string TrailerUrl { get; set; }
    public string AgeRestriction { get; set; }
    public int Duration { get; set; }
    public DateTime ReleaseDate { get; set; }
    public IEnumerable<Guid> GenresIds { get; set; }
    public IEnumerable<Guid> ActorsIds { get; set; }
}