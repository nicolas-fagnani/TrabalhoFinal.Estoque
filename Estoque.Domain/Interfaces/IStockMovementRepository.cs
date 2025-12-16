using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Domain.Base;
using Estoque.Domain.Entities;

namespace Estoque.Domain.Interfaces
{
    public interface IStockMovementRepository : IBaseRepository<StockMovement>
    {
        IEnumerable<StockMovement> GetByProductName(string productName);

        IEnumerable<StockMovement> GetByDateRange(DateTime startDate, DateTime endDate);
    }
}
