using WarehouseManagementSystem.Domain.Common;

namespace WarehouseManagementSystem.Domain.Entities;

public class Category : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string? Description { get; set; }

    public ICollection<Item> Items { get; set; }
        = new List<Item>();
}