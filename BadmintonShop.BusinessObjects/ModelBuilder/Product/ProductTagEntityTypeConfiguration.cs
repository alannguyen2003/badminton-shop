using BadmintonShop.BusinessObjects.Entity.Shop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Product;

public class ProductTagEntityTypeConfiguration: IEntityTypeConfiguration<ProductTag>
{
    public void Configure(EntityTypeBuilder<ProductTag> builder)
    {
        builder.ToTable("ProductTags");
        builder.HasKey(item => new {item.ProductId, item.TagId});
        builder
            .HasOne(item => item.Product)
            .WithMany(item => item.ProductTags)
            .HasForeignKey(item => item.ProductId)
            .IsRequired();
        builder
            .HasOne(item => item.Tag)
            .WithMany(item => item.ProductTags)
            .HasForeignKey(item => item.TagId)
            .IsRequired();
    }
}