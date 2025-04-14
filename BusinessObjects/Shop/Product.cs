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
    [ForeignKey(nameof(ProductCategoryId))]
    public Guid? ProductCategoryId { get; set; }
    [ForeignKey(nameof(CreatedById))]
    public virtual Guid? CreatedById { get; set; }
    [ForeignKey(nameof(ModifiedById))]
    public virtual Guid? ModifiedById { get; set; }
    
    public virtual ProductCategory  ProductCategory { get; set; }
    public virtual ICollection<ProductImage> ProductImages { get; set; }
    public virtual Account? CreatedBy { get; set; }
    public virtual Account? ModifiedBy { get; set; }
}