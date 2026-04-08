using FluentValidation;
using InventoryManagement.API.DTOs;
using InventoryManagement.API.Models;

namespace InventoryManagement.API.Validators;

public class LoginRequestValidator : AbstractValidator<LoginRequest>
{
    public LoginRequestValidator()
    {
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
        RuleFor(x => x.Password).NotEmpty().MinimumLength(6);
    }
}

public class RegisterRequestValidator : AbstractValidator<RegisterRequest>
{
    public RegisterRequestValidator()
    {
        RuleFor(x => x.Username).NotEmpty().MaximumLength(50);
        RuleFor(x => x.Email).NotEmpty().EmailAddress();
        RuleFor(x => x.Password).NotEmpty().MinimumLength(6);
        RuleFor(x => x.Role).NotEmpty().Must(r => r == RoleConstants.Admin || r == RoleConstants.Shopkeeper || r == RoleConstants.Agency).WithMessage($"Role must be {RoleConstants.Admin}, {RoleConstants.Shopkeeper}, or {RoleConstants.Agency}.");
        RuleFor(x => x).Must(x => x.Role != RoleConstants.Agency || x.AgencyId.HasValue || true).WithMessage("AgencyId is optional when registering as Agency - will be auto-assigned.");
        RuleFor(x => x).Must(x => x.Role == RoleConstants.Agency || !x.AgencyId.HasValue).WithMessage("AgencyId should only be provided for Agency role.");
    }
}
