using Estoque.Domain.Entities;
using Estoque.Domain.Interfaces;
using FluentValidation;

namespace Estoque.Application.Services
{
    public class StockMovementService : IStockMovementService
    {
        private readonly IProductRepository _productRepository;
        private readonly IStockMovementRepository _stockMovementRepository;
        private readonly StockMovementValidator _validator;
        public StockMovementService(IProductRepository productRepository, IStockMovementRepository stockMovementRepository, IValidator<StockMovement> validator)
        {
            _productRepository = productRepository;
            _stockMovementRepository = stockMovementRepository;
            _validator = validator;
        }

        public void RegisterMovement(StockMovement movement)
        {
            var validationResult = _validator.Validate(movement);
            if (!validationResult.IsValid)
            {
                throw new Exception(validationResult.Errors.FirstOrDefault()?.ErrorMessage);
            }

            var dbProduct = _productRepository.Select(movement.Product.Id);
            if (dbProduct == null)
            {
                throw new Exception("Product not found.");
            }

            if (movement.Type == MovementType.Exit)
            {
                if (dbProduct.CurrentQuantity < movement.Quantity)
                {
                    throw new InvalidOperationException("Insufficient stock.");
                }
                dbProduct.CurrentQuantity -= movement.Quantity;
            }
            else if (movement.Type == MovementType.Entry)
            {
                dbProduct.CurrentQuantity += movement.Quantity;
            }

            _productRepository.Update(dbProduct);
            movement.Product = dbProduct;
            _stockMovementRepository.Insert(movement);
        }
            
        public IEnumerable<StockMovement> GetAll()
        {
            return _stockMovementRepository.Select();
        }
      
    }
}
