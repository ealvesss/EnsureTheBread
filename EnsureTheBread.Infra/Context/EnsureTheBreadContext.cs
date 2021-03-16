using EnsureTheBread.Domain.Entities;
using Microsoft.EntityFrameworkCore;

namespace EnsureTheBread.Infra.Context
{
    public class EnsureTheBreadContext : DbContext
    {
        public DbSet<Customer> Customer {get;set;}
        public DbSet<Order> Order {get;set;}
        public DbSet<Product> Product {get;set;}
        public DbSet<ProductProperties> ProductProperties {get;set;}

        public EnsureTheBreadContext(DbContextOptions<EnsureTheBreadContext> options)
        :base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder){
            
            builder.Entity<Customer>().HasKey(x => x.Id);
            builder.Entity<Customer>().Property(x => x.Address);
            builder.Entity<Customer>().Property(x => x.FistName);
            builder.Entity<Customer>().Property(x => x.LastName);
            builder.Entity<Customer>().Property(x => x.InsertedIn).HasDefaultValueSql("getdate()");

            builder.Entity<Order>().HasKey(x => x.Id);
            builder.Entity<Order>().Property(x => x.Customer.Id);
            builder.Entity<Order>().Property(x => x.Items);
            builder.Entity<Order>().Property(x => x.OrderDate).HasDefaultValueSql("getdate()");

            builder.Entity<Items>().Property(x => x.Id);

            builder.Entity<Product>().HasKey(x => x.Id);


            builder.Entity<ProductProperties>().HasKey(x => x.Id);
        }
    }
}