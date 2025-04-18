using System.ComponentModel.DataAnnotations.Schema;
using BusinessObjects.Authentication;

namespace BusinessObjects.Shop;

public class ProductImage
{
    public Guid Id { get; set; }
    public String? ImageUrl { get; set; }
    public String? ImageTag { get; set; }
    public String? ImageBase64 { get; set; }
    public DateTime UpdatedAt { get; set; }
    public DateTime CreatedAt { get; set; }
    public Guid? UpdatedById { get; set; }
    public Guid? CreatedById { get; set; }
    public Guid ProductId { get; set; }
    
    public virtual Account? CreatedBy { get; set; }
    public virtual Account? UpdatedBy { get; set; }
    public virtual Product Product { get; set; }
}