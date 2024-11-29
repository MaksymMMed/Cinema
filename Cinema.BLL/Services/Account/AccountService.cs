using AutoMapper;
using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Account;
using Cinema.BLL.DTOs.Invoices;
using Cinema.BLL.DTOs.Reviews;
using Cinema.BLL.DTOs.Tickets;
using Cinema.BLL.Interfaces;
using Cinema.BLL.Services.Core;
using Cinema.DAL.Entities;
using Cinema.DAL.Enums;
using Cinema.DAL.Interfaces.Invoices;
using Cinema.DAL.Interfaces.Reviews;
using Cinema.DAL.Interfaces.Tickets;
using Cinema.EmailService.Sender;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;


namespace Cinema.BLL.Services.Account
{
    public class AccountService : BaseBusinessService, IAccountService
    {
        private readonly UserManager<AspNetUser> _userManager;
        private readonly RoleManager<IdentityRole<Guid>> _roleManager;
        private readonly IEmailSender _emailSender;
        private readonly IConfiguration _configuration;
        private readonly IMapper _mapper;
        private readonly IReviewsRepository _reviewsRepository;
        private readonly IInvoicesRepository _invoicesRepository;

        public AccountService(
            IInvoicesRepository invoicesRepository,
            IReviewsRepository reviewsRepository,
            IHttpContextAccessor httpContextAccessor,
            UserManager<AspNetUser> userManager,
            RoleManager<IdentityRole<Guid>> roleManager,
            IEmailSender emailSender,
            IConfiguration configuration,
            IMapper mapper
        ) : base(httpContextAccessor)
        {
            _reviewsRepository = reviewsRepository;
            _invoicesRepository = invoicesRepository;
            _userManager = userManager;
            _roleManager = roleManager;
            _emailSender = emailSender;
            _configuration = configuration;
            _mapper = mapper;
        }

        public async Task<Result<UserInfoDto>> GetUserInfo()
        {
            var user = await _userManager.FindByIdAsync(CurrentUserId!);

            if (user == null)
                return Result<UserInfoDto>.Fail("User not founded")!;

            var invoices = await _invoicesRepository.GetQuery(include: q => q
                .Include(x => x.Tickets)
                    .ThenInclude(x => x.Session)
                    .ThenInclude(x => x.Movie)
                .Include(x => x.Tickets)
                    .ThenInclude(x => x.Session)
                    .ThenInclude(x => x.Hall))
                .Where(x=>x.CreatedById == user.Id) 
                .ToListAsync();

            var reviews = await _reviewsRepository
                .GetQuery(include: q => q
                .Include(x => x.Movie))
                .Where(x => x.CreatedById == user.Id)
                .ToListAsync();
;


            UserInfoDto userInfo = new UserInfoDto()
            {
                Email = user.Email!,
                UserName = user.UserName!,
                Reviews = _mapper.Map<IEnumerable<ReviewReadDto>>(reviews),
                Invoices = _mapper.Map<IEnumerable<InvoiceDetailsReadDto>>(invoices)

            }; 
            return Result<UserInfoDto>.Success(userInfo);
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
                expires: DateTime.Now.AddDays(7),
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

        public async Task<Result<string>> GenerateResetPasswordToken(string email)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return Result<string>.Fail("User not found")!;

            var resetToken = await _userManager.GeneratePasswordResetTokenAsync(user);
            return Result<string>.Success(resetToken);
        }

        public async Task SendResetPasswordEmail(string email, string confirmationLink)
        {
            await _emailSender.SendResetPasswordEmailAsync(email, confirmationLink);
        }

        public async Task<Result<string>> ResetPassword(string email, string resetToken, string newPassword, string confirmPassword)
        {
            var user = await _userManager.FindByEmailAsync(email);
            if (user == null)
                return Result<string>.Fail("User not found")!;

            if (newPassword != confirmPassword)
                return Result<string>.Fail("Passwords do not match")!;

            await _userManager.ResetPasswordAsync(user, resetToken, newPassword);
            return Result<string>.Success("Password changed");
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

        public async Task<Result<string>> ChangePassword(ChangePasswordDto model)
        {
            var user = await _userManager.FindByIdAsync(CurrentUserId!);
            if (user == null)
                return Result<string>.Fail("User not found")!;

            var result = await _userManager.ChangePasswordAsync(user, model.OldPassword,model.NewPassword);
            if (!result.Succeeded)
                return Result<string>.Fail(string.Join(", ", result.Errors.Select(e => e.Description)))!;

            return Result<string>.Success("Password successfully changed"); 
        }

        public async Task<Result<string>> ChangeUserName(ChangeUserNameDto model)
        {
            var user = await _userManager.FindByIdAsync(CurrentUserId!);
            if (user == null)
                return Result<string>.Fail("User not found")!;

            var result = await _userManager.SetUserNameAsync(user, model.UserName);
            if (!result.Succeeded)
                return Result<string>.Fail(string.Join(", ", result.Errors.Select(e => e.Description)))!;

            return Result<string>.Success("UserName successfully changed");
        }
    }
}
