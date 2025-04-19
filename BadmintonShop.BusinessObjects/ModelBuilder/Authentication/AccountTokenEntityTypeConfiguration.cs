using BadmintonShop.BusinessObjects.Entity.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Authentication;

public class AccountTokenEntityTypeConfiguration: IEntityTypeConfiguration<AccountToken>
{
    public void Configure(EntityTypeBuilder<AccountToken> builder)
    {
        builder.ToTable("AccountTokens");
        builder.Property(item => item.Value)
            .HasMaxLength(200);
        builder
            .Property(item => item.LoginProvider)
            .HasMaxLength(128);
        builder
            .Property(item => item.Name)
            .HasMaxLength(128);
        builder
            .HasOne(item => item.Account)
            .WithMany(item => item.AccountTokens)
            .HasForeignKey(item => item.UserId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}