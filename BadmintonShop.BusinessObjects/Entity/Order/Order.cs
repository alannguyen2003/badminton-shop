using BadmintonShop.BusinessObjects.Entity.Address;
using BadmintonShop.BusinessObjects.Entity.Authentication;

namespace BadmintonShop.BusinessObjects.Entity.Order;

public class Order
{
    public Guid Id { get; set; }
    public Guid AccountId { get; set; }
    public float TotalPrice { get; set; }
    public String OrderStatus { get; set; }
    public String PaymentMethod { get; set; }
    public DateTime OrderDate { get; set; }
    public DateTime DeliveryDate { get; set; }
    public Guid LocationId { get; set; }
    
    public virtual Account Account { get; set; }
    public virtual Location Location { get; set; }
    public virtual ICollection<OrderItem> OrderItems { get; set; }
}