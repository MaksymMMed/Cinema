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

namespace Cinema.BLL.Services.Reviews
{
    public class ReviewsService : BaseBusinessService, IReviewsService
    {
        private readonly IReviewsRepository _repository;
        private readonly IMapper _mapper;

        public ReviewsService(
            IHttpContextAccessor httpContextAccessor,
            IReviewsRepository repository,
            IMapper mapper
        ) : base(httpContextAccessor)
        {
            _repository = repository;
            _mapper = mapper;
        }

        public async Task<Result<ReviewReadDto>> Create(ReviewCreateDto dto)
        {
            bool flag = await _repository.IsAlreadyCommented(dto.CreatedById,dto.MovieId);

            if (flag)
            {
                return Result<ReviewReadDto>.Fail("You already leave comment")!;
            }

            var review = _mapper.Map<Review>(dto);

            await _repository.Add(review);

            var mappedReview = _mapper.Map<ReviewReadDto>(review);
            return Result<ReviewReadDto>.Success(mappedReview);
        }

        public async Task<Result<ReviewReadDto>> Delete(Guid id)
        {
            var review = await _repository.GetById(id);

            if (review == null)
                return Result<ReviewReadDto>.Fail($"Review with id {id} not found")!;

            await _repository.Delete(review);

            var mappedReview = _mapper.Map<ReviewReadDto>(review);
            return Result<ReviewReadDto>.Success(mappedReview);
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
            var review = await _repository.GetById(dto.Id);

            if (review == null)
                return Result<ReviewReadDto>.Fail($"Review with id {dto.Id} not found")!;

            _mapper.Map(dto, review);

            var newReview = _repository.Update(review).Result;

            var mappedReview = _mapper.Map<ReviewReadDto>(newReview);
            return Result<ReviewReadDto>.Success(mappedReview);
        }
    }
}
