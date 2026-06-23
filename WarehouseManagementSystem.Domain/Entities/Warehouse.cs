using WarehouseManagementSystem.Domain.Common;

namespace WarehouseManagementSystem.Domain.Entities;

public class Warehouse : BaseEntity
{
    public string WarehouseCode { get; set; } = string.Empty;

    public string WarehouseName { get; set; } = string.Empty;

    public string? Description { get; set; }
}