using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Directors;
using Cinema.BLL.Filtering.Directors;

namespace Cinema.BLL.Interfaces
{
    public interface IDirectorsService
    {
        Task<Result<EntitiesWithTotalCount<DirectorReadDto>>> Get(DirectorsFilteringModel model);

        Task<Result<DirectorReadDto>> GetById(Guid id);

        Task<Result<DirectorReadDto>> Create(DirectorCreateDto dto);

        Task<Result<DirectorReadDto>> Update(DirectorUpdateDto dto);

        Task<Result<DirectorReadDto>> Delete(Guid id);
    }
}
