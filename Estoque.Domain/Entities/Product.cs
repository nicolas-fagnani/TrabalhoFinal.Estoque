using Estoque.Domain.Base;

namespace Estoque.Domain.Entities
{
    public class Product : BaseEntity<int>
    {
        // Atributos //
        public string Name { get; set; }
        public decimal Price { get; set; }
        public decimal CurrentQuantity { get; set; }
        public string UnitOfMeasure { get; set; }
        public bool IsActive { get; set; } = true;

        public int CategoryId { get; set; }
        public Category Category { get; set; }


        // Métodos //
        public Product()
        {

        }

        public Product(int id, string name, decimal price, decimal currentQuantity, string unitOfMeasure, bool isActive, int categoryId, Category category) : base(id)
        {
            Name = name;
            Price = price;
            CurrentQuantity = currentQuantity;
            UnitOfMeasure = unitOfMeasure;
            IsActive = isActive;
            CategoryId = categoryId;
            Category = category;
        }
    }
}
