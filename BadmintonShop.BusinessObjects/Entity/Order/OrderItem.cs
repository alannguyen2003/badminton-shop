using BadmintonShop.BusinessObjects.Entity.Shop;

namespace BadmintonShop.BusinessObjects.Entity.Order;

public class OrderItem
{
    public Guid Id { get; set; }
    public Guid OrderId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    public float Price { get; set; }
    
    public virtual Entity.Order.Order Order { get; set; }
    public virtual Product Product { get; set; }
}