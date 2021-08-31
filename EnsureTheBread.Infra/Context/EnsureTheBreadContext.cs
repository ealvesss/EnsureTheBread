using EnsureTheBread.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnsureTheBread.Infra.Context
{
  public class EnsureTheBreadContext : DbContext
  {
    public DbSet<Customer> Customer { get; set; }
    public DbSet<Order> Order { get; set; }
    public DbSet<Product> Product { get; set; }
    public DbSet<Item> Item { get; set; }
    public DbSet<ProductProperties> ProductProperties { get; set; }
    
    public EnsureTheBreadContext()
    {
    }

    public EnsureTheBreadContext(DbContextOptions<EnsureTheBreadContext> options)
    : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
      builder.Entity<Customer>().Property(x => x.InsertedIn).HasDefaultValueSql("getdate()");
      builder.Entity<Order>().Property(x => x.OrderDate).HasDefaultValueSql("getdate()");
    }
  }
}