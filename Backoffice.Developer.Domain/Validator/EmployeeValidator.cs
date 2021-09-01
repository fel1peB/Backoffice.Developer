using Backoffice.Developer.Domain.Entities;
using FluentValidation;

namespace Backoffice.Developer.Domain.Validator
{
    public class EmployeeValidator : AbstractValidator<Employee>
    {
        public EmployeeValidator()
        {
            RuleFor(x => x.Name)
                .Matches("^(?!^.{100}).+").WithMessage("Name field must be 100 characters in length.");
            RuleFor(x => x.Name)
                .NotEmpty();
        }
    }
}
