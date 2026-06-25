using WarehouseManagementSystem.Domain.Entities;

namespace WarehouseManagementSystem.Application.Interfaces.Repositories;

public interface IWarehouseRepository
{
    Task<List<Warehouse>> GetAllAsync();

    Task<Warehouse?> GetByIdAsync(int id);

    Task AddAsync(Warehouse warehouse);

    Task UpdateAsync(Warehouse warehouse);

    Task DeleteAsync(Warehouse warehouse);
}