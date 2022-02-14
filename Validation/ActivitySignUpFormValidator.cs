using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AcmeWidgetAPI.Validation
{
    public class ActivitySignUpFormValidator : AbstractValidator<ActivitySignUpForm>
    {
        public ActivitySignUpFormValidator()
        {
            RuleFor(x => x.FirstName).NotEmpty().WithMessage("First name is required.");
            RuleFor(x => x.LastName).NotEmpty().WithMessage("Last name is required.");
            RuleFor(x => x.EmailAddress).NotEmpty().WithMessage("Email address is required.");
            RuleFor(x => x.EmailAddress).EmailAddress().WithMessage("Email address should be valid.");
            RuleFor(x => x.Activity).NotEmpty().WithMessage("Activity must be specified");
            RuleFor(x => x.Activity).IsInEnum().WithMessage("Activity must be according to the specifications.");
        }
    }
}
