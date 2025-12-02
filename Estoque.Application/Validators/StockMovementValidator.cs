using Estoque.Domain.Entities;
using FluentValidation;

namespace Estoque.Application.Validators
{
    public class StockMovementValidator : AbstractValidator<StockMovement>
    {
        public StockMovementValidator()
        {
            RuleFor(m => m.Product)
                .NotNull()
                .WithMessage("Product must be provied.");

            RuleFor(m => m.Quantity)
                .GreaterThan(0)
                .WithMessage("Quantity must be greater than zero.")

            RuleFor(m => m.Type)
                .IsInEnum()
                .WithMessage("Movement type is invalid.");

            RuleFor(m => m.User)
                .NotNull()
                .WithMessage("User must be provided.");

            RuleFor(m => m.Supplier)
                 .NotNull()
                 .When(m => m.Type == MovementType.Entry)
                 .WithMessage("Supplier must be informed for stock entries.");

            RuleFor(m => m.Customer)
                .NotNull()
                .When(m => m.Type == MovementType.Exit)
                .WithMessage("Customer must be informed for stock exits.");
        }
    }
}
