using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManagementSystem.Domain.Entities;

namespace WarehouseManagementSystem.Infrastructure.Configurations;

public class ItemSerialConfiguration
    : IEntityTypeConfiguration<ItemSerial>
{
    public void Configure(EntityTypeBuilder<ItemSerial> builder)
    {
        builder.ToTable("ItemSerials");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.SerialNumber)
            .HasMaxLength(200)
            .IsRequired();

        builder.HasOne(x => x.Item)
            .WithMany(x => x.ItemSerials)
            .HasForeignKey(x => x.ItemId)
            .OnDelete(DeleteBehavior.Cascade);
    }
}