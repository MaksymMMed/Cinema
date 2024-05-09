using Cinema.BLL.DTOs.Account;
using Cinema.BLL.Interfaces;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Cinema.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AccountController : ControllerBase
    {
        private readonly IAccountService _accountService;

        public AccountController(IAccountService accountService)
        {
            _accountService = accountService;
        }

        [HttpPost("sign-in")]
        public async Task<IActionResult> SignIn([FromBody] SignInDto model)
        {
            var result = await _accountService.SignIn(model); 

            if (!result.IsSuccess)
                return Unauthorized(result.Error);

            return Ok(result.Value);
        }

        [HttpPost("sign-up-user")]
        public async Task<IActionResult> SignUpUser([FromBody] SignUpDto model)
        {
            var result = await _accountService.SignUpUser(model);
            if (result.IsSuccess) 
                return Ok(result.Value);

            if (result.Error == "UserAlreadyExists")
                return Conflict("User already exists.");
            
            return BadRequest(result.Error);
        }

        [Authorize(Roles ="SuperAdmin")]
        [HttpPost("sign-up-admin")]
        public async Task<IActionResult> SignUpAdmin([FromBody] SignUpDto model)
        {
            var result = await _accountService.SignUpAdmin(model);
            if (result.IsSuccess)
                return Ok(result.Value);

            if (result.Error == "UserAlreadyExists")
                return Conflict("User already exists.");

            return BadRequest(result.Error);
        }
    }
}
