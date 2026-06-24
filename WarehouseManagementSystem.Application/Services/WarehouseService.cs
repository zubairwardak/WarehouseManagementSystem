using WarehouseManagementSystem.Application.DTOs;
using WarehouseManagementSystem.Application.Interfaces;
using WarehouseManagementSystem.Domain.Entities;
using WarehouseManagementSystem.Infrastructure.Persistence;
using Microsoft.EntityFrameworkCore;

namespace WarehouseManagementSystem.Application.Services;

public class WarehouseService : IWarehouseService
{
    private readonly ApplicationDbContext _context;

    public WarehouseService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<List<WarehouseDto>> GetAllAsync()
    {
        return await _context.Warehouses
            .Select(x => new WarehouseDto
            {
                Id = x.Id,
                WarehouseCode = x.WarehouseCode,
                WarehouseName = x.WarehouseName,
                Description = x.Description
            })
            .ToListAsync();
    }

    public async Task<WarehouseDto?> GetByIdAsync(int id)
    {
        return await _context.Warehouses
            .Where(x => x.Id == id)
            .Select(x => new WarehouseDto
            {
                Id = x.Id,
                WarehouseCode = x.WarehouseCode,
                WarehouseName = x.WarehouseName,
                Description = x.Description
            })
            .FirstOrDefaultAsync();
    }

    public async Task CreateAsync(CreateWarehouseDto dto)
    {
        var warehouse = new Warehouse
        {
            WarehouseCode = dto.WarehouseCode,
            WarehouseName = dto.WarehouseName,
            Description = dto.Description
        };

        _context.Warehouses.Add(warehouse);

        await _context.SaveChangesAsync();
    }

    public async Task UpdateAsync(UpdateWarehouseDto dto)
    {
        var warehouse = await _context.Warehouses
            .FirstOrDefaultAsync(x => x.Id == dto.Id);

        if (warehouse == null)
            return;

        warehouse.WarehouseCode = dto.WarehouseCode;
        warehouse.WarehouseName = dto.WarehouseName;
        warehouse.Description = dto.Description;

        await _context.SaveChangesAsync();
    }

    public async Task DeleteAsync(int id)
    {
        var warehouse = await _context.Warehouses
            .FirstOrDefaultAsync(x => x.Id == id);

        if (warehouse == null)
            return;

        _context.Warehouses.Remove(warehouse);

        await _context.SaveChangesAsync();
    }
}