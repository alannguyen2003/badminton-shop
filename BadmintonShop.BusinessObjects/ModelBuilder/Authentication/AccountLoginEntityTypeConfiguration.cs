using BadmintonShop.BusinessObjects.Entity.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Authentication;

public class AccountLoginEntityTypeConfiguration: IEntityTypeConfiguration<AccountLogin>
{
    public void Configure(EntityTypeBuilder<AccountLogin> builder)
    {
        builder.ToTable("AccountLogins");   
    }
}