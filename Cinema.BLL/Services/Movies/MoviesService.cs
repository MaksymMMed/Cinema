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
    private readonly IDirectorsRepository _directorsRepository;
    private readonly IMapper _mapper;

    public MoviesService(
        IHttpContextAccessor httpContextAccessor, 
        IMoviesRepository moviesRepository,
        IMoviesGenresRepository moviesGenresRepository,
        IMoviesActorsRepository moviesActorsRepository,
        IDirectorsRepository directorsRepository,
        IMapper mapper
    ) : base(httpContextAccessor)
    {
        _moviesRepository = moviesRepository;
        _moviesGenresRepository = moviesGenresRepository;
        _moviesActorsRepository = moviesActorsRepository;
        _directorsRepository = directorsRepository;
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
    
    public async Task<Result<MovieDetailsDto>> GetById(Guid id)
    {
        var movie = await _moviesRepository
            .GetQuery(include: q => q
                .Include(m => m.MovieGenres)
                .ThenInclude(mg => mg.Genre)
                .Include(j => j.MovieActors)
                .ThenInclude(ma => ma.Actor)
                .Include(j => j.Director)
                .Include(j => j.MovieReviews)
                .Include(j => j.ImageSet))
            .ProjectTo<MovieDetailsDto>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(m => m.Id == id);
        
        return movie == null 
            ? Result<MovieDetailsDto>.Fail($"Movie with id {id} not found")! 
            : Result<MovieDetailsDto>.Success(movie);
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

    public async Task<Result<MovieReadDto>> Update(MovieUpdateDto model)
    {
        var movie = await _moviesRepository
            .GetQuery(include: q => q
                .Include(m => m.MovieGenres)
                .ThenInclude(mg => mg.Genre)
                .Include(j => j.Director)
                .Include(j => j.MovieReviews)
                .Include(j => j.Sessions))
            .ProjectTo<MovieReadDto>(_mapper.ConfigurationProvider)
            .FirstOrDefaultAsync(m => m.Id == model.Id);

        if (movie == null)
            return Result<MovieReadDto>.Fail($"Movie with id {model.Id} not found")!;

        var mappedModel = _mapper.Map<Movie>(model);
        await _moviesRepository.Update(mappedModel);
        
        var result = _mapper.Map<MovieReadDto>(mappedModel);
        result.AvgMark = movie.AvgMark;
        result.Genres = movie.Genres;
        result.FiveClosestSessions = movie.FiveClosestSessions;
        
        if (result.DirectorId != movie.DirectorId)
        {
            var director = await _directorsRepository.GetById(result.DirectorId);
            result.DirectorName = director!.Name;
        }
        else
            result.DirectorName = movie.Name;

        return Result<MovieReadDto>.Success(result);
    }
    
    public async Task<Result<bool>> UpdateMovieImageSet(UpdateMovieImageSetDto model)
    {
        var movieImageSet = _mapper.Map<MovieImageSet>(model);
        await _moviesRepository.UpdateImageSet(movieImageSet);
        return Result<bool>.Success(true);
    }

    public async Task<Result<bool>> AddGenreToMovie(MovieGenreDto model)
    {
        var movieGenreExists = await _moviesGenresRepository.AnyByMovieIdAndGenreId(model.MovieId, model.GenreId);
        if (movieGenreExists)
            return Result<bool>.Fail("Movie already has this genre.");
        
        var movieGenre = _mapper.Map<MovieGenre>(model);
        await _moviesGenresRepository.Add(movieGenre);
        return Result<bool>.Success(true);
    }
    
    public async Task<Result<bool>> RemoveGenreFromMovie(MovieGenreDto model)
    {
        var movieGenre = _mapper.Map<MovieGenre>(model);
        await _moviesGenresRepository.Delete(movieGenre);
        return Result<bool>.Success(true);
    }
    
    public async Task<Result<bool>> AddActorToMovie(MovieActorDto model)
    {
        var movieGenreExists = await _moviesActorsRepository.AnyByMovieIdAndActorId(model.MovieId, model.ActorId);
        if (movieGenreExists)
            return Result<bool>.Fail("Movie already has this actor.");
        
        var actorMovie = _mapper.Map<ActorMovie>(model);
        await _moviesActorsRepository.Add(actorMovie);
        return Result<bool>.Success(true);
    }
    
    public async Task<Result<bool>> RemoveActorFromMovie(MovieActorDto model)
    {
        var actorMovie = _mapper.Map<ActorMovie>(model);
        await _moviesActorsRepository.Delete(actorMovie);
        return Result<bool>.Success(true);
    }

    public async Task<Result<bool>> Delete(Guid id)
    {
        var movie = await _moviesRepository.GetById(id);
        if(movie == null)
            return Result<bool>.Fail($"Movie with id {id} does not exist.")!;
            
        await _moviesRepository.Delete(movie);
        return Result<bool>.Success(true);
    }
}