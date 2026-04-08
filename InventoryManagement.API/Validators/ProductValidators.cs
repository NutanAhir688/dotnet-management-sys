using FluentValidation;
using InventoryManagement.API.DTOs;

namespace InventoryManagement.API.Validators;

public class CreateProductRequestValidator : AbstractValidator<CreateProductRequest>
{
    public CreateProductRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Price).GreaterThan(0);
        RuleFor(x => x.StockQuantity).GreaterThanOrEqualTo(0);
        RuleFor(x => x).Must(x => !(x.AgencyId.HasValue && x.ShopkeeperUserId.HasValue))
            .WithMessage("Product cannot be assigned to both Agency and Shopkeeper.");
    }
}

public class UpdateProductRequestValidator : AbstractValidator<UpdateProductRequest>
{
    public UpdateProductRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(100);
        RuleFor(x => x.Price).GreaterThan(0);
        RuleFor(x => x.StockQuantity).GreaterThanOrEqualTo(0);
        RuleFor(x => x).Must(x => !(x.AgencyId.HasValue && x.ShopkeeperUserId.HasValue))
            .WithMessage("Product cannot be assigned to both Agency and Shopkeeper.");
    }
}
