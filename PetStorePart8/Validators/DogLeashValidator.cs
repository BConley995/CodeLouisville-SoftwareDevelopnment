using FluentValidation;
using PetStorePart8;

public class DogLeashValidator : AbstractValidator<DogLeash>
{
    public DogLeashValidator()
    {
        RuleFor(dl => dl.Name).NotEmpty();
        RuleFor(dl => dl.Price).GreaterThan(0);
        RuleFor(dl => dl.Quantity).GreaterThan(0);
        RuleFor(dl => dl.Description).MinimumLength(10).When(dl => !string.IsNullOrEmpty(dl.Description));
    }
}
