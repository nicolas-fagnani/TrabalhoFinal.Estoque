using Estoque.Domain.Base;
using Estoque.Domain.Entities;

namespace Estoque.Domain.Interfaces
{
    public interface IProductRepository : IBaseRepository<Product>
    {
        IEnumerable<Product> GetByName(string name);

        IEnumerable<Product> GetByCategoryName(string categoryName);
    }
}
