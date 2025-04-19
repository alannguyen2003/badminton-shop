using BadmintonShop.BusinessObjects.Entity.Address;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Address;

public class WardEntityTypeConfiguration: IEntityTypeConfiguration<Ward>
{
    public void Configure(EntityTypeBuilder<Ward> builder)
    {
        builder.ToTable("Wards");
        builder.HasKey(item => item.Id);
        builder
            .Property(item => item.WardName)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(item => item.WardCode)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .HasOne(item => item.District)
            .WithMany(item => item.Wards)
            .HasForeignKey(item => item.DistrictId)
            .IsRequired();
    }
}