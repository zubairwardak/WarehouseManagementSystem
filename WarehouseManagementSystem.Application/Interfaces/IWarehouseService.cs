using WarehouseManagementSystem.Application.DTOs;

namespace WarehouseManagementSystem.Application.Interfaces;

public interface IWarehouseService
{
    Task<List<WarehouseDto>> GetAllAsync();

    Task<WarehouseDto?> GetByIdAsync(int id);

    Task CreateAsync(CreateWarehouseDto dto);

    Task UpdateAsync(UpdateWarehouseDto dto);

    Task DeleteAsync(int id);
}