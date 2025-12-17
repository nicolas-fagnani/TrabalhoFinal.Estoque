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
    public class CustomerRepository(EstoqueDbContext context) : BaseRepository<Customer>(context), ICustomerRepository
    {
        public Customer? GetByCpf(string cpf)
        {
            return context.Customers
                .FirstOrDefault(c => c.Cpf == cpf);
        }

        public IEnumerable<Customer> GetByName(string name)
        {
            return context.Customers
                .Where(c => c.Name.Contains(name))
                .ToList();
        }
    }
}
