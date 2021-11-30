using FluentValidation;

namespace EmailServiceLibrary.Validators
{
    internal abstract class ThrowableValidator<TModel, SValidator> : AbstractValidator<TModel>
        where TModel : class
        where SValidator : AbstractValidator<TModel>, new()
    {

        internal static void ThrowOnFailures(TModel options)
        {
            var validator = new SValidator();
            validator.Validate(options, c => c.ThrowOnFailures());
        }
    }
}
