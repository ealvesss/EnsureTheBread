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
    }
}