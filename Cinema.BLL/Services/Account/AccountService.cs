using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Account;
using Cinema.BLL.Interfaces;
using Cinema.DAL.Entities;
using Cinema.DAL.Enums;
using Cinema.EmailService.Sender;
using Microsoft.AspNetCore.Identity;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;
using System;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace Cinema.BLL.Services.Account
{
    public class AccountService : IAccountService
    {
        private readonly UserManager<AspNetUser> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IEmailSender _emailSender;
        private readonly IConfiguration _configuration;

        public AccountService(
            UserManager<AspNetUser> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            IEmailSender emailSender,
            IConfiguration configuration
        )
        {
            _userManager = userManager;
            _roleManager = roleManager;
            _emailSender = emailSender;
            _configuration = configuration;
        }

        public async Task<Result<TokenDto>> SignIn(SignInDto model)
        {
            var user = await _userManager.FindByEmailAsync(model.Email);
            if (user == null || !await _userManager.CheckPasswordAsync(user, model.Password))
                return Result<TokenDto>.Fail("Wrong email or password")!;
            
            var userRoles = await _userManager.GetRolesAsync(user);

            var authClaims = new List<Claim>
            {
                new Claim(ClaimTypes.Email, user.Email!),
                new Claim(ClaimTypes.NameIdentifier, user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
            };

            foreach (var userRole in userRoles)
            {
                authClaims.Add(new Claim(ClaimTypes.Role, userRole));
            }

            var authSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_configuration["Jwt:Key"]!));

            var token = new JwtSecurityToken(
                issuer: _configuration["Jwt:Issuer"],
                audience: _configuration["Jwt:Audience"],
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

        private async Task<Result<TokenDto>> SignIn(SignUpDto model) => await SignIn(new SignInDto
        {
            Email = model.Email,
            Password = model.Password
        });

        private async Task<Result<AspNetUser>> SignUp(SignUpDto model)
        {
            var userExists = await _userManager.FindByEmailAsync(model.Email);
            if (userExists != null)
                return Result<AspNetUser>.Fail("User already exists")!;

            var user = new AspNetUser()
            {
                Email = model.Email,
                SecurityStamp = Guid.NewGuid().ToString(),
                UserName = model.Username
            };
            var result = await _userManager.CreateAsync(user, model.Password);

            if (result.Succeeded)
                return Result<AspNetUser>.Success(user);

            var errors = string.Join(" ", result.Errors.Select(x => x.Description));
            return Result<AspNetUser>.Fail(errors)!;
        }

        public async Task<Result<TokenDto>> SignUpUser(SignUpDto model)
        {
            var result = await SignUp(model);
            if (!result.IsSuccess)
                return Result<TokenDto>.Fail(result.Error!)!;

            var user = result.Value;

            if (await _roleManager.RoleExistsAsync(UserRolesEnum.User.ToString()))
            {
                await _userManager.AddToRoleAsync(user, UserRolesEnum.User.ToString());
            }

            return await SignIn(model);
        }

        public async Task<Result<TokenDto>> SignUpAdmin(SignUpDto model)
        {
            var result = await SignUp(model);
            if (!result.IsSuccess)
                return Result<TokenDto>.Fail(result.Error!)!;

            var user = result.Value;

            if (await _roleManager.RoleExistsAsync(UserRolesEnum.Admin.ToString()))
            {
                await _userManager.AddToRoleAsync(user, UserRolesEnum.Admin.ToString());
            }

            return await SignIn(model);
        }

        public async Task<Result<string>> GenerateConfirmationToken(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return Result<string>.Fail("User not found")!;

            var confirmationToken = await _userManager.GenerateEmailConfirmationTokenAsync(user);
            return Result<string>.Success(confirmationToken);
        }

        public async Task SendConfirmationEmail(string email, string confirmationLink)
        {
            await _emailSender.SendConfirmationEmailAsync(email, confirmationLink);
        }

        public async Task<Result<string>> ConfirmEmail(string email, string confirmationToken)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return Result<string>.Fail("User not found")!;

            var isConfirmed = await _userManager.IsEmailConfirmedAsync(user);
            if (isConfirmed)
                return Result<string>.Fail("Your email is already confirmed")!;

            await _userManager.ConfirmEmailAsync(user, confirmationToken);
            return Result<string>.Success("Your email is confirmed");
        }
    }
}
