using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Sessions;
using Cinema.BLL.Filtering.Sessions;

namespace Cinema.BLL.Interfaces
{
    public interface ISessionsService
    {
        Task<Result<EntitiesWithTotalCount<SessionReadDto>>> Get(SessionsFilteringModel model);
        Task<Result<SessionDetailsDto>> GetById(Guid id);
        Task<Result<SessionReadDto>> Create(SessionCreateDto dto);
        Task<Result<SessionReadDto>> Update(SessionUpdateDto dto);
        Task<Result<bool>> Delete(Guid id);
    }
}
