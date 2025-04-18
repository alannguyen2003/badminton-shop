using BadmintonShop.BusinessObjects;
using BadmintonShop.BusinessObjects.Authentication;
using BadmintonShop.BusinessObjects.Shop;
using Infrastructure.Context.Configuration.ModelBuilder;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace BadmintonShop.Repositories;

public class ApplicationDbContext: IdentityDbContext<Account, Role, Guid>
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
        modelBuilder.Ignore<IdentityUserClaim<Guid>>();
        modelBuilder.Ignore<IdentityUserLogin<Guid>>();
        modelBuilder.Ignore<IdentityUserToken<Guid>>();
        modelBuilder.Ignore<IdentityUserRole<Guid>>();
        modelBuilder.Ignore<IdentityRoleClaim<Guid>>();
        modelBuilder.Entity<Account>()
            .ToTable("Accounts");
        modelBuilder.Entity<Role>()
            .ToTable("Roles");
        new ProductEntityTypeConfiguration().Configure(modelBuilder.Entity<Product>());
        new ProductCategoryEntityTypeConfiguration().Configure(modelBuilder.Entity<ProductCategory>());
        new ProductImageEntityTypeConfiguration().Configure(modelBuilder.Entity<ProductImage>());
    }
}