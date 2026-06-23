using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManagementSystem.Domain.Entities;

namespace WarehouseManagementSystem.Infrastructure.Configurations;

public class WarehouseConfiguration :
    IEntityTypeConfiguration<Warehouse>
{
    public void Configure(
        EntityTypeBuilder<Warehouse> builder)
    {
        builder.ToTable("Warehouses");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.WarehouseCode)
               .HasMaxLength(20)
               .IsRequired();

        builder.Property(x => x.WarehouseName)
               .HasMaxLength(200)
               .IsRequired();
    }
}