using System.Collections.Generic;
using System.Linq;
using VillasenorAPI.Models;

namespace VillasenorAPI.Data
{
    public class SqlCustomerAPIRepo : ICustomerAPIRepo
    {
        private readonly CustomerContext _customer;

        public SqlCustomerAPIRepo(CustomerContext customer)
        {
            _customer = customer ; 
        }
        public void CreateCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public void DeleteCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<Customer> GetAllCustomers()
        {
            return _customer.customerItems.ToList();
        }

        public Customer GetCustomerbyId(int id)
        {
            return _customer.customerItems.FirstOrDefault(p => p.Id  == id);
        }

        public bool SaveChanges()
        {
            throw new System.NotImplementedException();
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }
    }
}