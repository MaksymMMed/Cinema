using Cinema.BLL.DTOs.Sessions;

namespace Cinema.BLL.DTOs.Movies;

public class MovieReadDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public Guid DirectorId { get; set; }
    public string DirectorName { get; set; }
    public string SmallPosterImageUrl { get; set; }
    public string LargePosterImageUrl { get; set; }
    public string TrailerUrl { get; set; }
    public string AgeRestriction { get; set; }
    public int Duration { get; set; }
    public DateTime ReleaseDate { get; set; }
    public IEnumerable<string> Genres { get; set; }
    public double AvgMark { get; set; }
}