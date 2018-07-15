using DemoApp.ApplicationService;
using DemoApp.IntegrationTests.Fixtures;
using DemoApp.Repositories;
using FluentAssertions;
using Xunit;

namespace DemoApp.IntegrationTests
{
    public class CustomerServiceTests : IClassFixture<DbFixture>
    {
        public CustomerServiceTests(DbFixture fixture)
        {
            _fixture = fixture;
        }

        private readonly DbFixture _fixture;

        [Fact]
        public void SmokeTest()
        {
            var customerRepository = new CustomerRepository(_fixture.DB);
            var customerService = new CustomerService(customerRepository);
            var customers = customerService.GetCustomers();

            customers.Should().BeEmpty();
        }
    }
}