using Estoque.Domain.Base;
using Estoque.Domain.Entities;

namespace Estoque.Domain.Interfaces
{
    public interface ICategoryRepository : IBaseRepository<Category>
    {
        IEnumerable<Category> GetByName(string name);
    } 
}
