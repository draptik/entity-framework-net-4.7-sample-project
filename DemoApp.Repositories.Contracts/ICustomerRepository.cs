using System.Collections.Generic;
using DemoApp.Domain;

namespace DemoApp.Repositories.Contracts
{
    public interface ICustomerRepository
    {
        List<Customer> GetAllCustomers();
    }
}