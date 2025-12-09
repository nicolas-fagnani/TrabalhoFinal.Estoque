using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;
using Estoque.Repository.Context;

namespace Estoque.Repository.Repository
{
    public class UserRepository(EstoqueDbContext context) : BaseRepository<User>(context), IUserRepository
    {
        public User GetByEmail(string email)
        {
            var user = context.Users.FirstOrDefault(c => c.Email == email);

            return user;
        }
    }
}
