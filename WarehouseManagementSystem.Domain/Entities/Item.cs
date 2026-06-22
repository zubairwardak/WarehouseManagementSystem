using WarehouseManagementSystem.Domain.Common;

namespace WarehouseManagementSystem.Domain.Entities;

public class Item : BaseEntity
{
    public string ItemCode { get; set; } = string.Empty;

    public string ItemName { get; set; } = string.Empty;

    public string? Description { get; set; }

    public decimal CurrentPrice { get; set; }

    public decimal MinimumStockLevel { get; set; }

    public bool IsSerialTracked { get; set; }

    public int CategoryId { get; set; }

    public Category Category { get; set; } = null!;

    public int UnitId { get; set; }

    public Unit Unit { get; set; } = null!;

    public ICollection<ItemSerial> ItemSerials { get; set; }
        = new List<ItemSerial>();
}