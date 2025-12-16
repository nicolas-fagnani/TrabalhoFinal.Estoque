using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;
using Estoque.Repository.Context;

namespace Estoque.Repository.Repository
{
    public class CategoryRepository(EstoqueDbContext context) : BaseRepository<Category>(context), ICategoryRepository
    {
        public IEnumerable<Category> GetByName(string name)
        {
            return context.Categories
                .Where(c => c.Name.Contains(name))
                .ToList();
        }
    }
}
