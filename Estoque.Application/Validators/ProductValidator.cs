using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Domain.Entities;
using FluentValidation;

namespace Estoque.Application.Validators
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name)
                .NotEmpty()
                .WithMessage("Product name is required.");

            RuleFor(p => p.Price)
                .GreaterThan(0)
                .WithMessage("Price must be greater than zero.");

            RuleFor(p => p.Category)
                .NotNull()
                .WithMessage("Category must be provided.");
        }
    }
}
