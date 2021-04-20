using VillasenorAPI.Models;

namespace VillasenorAPI.Data
{
    public interface ICustomerAPIRepo
    {
        bool SaveChanges();

        void CreateCustomer(Customer cutomer);
    }
}