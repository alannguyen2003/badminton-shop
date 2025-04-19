namespace BadmintonShop.BusinessObjects.Entity.Address;

public class District
{
    public Guid Id { get; set; }
    public String DistrictName { get; set; }
    public String DistrictCode { get; set; }
    public Guid ProvinceId { get; set; }
    
    public virtual Province Province { get; set; }
    public virtual ICollection<Ward> Wards { get; set; }
    public virtual ICollection<Location> Locations { get; set; }
}