using BadmintonShop.BusinessObjects.Shop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configuration.ModelBuilder;

public class ProductImageEntityTypeConfiguration: IEntityTypeConfiguration<ProductImage>
{
    public void Configure(EntityTypeBuilder<ProductImage> builder)
    {
        builder.ToTable("ProductImages");
        builder
            .Property(prop => prop.Id)
            .IsRequired();
        builder
            .HasOne(prop => prop.Product)
            .WithMany(prop => prop.ProductImages)
            .HasForeignKey(prop => prop.ProductId)
            .IsRequired();  
        builder.Property(prop => prop.CreatedAt)
            .HasDefaultValueSql("getdate()");
        builder.Property(prop => prop.UpdatedAt)
            .HasDefaultValueSql("getdate()");
        builder
            .HasOne(prop => prop.CreatedBy)
            .WithMany(prop => prop.ProductImagesCreated)
            .HasForeignKey(prop => prop.CreatedById);
        builder
            .HasOne(prop => prop.UpdatedBy)
            .WithMany(prop => prop.ProductImagesUpdated)
            .HasForeignKey(prop => prop.UpdatedById);
    }
}