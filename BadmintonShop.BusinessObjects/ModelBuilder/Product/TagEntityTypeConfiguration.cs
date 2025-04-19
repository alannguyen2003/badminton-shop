using BadmintonShop.BusinessObjects.Entity.Shop;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Product;


public class TagEntityTypeConfiguration: IEntityTypeConfiguration<Tag>
{
    public void Configure(EntityTypeBuilder<Tag> builder)
    {
        builder.ToTable("Tags");
        builder.HasKey(item => item.Id);
        builder
            .HasMany(item => item.ProductTags)
            .WithOne(item => item.Tag)
            .HasForeignKey(item => item.TagId);
    }
}