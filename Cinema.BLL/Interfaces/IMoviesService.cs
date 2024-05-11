using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Movies;
using Cinema.BLL.Filtering.Movies;

namespace Cinema.BLL.Interfaces;

public interface IMoviesService
{
    Task<Result<EntitiesWithTotalCount<MovieReadDto>>> Get(MoviesFilteringModel model);

    Task<Result<MovieDetailsDto>> GetById(Guid id);

    Task<Result<MovieReadDto>> Create(MovieCreateDto model);
}