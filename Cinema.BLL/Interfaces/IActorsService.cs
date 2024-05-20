using Cinema.BLL.DTOs.Actors;
using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Movies;
using Cinema.BLL.Filtering.Actors;
using Cinema.BLL.Filtering.Movies;

namespace Cinema.BLL.Interfaces
{
    public interface IActorsService
    {
        Task<Result<EntitiesWithTotalCount<ActorReadDto>>> Get(ActorsFilteringModel model);

        Task<Result<ActorReadDto>> GetById(Guid id);

        Task<Result<EntitiesWithTotalCount<MovieReadDto>>> GetActorMovies(Guid id,
            MoviesFilteringModel filter);

        Task<Result<ActorReadDto>> Create(ActorCreateDto dto);

        Task<Result<ActorReadDto>> Update(ActorUpdateDto dto);

        Task<Result<ActorReadDto>> Delete(Guid id);

    }
}
