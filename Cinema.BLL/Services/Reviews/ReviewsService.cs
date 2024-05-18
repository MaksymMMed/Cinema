using AutoMapper;
using Cinema.DAL.Interfaces.Reviews;
using Microsoft.AspNetCore.Http;
using Cinema.DAL.Entities;
using Cinema.BLL.DTOs.Reviews;
using Cinema.BLL.DTOs;
using Cinema.BLL.Extensions;
using Cinema.BLL.Filtering.Reviews;
using AutoMapper.QueryableExtensions;
using Microsoft.EntityFrameworkCore;
using Cinema.BLL.Interfaces;
using Cinema.BLL.Services.Core;
using Microsoft.AspNetCore.Identity;

namespace Cinema.BLL.Services.Reviews
{
    public class ReviewsService : BaseBusinessService, IReviewsService
    {
        private readonly IReviewsRepository _repository;
        private readonly IMapper _mapper;
        private readonly UserManager<AspNetUser> _userManager;

        public ReviewsService(
            UserManager<AspNetUser> userManager,
            IHttpContextAccessor httpContextAccessor,
            IReviewsRepository repository,
            IMapper mapper
        ) : base(httpContextAccessor)
        {
            _repository = repository;
            _mapper = mapper;
            _userManager = userManager;
        }

        public async Task<Result<ReviewReadDto>> Create(ReviewCreateDto dto)
        {

            var user = await _userManager.FindByIdAsync(CurrentUserId!);

            if (user == null)
            {
                return Result<ReviewReadDto>.Fail("User not found")!;
            }

            if (dto.Rank > 10 || dto.Rank < 1)
            {
                return Result<ReviewReadDto>.Fail("Choose rank between 1 and 10")!;
            }

            bool alreadyCommented = await _repository.AnyAsync(x => x.CreatedById == user!.Id && x.MovieId == dto.MovieId);

            if (alreadyCommented)
            {
                return Result<ReviewReadDto>.Fail("You already leave comment")!;
            }

            var review = _mapper.Map<Review>(dto);

            review.RegisterCreation(user);

            await _repository.Add(review);

            var mappedReview = _mapper.Map<ReviewReadDto>(review);
            return Result<ReviewReadDto>.Success(mappedReview);
        }

        public async Task<Result<bool>> Delete(Guid id)
        {
            var user = await _userManager.FindByIdAsync(CurrentUserId!);

            if (user == null)
            {
                return Result<bool>.Fail("User not found")!;
            }

            var review = await _repository.GetById(id);

            if (review == null)
                return Result<bool>.Fail($"Review with id {id} not found")!;

            bool isAdmin = await _userManager.IsInRoleAsync(user, "Admin");
            bool isSuperAdmin = await _userManager.IsInRoleAsync(user, "SuperAdmin");

            if (!(review.CreatedById == user.Id || isAdmin || isSuperAdmin))
            {
                return Result<bool>.Fail("User doesn't have the necessary permissions to delete review")!;
            }

            await _repository.Delete(review);

            return Result<bool>.Success(true);
        }

        public async Task<Result<EntitiesWithTotalCount<ReviewReadDto>>> Get(ReviewsFilteringModel model)
        {
            var query = _repository.GetQuery();

            query = query.SortByField(model);
            var totalCount = query.Count();
            query = query.Paginate(model);

            var mappedReviews = await query.ProjectTo<ReviewReadDto>(_mapper.ConfigurationProvider).ToListAsync();

            var result = new EntitiesWithTotalCount<ReviewReadDto> { Items = mappedReviews, TotalCount = totalCount };
            return Result<EntitiesWithTotalCount<ReviewReadDto>>.Success(result);
        }

        public async Task<Result<ReviewReadDto>> GetById(Guid id)
        {
            var review = await _repository.GetById(id);

            if (review == null)
                return Result<ReviewReadDto>.Fail($"Review with id {id} not found")!;

            var mappedReview = _mapper.Map<ReviewReadDto>(review);
            return Result<ReviewReadDto>.Success(mappedReview);
        }

        public async Task<Result<ReviewReadDto>> Update(ReviewUpdateDto dto)
        {
            var user = await _userManager.FindByIdAsync(CurrentUserId!);

            if (user == null)
            {
                return Result<ReviewReadDto>.Fail("User not found")!;
            }

            if (dto.Rank > 10 || dto.Rank < 1)
            {
                return Result<ReviewReadDto>.Fail("Choose rank between 1 and 10")!;
            }

            var review = await _repository.GetById(dto.Id);

            if (review == null)
                return Result<ReviewReadDto>.Fail($"Review with id {dto.Id} not found")!;


            if (review.CreatedById != user.Id)
            {
                return Result<ReviewReadDto>.Fail("User doesn't have the necessary permissions to update review")!;
            }

            _mapper.Map(dto, review);

            var newReview = _repository.Update(review).Result;

            var mappedReview = _mapper.Map<ReviewReadDto>(newReview);
            return Result<ReviewReadDto>.Success(mappedReview);
        }
    }
}
