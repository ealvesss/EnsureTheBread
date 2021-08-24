using EnsureTheBread.Domain.Entities;
using FluentValidation;

namespace EnsureTheBread.Domain.Service.Validators
{
    public class CustomerValidator : AbstractValidator<Customer>
    {
        public CustomerValidator()
        {
            RuleFor(c => c.FistName)
                .NotEmpty().WithMessage("Please enter the first name.")
                .NotNull().WithMessage("Please enter the first name.");

            RuleFor(c => c.Address)
                .NotEmpty().WithMessage("Please enter the address.")
                .NotNull().WithMessage("Please enter the address.");

            RuleFor(c => c.LastName)
                .NotEmpty().WithMessage("Please enter the lastname.")
                .NotNull().WithMessage("Please enter the lastname.");
            
            RuleFor(c => c.Email)
            .NotEmpty().WithMessage("Please enter the email")
            .NotNull().WithMessage("Please enter the email");
        }
    }
}