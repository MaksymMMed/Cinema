using System.Security.Claims;

namespace Cinema.BLL.Extensions;

public static class ClaimsPrincipalExtensions
{
    public static string? GetValueByClaimType(this ClaimsPrincipal claim, string claimType)
    {
        return claim.HasClaim(x => x.Type == claimType) 
            ? claim.FindFirstValue(claimType) 
            : null;
    }
}