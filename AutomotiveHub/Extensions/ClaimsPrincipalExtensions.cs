using System.Security.Claims;

namespace AutomotiveHub.Extensions
{
    public static class ClaimsPrincipalExtensions
    {
        //Our Identity Class

        public static string Id(this ClaimsPrincipal user)
        {
            return user.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
