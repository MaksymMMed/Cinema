using System.Security.Claims;
using Cinema.BLL.Extensions;
using Cinema.DAL.Enums;
using Microsoft.AspNetCore.Http;

namespace Cinema.BLL.Services.Core;

public abstract class BaseBusinessService(IHttpContextAccessor httpContextAccessor)
{
    protected readonly IHttpContextAccessor HttpContextAccessor = httpContextAccessor;

    public string? CurrentUserEmail => HttpContextAccessor.HttpContext.User.GetValueByClaimType(ClaimTypes.Email);

    public string? CurrentUserId => HttpContextAccessor.HttpContext.User.GetValueByClaimType(ClaimTypes.NameIdentifier);

    public UserRolesEnum CurrentUserRole => (UserRolesEnum) Enum.Parse(typeof(UserRolesEnum),
        HttpContextAccessor.HttpContext.User.GetValueByClaimType(ClaimTypes.Role)!, true);
}