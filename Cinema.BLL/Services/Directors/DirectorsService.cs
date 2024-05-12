using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Directors;
using Cinema.BLL.Extensions;
using Cinema.BLL.Filtering.Directors;
using Cinema.BLL.Interfaces;
using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Directors;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Cinema.BLL.Services.Directors
{
    public class DirectorsService : BusinessService<Director, Guid>, IDirectorsService
    {
        public DirectorsService(
            IHttpContextAccessor httpContextAccessor,
            IDirectorsRepository repository, IMapper mapper
            ): base(httpContextAccessor, repository, mapper)
        {
        }

        public async Task<Result<DirectorReadDto>> Create(DirectorCreateDto dto)
        {
            var director = _mapper.Map<Director>(dto);

            await _repository.Add(director);

            var mappedDirector = _mapper.Map<DirectorReadDto>(director);
            return Result<DirectorReadDto>.Success(mappedDirector);
        }

        public async Task<Result<DirectorReadDto>> Delete(Guid id)
        {
            var director = await _repository.GetById(id);

            if (director == null)
                return Result<DirectorReadDto>.Fail($"Director with id {id} not found");

            await _repository.Delete(director);

            var mappedDirector = _mapper.Map<DirectorReadDto>(director);
            return Result<DirectorReadDto>.Success(mappedDirector);
        }

        public async Task<Result<EntitiesWithTotalCount<DirectorReadDto>>> Get(DirectorsFilteringModel model)
        {
            var query = _repository.GetQuery().Filter(model);

            query = query.SortByField(model);
            var totalCount = query.Count();
            query = query.Paginate(model);

            var mappedDirectors = await query.ProjectTo<DirectorReadDto>(_mapper.ConfigurationProvider).ToListAsync();

            var result = new EntitiesWithTotalCount<DirectorReadDto> { Items = mappedDirectors, TotalCount = totalCount };
            return Result<EntitiesWithTotalCount<DirectorReadDto>>.Success(result);
        }

        public async Task<Result<DirectorReadDto>> GetById(Guid id)
        {
            var director = await _repository.GetById(id);

            if (director == null)
                return Result<DirectorReadDto>.Fail($"Director with id {id} not found");

            var mappedDirector = _mapper.Map<DirectorReadDto>(director);
            return Result<DirectorReadDto>.Success(mappedDirector);
        }

        public async Task<Result<DirectorReadDto>> Update(DirectorUpdateDto dto)
        {
            var director = await _repository.GetById(dto.Id);

            if (director == null)
                return Result<DirectorReadDto>.Fail($"Director with id {dto.Id} not found");

            _mapper.Map(dto, director);

            var newDirector = _repository.Update(director).Result;

            var mappedDirector = _mapper.Map<DirectorReadDto>(newDirector);
            return Result<DirectorReadDto>.Success(mappedDirector);
        }
    }
}
