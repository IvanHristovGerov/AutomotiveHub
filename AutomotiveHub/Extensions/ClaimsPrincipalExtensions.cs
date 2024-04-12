using System.Security.Claims;
using static AutomotiveHub.Areas.Constants.UserConstants;

namespace AutomotiveHub.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        //Our Identity Class

        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }

        public static bool IsAdmin(this  ClaimsPrincipal user)
        {
            return user.IsInRole(AdminRole);
        }

        public static bool IsDealer(this ClaimsPrincipal user)
        {
            return user.IsInRole(DealerRole);
        }
    }
}
