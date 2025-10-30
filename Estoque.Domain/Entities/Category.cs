using Estoque.Domain.Base;

namespace Estoque.Domain.Entities
{
    public class Category : BaseEntity<int>
    {
        // Atributos //
        public string Name { get; set; }

        // Métodos //
        public Category()
        {

        }

        public Category(int id, string name) : base(id)
        { 
            Name = name;
        }
    }
}
