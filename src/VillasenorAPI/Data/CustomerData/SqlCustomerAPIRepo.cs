using System;
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
            if(customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            
            
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
            return (_customer.SaveChanges() >=0);
        }

        public void UpdateCustomer(Customer customer)
        {
            throw new System.NotImplementedException();
        }

        public IEnumerable<SellingCustomer> GetAllSellingCustomers()
        {
            return _customer.sellingCustomer.ToList();
        }

        public IEnumerable<BuyingCustomer> GetAllBuyingCustomers()
        {
            return _customer.buyingCustomer.ToList();
        }

        public void CreateBuyingCustomer(BuyingCustomer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            _customer.buyingCustomer.Add(customer);
        }

        public void CreateSellingCustomer(SellingCustomer customer)
        {
            if(customer == null)
            {
                throw new ArgumentNullException(nameof(customer));
            }
            _customer.sellingCustomer.Add(customer);
        }
    }
}