using Cinema.BLL.Filtering.Halls;
using Cinema.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class HallsController : ControllerBase
{
    private readonly IHallsService _hallsService;

    public HallsController(IHallsService hallsService)
    {
        _hallsService = hallsService;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] HallsFilteringModel model)
    {
        var result = await _hallsService.Get(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _hallsService.GetById(id);

        if (!result.IsSuccess)
            return NotFound(result.Error);

        return Ok(result.Value);
    }
}