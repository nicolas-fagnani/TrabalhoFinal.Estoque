using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Estoque.Domain.Entities;
using FluentValidation;

namespace Estoque.Application.Validators
{
    public class UserValidator : AbstractValidator<User>
    {
        public UserValidator()
        {
            RuleFor(m => m.Name)
                .NotEmpty()
                .WithMessage("Name must be provied!");

            RuleFor(m => m.Email)
                .NotEmpty()
                .WithMessage("Email must be provied!");

            RuleFor(m => m.Password)
                .NotEmpty()
                .WithMessage("Password must be provied!");
        }
    }
}
