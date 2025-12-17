using Estoque.Domain.Entities;

namespace Estoque.Domain.Interfaces
{
    public interface IStockMovementService
    {
        void RegisterMovement(StockMovement movement);
        IEnumerable<StockMovement> GetAll();
    }
}
