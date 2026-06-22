using WarehouseManagementSystem.Domain.Common;

namespace WarehouseManagementSystem.Domain.Entities;

public class ItemSerial : BaseEntity
{
    public int ItemId { get; set; }

    public Item Item { get; set; } = null!;

    public string SerialNumber { get; set; } = string.Empty;

    public bool IsAssigned { get; set; }
}