namespace Cinema.BLL.DTOs.Movies;

public class MoviePreviewDto
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string DirectorName { get; set; }
    public string SmallPosterImageUrl { get; set; }
    public string AgeRestriction { get; set; }
    public int Duration { get; set; }
    public double AvgMark { get; set; }
}
