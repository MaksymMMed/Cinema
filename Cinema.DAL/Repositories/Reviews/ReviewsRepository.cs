using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Reviews;
using Microsoft.EntityFrameworkCore;

namespace Cinema.DAL.Repositories.Reviews
{
    public class ReviewsRepository(AppDbContext appDbContext) : GenericRepository<Review, Guid>(appDbContext), IReviewsRepository
    {
    }
}
