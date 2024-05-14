using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Reviews;
using Microsoft.EntityFrameworkCore;

namespace Cinema.DAL.Repositories.Reviews
{
    public class ReviewsRepository(AppDbContext appDbContext) : GenericRepository<Review, Guid>(appDbContext), IReviewsRepository
    {
        public async Task<bool> IsAlreadyCommented(Guid userId,Guid movieId)
        {
            return await DbContext.Review.AnyAsync(x => x.CreatedById == userId && x.MovieId == movieId);
        }
    }
}
