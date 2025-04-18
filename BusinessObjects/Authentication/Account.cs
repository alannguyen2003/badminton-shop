using BusinessObjects.Shop;
using Microsoft.AspNetCore.Identity;

namespace BusinessObjects.Authentication;

public class Account : IdentityUser<Guid>
{
    public String? AvatarUrl { get; set; }
    public virtual ICollection<Product> ProductsCreated { get; set; }
    public virtual ICollection<Product> ProductsUpdated { get; set; }
    public virtual ICollection<ProductCategory> ProductCategoriesCreated { get; set; }
    public virtual ICollection<ProductCategory> ProductsCategoriesUpdated { get; set; }
    public virtual ICollection<ProductImage> ProductImagesCreated { get; set; }
    public virtual ICollection<ProductImage> ProductImagesUpdated { get; set; }
}