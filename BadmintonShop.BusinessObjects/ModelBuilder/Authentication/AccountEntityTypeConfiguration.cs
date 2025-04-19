using BadmintonShop.BusinessObjects.Entity.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Authentication;

public class AccountEntityTypeConfiguration: IEntityTypeConfiguration<Account>
{
    public void Configure(EntityTypeBuilder<Account> builder)
    {
        builder.ToTable("Accounts");
        //Product
        builder
            .HasMany(item => item.ProductsCreated)
            .WithOne(item => item.CreatedBy)
            .HasForeignKey(item => item.CreatedById)
            .OnDelete(DeleteBehavior.SetNull);
        builder
            .HasMany(item => item.ProductsUpdated)
            .WithOne(item => item.UpdatedBy)
            .HasForeignKey(item => item.UpdatedById)
            .OnDelete(DeleteBehavior.SetNull);
        //Product Category
        builder
            .HasMany(item => item.ProductCategoriesCreated)
            .WithOne(item => item.CreatedBy)
            .HasForeignKey(item => item.CreatedById)
            .OnDelete(DeleteBehavior.SetNull);
        builder
            .HasMany(item => item.ProductCategoriesUpdated)
            .WithOne(item => item.UpdatedBy)
            .HasForeignKey(item => item.UpdatedById)
            .OnDelete(DeleteBehavior.SetNull);
        //Product Image
        builder
            .HasMany(item => item.ProductImagesCreated)
            .WithOne(item => item.CreatedBy)
            .HasForeignKey(item => item.CreatedById)
            .OnDelete(DeleteBehavior.SetNull);
        builder
            .HasMany(item => item.ProductImagesUpdated)
            .WithOne(item => item.UpdatedBy)
            .HasForeignKey(item => item.UpdatedById)
            .OnDelete(DeleteBehavior.SetNull);  
        //Location
        builder
            .HasMany(item => item.Locations)
            .WithOne(item => item.Account)
            .HasForeignKey(item => item.AccountId)
            .OnDelete(DeleteBehavior.Cascade);
        
    }
}