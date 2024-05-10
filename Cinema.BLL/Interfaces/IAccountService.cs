using Cinema.BLL.DTOs;
using Cinema.BLL.DTOs.Account;

namespace Cinema.BLL.Interfaces
{
    public interface IAccountService
    {
        Task<Result<TokenDto>> SignIn(SignInDto model);
        Task<Result<TokenDto>> SignUpUser(SignUpDto model);
        Task<Result<TokenDto>> SignUpAdmin(SignUpDto model);
    }
}