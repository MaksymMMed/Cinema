using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Halls;
using Cinema.BLL.Filtering.Halls;

namespace Cinema.BLL.Interfaces;

public interface IHallsService
{
    Task<Result<EntitiesWithTotalCount<HallReadDto>>> Get(HallsFilteringModel model);
    Task<Result<HallDetailReadDto>> GetById(Guid id);
    Task<Result<HallDetailReadDto>> Create(HallCreateDto dto);
    Task<Result<HallDetailReadDto>> Update(HallUpdateDto dto);
    Task<Result<HallDetailReadDto>> Delete(Guid id);
}
