namespace InventoryManagement.API.Models;

public class ShopkeeperSupplier : BaseEntity
{
    public Guid ShopkeeperUserId { get; set; }
    public User? ShopkeeperUser { get; set; }

    public Guid AgencyId { get; set; }
    public Agency? Agency { get; set; }
}
