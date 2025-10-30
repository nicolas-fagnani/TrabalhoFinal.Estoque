using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;

namespace Estoque.Application.Services
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        public User GetByMail(string mail)
        {
            throw new NotImplementedException();
        }
    }
}
