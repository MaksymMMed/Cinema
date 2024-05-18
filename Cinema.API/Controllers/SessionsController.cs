using Cinema.BLL.DTOs.Sessions;
using Cinema.BLL.Filtering.Sessions;
using Cinema.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers;

[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class SessionsController : ControllerBase
{
    private readonly ISessionsService _sessionsService;

    public SessionsController(ISessionsService sessionsService)
    {
        _sessionsService = sessionsService;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] SessionsFilteringModel model)
    {
        var result = await _sessionsService.Get(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }

    [HttpGet]
    [Route("{id}")]
    public async Task<IActionResult> GetById(Guid id)
    {
        var result = await _sessionsService.GetById(id);

        if (!result.IsSuccess)
            return NotFound(result.Error);

        return Ok(result.Value);
    }

    [HttpPost]
    public async Task<IActionResult> Create([FromBody] SessionCreateDto dto)
    {
        var result = await _sessionsService.Create(dto);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }

    [HttpPut]
    public async Task<IActionResult> Update([FromBody] SessionUpdateDto dto)
    {
        var result = await _sessionsService.Update(dto);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }

    [HttpDelete]
    [Route("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _sessionsService.Delete(id);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }

}
