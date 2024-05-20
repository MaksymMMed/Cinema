using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Movies;
using Cinema.RecomendationSystem;

namespace Cinema.BLL.Interfaces
{
    public interface IRecomendationsService
    {
        Task<Result<List<MovieReadDto>>> GetRecommendedMovies();
    }
}