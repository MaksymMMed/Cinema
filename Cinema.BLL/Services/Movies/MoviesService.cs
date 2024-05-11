using AutoMapper;
using AutoMapper.QueryableExtensions;
using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Movies;
using Cinema.BLL.Extensions;
using Cinema.BLL.Filtering.Movies;
using Cinema.BLL.Interfaces;
using Cinema.BLL.Services.Core;
using Cinema.DAL.Entities;
using Cinema.DAL.Interfaces.Movies;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json;

namespace Cinema.BLL.Services.Movies;

public class MoviesService : BaseBusinessService, IMoviesService
{
    private readonly IMoviesRepository _moviesRepository;
    private readonly IMoviesGenresRepository _moviesGenresRepository;
    private readonly IMoviesActorsRepository _moviesActorsRepository;
    private readonly IMapper _mapper;

    public MoviesService(
        IHttpContextAccessor httpContextAccessor, 
        IMoviesRepository moviesRepository,
        IMoviesGenresRepository moviesGenresRepository,
        IMoviesActorsRepository moviesActorsRepository,
        IMapper mapper
    ) : base(httpContextAccessor)
    {
        _moviesRepository = moviesRepository;
        _moviesGenresRepository = moviesGenresRepository;
        _moviesActorsRepository = moviesActorsRepository;
        _mapper = mapper;
    }

    public async Task<Result<EntitiesWithTotalCount<MovieReadDto>>> Get(MoviesFilteringModel model)
    {
        var query = _moviesRepository
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
    
    public async Task<Result<MovieReadDto>> Create(MovieCreateDto model)
    {
        // In the future this check can be moved to the FluentValidation
        if(!model.ImagesUrls.Any())
            return Result<MovieReadDto>.Fail("The movie needs to have at least one image.")!;
        
        var movie = _mapper.Map<Movie>(model);
        movie.ImageUrl = model.ImagesUrls.First();
        await _moviesRepository.Add(movie);

        var serializedImageUrls = JsonConvert.SerializeObject(model.ImagesUrls.Skip(1));
        await _moviesRepository.AddImageSet(new MovieImageSet { MovieId = movie.Id, ImagesUrl = serializedImageUrls });

        var movieGenres = model.GenresIds
            .Select(genreId => new MovieGenre {MovieId = movie.Id, GenreId = genreId}).ToList();
        await _moviesGenresRepository.AddRange(movieGenres);
        
        var movieActors = model.ActorsIds
            .Select(actorId => new ActorMovie {MovieId = movie.Id, ActorId = actorId}).ToList();
        await _moviesActorsRepository.AddRange(movieActors);

        movie = await _moviesRepository.GetByIdWithInclude(movie.Id, include: q => q
            .Include(m => m.MovieGenres)
            .ThenInclude(mg => mg.Genre)
            .Include(j => j.Director));
        
        var result = _mapper.Map<MovieReadDto>(movie);
        return Result<MovieReadDto>.Success(result);
    }
}