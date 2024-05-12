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
        public GenresService(
            IHttpContextAccessor httpContextAccessor,
            IGenresRepository repository,
            IMapper mapper
        ) : base(httpContextAccessor, repository, mapper)
        {
        }

        public async Task<Result<GenreReadDto>> Create(GenreCreateDto dto)
        {
            var genre = _mapper.Map<Genre>(dto);

            await _repository.Add(genre);

            var mappedGenre = _mapper.Map<GenreReadDto>(genre);
            return Result<GenreReadDto>.Success(mappedGenre);
        }

        public async Task<Result<GenreReadDto>> Delete(Guid id)
        {
            var genre = await _repository.GetById(id);

            if (genre == null)
                return Result<GenreReadDto>.Fail($"Genre with id {id} not found");

            await _repository.Delete(genre);

            var mappedGenre = _mapper.Map<GenreReadDto>(genre);
            return Result<GenreReadDto>.Success(mappedGenre);
        }

        public async Task<Result<EntitiesWithTotalCount<GenreReadDto>>> Get(GenresFilteringModel model)
        {
            var query = _repository.GetQuery().Filter(model);

            var totalCount = query.Count();
            query = query.SortByField(model).Paginate(model);

            var mappedGenres = await query.ProjectTo<GenreReadDto>(_mapper.ConfigurationProvider).ToListAsync();

            var result = new EntitiesWithTotalCount<GenreReadDto> { Items = mappedGenres, TotalCount = totalCount };
            return Result<EntitiesWithTotalCount<GenreReadDto>>.Success(result);
        }


        public async Task<Result<GenreReadDto>> GetById(Guid id)
        {
            var genre = await _repository.GetById(id);

            if (genre == null)
                return Result<GenreReadDto>.Fail($"Genre with id {id} not found");

            var mappedGenre = _mapper.Map<GenreReadDto>(genre);
            return Result<GenreReadDto>.Success(mappedGenre);
        }
       
        public async Task<Result<GenreReadDto>> Update(GenreUpdateDto dto)
        {
            var genre = await _repository.GetById(dto.Id);

            if (genre == null)
                return Result<GenreReadDto>.Fail($"Genre with id {dto.Id} not found");

            _mapper.Map(dto, genre);

            var newGenre = _repository.Update(genre).Result;

            var mappedGenre = _mapper.Map<GenreReadDto>(newGenre);
            return Result<GenreReadDto>.Success(mappedGenre);
        }
    }
}
