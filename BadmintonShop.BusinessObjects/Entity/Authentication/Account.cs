using BadmintonShop.BusinessObjects.Entity.Address;
using BadmintonShop.BusinessObjects.Entity.Shop;
using Microsoft.AspNetCore.Identity;

namespace BadmintonShop.BusinessObjects.Entity.Authentication;

public class Account : IdentityUser<Guid>
{
    public String? AvatarUrl { get; set; }
    public virtual ICollection<Product> ProductsCreated { get; set; }
    public virtual ICollection<Product> ProductsUpdated { get; set; }
    public virtual ICollection<ProductCategory> ProductCategoriesCreated { get; set; }
    public virtual ICollection<ProductCategory> ProductCategoriesUpdated { get; set; }
    public virtual ICollection<ProductImage> ProductImagesCreated { get; set; }
    public virtual ICollection<ProductImage> ProductImagesUpdated { get; set; }
    public virtual ICollection<Location> Locations { get; set; }
    public virtual ICollection<Order.Order> Orders { get; set; }
    public virtual ICollection<Cart.Cart> Carts { get; set; }
    public virtual ICollection<AccountRole> AccountRoles { get; set; }
    public virtual ICollection<AccountToken> AccountTokens { get; set; }
}