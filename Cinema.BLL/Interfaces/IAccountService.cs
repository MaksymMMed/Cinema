using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Account;

namespace Cinema.BLL.Interfaces
{
    public interface IAccountService
    {
        Task<Result<TokenDto>> SignIn(SignInDto model);
        Task<Result<TokenDto>> SignUpUser(SignUpDto model);
        Task<Result<TokenDto>> SignUpAdmin(SignUpDto model);
        Task<Result<string>> GenerateConfirmationToken(string email);
        Task SendConfirmationEmail(string email, string confirmationLink);
        Task<Result<string>> ConfirmEmail(string email, string confirmationToken);
        Task<Result<string>> ChangePassword(ChangePasswordDto model);
        Task<Result<string>> ChangeUserName(ChangeUserNameDto model);
    }
}