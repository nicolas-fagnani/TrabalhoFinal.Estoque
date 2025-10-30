using Estoque.Domain.Base;
using Estoque.Domain.Entities;

namespace Estoque.Domain.Interfaces
{
    public interface IUserRepository : IBaseRepository<User>
    {
        User GetByMail(string mail);
    }
}
