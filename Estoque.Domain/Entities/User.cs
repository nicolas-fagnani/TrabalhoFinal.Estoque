using Estoque.Domain.Base;

namespace Estoque.Domain.Entities
{
    public class User : BaseEntity<int>
    {
        // Atributos //
        public string Name { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }

        // Métodos //
        public User()
        {

        }

        public User(int id, string name, string email, string password)
        {
            Name = name;
            Email = email;
            Password = password;
        }

    }
}
