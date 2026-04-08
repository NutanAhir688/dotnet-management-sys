namespace InventoryManagement.API.Models;

public class Customer : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string Phone { get; set; } = null!;

    // Owner isolation — each Shopkeeper manages their own client list
    public Guid? ShopkeeperUserId { get; set; }
    public User? ShopkeeperUser { get; set; }
}
