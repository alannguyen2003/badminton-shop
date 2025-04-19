using BadmintonShop.BusinessObjects.Entity.Authentication;

namespace BadmintonShop.BusinessObjects.Entity.Address;

public class Location
{
    public Guid Id { get; set; }
    public String LocationAddress { get; set; }
    public String LocationType { get; set; }
    public bool IsDelete { get; set; }
    public bool IsDefaultAddress { get; set; }
    public Guid WardId { get; set; }
    public Guid DistrictId { get; set; }
    public Guid ProvinceId { get; set; }
    public Guid AccountId { get; set; }
    
    public virtual Ward Ward { get; set; }
    public virtual District District { get; set; }
    public virtual Province Province { get; set; }
    public virtual Account Account { get; set; }
    public virtual ICollection<Order.Order> Orders { get; set; }
}