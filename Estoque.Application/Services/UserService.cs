using Estoque.Application.Validators;
using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;

namespace Estoque.Application.Services
{
    public class UserService(IUserRepository userRepository, UserValidator validator)
    {
        public User GetByEmail(string email, string password)
        {
            User user = userRepository.GetByEmail(email);
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

        public void Register(User user)
        {
            var validationResult = validator.Validate(user);
            if (!validationResult.IsValid)
            {
                throw new Exception(validationResult.Errors.FirstOrDefault()?.ErrorMessage);
            }

            var existingUser = userRepository.GetByEmail(user.Email);
            if (existingUser != null)
            {
                throw new Exception("This email is already registered.");
            }

            userRepository.Insert(user);
        }
    }
}
