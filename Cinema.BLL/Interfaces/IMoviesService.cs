using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Movies;
using Cinema.BLL.Filtering.Movies;

namespace Cinema.BLL.Interfaces;

public interface IMoviesService
{
    Task<Result<EntitiesWithTotalCount<MovieReadDto>>> Get(MoviesFilteringModel model);

    Task<Result<MovieDetailsDto>> GetById(Guid id);

    Task<Result<MovieReadDto>> Create(MovieCreateDto model);

    Task<Result<MovieReadDto>> Update(MovieUpdateDto model);

    Task<Result<bool>> UpdateMovieImageSet(UpdateMovieImageSetDto model);

    Task<Result<bool>> AddGenreToMovie(MovieGenreDto model);

    Task<Result<bool>> RemoveGenreFromMovie(MovieGenreDto model);

    Task<Result<bool>> AddActorToMovie(MovieActorDto model);

    Task<Result<bool>> RemoveActorFromMovie(MovieActorDto model);

    Task<Result<bool>> Delete(Guid id);
}