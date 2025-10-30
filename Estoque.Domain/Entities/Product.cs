using Estoque.Domain.Base;

namespace Estoque.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        // Atributos //
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal Quantity { get; set; }
        public Category Category { get; set; }


        // Métodos //
        public Product()
        {

        }

        public Product(int id, string name, decimal price, decimal quantity, Category category) : base(id)
        {
            Name = name;
            Price = price;
            Quantity = quantity;
            Category = category;
        }
    }
}
