using Cinema.BLL.DTOs.Directors;
using Cinema.BLL.Filtering.Directors;
using Cinema.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class DirectorsController : ControllerBase
    {
        private readonly IDirectorsService _directorsService;

        public DirectorsController(IDirectorsService directorsService)
        {
            _directorsService = directorsService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] DirectorsFilteringModel model)
        {
            var result = await _directorsService.Get(model);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _directorsService.GetById(id);

            if (!result.IsSuccess)
                return NotFound(result.Error);

            return Ok(result.Value);
        }
        [HttpPost]
        public async Task<IActionResult> Create([FromBody] DirectorCreateDto dto)
        {
            var result = await _directorsService.Create(dto);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }
        [HttpPut]
        public async Task<IActionResult> Update([FromBody] DirectorUpdateDto dto)
        {
            var result = await _directorsService.Update(dto);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }
        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _directorsService.Delete(id);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }

    }
}
