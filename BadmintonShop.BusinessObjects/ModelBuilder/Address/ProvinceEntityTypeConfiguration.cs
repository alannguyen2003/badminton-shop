using BadmintonShop.BusinessObjects.Entity.Address;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Address;

public class ProvinceEntityTypeConfiguration: IEntityTypeConfiguration<Province>
{
    public void Configure(EntityTypeBuilder<Province> builder)
    {
        builder.ToTable("Provinces");
        builder.HasKey(x => x.Id);
        builder
            .HasMany(item => item.Districts)
            .WithOne(item => item.Province)
            .HasForeignKey(item => item.ProvinceId);
        builder.Property(x => x.ProvinceName)
            .HasMaxLength(100)
            .IsRequired();
        builder.Property(x => x.ProvinceCode)
            .HasMaxLength(100)
            .IsRequired();
    }
}