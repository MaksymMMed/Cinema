using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Reviews;
using Cinema.BLL.Filtering.Reviews;

namespace Cinema.BLL.Interfaces
{
    public interface IReviewsService
    {
        Task<Result<EntitiesWithTotalCount<ReviewReadDto>>> Get(ReviewsFilteringModel model);
        Task<Result<ReviewReadDto>> GetById(Guid id);
        Task<Result<ReviewReadDto>> Create(ReviewCreateDto dto);
        Task<Result<ReviewReadDto>> Update(ReviewUpdateDto dto);
        Task<Result<bool>> Delete(Guid id);
    }
}