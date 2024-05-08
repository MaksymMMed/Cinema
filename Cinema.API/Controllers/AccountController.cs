using Cinema.BLL.DTOs.Account;
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
        private readonly UserManager<AspNetUser> userManager;
        private readonly RoleManager<IdentityRole<Guid>> roleManager;
        private readonly IConfiguration configuration;

        public AccountController(UserManager<AspNetUser> userManager, RoleManager<IdentityRole<Guid>> roleManager, IConfiguration configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
        }

        [HttpPost("SignIn")]
        public async Task<IActionResult> SignIn([FromBody] SignInDto model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!));

                var token = new JwtSecurityToken(
                    issuer: "JWT:ValidIssuer",
                    audience: "JWT:ValidAudience",
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                return Ok(new
                {
                    token = new JwtSecurityTokenHandler().WriteToken(token),
                    expiration = token.ValidTo
                });
            }
            return Unauthorized();
        }

        [HttpPost("SignUpUser")]
        public async Task<IActionResult> SignUpUser([FromBody] SignUpDto model)
        {
            var userExists = await userManager.FindByEmailAsync(model.Email);
            if (userExists != null)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResponseDto { Status = "Error", Message = "User already exists!" });
            }

            AspNetUser user = new AspNetUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await userManager.CreateAsync(user, model.Password);

            if (!result.Succeeded)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ResponseDto { Status = "Error", Message = string.Join(" ", result.Errors.Select(x=> x.Description))});
            }

            if (!await roleManager.RoleExistsAsync(UserRolesEnum.User.GetDisplayName()))
            {
                await roleManager.CreateAsync(new IdentityRole<Guid>(UserRolesEnum.User.GetDisplayName()));
            }

            if (await roleManager.RoleExistsAsync(UserRolesEnum.User.GetDisplayName()))
            {
                await userManager.AddToRoleAsync(user, UserRolesEnum.User.GetDisplayName());
            }
            return Ok(new ResponseDto { Status = "Success", Message = "User created successfully!" });
        }
    }
}
