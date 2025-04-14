using System.ComponentModel.DataAnnotations.Schema;
using BusinessObjects.Authentication;

namespace BusinessObjects.Shop;

public class ProductImage
{
    public Guid Id { get; set; }
    public String? ImageUrl { get; set; }
    public String? ImageTag { get; set; }
    public String? ImageBase64 { get; set; }
    public DateTime ModifiedAt { get; set; }
    public DateTime CreatedAt { get; set; }
    [ForeignKey(nameof(ModifiedById))]
    public Guid? ModifiedById { get; set; }
    [ForeignKey(nameof(CreatedById))]
    public Guid? CreatedById { get; set; }
    [ForeignKey(nameof(ProductId))]
    public Guid ProductId { get; set; }
    
    public virtual Account? CreatedBy { get; set; }
    public virtual Account? ModifiedBy { get; set; }
    public virtual Product Product { get; set; }
}