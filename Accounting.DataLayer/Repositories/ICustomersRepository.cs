using System.Collections.Generic;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomersRepository
    {
        List<Customers> GetCustomers();
        IEnumerable<Customers> GetCustomerBySearch(string param);
        Customers GetCustomerById(int id);

        bool AddCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool RemoveCustomer(Customers customer);
        bool RemoveCustomer(int id);
        
    }
}