using BadmintonShop.BusinessObjects.Entity.Order;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Order;

public class OrderItemEntityTypeConfiguration: IEntityTypeConfiguration<OrderItem>
{
    public void Configure(EntityTypeBuilder<OrderItem> builder)
    {
        builder.ToTable("OrderItems");
        builder.HasKey(item => item.Id);
        builder
            .HasOne(item => item.Order)
            .WithMany(item => item.OrderItems)
            .HasForeignKey(item => item.OrderId)
            .IsRequired();
        builder
            .HasOne(item => item.Product)
            .WithMany(item => item.OrderItems)
            .HasForeignKey(item => item.ProductId)
            .IsRequired();
        builder
            .Property(item => item.Price)
            .HasDefaultValue(0)
            .IsRequired();
        builder.Property(item => item.Quantity)
            .HasDefaultValue(0)
            .IsRequired();
    }
}