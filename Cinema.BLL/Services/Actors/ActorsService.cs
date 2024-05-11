using AutoMapper.QueryableExtensions;
using AutoMapper;
using Cinema.BLL.DTOs.Actors;
using Cinema.BLL.DTOs;
using Cinema.BLL.Extensions;
using Cinema.BLL.Filtering.Actors;
using Cinema.BLL.Interfaces;
using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Actors;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Cinema.BLL.Services.Actors
{
    public class ActorsService : BusinessService<Actor, Guid>, IActorsService
    {
        public ActorsService(IHttpContextAccessor httpContextAccessor, IActorsRepository repository, IMapper mapper
            ) : base(httpContextAccessor, repository, mapper)
        {
        }

        public async Task<Result<ActorReadDto>> Create(ActorCreateDto dto)
        {
            var Actor = _mapper.Map<Actor>(dto);

            await _repository.Add(Actor);

            var mappedActor = _mapper.Map<ActorReadDto>(Actor);
            return Result<ActorReadDto>.Success(mappedActor);
        }

        public async Task<Result<ActorReadDto>> Delete(Guid id)
        {
            var Actor = await _repository.GetById(id);

            if (Actor == null)
                return Result<ActorReadDto>.Fail($"Actor with id {id} not found");

            await _repository.Delete(Actor);

            var mappedActor = _mapper.Map<ActorReadDto>(Actor);
            return Result<ActorReadDto>.Success(mappedActor);
        }

        public async Task<Result<EntitiesWithTotalCount<ActorReadDto>>> Get(ActorsFilteringModel model)
        {
            var query = _repository.GetQuery(include: q => q
                .Include(x => x.ActorMovies)).Filter(model);

            var totalCount = query.Count();
            query = query.SortByField(model).Paginate(model);

            var mappedActors = await query.ProjectTo<ActorReadDto>(_mapper.ConfigurationProvider).ToListAsync();

            var result = new EntitiesWithTotalCount<ActorReadDto> { Items = mappedActors, TotalCount = totalCount };
            return Result<EntitiesWithTotalCount<ActorReadDto>>.Success(result);
        }

        public async Task<Result<ActorReadDto>> GetById(Guid id)
        {
            var Actor = await _repository.GetByIdWithInclude(id, include: q => q
                       .Include(x => x.ActorMovies));

            if (Actor == null)
                return Result<ActorReadDto>.Fail($"Actor with id {id} not found");

            var mappedActor = _mapper.Map<ActorReadDto>(Actor);
            return Result<ActorReadDto>.Success(mappedActor);
        }

        public async Task<Result<ActorReadDto>> Update(ActorUpdateDto dto)
        {
            var Actor = await _repository.GetById(dto.Id);

            if (Actor == null)
                return Result<ActorReadDto>.Fail($"Actor with id {dto.Id} not found");

            _mapper.Map(dto, Actor);

            var newActor = _repository.Update(Actor).Result;

            var mappedActor = _mapper.Map<ActorReadDto>(newActor);
            return Result<ActorReadDto>.Success(mappedActor);
        }
    }
}