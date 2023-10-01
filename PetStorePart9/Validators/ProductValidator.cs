using FluentValidation;
using PetStore.Data;

namespace PetStorePart9
{
    public class ProductValidator : AbstractValidator<Product>
    {
        public ProductValidator()
        {
            RuleFor(p => p.Name).NotEmpty();
            RuleFor(p => p.Price).GreaterThan(0);
            RuleFor(p => p.Quantity).GreaterThanOrEqualTo(0);
            RuleFor(p => p.Description).MinimumLength(10).When(p => !string.IsNullOrEmpty(p.Description));
        }
    }
}
