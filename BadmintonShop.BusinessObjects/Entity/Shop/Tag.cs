namespace BadmintonShop.BusinessObjects.Entity.Shop;

public class Tag
{
    public Guid Id { get; set; }
    public String TagName { get; set; }
    public String TagDescription { get; set; }
    public virtual ICollection<ProductTag> ProductTags { get; set; }
}