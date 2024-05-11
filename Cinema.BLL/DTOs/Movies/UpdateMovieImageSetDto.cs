namespace Cinema.BLL.DTOs.Movies;

public class UpdateMovieImageSetDto
{
    public required Guid MovieId { get; set; }
    public required IEnumerable<string> ImagesUrls { get; set; }
}