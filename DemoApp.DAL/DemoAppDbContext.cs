using System.Data.Entity;
using DemoApp.Domain;

namespace DemoApp.DAL
{
    public class DemoAppDbContext : DbContext
    {
        public DemoAppDbContext() : base()
        {
        }

        public DbSet<Customer> Customers { get; set; }
    }
}