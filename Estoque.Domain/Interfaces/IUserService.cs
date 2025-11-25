using Estoque.Domain.Entities;

namespace Estoque.Domain.Interfaces
{
    public interface IUserService
    {
        User GetByMail(string mail, string senha);
    }
}
