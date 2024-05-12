using Cinema.BLL.DTOs.Genres;
using Cinema.BLL.DTOs;
using Cinema.BLL.Filtering.Genres;

namespace Cinema.BLL.Interfaces
{
    public interface IGenresService
    {
        Task<Result<EntitiesWithTotalCount<GenreReadDto>>> Get(GenresFilteringModel model);

        Task<Result<GenreReadDto>> GetById(Guid id);
        
        Task<Result<GenreReadDto>> Create(GenreCreateDto dto);
        
        Task<Result<GenreReadDto>> Update(GenreUpdateDto dto);
        
        Task<Result<GenreReadDto>> Delete(Guid id);
    }
}
