using System.Collections.Generic;
using DemoApp.ApplicationService.Contracts;
using DemoApp.Domain;
using DemoApp.Repositories.Contracts;

namespace DemoApp.ApplicationService
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository _customerRepository;

        public CustomerService(ICustomerRepository customerRepository)
        {
            _customerRepository = customerRepository;
        }

        public List<Customer> GetCustomers()
        {
            return _customerRepository.GetAllCustomers();
        }
    }
}