using BadmintonShop.BusinessObjects.Entity.Cart;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Product;

public class CartEntityTypeConfiguration: IEntityTypeConfiguration<Cart>
{
    public void Configure(EntityTypeBuilder<Cart> builder)
    {
        builder.ToTable("Carts");
        builder.HasKey(item => new {item.AccountId, item.ProductId });
        builder.Property(item => item.Quantity).IsRequired()
            .HasDefaultValue(0);
        builder
            .HasOne(item => item.Product)
            .WithMany(item => item.Carts)
            .HasForeignKey(item => item.ProductId)
            .IsRequired();
        builder
            .HasOne(item => item.Account)
            .WithMany(item => item.Carts)
            .HasForeignKey(item => item.AccountId)
            .IsRequired();
    }
}