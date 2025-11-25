using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;

namespace Estoque.Application.Services
{
    public class UserService(IUserRepository userRepository) : IUserService
    {
        public User GetByMail(string email, string password)
        {
            User user = userRepository.GetByMail(email);
            User result;

            if (user != null && user.Password == password)
            {
                result = user;
            }
            else
            {
                result = null;
            }

            return result;
        }
    }
}
