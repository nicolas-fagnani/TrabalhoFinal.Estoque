
using Estoque.Domain.Base;

namespace Estoque.Domain.Entities
{
    public class Supplier : BaseEntity<int>
    {
        // Atributos //
        public string Name { get; set; }
        public string Cnpj { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public bool IsActive { get; set; } = true;

        // Métodos //
        public Supplier()
        {

        }

        public Supplier(int id, string name, string cnpj, string phone, string email, bool isActive) : base(id)
        {
            Name = name;
            Cnpj = cnpj;
            Phone = phone;
            Email = email;
            IsActive = isActive;
        }
    }
}
