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
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] MovieCreateDto model)
    {
        var result = await _moviesService.Create(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
}