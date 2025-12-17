using Estoque.Domain.Base;

namespace Estoque.Domain.Entities
{
    public class StockMovement : BaseEntity<int>
    {
        // IDs removidos — apenas Navigation Properties
        public Product Product { get; set; }
        public User User { get; set; }
        public Supplier? Supplier { get; set; }
        public Customer? Customer { get; set; }

        public decimal Quantity { get; set; }
        public MovementType Type { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;

        public StockMovement() { }

        public StockMovement(int id, Product product, User user, Supplier supplier, Customer customer, decimal quantity, MovementType type, DateTime date) : base(id)
        {
            Product = product;
            User = user;
            Supplier = supplier;
            Customer = customer;
            Quantity = quantity;
            Type = type;
            Date = date;
        }
    }
}

