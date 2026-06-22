using WarehouseManagementSystem.Domain.Common;

namespace WarehouseManagementSystem.Domain.Entities;

public class Condition : BaseEntity
{
    public string Name { get; set; } = string.Empty;
}