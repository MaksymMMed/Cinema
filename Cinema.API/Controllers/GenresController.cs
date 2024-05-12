using Cinema.BLL.DTOs.Genres;
using Cinema.BLL.Filtering.Genres;
using Cinema.BLL.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class GenresController : ControllerBase
    {
        private readonly IGenresService _GenresService;

        public GenresController(IGenresService GenresService)
        {
            _GenresService = GenresService;
        }

        [HttpGet]
        public async Task<IActionResult> Get([FromQuery] GenresFilteringModel model)
        {
            var result = await _GenresService.Get(model);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }

        [HttpGet]
        [Route("{id}")]
        public async Task<IActionResult> GetById(Guid id)
        {
            var result = await _GenresService.GetById(id);

            if (!result.IsSuccess)
                return NotFound(result.Error);

            return Ok(result.Value);
        }

        [HttpPost]
        public async Task<IActionResult> Create([FromBody] GenreCreateDto dto)
        {
            var result = await _GenresService.Create(dto);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }

        [HttpPut]
        public async Task<IActionResult> Update([FromBody] GenreUpdateDto dto)
        {
            var result = await _GenresService.Update(dto);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var result = await _GenresService.Delete(id);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }
    }
}
