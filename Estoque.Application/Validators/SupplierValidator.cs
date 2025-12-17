using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Domain.Entities;
using FluentValidation;

namespace Estoque.Application.Validators
{
    public class SupplierValidator : AbstractValidator<Supplier>
    {
        public SupplierValidator()
        {
            RuleFor(s => s.Name)
                .NotEmpty()
                .WithMessage("Supplier name is required.")
                .Length(2, 100)
                .WithMessage("Name must be between 2 and 100 characters.");

            RuleFor(s => s.Cnpj)
                .NotEmpty()
                .WithMessage("CNPJ is required.")
                .Length(14)
                .WithMessage("CNPJ must have exactly 14 digits.")
                .Matches(@"^\d+$")
                .WithMessage("CNPJ must contain only numbers.");
        }
    }
}
