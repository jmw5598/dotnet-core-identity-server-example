using  Microsoft.AspNetCore.Identity;

namespace Auth.Server.Data.Identity
{
    public class AuthUser : IdentityUser
    {
        public string Name { get; set; }
    }
}