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
                .NotEmpty().WithMessage("Password must be provied!")
                .MinimumLength(8).WithMessage("Your password must have at least 8 characters!")
                .MaximumLength(16).WithMessage("Your password must have at most 16characters!")
                .Matches(@"[A-Z]+").WithMessage("Your password must contain at leats one uppercase letter!")
                .Matches(@"[a-z]+").WithMessage("Your password must contain at least one lowercase letter!")
                .Matches(@"[0-9]+").WithMessage("Your password must contain at least one number!")
                .Matches(@"[\!\?\*\.\@]+").WithMessage("Your password must contain at least one special character!");
        }
    }
}
