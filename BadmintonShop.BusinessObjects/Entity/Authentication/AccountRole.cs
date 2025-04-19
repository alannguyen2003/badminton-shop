using Microsoft.AspNetCore.Identity;

namespace BadmintonShop.BusinessObjects.Entity.Authentication;

public class AccountRole: IdentityUserRole<Guid>
{
    public virtual Account Account { get; set; }
    public virtual Role Role { get; set; }
}