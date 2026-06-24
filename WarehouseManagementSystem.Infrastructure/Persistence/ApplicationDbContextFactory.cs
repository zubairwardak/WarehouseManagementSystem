using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace WarehouseManagementSystem.Infrastructure.Persistence;

public class ApplicationDbContextFactory
    : IDesignTimeDbContextFactory<ApplicationDbContext>
{
    public ApplicationDbContext CreateDbContext(string[] args)
    {
        var optionsBuilder =
            new DbContextOptionsBuilder<ApplicationDbContext>();

        optionsBuilder.UseSqlServer(
             @"Server=(localdb)\MSSQLLocalDB;Database=WarehouseManagementDb;Trusted_Connection=True;TrustServerCertificate=True");

        return new ApplicationDbContext(
            optionsBuilder.Options);
    }
}