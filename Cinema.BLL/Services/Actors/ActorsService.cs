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
        public ActorsService(
            IHttpContextAccessor httpContextAccessor,
            IActorsRepository repository,
            IMapper mapper
            ) : base(httpContextAccessor, repository, mapper)
        {
        }

        public async Task<Result<ActorReadDto>> Create(ActorCreateDto dto)
        {
            var actor = _mapper.Map<Actor>(dto);

            await _repository.Add(actor);

            var mappedActor = _mapper.Map<ActorReadDto>(actor);
            return Result<ActorReadDto>.Success(mappedActor);
        }

        public async Task<Result<ActorReadDto>> Delete(Guid id)
        {
            var actor = await _repository.GetById(id);

            if (actor == null)
                return Result<ActorReadDto>.Fail($"Actor with id {id} not found");

            await _repository.Delete(actor);

            var mappedActor = _mapper.Map<ActorReadDto>(actor);
            return Result<ActorReadDto>.Success(mappedActor);
        }

        public async Task<Result<EntitiesWithTotalCount<ActorReadDto>>> Get(ActorsFilteringModel model)
        {
            var query = _repository.GetQuery().Filter(model);

            var totalCount = query.Count();
            query = query.SortByField(model).Paginate(model);

            var mappedActors = await query.ProjectTo<ActorReadDto>(_mapper.ConfigurationProvider).ToListAsync();

            var result = new EntitiesWithTotalCount<ActorReadDto> { Items = mappedActors, TotalCount = totalCount };
            return Result<EntitiesWithTotalCount<ActorReadDto>>.Success(result);
        }

        public async Task<Result<ActorReadDto>> GetById(Guid id)
        {
            var actor = await _repository.GetById(id);

            if (actor == null)
                return Result<ActorReadDto>.Fail($"Actor with id {id} not found");

            var mappedActor = _mapper.Map<ActorReadDto>(actor);
            return Result<ActorReadDto>.Success(mappedActor);
        }

        public async Task<Result<ActorReadDto>> Update(ActorUpdateDto dto)
        {
            var actor = await _repository.GetById(dto.Id);

            if (actor == null)
                return Result<ActorReadDto>.Fail($"Actor with id {dto.Id} not found");

            _mapper.Map(dto, actor);

            var newActor = _repository.Update(actor).Result;

            var mappedActor = _mapper.Map<ActorReadDto>(newActor);
            return Result<ActorReadDto>.Success(mappedActor);
        }
    }
}