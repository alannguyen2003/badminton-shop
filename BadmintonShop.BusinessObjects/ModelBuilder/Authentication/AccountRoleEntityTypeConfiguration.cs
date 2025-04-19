using BadmintonShop.BusinessObjects.Entity.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BadmintonShop.BusinessObjects.ModelBuilder.Authentication;

public class AccountRoleEntityTypeConfiguration: IEntityTypeConfiguration<AccountRole>
{
    public void Configure(EntityTypeBuilder<AccountRole> builder)
    {
        builder.ToTable("AccountRoles"); 
        builder
            .HasOne(item => item.Account)
            .WithMany(item => item.AccountRoles)
            .HasForeignKey(item => item.UserId)
            .OnDelete(DeleteBehavior.NoAction);
        builder
            .HasOne(item => item.Role)
            .WithMany(item => item.AccountRoles)
            .HasForeignKey(item => item.RoleId)
            .OnDelete(DeleteBehavior.NoAction);
    }
}