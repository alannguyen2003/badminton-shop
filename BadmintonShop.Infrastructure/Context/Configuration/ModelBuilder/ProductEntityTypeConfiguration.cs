using BadmintonShop.BusinessObjects.Shop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infrastructure.Context.Configuration.ModelBuilder;

/*public class ProductModelBuilder
{
    /*public void OnProductModelCreating(Microsoft.EntityFrameworkCore.ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<Product>()
            .HasKey(x => x.Id)
            .
    }#1#
}*/

public class ProductEntityTypeConfiguration : IEntityTypeConfiguration<Product>
{
    public void Configure(EntityTypeBuilder<Product> builder)
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
            .HasForeignKey(prop => prop.CreatedById);
        builder
            .HasOne(prop => prop.UpdatedBy)
            .WithMany(prop => prop.ProductsUpdated)
            .HasForeignKey(prop => prop.UpdatedById);
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