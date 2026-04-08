using FluentValidation;
using InventoryManagement.API.DTOs;
using InventoryManagement.API.Models;

namespace InventoryManagement.API.Validators;

public class GenerateBillRequestValidator : AbstractValidator<GenerateBillRequest>
{
    public GenerateBillRequestValidator()
    {
        RuleFor(x => x.OrderId).NotEmpty();
        RuleFor(x => x.PaymentMethod).NotEmpty().Must(p => p == "Online" || p == "Cash" || p == "Offline" || p == "Invoiced").WithMessage("PaymentMethod must be Online, Cash, Offline, or Invoiced.");
        RuleFor(x => x.PaymentStatus).NotEmpty().Must(p => p == "Pending" || p == "Completed" || p == "Failed" || p == "Partial").WithMessage("PaymentStatus must be Pending, Completed, Failed, or Partial.");
    }
}
