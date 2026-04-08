namespace InventoryManagement.API.Models;

public class User : BaseEntity
{
    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    public string PasswordHash { get; set; } = null!;
    public string Role { get; set; } = null!; // Admin, Shopkeeper, Agency

    // Agency relationship — only populated for users with Role == "Agency"
    public Guid? AgencyId { get; set; }
    public Agency? Agency { get; set; }
}
