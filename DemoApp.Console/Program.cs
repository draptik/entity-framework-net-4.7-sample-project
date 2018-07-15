using DemoApp.ApplicationService;
using DemoApp.DAL;
using DemoApp.Repositories;

namespace DemoApp.Console
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            StartWithoutIoC();
        }

        private static void StartWithoutIoC()
        {
            var demoAppDbContext = new DemoAppDbContext();
            var customerRepository = new CustomerRepository(demoAppDbContext);
            var customerService = new CustomerService(customerRepository);
            var customers = customerService.GetCustomers();
        }
    }
}