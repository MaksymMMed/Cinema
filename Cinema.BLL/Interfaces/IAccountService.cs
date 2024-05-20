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
        Task<Result<string>> GenerateResetPasswordToken(string email);
        Task SendConfirmationEmail(string email, string confirmationLink);
        Task SendResetPasswordEmail(string email, string confirmationLink);
        Task<Result<string>> ResetPassword(string email, string resetToken, string newPassword, string confirmPassword);
        Task<Result<string>> ConfirmEmail(string email, string confirmationToken);
        Task<Result<string>> ChangePassword(ChangePasswordDto model);
        Task<Result<string>> ChangeUserName(ChangeUserNameDto model);
    }
}