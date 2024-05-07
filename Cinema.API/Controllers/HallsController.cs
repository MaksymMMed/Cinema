using Cinema.BLL.DTOs.Halls;
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
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] HallCreateDto dto)
    {
        var result = await _hallsService.Create(dto);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    [HttpPut]
    public async Task<IActionResult> Update([FromBody] HallUpdateDto dto)
    {
        var result = await _hallsService.Update(dto);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _hallsService.Delete(id);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
}