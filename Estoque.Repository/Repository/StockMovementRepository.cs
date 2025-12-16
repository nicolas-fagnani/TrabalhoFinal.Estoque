using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;
using Estoque.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Repository.Repository
{
    public class StockMovementRepository(EstoqueDbContext context) : BaseRepository<StockMovement>(context), IStockMovementRepository
    {
        public IEnumerable<StockMovement> GetByProductName(String productName)
        {
            return context.StockMovements
                .Include(m => m.Product)
                    .ThenInclude(p => p.Category)
                .Include(m => m.User)
                .Include(m => m.Supplier)
                .Include(m => m.Customer)

                .Where(m => m.Product.Name.Contains(productName))
                .OrderByDescending(m => m.Date)
                .ToList();
        }

        public IEnumerable<StockMovement> GetByDateRange(DateTime startDate, DateTime endDate)
        {
            return context.StockMovements
                .Include(m => m.Product)
                .Include(m => m.User)
                .Include(m => m.Supplier)
                .Include(m => m.Customer)

                .Where(m => m.Date >= startDate && m.Date <= endDate)
                .OrderByDescending(m => m.Date)
                .ToList();
        }
    }
}
