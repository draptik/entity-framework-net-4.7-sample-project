using System.Data.Entity;
using DemoApp.Domain;

namespace DemoApp.DAL
{
    public class DemoAppDbContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}