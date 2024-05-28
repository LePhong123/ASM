namespace ASM.Models;

using System.Reflection;

using Microsoft.EntityFrameworkCore;

public class ShopDbContext : DbContext
{
    public ShopDbContext()
    {
    }

    public ShopDbContext(DbContextOptions options)
        : base(options)
    {
    }

    public object BillDetail { get; internal set; }

    public object BillDetails { get; internal set; }

    public DbSet<BillDetails> BillDetailss { get; set; }

    public DbSet<Bill> Bills { get; set; }

    public DbSet<CartDetail> CartDetails { get; set; }

    public DbSet<Cart> Carts { get; set; }

    public DbSet<Product> Products { get; set; }

    public DbSet<Role> Roles { get; set; }

    public DbSet<User> Users { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder.UseSqlServer(
            @"Data Source=DESKTOP-UBD0I1G\SQLEXPRESS;Initial Catalog=SD_NET104_phong;User ID=phonglhph24259;Password=123");
    }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
    }
}