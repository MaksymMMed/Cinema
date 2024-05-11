using Cinema.BLL.DTOs.Actors;
using Cinema.BLL.Filtering.Actors;
using Cinema.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class ActorsController : ControllerBase
    {
        private readonly IActorsService _ActorsService;

        public ActorsController(IActorsService ActorsService)
        {
            _ActorsService = ActorsService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] ActorsFilteringModel model)
        {
            var result = await _ActorsService.Get(model);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _ActorsService.GetById(id);

            if (!result.IsSuccess)
                return NotFound(result.Error);

            return Ok(result.Value);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] ActorCreateDto dto)
        {
            var result = await _ActorsService.Create(dto);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] ActorUpdateDto dto)
        {
            var result = await _ActorsService.Update(dto);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _ActorsService.Delete(id);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }
    }
}
