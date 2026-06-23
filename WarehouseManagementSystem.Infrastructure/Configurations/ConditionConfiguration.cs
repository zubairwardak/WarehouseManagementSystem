using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using WarehouseManagementSystem.Domain.Entities;

namespace WarehouseManagementSystem.Infrastructure.Configurations;

public class ConditionConfiguration :
    IEntityTypeConfiguration<Condition>
{
    public void Configure(
        EntityTypeBuilder<Condition> builder)
    {
        builder.ToTable("Conditions");

        builder.HasKey(x => x.Id);

        builder.Property(x => x.Name)
               .HasMaxLength(100)
               .IsRequired();
    }
}