namespace BadmintonShop.BusinessObjects.Entity.Address;

public class Ward
{
    public Guid Id { get; set; }
    public String WardName { get; set; }
    public String WardCode { get; set; }
    public Guid DistrictId { get; set; }
    
    public virtual District District { get; set; }
    public virtual ICollection<Location> Locations { get; set; }
}