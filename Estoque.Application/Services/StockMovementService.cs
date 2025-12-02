using Estoque.Domain.Entities;
using FluentValidation;

namespace Estoque.Application.Services
{
    public class StockMovementService : IStockMovementService
    {
        private readonly IProductRepository _productRepository;
        private readonly IStockMovementRepository _stockMovementRepository;
        private readonly IValidator<StockMovement> _validator;
        public StockMovementService(IProductRepository productRepository, IStockMovementRepository stockMovementRepository, IValidator<StockMovement> validator)
        {
            _productRepository = productRepository;
            _stockMovementRepository = stockMovementRepository;
            _validator = validator;
        }

        public async Task<StockMovement> RegisterMovementAsync(StockMovement movement)
        {
            // Validação FluentValidation //
            var validationResult = await _validator.ValidateAsync(movement);
            if(!validationResult.IsValid)
            {
                throw new ValidationException(validationResult.Errors);
            }

            // Carrega o produto //
            var product = await _productRepository.GetByIdAsync(movement.Product.Id)
                ?? throw new ArgumentException("Product not found.");

            // Parte Lógica //
            if(movement.Type == MovementType.Exit)
            {
                if(product.CurrentQuantity < movement.Quantity)
                {
                    throw new InvalidOperationException("Insufficient stock.");
                }
                else
                {
                    product.CurrentQuantity -= movement.Quantity;
                }
            }
            else if(movement.Type == MovementType.Entry)
            {
                product.CurrentQuantity += movement.Quantity;
            }

            await _productRepository.UpdateAsync(product);
            movement.Product = product;
            return await _stockMovementRepository.AddAsync(movement);
        }

        public Task<IEnumerable<StockMovement>> GetAllAsync() => _stockMovementRepository.GetAllAsync();
        public Task<StockMovement?> GetByIdAsync(int id) => _stockMovementRepository.GetByIdAsync(id);
    }
}
