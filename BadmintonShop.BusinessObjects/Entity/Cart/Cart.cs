using BadmintonShop.BusinessObjects.Entity.Authentication;
using BadmintonShop.BusinessObjects.Entity.Shop;

namespace BadmintonShop.BusinessObjects.Entity.Cart;

public class Cart
{
    public Guid AccountId { get; set; }
    public Guid ProductId { get; set; }
    public int Quantity { get; set; }
    
    public virtual Account Account { get; set; }
    public virtual Product Product { get; set; }
}