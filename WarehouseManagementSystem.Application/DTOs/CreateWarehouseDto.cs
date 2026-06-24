namespace WarehouseManagementSystem.Application.DTOs;

public class CreateWarehouseDto
{
    public string WarehouseCode { get; set; } = string.Empty;

    public string WarehouseName { get; set; } = string.Empty;

    public string? Description { get; set; }
}