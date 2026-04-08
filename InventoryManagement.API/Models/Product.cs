namespace InventoryManagement.API.Models;

public class Product : BaseEntity
{
    public Guid? AgencyId { get; set; }
    public Agency? Agency { get; set; }

    public Guid? ShopkeeperUserId { get; set; }
    public User? ShopkeeperUser { get; set; }

    public string Name { get; set; } = null!;
    public string Description { get; set; } = string.Empty;
    public decimal Price { get; set; }
    public int StockQuantity { get; set; }
}
