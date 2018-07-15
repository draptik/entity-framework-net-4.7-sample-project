using System.Data.Entity;
using DemoApp.ApplicationService;
using DemoApp.DAL;
using DemoApp.DbLocator;
using DemoApp.Repositories;
using FluentAssertions;
using Xunit;

namespace DemoApp.IntegrationTests
{
    public class CustomerServiceTests
    {
        private DemoAppDbContext DB { get; set; }

        [Fact]
        public void SmokeTest()
        {
            LocateDevDb.SetDataDirectory();
            Database.SetInitializer(new DropCreateDatabaseAlways<DemoAppDbContext>());
            this.DB = new DemoAppDbContext();
            this.DB.Database.Initialize(true);
            //this.DB.Database.ExecuteSqlCommand("...");

            var demoAppDbContext = new DemoAppDbContext();
            var customerRepository = new CustomerRepository(demoAppDbContext);
            var customerService = new CustomerService(customerRepository);
            var customers = customerService.GetCustomers();

            customers.Should().BeEmpty();
        }
    }
}