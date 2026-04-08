namespace InventoryManagement.API.Models;

public class Agency : BaseEntity
{
    public string Name { get; set; } = null!;
    public string Address { get; set; } = null!;
    public string Phone { get; set; } = null!;
    public string TaxId { get; set; } = null!;

    public Guid? CreatedByUserId { get; set; }
    public User? CreatedByUser { get; set; }

    public ICollection<Order> Orders { get; set; } = new List<Order>();
}
