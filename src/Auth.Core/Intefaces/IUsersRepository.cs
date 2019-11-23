using Auth.Core.Entities;

namespace Auth.Core.Interfaces
{
    public interface IUsersRepository
    {
        User FindById(long id);
        User FindByUsername(string username);
        User FindByEmail(string email);
    }
}