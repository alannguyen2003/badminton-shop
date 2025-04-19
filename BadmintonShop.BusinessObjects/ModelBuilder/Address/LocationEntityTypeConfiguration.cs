using BadmintonShop.BusinessObjects.Entity.Address;
using BadmintonShop.Enumarable;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Address;

public class LocationEntityTypeConfiguration: IEntityTypeConfiguration<Location>
{
    public void Configure(EntityTypeBuilder<Location> builder)
    {
        builder.ToTable("Locations");
        builder.HasKey(item => item.Id);
        builder
            .Property(item => item.LocationAddress)
            .HasMaxLength(500)
            .IsRequired();  
        builder
            .Property(item => item.LocationType)
            .HasDefaultValue(LocationType.HOME)
            .IsRequired();
        builder
            .HasOne(item => item.Province)
            .WithMany(item => item.Locations)
            .HasForeignKey(item => item.ProvinceId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);
        builder
            .HasOne(item => item.District)
            .WithMany(item => item.Locations)
            .HasForeignKey(item => item.DistrictId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);
        builder
            .HasOne(item => item.Ward)
            .WithMany(item => item.Locations)
            .HasForeignKey(item => item.WardId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);
        builder
            .HasOne(item => item.Account)
            .WithMany(item => item.Locations)
            .HasForeignKey(item => item.AccountId)
            .IsRequired()
            .OnDelete(DeleteBehavior.NoAction);
    }
}