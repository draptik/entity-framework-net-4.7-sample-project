using System.Collections.Generic;
using System.Linq;
using DemoApp.DAL;
using DemoApp.Domain;
using DemoApp.Repositories.Contracts;

namespace DemoApp.Repositories
{
    public class CustomerRepository : ICustomerRepository
    {
        private readonly DemoAppDbContext _dbContext;

        public CustomerRepository(DemoAppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public List<Customer> GetAllCustomers()
        {
            return _dbContext.Customers.ToList();
        }
    }
}