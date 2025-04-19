using BadmintonShop.BusinessObjects;
using BadmintonShop.BusinessObjects.Entity.Address;
using BadmintonShop.BusinessObjects.Entity.Authentication;
using BadmintonShop.BusinessObjects.Entity.Cart;
using BadmintonShop.BusinessObjects.Entity.Order;
using BadmintonShop.BusinessObjects.Entity.Shop;
using BadmintonShop.BusinessObjects.ModelBuilder.Address;
using BadmintonShop.BusinessObjects.ModelBuilder.Authentication;
using BadmintonShop.BusinessObjects.ModelBuilder.Order;
using BadmintonShop.BusinessObjects.ModelBuilder.Product;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BadmintonShop.Repositories;

public class ApplicationDbContext: IdentityDbContext<
    Account, 
    Role, 
    Guid,
    AccountClaim,
    AccountRole,
    AccountLogin,
    RoleClaim,
    AccountToken>
{
    private static String DEFAULT_CONNECTION_STRING = "DefaultConnectionString";

    public ApplicationDbContext()
    {
    }
    
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }
    
    public virtual DbSet<Account> Accounts { get; set; }
    public virtual DbSet<Role> Roles { get; set; }
    public virtual DbSet<Product> Products { get; set; }    
    public virtual DbSet<ProductCategory> ProductCategories { get; set; }
    public virtual DbSet<ProductImage> ProductImages { get; set; }
    public virtual DbSet<Order> Orders { get; set; }
    public virtual DbSet<OrderItem> OrderItems { get; set; }
    public virtual DbSet<Cart> Carts { get; set; }

    private String GetConnectionString()
    {
        IConfiguration configuration = new ConfigurationBuilder()
            .SetBasePath(Directory.GetCurrentDirectory())
            .AddJsonFile("appsettings.json", true, true)
            .Build();
        return configuration.GetConnectionString("DefaultConnectionString") ?? String.Empty;
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(GetConnectionString());
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        base.OnModelCreating(modelBuilder);
        new AccountEntityTypeConfiguration().Configure(modelBuilder.Entity<Account>());
        new RoleEntityTypeConfiguration().Configure(modelBuilder.Entity<Role>());
        new AccountClaimEntityTypeConfiguration().Configure(modelBuilder.Entity<AccountClaim>());
        new RoleClaimEntityTypeConfiguration().Configure(modelBuilder.Entity<RoleClaim>());
        new AccountTokenEntityTypeConfiguration().Configure(modelBuilder.Entity<AccountToken>());
        new AccountRoleEntityTypeConfiguration().Configure(modelBuilder.Entity<AccountRole>());
        new AccountLoginEntityTypeConfiguration().Configure(modelBuilder.Entity<AccountLogin>());
        new ProductEntityTypeConfiguration().Configure(modelBuilder.Entity<Product>());
        new ProductCategoryEntityTypeConfiguration().Configure(modelBuilder.Entity<ProductCategory>());
        new ProductImageEntityTypeConfiguration().Configure(modelBuilder.Entity<ProductImage>());
        new ProvinceEntityTypeConfiguration().Configure(modelBuilder.Entity<Province>());
        new DistrictEntityTypeConfiguration().Configure(modelBuilder.Entity<District>());
        new WardEntityTypeConfiguration().Configure(modelBuilder.Entity<Ward>());
        new LocationEntityTypeConfiguration().Configure(modelBuilder.Entity<Location>());
        new CartEntityTypeConfiguration().Configure(modelBuilder.Entity<Cart>());
        new OrderEntityTypeConfiguration().Configure(modelBuilder.Entity<Order>());
        new OrderItemEntityTypeConfiguration().Configure(modelBuilder.Entity<OrderItem>());
        new TagEntityTypeConfiguration().Configure(modelBuilder.Entity<Tag>());
        new ProductTagEntityTypeConfiguration().Configure(modelBuilder.Entity<ProductTag>());
    }
}