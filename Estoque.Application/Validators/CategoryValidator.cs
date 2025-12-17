using Estoque.Domain.Entities;
using FluentValidation;

namespace Estoque.Application.Validators
{
    public class CategoryValidator : AbstractValidator<Category>
    {
        public CategoryValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("Category name is required.")
                .Length(2, 100)
                .WithMessage("Category name must be between 2 and 100 characters.");
        }
    }
}