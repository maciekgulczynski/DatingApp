using System.Security.Claims;

namespace API.Extensions
{
    public static class ClaimPrincipalExtension
    {
        public static string GetUserName (this ClaimsPrincipal user )
        {
            return user.FindFirst(ClaimTypes.Name)?.Value;
        }

            public static int GetUserId (this ClaimsPrincipal user )
        {
            return Int32.Parse(user.FindFirst(ClaimTypes.NameIdentifier)?.Value);
        }
    }
}