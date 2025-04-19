using BadmintonShop.BusinessObjects.Entity.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Authentication;

public class AccountClaimEntityTypeConfiguration: IEntityTypeConfiguration<AccountClaim>
{
    public void Configure(EntityTypeBuilder<AccountClaim> builder)
    {
        builder.ToTable("AccountClaims");
    }
}