using Cinema.BLL.DTOs.Actors;
using Cinema.BLL.DTOs.Genres;
using Cinema.BLL.DTOs.Reviews;
using Cinema.BLL.DTOs.Sessions;

namespace Cinema.BLL.DTOs.Movies;

public class MovieDetailsDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public Guid DirectorId { get; set; }
    public string DirectorName { get; set; }
    public string LargePosterImageUrl { get; set; }
    public string SmallPosterImageUrl { get; set; }
    public string TrailerUrl { get; set; }
    public IEnumerable<string> ImagesUrls { get; set; }
    public string AgeRestriction { get; set; }
    public int Duration { get; set; }
    public DateTime ReleaseDate { get; set; }
    public IEnumerable<ReviewReadDto> MovieReviews { get; set; }
    public IEnumerable<GenreReadDto> Genres { get; set; }
    public IEnumerable<ActorReadDto> Actors { get; set; }
    public IEnumerable<SessionDateTimeReadDto> FiveClosestSessions { get; set; }
    public double AvgMark { get; set; }
}