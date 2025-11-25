using Estoque.Domain.Base;

namespace Estoque.Domain.Entities
{
    public class StockMovement : BaseEntity<int>
    {
        // Atributos //
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int UserId { get; set; }
        public User User { get; set; }

        public decimal Quantity { get; set; }
        public MovementType Type { get; set; }

        public DateTime Date { get; set; } = DateTime.Now;

        // Métodos //

        public StockMovement()
        {

        }

        public StockMovement(int id, int productId, Product product, int userId, User user, decimal quantity, MovementType type, DateTime date) : base(id)
        {
            ProductId = productId;
            Product = product;
            UserId = userId;
            User = user;
            Quantity = quantity;
            Type = type;
            Date = date;
        }
    }
}
