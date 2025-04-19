using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Order;

public class OrderEntityTypeConfiguration: IEntityTypeConfiguration<BadmintonShop.BusinessObjects.Entity.Order.Order>
{
    public void Configure(EntityTypeBuilder<BadmintonShop.BusinessObjects.Entity.Order.Order> builder)
    {
        builder.ToTable("Orders");
        builder.HasKey(item => item.Id);
        builder
            .HasOne(item => item.Account)
            .WithMany(item => item.Orders)
            .HasForeignKey(item => item.AccountId)
            .IsRequired();
        builder
            .HasOne(item => item.Location)
            .WithMany(item => item.Orders)
            .HasForeignKey(item => item.LocationId)
            .IsRequired();
        builder
            .HasMany(item => item.OrderItems)
            .WithOne(item => item.Order)
            .HasForeignKey(item => item.OrderId)
            .IsRequired();
    }
}