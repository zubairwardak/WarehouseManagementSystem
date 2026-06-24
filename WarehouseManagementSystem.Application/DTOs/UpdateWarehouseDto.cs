namespace WarehouseManagementSystem.Application.DTOs;

public class UpdateWarehouseDto
{
    public int Id { get; set; }

    public string WarehouseCode { get; set; } = string.Empty;

    public string WarehouseName { get; set; } = string.Empty;

    public string? Description { get; set; }
}