using Cinema.BLL.DTOs.Account;
using Cinema.BLL.Interfaces;
using Cinema.DAL.Entities;
using Cinema.DAL.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using Microsoft.OpenApi.Extensions;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

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
            if (result.IsSuccess) 
            {
                return Ok(result.Value);
            }
            else 
            {
                return Unauthorized(result.Error);
            }
        }

        [HttpPost("sign-up-user")]
        public async Task<IActionResult> SignUpUser([FromBody] SignUpDto model)
        {
            var result = await _accountService.SignUpUser(model);
            if (result.IsSuccess) 
            {
                return Ok(result.Value);
            }
            else
            {
                return StatusCode(StatusCodes.Status500InternalServerError, result.Error);
            }
        }
    }
}
