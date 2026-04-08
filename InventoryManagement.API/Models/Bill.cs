namespace InventoryManagement.API.Models;

public class Bill : BaseEntity
{
    public Guid OrderId { get; set; }
    public Order Order { get; set; } = null!;

    public Guid? CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public string BillNumber { get; set; } = null!;
    public decimal Amount { get; set; }
    public decimal PaidAmount { get; set; } = 0;
    public decimal BalanceAmount => Amount - PaidAmount;
    
    public string PaymentMethod { get; set; } = null!; // e.g., "Online", "Cash"
    public string PaymentStatus { get; set; } = null!; // e.g., "Pending", "Partial", "Completed", "Failed"
}
