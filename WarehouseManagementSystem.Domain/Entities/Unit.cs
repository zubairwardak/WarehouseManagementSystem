using WarehouseManagementSystem.Domain.Common;

namespace WarehouseManagementSystem.Domain.Entities;

public class Unit : BaseEntity
{
    public string Name { get; set; } = string.Empty;

    public string Code { get; set; } = string.Empty;

    public ICollection<Item> Items { get; set; }
        = new List<Item>();
}