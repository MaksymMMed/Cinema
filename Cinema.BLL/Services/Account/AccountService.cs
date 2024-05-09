using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Account;
using Cinema.BLL.Interfaces;
using Cinema.DAL.Entities;
using Cinema.DAL.Enums;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace Cinema.BLL.Services.Account
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AspNetUser> userManager;
        private readonly RoleManager<IdentityRole<Guid>> roleManager;
        private readonly IConfiguration configuration;

        public AccountService(UserManager<AspNetUser> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            IConfiguration configuration)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.configuration = configuration;
        }

        public async Task<Result<TokenDto>> SignIn(SignInDto model)
        {
            var user = await userManager.FindByEmailAsync(model.Email);
            if (user != null && await userManager.CheckPasswordAsync(user, model.Password))
            {
                var userRoles = await userManager.GetRolesAsync(user);

                var authClaims = new List<Claim>
                {
                    new Claim(ClaimTypes.Email, user.Email),
                    new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                    new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                };

                foreach (var userRole in userRoles)
                {
                    authClaims.Add(new Claim(ClaimTypes.Role, userRole));
                }

                var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(configuration["Jwt:Key"]!));

                var token = new JwtSecurityToken(
                    issuer: configuration["Jwt:Issuer"],
                    audience: configuration["Jwt:Audience"],
                    expires: DateTime.Now.AddHours(3),
                    claims: authClaims,
                    signingCredentials: new SigningCredentials(authSigningKey, SecurityAlgorithms.HmacSha256)
                    );

                TokenDto tokenDto = new()
                {
                    Token = new JwtSecurityTokenHandler().WriteToken(token),
                    Expiration = token.ValidTo
                };

                return Result<TokenDto>.Success(tokenDto);
            }
            else
            {
                return Result<TokenDto>.Fail("Wrong email or password");
            }
        }

        public async Task<Result<TokenDto>> SignUpUser(SignUpDto model)
        {
            var userExists = await userManager.FindByEmailAsync(model.Email);
            if (userExists != null)
            {
                return Result<TokenDto>.Fail("UserAlreadyExists");
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
                string errors = string.Join(" ", result.Errors.Select(x => x.Description));
                return Result<TokenDto>.Fail(errors);
            }

            if (!await roleManager.RoleExistsAsync(UserRolesEnum.User.ToString()))
            {
                await roleManager.CreateAsync(new IdentityRole<Guid>(UserRolesEnum.User.ToString()));
            }

            if (await roleManager.RoleExistsAsync(UserRolesEnum.User.ToString()))
            {
                await userManager.AddToRoleAsync(user, UserRolesEnum.User.ToString());
            }

            SignInDto signInDto = new SignInDto()
            {
                Email = model.Email,
                Password = model.Password
            };

            return await SignIn(signInDto);
        }
    }
}
