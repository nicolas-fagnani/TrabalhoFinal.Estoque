using Estoque.Domain.Entities;

namespace Estoque.Domain.Interfaces
{
    public interface IUserService
    {
        User GetByEmail(string email, string senha);
        void Register(User user);
    }
}
