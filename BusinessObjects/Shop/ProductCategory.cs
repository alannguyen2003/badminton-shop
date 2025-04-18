﻿using System.ComponentModel.DataAnnotations.Schema;
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
    public Guid? CreatedById { get; set; }
    public DateTime UpdatedAt { get; set; }
    public Guid? UpdatedById { get; set; }
    public Guid? ParentCategoryId { get; set; }
    
    public virtual Account? CreatedBy { get; set; }
    public virtual Account? UpdatedBy { get; set; }
    public virtual ProductCategory? ParentCategory { get; set; }
    public virtual ICollection<ProductCategory> ProductCategories { get; set; }
    public virtual ICollection<Product> Products { get; set; }
}