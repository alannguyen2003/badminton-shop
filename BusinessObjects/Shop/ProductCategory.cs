using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;
using BusinessObjects.Authentication;

namespace BusinessObjects.Shop;

public class ProductCategory
{
    public Guid Id { get; set; }
    public String CategoryName { get; set; }
    public String CategoryDescription { get; set; }
    public bool IsDelete { get; set; }
    public DateTime CreatedAt { get; set; }
    [ForeignKey(nameof(CreatedById))]
    public Guid? CreatedById { get; set; }
    public DateTime ModifiedAt { get; set; }
    [ForeignKey(nameof(ModifiedById))]
    public Guid? ModifiedById { get; set; }
    
    [ForeignKey(nameof(OfCategoryId))]
    public Guid? OfCategoryId { get; set; }
        
        
    public virtual Account CreatedBy { get; set; }
    public virtual Account ModifiedBy { get; set; }
    public virtual ICollection<ProductCategory> Categories { get; set; }
    public virtual ProductCategory OfCategory { get; set; }

}