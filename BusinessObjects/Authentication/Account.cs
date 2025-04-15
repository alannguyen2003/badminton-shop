using Microsoft.AspNetCore.Identity;

namespace BusinessObjects.Authentication;

public class Account : IdentityUser<Guid>
{
    public String? AvatarUrl { get; set; }
       
}