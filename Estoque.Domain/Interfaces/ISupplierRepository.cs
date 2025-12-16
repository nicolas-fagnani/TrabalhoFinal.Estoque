using Estoque.Domain.Base;
using Estoque.Domain.Entities;

namespace Estoque.Domain.Interfaces
{
    public interface ISupplierRepository : IBaseRepository<Supplier>
    {
        Supplier? GetByCnpj(string cnpj);
        IEnumerable<Supplier> GetByName(string name);
    }
}
