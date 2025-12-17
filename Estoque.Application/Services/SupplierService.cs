using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Application.Validators;
using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;

namespace Estoque.Application.Services
{
    public class SupplierService
    {
        private readonly ISupplierRepository _supplierRepository;
        private readonly SupplierValidator _validator;

        public SupplierService(ISupplierRepository supplierRepository, SupplierValidator validator)
        {
            _supplierRepository = supplierRepository;
            _validator = validator;
        }

        public void Register(SupplierValidator supplier)
        {
            var validationResult = _validator.Validate(supplier);
            if (!validationResult.IsValid)
            {
                throw new Exception(validationResult.Errors.FirstOrDefault()?.ErrorMessage);
            }

            var existingSupplier = _supplierRepository.GetByCnpj(supplier.Cnpj);
            if (existingSupplier != null && existingSupplier.Id != supplier.Id)
            {
                throw new Exception("This CNPJ is already registered.");
            }

            if (supplier.Id > 0)
            {
                _supplierRepository.Update(supplier);
            }
            else
            {
                _supplierRepository.Insert(supplier);
            }
        }

        public IEnumerable<Supplier> GetAll()
        {
            return _supplierRepository.Select();
        }

        public IEnumerable<Supplier> GetByName(string name)
        {
            return _supplierRepository.GetByName(name);
        }
    }
}
