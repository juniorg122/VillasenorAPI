using System.Collections.Generic;
using VillasenorAPI.Models;

namespace VillasenorAPI.Data
{
    public interface ICustomerAPIRepo
    {
        bool SaveChanges();

        IEnumerable<Customer> GetAllCustomers();
        
        IEnumerable<SellingCustomer> GetAllSellingCustomers();
        IEnumerable<BuyingCustomer> GetAllBuyingCustomers();
        Customer GetCustomerbyId(int id) ; 
        void CreateBuyingCustomer(BuyingCustomer customer);

    void CreateSellingCustomer(SellingCustomer customer);
        
        void UpdateCustomer(Customer customer);
        void DeleteCustomer(Customer customer);
    }
}