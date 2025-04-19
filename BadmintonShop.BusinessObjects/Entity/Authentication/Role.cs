using Microsoft.AspNetCore.Identity;

namespace BadmintonShop.BusinessObjects.Entity.Authentication;

public class Role : IdentityRole<Guid>
{
    public virtual ICollection<AccountRole> AccountRoles { get; set; }
}