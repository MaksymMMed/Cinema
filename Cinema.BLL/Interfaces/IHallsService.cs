using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Halls;
using Cinema.BLL.Filtering.Halls;

namespace Cinema.BLL.Interfaces;

public interface IHallsService
{
    Task<Result<EntitiesWithTotalCount<HallReadDto>>> Get(HallsFilteringModel model);
    Task<Result<HallDetailReadDto>> GetById(Guid id);
    Task<Result<HallReadDto>> Create(HallCreateDto dto);
    //Task<Result<HallReadDto>> Update(Guid id, HallUpdateDto dto);
    //Task<Result<HallReadDto>> Delete(Guid id);
}
