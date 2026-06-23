using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManagementSystem.Domain.Entities;

namespace WarehouseManagementSystem.Infrastructure.Configurations;

public class ItemConfiguration :
    IEntityTypeConfiguration<Item>
{
    public void Configure(
        EntityTypeBuilder<Item> builder)
    {
        builder.ToTable("Items");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.ItemCode)
               .HasMaxLength(50)
               .IsRequired();

        builder.Property(x => x.ItemName)
               .HasMaxLength(200)
               .IsRequired();

        builder.Property(x => x.CurrentPrice)
               .HasPrecision(18, 2);

        builder.Property(x => x.MinimumStockLevel)
               .HasPrecision(18, 2);

        builder.HasOne(x => x.Category)
               .WithMany(x => x.Items)
               .HasForeignKey(x => x.CategoryId)
               .OnDelete(DeleteBehavior.Restrict);

        builder.HasOne(x => x.Unit)
               .WithMany(x => x.Items)
               .HasForeignKey(x => x.UnitId)
               .OnDelete(DeleteBehavior.Restrict);
    }
}