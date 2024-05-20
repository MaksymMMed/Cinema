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


        [HttpPost("confirm-email")]
        public async Task<IActionResult> ConfirmEmail([FromQuery] string Value, [FromQuery] string Email)
        {
            var result = await _accountService.ConfirmEmail(Email, Value);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }

        [HttpPost("change-password")]
        public async Task<IActionResult> ChangePassword(ChangePasswordDto model)
        {
            var result = await _accountService.ChangePassword(model);
            
            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }

        [HttpPost("change-username")]
        public async Task<IActionResult> ChangeUserName(ChangeUserNameDto model)
        {
            var result = await _accountService.ChangeUserName(model);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
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
            {
                var getConfirmationToken = await _accountService.GenerateConfirmationToken(model.Email);
                if (getConfirmationToken.IsSuccess)
                {
                    var confirmationLink = Url.Action("ConfirmEmail", "Account", new { getConfirmationToken.Value, model.Email }, Request.Scheme);
                    await _accountService.SendConfirmationEmail(model.Email,confirmationLink!);
                    return Ok(result.Value);
                }
                return BadRequest(getConfirmationToken.Error);
            }

            return BadRequest(result.Error);
        }

        [Authorize(Roles ="SuperAdmin")]
        [HttpPost("sign-up-admin")]
        public async Task<IActionResult> SignUpAdmin([FromBody] SignUpDto model)
        {
            var result = await _accountService.SignUpAdmin(model);
            if (result.IsSuccess)
                return Ok(result.Value);

            return BadRequest(result.Error);
        }
    }
}
