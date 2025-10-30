using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;
using Estoque.Repository.Context;

namespace Estoque.Repository.Repository
{
    public class UserRepository(EstoqueDbContext context) : BaseRepository<User>(context), IUserRepository
    {
        public User GetByMail(string mail)
        {
            var user = context.Users.FirstOrDefault(c => c.Mail == mail);

            return user;
        }
    }
}
