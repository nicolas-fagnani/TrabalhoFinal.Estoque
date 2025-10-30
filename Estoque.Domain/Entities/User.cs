using Estoque.Domain.Base;

namespace Estoque.Domain.Entities
{
    public class User : BaseEntity<int>
    {
        // Atributos //
        public string Name { get; set; }
        public string Mail { get; set; }
        public string Password { get; set; }

        // Métodos //
        public User()
        {

        }

        public User(int id, string name, string mail, string password)
        {
            Name = name;
            Mail = mail;
            Password = password;
        }

    }
}
