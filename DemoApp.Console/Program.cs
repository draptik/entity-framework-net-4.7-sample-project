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
            var customerService = new CustomerService(new CustomerRepository(new DemoAppDbContext()));
            var customers = customerService.GetCustomers();
        }
    }
}