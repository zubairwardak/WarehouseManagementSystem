using WarehouseManagementSystem.Domain.Entities;

namespace WarehouseManagementSystem.Infrastructure.Persistence;

public static class DbSeeder
{
    public static async Task SeedAsync(
        ApplicationDbContext context)
    {
        if (!context.Warehouses.Any())
        {
            context.Warehouses.AddRange(
                new Warehouse
                {
                    WarehouseCode = "CMW",
                    WarehouseName = "Construction Materials"
                },

                new Warehouse
                {
                    WarehouseCode = "TCB",
                    WarehouseName = "Tires Chains Batteries"
                },

                new Warehouse
                {
                    WarehouseCode = "CSW",
                    WarehouseName = "Clothing Stationery"
                },

                new Warehouse
                {
                    WarehouseCode = "VSE",
                    WarehouseName = "Vehicle Spare Parts Equipment"
                });

            await context.SaveChangesAsync();
        }
    }
}