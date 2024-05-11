using Cinema.BLL.DTOs.Movies;

namespace Cinema.BLL.DTOs.Genres
{
    public class GenreDetailReadDto
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<MovieReadDto> Movies { get; set; }
    }
}
