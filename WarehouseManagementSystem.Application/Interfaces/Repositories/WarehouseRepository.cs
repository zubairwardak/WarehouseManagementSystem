using Microsoft.EntityFrameworkCore;
using WarehouseManagementSystem.Application.Interfaces.Repositories;
using WarehouseManagementSystem.Domain.Entities;
using WarehouseManagementSystem.Infrastructure.Persistence;

namespace WarehouseManagementSystem.Infrastructure.Repositories;

public class WarehouseRepository : IWarehouseRepository
{
    private readonly ApplicationDbContext _context;

    public WarehouseRepository(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<Warehouse>> GetAllAsync()
    {
        return await _context.Warehouses.ToListAsync();
    }

    public async Task<Warehouse?> GetByIdAsync(int id)
    {
        return await _context.Warehouses
            .FirstOrDefaultAsync(x => x.Id == id);
    }

    public async Task AddAsync(Warehouse warehouse)
    {
        _context.Warehouses.Add(warehouse);

        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(Warehouse warehouse)
    {
        _context.Warehouses.Update(warehouse);

        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(Warehouse warehouse)
    {
        _context.Warehouses.Remove(warehouse);

        await _context.SaveChangesAsync();
    }
}