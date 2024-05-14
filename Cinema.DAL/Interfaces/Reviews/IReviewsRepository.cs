using Cinema.DAL.Entities;

namespace Cinema.DAL.Interfaces.Reviews
{
    public interface IReviewsRepository:IGenericRepository<Review,Guid>
    {
        public Task<bool> IsAlreadyCommented(Guid userId, Guid movieId);
    }
}
