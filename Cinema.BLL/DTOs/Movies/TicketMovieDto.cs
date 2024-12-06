namespace Cinema.BLL.DTOs.Movies;

public class TicketMovieDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string SmallPosterImageUrl { get; set; }
    public string Duration { get; set; }
}