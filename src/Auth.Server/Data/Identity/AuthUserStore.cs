using Microsoft.AspNetCore.Identity;
using System;
using System.Threading;
using System.Threading.Tasks;

using Auth.Core.Interfaces;
using Auth.Infrastructure.Repositories;

namespace Auth.Server.Data.Identity
{
    public class AuthUserStore : IUserStore<AuthUser>
    {
        private readonly IUsersRepository _usersRepository;

        public AuthUserStore(IUsersRepository usersRepository)
        {
            this._usersRepository = usersRepository;
        }

        public async Task<IdentityResult> CreateAsync(AuthUser user, CancellationToken cancellationToken)
        {
            return null;
        }


        public async Task<IdentityResult> DeleteAsync(AuthUser user, CancellationToken cancellationToken)	
        {
            return null;
        }

        public async Task<AuthUser> FindByIdAsync(string id, CancellationToken cancellationToken)	
        {
            return null;
        }

        public async Task<AuthUser> FindByNameAsync(string id, CancellationToken cancellationToken)	
        {
            return null;
        }

        public async Task<string> GetNormalizedUserNameAsync(AuthUser user, CancellationToken cancellationToken)	
        {
            return null;
        }

        public async Task<string> GetUserIdAsync(AuthUser user, CancellationToken cancellationToken) 	
        {
            return null;
        }

        public async Task<string> GetUserNameAsync(AuthUser user, CancellationToken cancellationToken)	
        {
            return null;
        }

        public async Task SetNormalizedUserNameAsync(AuthUser user, string name, CancellationToken cancellationToken)	
        {
            return null;
        }

        public async Task SetUserNameAsync(AuthUser user, string name, CancellationToken cancellationToken)	
        {
            return null;
        }

        public async Task<IdentityResult> UpdateAsync(AuthUser user, CancellationToken cancellationToken)	
        {
            return null;
        }

        public void Dispose()
        {

        }
    }
}