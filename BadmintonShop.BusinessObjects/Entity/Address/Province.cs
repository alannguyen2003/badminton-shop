namespace BadmintonShop.BusinessObjects.Entity.Address;

public class Province
{
    public Guid Id { get; set; }
    public String ProvinceName { get; set; }
    public String ProvinceCode { get; set; }
    
    public virtual ICollection<District> Districts { get; set; }
    public virtual ICollection<Location> Locations { get; set; }
}