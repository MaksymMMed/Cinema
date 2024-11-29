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
        public async Task<IActionResult> ConfirmEmail([FromQuery] string token, [FromQuery] string email)
        {
            var result = await _accountService.ConfirmEmail(email, token);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }
        [Authorize]
        [HttpGet("profile")]
        public async Task<IActionResult> GetProfile()
        {
            var result = await _accountService.GetUserInfo();

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }

        [HttpPost("reset-password")]
        public async Task<IActionResult> ResetPassword([FromBody] ResetPasswordDto model)
        {
            var result = await _accountService.ResetPassword(model.Email,model.Token,model.NewPassword,model.ConfirmPassword);

            if (!result.IsSuccess)
                return BadRequest(result.Error);

            return Ok(result.Value);
        }

        [HttpPost("send-reset-password-email")]
        public async Task<IActionResult> SendResetPasswordEmail(string email)
        {
            var result = await _accountService.GenerateResetPasswordToken(email);

            if (result.IsSuccess)
            {
                var GetResetToken = await _accountService.GenerateResetPasswordToken(email);
                if (GetResetToken.IsSuccess)
                {
                    await _accountService.SendResetPasswordEmail(email, GetResetToken.Value!);
                    return Ok("Email sent");
                }
                return BadRequest(GetResetToken.Error);
            }

            return BadRequest(result.Error);
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
                    var confirmationLink = Url.Action("ConfirmEmail", "Account", new {token = getConfirmationToken.Value,email = model.Email }, Request.Scheme);
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
