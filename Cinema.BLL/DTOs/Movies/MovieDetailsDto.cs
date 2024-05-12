using Cinema.BLL.DTOs.Actors;
using Cinema.BLL.DTOs.Genres;

namespace Cinema.BLL.DTOs.Movies;

public class MovieDetailsDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid DirectorId { get; set; }
    public string DirectorName { get; set; }
    public string ImageUrl { get; set; }
    public string TrailerUrl { get; set; }
    public IEnumerable<string> ImagesUrls { get; set; }
    public string AgeRestriction { get; set; }
    public int Duration { get; set; }
    public DateTime ReleaseDate { get; set; }
    public IEnumerable<GenreReadDto> Genres { get; set; }
    public IEnumerable<ActorReadDto> Actors { get; set; }
    public double AvgMark { get; set; }
}