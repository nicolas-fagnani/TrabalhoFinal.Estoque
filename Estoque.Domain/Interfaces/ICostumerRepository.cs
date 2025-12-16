using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Domain.Base;
using Estoque.Domain.Entities;

namespace Estoque.Domain.Interfaces
{
    public interface ICostumerRepository : IBaseRepository<Customer>
    {
        Customer? GetByCpf(string cpf);

        IEnumerable<Customer> GetByName(string name);
    }
}
