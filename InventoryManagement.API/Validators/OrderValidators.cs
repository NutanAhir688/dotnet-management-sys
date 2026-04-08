using FluentValidation;
using InventoryManagement.API.DTOs;

namespace InventoryManagement.API.Validators;

public class OrderItemRequestValidator : AbstractValidator<OrderItemRequest>
{
    public OrderItemRequestValidator()
    {
        RuleFor(x => x.ProductId).NotEmpty();
        RuleFor(x => x.Quantity).GreaterThan(0);
    }
}

public class CreateSalesOrderRequestValidator : AbstractValidator<CreateSalesOrderRequest>
{
    public CreateSalesOrderRequestValidator()
    {
        RuleFor(x => x.CustomerId).NotEmpty().WithMessage("CustomerId is required for a sales order.");
        RuleFor(x => x.Items).NotEmpty().WithMessage("An order must contain at least one item.");
        RuleForEach(x => x.Items).SetValidator(new OrderItemRequestValidator());
    }
}

public class CreateRestockOrderRequestValidator : AbstractValidator<CreateRestockOrderRequest>
{
    public CreateRestockOrderRequestValidator()
    {
        RuleFor(x => x.AgencyId).NotEmpty().WithMessage("AgencyId is required for a restock order.");
        RuleFor(x => x.Items).NotEmpty().WithMessage("A restock order must contain at least one item.");
        RuleForEach(x => x.Items).SetValidator(new OrderItemRequestValidator());
    }
}
