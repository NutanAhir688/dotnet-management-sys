using FluentValidation;
using InventoryManagement.API.DTOs;

namespace InventoryManagement.API.Validators;

public class AgencyRequestValidator : AbstractValidator<AgencyRequest>
{
    public AgencyRequestValidator()
    {
        RuleFor(x => x.Name).NotEmpty().MaximumLength(200);
        RuleFor(x => x.Address).NotEmpty().MaximumLength(500);
        RuleFor(x => x.Phone).NotEmpty().MaximumLength(20);
        RuleFor(x => x.TaxId).NotEmpty().MaximumLength(50);
    }
}
