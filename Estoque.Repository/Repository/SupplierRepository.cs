using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;
using Estoque.Repository.Context;

namespace Estoque.Repository.Repository
{
    public class SupplierRepository(EstoqueDbContext context) : BaseRepository<Supplier>(context), ISupplierRepository
    {
        public Supplier? GetByCnpj(string cnpj)
        {
            return context.Suppliers
                .FirstOrDefault(s => s.Cnpj == cnpj);
        }

        public IEnumerable<Supplier> GetByName(string name)
        {
            return context.Suppliers
                .Where(s => s.Name.Contains(name))
                .ToList();
        }
    }
}
