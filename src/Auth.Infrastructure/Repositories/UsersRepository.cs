using System.Collections.Generic;
using System.Linq;

using Auth.Core.Entities;
using Auth.Core.Interfaces;

namespace Auth.Infrastructure.Repositories
{
    public class UsersRepository : IUsersRepository
    {
        private readonly IList<User> _users;
        
        public UsersRepository()
        {
            this._users = new List<User>()
            {
                new User()
                {
                    UserId = 112,
                    FirstName = "Jason",
                    LastName = "White",
                    Username = "jmw5598",
                    Email = "jmw5598@gmail.com",
                    Role = "ADMIN",
                    AccountId = 1231
                }
            };
        }

        public User FindById(long id)
        {
            return this._users.Where(e => e.UserId == id)
                .FirstOrDefault();
        }

        public User FindByUsername(string username)
        {
            return this._users.Where(e => e.Username == username)
                .FirstOrDefault();
        }

        public User FindByEmail(string email)
        {
            return this._users.Where(e => e.Email == email)
                .FirstOrDefault();
        }
    }
}   