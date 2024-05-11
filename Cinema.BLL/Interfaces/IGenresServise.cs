using Cinema.BLL.DTOs.Genres;
using Cinema.BLL.DTOs;
using Cinema.BLL.Filtering.Genres;

namespace Cinema.BLL.Interfaces
{
    public interface IGenresService
    {
        Task<Result<EntitiesWithTotalCount<GenreDetailReadDto>>> GetDetailed(GenresFilteringModel model);
        Task<Result<EntitiesWithTotalCount<GenreReadDto>>> Get(GenresFilteringModel model);
        Task<Result<GenreDetailReadDto>> GetById(Guid id);
        Task<Result<GenreDetailReadDto>> Create(GenreCreateDto dto);
        Task<Result<GenreDetailReadDto>> Update(GenreUpdateDto dto);
        Task<Result<GenreDetailReadDto>> Delete(Guid id);
    }
}
