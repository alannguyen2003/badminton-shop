using BadmintonShop.BusinessObjects.Entity.Address;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Address;

public class DistrictEntityTypeConfiguration: IEntityTypeConfiguration<District>
{
    public void Configure(EntityTypeBuilder<District> builder)
    {
        builder.ToTable("Districts");
        builder.HasKey(x => x.Id);
        builder.Property(item => item.DistrictName)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(item => item.DistrictCode)
            .HasMaxLength(100)
            .IsRequired();
        builder
            .HasOne(item => item.Province)
            .WithMany(item => item.Districts)
            .HasForeignKey(item => item.ProvinceId)
            .IsRequired();
        
        builder
            .HasMany(item => item.Wards)
            .WithOne(item => item.District)
            .HasForeignKey(item => item.DistrictId);
    }
}