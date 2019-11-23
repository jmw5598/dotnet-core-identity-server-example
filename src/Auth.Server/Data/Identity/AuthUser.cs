using  Microsoft.AspNetCore.Identity;

namespace Auth.Server.Identity
{
    public class AuthUser : IdentityUser
    {
        public string Name { get; set; }
    }
}