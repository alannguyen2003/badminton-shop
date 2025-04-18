using System.ComponentModel.DataAnnotations.Schema;
using BusinessObjects.Authentication;

namespace BusinessObjects.Shop;

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

}