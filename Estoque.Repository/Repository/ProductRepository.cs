using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;
using Estoque.Repository.Context;
using Microsoft.EntityFrameworkCore;

namespace Estoque.Repository.Repository
{
    public class ProductRepository(EstoqueDbContext context) : BaseRepository<Product>(context), IProductRepository
    {
        public IEnumerable<Product> GetByName(string name)
        {
            return context.Products
                .Where(propa => propa.Name.Contains(name))
                .ToList();
        }

        public IEnumerable<Product> GetByCategoryName(string categoryName)
        {
            return context.Products
                .Include(p => p.Category)
                .Where(p => p.Category.Name.Contains(categoryName))
                .ToList();
        }
    }
}
