using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Domain.Entities;
using FluentValidation;

namespace Estoque.Application.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.Name)
                .NotEmpty()
                .WithMessage("Name is required.")
                .Length(2, 100)
                .WithMessage("Name must be between 2 and 100 characters.");

            RuleFor(c => c.Cpf)
                .NotEmpty()
                .WithMessage("CPF is required.")
                .Length(11)
                .WithMessage("CPF must have exactly 11 digits.")
                .Matches(@"^\d+$")
                .WithMessage("CPF must contain only numbers.");

            RuleFor(c => c.Email)
                .EmailAddress()
                .WithMessage("Invalid email format.")
                .When(c => !string.IsNullOrEmpty(c.Email));
        }
    }
}
