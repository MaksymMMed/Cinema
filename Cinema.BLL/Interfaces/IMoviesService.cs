using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Movies;
using Cinema.BLL.Filtering.Movies;

namespace Cinema.BLL.Interfaces;

public interface IMoviesService
{
    Task<Result<EntitiesWithTotalCount<MovieReadDto>>> Get(MoviesFilteringModel model);
}