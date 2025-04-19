using BadmintonShop.BusinessObjects.Entity.Shop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Product;

public class ProductCategoryEntityTypeConfiguration: IEntityTypeConfiguration<ProductCategory>
{
    public void Configure(EntityTypeBuilder<ProductCategory> builder)
    {
        builder.ToTable("ProductCategories");
        builder.Property(c => c.Id)
            .IsRequired();
        builder.Property(prop => prop.CategoryName)
            .IsRequired();
        builder.Property(prop => prop.IsDelete)
            .IsRequired()
            .HasDefaultValue(false);
        builder.Property(prop => prop.CategoryDescription)
            .IsRequired(false)
            .HasMaxLength(1000);
        builder.Property(prop => prop.CreatedAt)
            .IsRequired()
            .HasDefaultValueSql("getdate()");
        builder.Property(prop => prop.UpdatedAt)
            .IsRequired()
            .HasDefaultValueSql("getdate()");
        builder
            .HasOne(prop => prop.CreatedBy)
            .WithMany(prop => prop.ProductCategoriesCreated)
            .HasForeignKey(prop => prop.CreatedById)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);
        builder
            .HasOne(prop => prop.UpdatedBy)
            .WithMany(prop => prop.ProductCategoriesUpdated)
            .HasForeignKey(prop => prop.UpdatedById)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);
        builder
            .HasMany(prop => prop.Products)
            .WithOne(prop => prop.ProductCategory)
            .HasForeignKey(prop => prop.ProductCategoryId)
            .IsRequired();
        builder
            .HasMany(prop => prop.ProductCategories)
            .WithOne(prop => prop.ParentCategory)
            .HasForeignKey(prop => prop.ParentCategoryId)
            .IsRequired(false)
            .OnDelete(DeleteBehavior.NoAction);
    }
}