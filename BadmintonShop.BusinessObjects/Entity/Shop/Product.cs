using BadmintonShop.BusinessObjects.Entity.Authentication;
using BadmintonShop.BusinessObjects.Entity.Order;

namespace BadmintonShop.BusinessObjects.Entity.Shop;

public class Product
{
    public Guid Id { get; set; }
    public String ProductName { get; set; }
    public String ProductDescription { get; set; }
    public String? ThumbnailUrl { get; set; }
    public String? ThumbnailBase64 { get; set; }
    public Guid? ProductCategoryId { get; set; }
    public DateTime CreatedAt { get; set; }
    public virtual Guid? CreatedById { get; set; }
    public DateTime UpdatedAt { get; set; }
    public virtual Guid? UpdatedById { get; set; }
    
    public virtual ProductCategory  ProductCategory { get; set; }
    public virtual Account? CreatedBy { get; set; }
    public virtual Account? UpdatedBy { get; set; }
    public virtual ICollection<ProductImage> ProductImages { get; set; }
    public virtual ICollection<ProductTag> ProductTags { get; set; }
    public virtual ICollection<OrderItem> OrderItems { get; set; }
    public virtual ICollection<Cart.Cart> Carts { get; set; }

}