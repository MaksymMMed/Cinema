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
    [Route("api/[controller]")]
    public async Task<IActionResult> Get([FromQuery] MoviesFilteringModel model)
    {
        var result = await _moviesService.Get(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
}