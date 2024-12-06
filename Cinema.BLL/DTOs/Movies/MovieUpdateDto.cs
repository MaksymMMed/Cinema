namespace Cinema.BLL.DTOs.Movies;

public class MovieUpdateDto
{
    public Guid Id { get; set; }
    public Guid DirectorId { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string LargePosterImageUrl { get; set; }
    public string SmallPosterImageUrl { get; set; }
    public string TrailerUrl { get; set; }
    public string AgeRestriction { get; set; }
    public int Duration { get; set; }
    public DateTime ReleaseDate { get; set; }
}