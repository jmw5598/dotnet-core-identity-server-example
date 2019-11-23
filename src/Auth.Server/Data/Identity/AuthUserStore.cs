using Microsoft.AspNetCore.Identity;
using System.Threading;
using System.Threading.Tasks;

using Auth.Core.Interfaces;
using Auth.Infrastructure.Repositories;

namespace Auth.Server.Identity
{
    public class AuthUserStore : IUserStore<AuthUser>
    {
        private readonly IUsersRepository _usersRepository;

        public AuthUserStore(IUsersRepository usersRepository)
        {
            this._usersRepository = usersRepository;
        }
    }
}