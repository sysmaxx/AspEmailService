using EmailServiceLibrary.Models;
using FluentValidation;

namespace EmailServiceLibrary.Validators
{
    internal class EmailServiceOptionsValidator : ThrowableValidator<EmailServiceOptions, EmailServiceOptionsValidator>
    {
        public EmailServiceOptionsValidator()
        {
            RuleFor(option => option.Account).NotEmpty();
            RuleFor(option => option.Email).EmailAddress();
            RuleFor(option => option.Host).NotEmpty();
            RuleFor(option => option.DisplayName).NotEmpty();
            RuleFor(option => option.Port).GreaterThan(0).LessThanOrEqualTo(65535);
            RuleFor(option => option.Security).NotNull();
        }
    }
}
