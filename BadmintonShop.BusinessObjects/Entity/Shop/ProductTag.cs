﻿namespace BadmintonShop.BusinessObjects.Entity.Shop;

public class ProductTag
{
    public Guid ProductId { get; set; }
    public Guid TagId { get; set; }
    
    public virtual Product Product { get; set; }
    public virtual Tag Tag { get; set; }
}