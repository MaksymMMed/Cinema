using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Movies;
using Cinema.BLL.Extensions;
using Cinema.BLL.Filtering.Movies;
using Cinema.BLL.Interfaces;
using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Movies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;

namespace Cinema.BLL.Services.Movies;

public class MoviesService : BusinessService<Movie, Guid>, IMoviesService
{
    public MoviesService(
        IHttpContextAccessor httpContextAccessor, 
        IMoviesRepository repository, 
        IMapper mapper
    ) : base(httpContextAccessor, repository, mapper) 
    {
        
    }

    public async Task<Result<EntitiesWithTotalCount<MovieReadDto>>> Get(MoviesFilteringModel model)
    {
        var query = _repository
            .GetQuery(include: q => q
                .Include(m => m.MovieGenres)
                .ThenInclude(mg => mg.Genre)
                .Include(j => j.Director)
                .Include(j => j.MovieReviews)
                .Include(j => j.Sessions))
            .Filter(model);
        
        var totalCount = query.Count();
        query = query.SortByField(model).Paginate(model);

        var mappedMovies = await query.ProjectTo<MovieReadDto>(_mapper.ConfigurationProvider).ToListAsync();
        
        var result = new EntitiesWithTotalCount<MovieReadDto> { Items = mappedMovies, TotalCount = totalCount };
        return Result<EntitiesWithTotalCount<MovieReadDto>>.Success(result);
    }
}