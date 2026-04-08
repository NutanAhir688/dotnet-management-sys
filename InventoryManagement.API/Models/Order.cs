namespace InventoryManagement.API.Models;

public class Order : BaseEntity
{
    public Guid? CustomerId { get; set; }
    public Customer? Customer { get; set; }

    public Guid? AgencyId { get; set; }
    public Agency? Agency { get; set; }

    public Guid? ShopkeeperUserId { get; set; }
    public User? ShopkeeperUser { get; set; }

    public DateTime OrderDate { get; set; }
    public decimal TotalAmount { get; set; }
    public decimal TaxAmount { get; set; }

    public string Status { get; set; } = "Pending"; // Pending, Accepted, Shipped, Delivered, Rejected

    public ICollection<OrderItem> OrderItems { get; set; } = new List<OrderItem>();
}
