using Cinema.BLL.DTOs.Movies;
using Cinema.BLL.Filtering.Movies;
using Cinema.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class MoviesController : ControllerBase
{
    private readonly IMoviesService _moviesService;
        
    public MoviesController(IMoviesService moviesService)
    {
        _moviesService = moviesService;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] MoviesFilteringModel model)
    {
        var result = await _moviesService.Get(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _moviesService.GetById(id);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] MovieCreateDto model)
    {
        var result = await _moviesService.Create(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpPut]
    public async Task<IActionResult> Update([FromBody] MovieUpdateDto model)
    {
        var result = await _moviesService.Update(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpPatch("update-image-set")]
    public async Task<IActionResult> UpdateMovieImageSet(UpdateMovieImageSetDto model)
    {
        var result = await _moviesService.UpdateMovieImageSet(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpPatch("add-genre")]
    public async Task<IActionResult> AddGenreToMovie(MovieGenreDto model)
    {
        var result = await _moviesService.AddGenreToMovie(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpPatch("remove-genre")]
    public async Task<IActionResult> RemoveGenreFromMovie(MovieGenreDto model)
    {
        var result = await _moviesService.RemoveGenreFromMovie(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpPatch("add-actor")]
    public async Task<IActionResult> AddActorToMovie(MovieActorDto model)
    {
        var result = await _moviesService.AddActorToMovie(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpPatch("remove-actor")]
    public async Task<IActionResult> RemoveActorFromMovie(MovieActorDto model)
    {
        var result = await _moviesService.RemoveActorFromMovie(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _moviesService.Delete(id);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
}