using Estoque.Domain.Base;

namespace Estoque.Domain.Entities
{
    public class Customer : BaseEntity<int>
    {
        // Atributos //
        public string Name { get; set; }
        public string Cpf { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; } = true;

        // Métodos //
        public Customer()
        {
        }

        public Customer(int id, string name, string cpf, string phone, string email, bool isActive)
            : base(id)
        {
            Name = name;
            Cpf = cpf;
            Phone = phone;
            Email = email;
            IsActive = isActive;
        }
    }
}
