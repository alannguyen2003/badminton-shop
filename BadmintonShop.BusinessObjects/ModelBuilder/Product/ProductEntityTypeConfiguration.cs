using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Product;

public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<BadmintonShop.BusinessObjects.Entity.Shop.Product>
{
    public void Configure(EntityTypeBuilder<BadmintonShop.BusinessObjects.Entity.Shop.Product> builder)
    {
        builder.ToTable("Products");
        builder.Property(prop => prop.ProductName)
            .IsRequired();
        builder.Property(prop => prop.ProductDescription)
            .HasMaxLength(4096)
            .IsRequired(false);
        builder.Property(prop => prop.ThumbnailUrl)
            .IsRequired(false);
        builder.Property(prop => prop.ThumbnailBase64)
            .IsRequired(false);
        builder
            .HasOne(prop => prop.CreatedBy)
            .WithMany(prop => prop.ProductsCreated)
            .HasForeignKey(prop => prop.CreatedById)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);
        builder
            .HasOne(prop => prop.UpdatedBy)
            .WithMany(prop => prop.ProductsUpdated)
            .HasForeignKey(prop => prop.UpdatedById)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);
        builder
            .HasOne(prop => prop.ProductCategory)
            .WithMany(prop => prop.Products)
            .HasForeignKey(prop => prop.ProductCategoryId)
            .IsRequired();
        builder
            .HasMany(prop => prop.ProductImages)
            .WithOne(prop => prop.Product)
            .HasForeignKey(prop => prop.ProductId)
            .IsRequired();
    }
}