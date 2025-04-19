using Microsoft.AspNetCore.Identity;

namespace BadmintonShop.BusinessObjects.Entity.Authentication;

public sealed class AccountToken: IdentityUserToken<Guid>
{
    public Account Account { get; set; }
}