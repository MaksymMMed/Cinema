using AutoMapper;
using Cinema.BLL.DTOs.Genres;
using Cinema.BLL.DTOs;
using Cinema.BLL.Filtering.Genres;
using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Genres;
using Microsoft.AspNetCore.Http;
using Cinema.BLL.Interfaces;
using Microsoft.EntityFrameworkCore;
using Cinema.BLL.Extensions;
using AutoMapper.QueryableExtensions;

namespace Cinema.BLL.Services.Genres
{
    public class GenresService:BusinessService<Genre,Guid>,IGenresService
    {
        public GenresService(IHttpContextAccessor httpContextAccessor, IGenresRepository repository, IMapper mapper
        ) : base(httpContextAccessor, repository, mapper)
        {
        }

        public async Task<Result<GenreDetailReadDto>> Create(GenreCreateDto dto)
        {
            var Genre = _mapper.Map<Genre>(dto);

            await _repository.Add(Genre);

            var mappedGenre = _mapper.Map<GenreDetailReadDto>(Genre);
            return Result<GenreDetailReadDto>.Success(mappedGenre);
        }

        public async Task<Result<GenreDetailReadDto>> Delete(Guid id)
        {
            var Genre = await _repository.GetById(id);

            if (Genre == null)
                return Result<GenreDetailReadDto>.Fail($"Genre with id {id} not found");

            await _repository.Delete(Genre);

            var mappedGenre = _mapper.Map<GenreDetailReadDto>(Genre);
            return Result<GenreDetailReadDto>.Success(mappedGenre);
        }

        public async Task<Result<EntitiesWithTotalCount<GenreReadDto>>> Get(GenresFilteringModel model)
        {
            var query = _repository.GetQuery(include: q => q
                .Include(x => x.MoviesGenre)).Filter(model);

            var totalCount = query.Count();
            query = query.SortByField(model).Paginate(model);

            var mappedGenres = await query.ProjectTo<GenreReadDto>(_mapper.ConfigurationProvider).ToListAsync();

            var result = new EntitiesWithTotalCount<GenreReadDto> { Items = mappedGenres, TotalCount = totalCount };
            return Result<EntitiesWithTotalCount<GenreReadDto>>.Success(result);
        }


        public async Task<Result<GenreDetailReadDto>> GetById(Guid id)
        {
            var Genre = await _repository.GetByIdWithInclude(id, include: q => q
                       .Include(x => x.MoviesGenre));

            if (Genre == null)
                return Result<GenreDetailReadDto>.Fail($"Genre with id {id} not found");

            var mappedGenre = _mapper.Map<GenreDetailReadDto>(Genre);
            return Result<GenreDetailReadDto>.Success(mappedGenre);
        }

        public async Task<Result<EntitiesWithTotalCount<GenreDetailReadDto>>> GetDetailed(GenresFilteringModel model)
        {
            var query = _repository.GetQuery(include: q => q
                .Include(x => x.MoviesGenre)).Filter(model);

            var totalCount = query.Count();
            query = query.SortByField(model).Paginate(model);

            var mappedGenres = await query.ProjectTo<GenreDetailReadDto>(_mapper.ConfigurationProvider).ToListAsync();

            var result = new EntitiesWithTotalCount<GenreDetailReadDto> { Items = mappedGenres, TotalCount = totalCount };
            return Result<EntitiesWithTotalCount<GenreDetailReadDto>>.Success(result);
        }

        public async Task<Result<GenreDetailReadDto>> Update(GenreUpdateDto dto)
        {
            var Genre = await _repository.GetById(dto.Id);

            if (Genre == null)
                return Result<GenreDetailReadDto>.Fail($"Genre with id {dto.Id} not found");

            _mapper.Map(dto, Genre);

            var newGenre = _repository.Update(Genre).Result;

            var mappedGenre = _mapper.Map<GenreDetailReadDto>(newGenre);
            return Result<GenreDetailReadDto>.Success(mappedGenre);
        }

        
    }
}
