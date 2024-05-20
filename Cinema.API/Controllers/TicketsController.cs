using Cinema.BLL.DTOs.Tickets;
using Cinema.BLL.Filtering.Tickets;
using Cinema.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers;

[Authorize]
[ApiController]
[Route("api/[controller]")]
[Produces("application/json")]
public class TicketsController : ControllerBase
{
    private readonly ITicketsService _ticketsService;
        
    public TicketsController(ITicketsService ticketsService)
    {
        _ticketsService = ticketsService;
    }

    [HttpGet]
    public async Task<IActionResult> Get([FromQuery] TicketsFilteringModel model)
    {
        var result = await _ticketsService.Get(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpGet("{id}")]
    public async Task<IActionResult> Get(Guid id)
    {
        var result = await _ticketsService.GetById(id);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpPost]
    public async Task<IActionResult> Create([FromBody] CreateTicketsDto model)
    {
        var result = await _ticketsService.Create(model);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
    
    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(Guid id)
    {
        var result = await _ticketsService.Delete(id);

        if (!result.IsSuccess)
            return BadRequest(result.Error);

        return Ok(result.Value);
    }
}