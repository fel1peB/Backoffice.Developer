using FluentValidation;

namespace Backoffice.Developer.Domain.Validator
{
    public class SkillValidator : AbstractValidator<Entities.Skill>
    {
        public SkillValidator()
        {
            RuleFor(x => x.Description)
                .Matches("^(?!^.{100}).+").WithMessage("Name field must be 100 characters in length.");
            RuleFor(x => x.Description)
                .NotEmpty();
        }
    }
}
