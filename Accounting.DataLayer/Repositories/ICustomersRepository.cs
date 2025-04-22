using System.Collections.Generic;
using Accounting.ViewModels.CustomerVm;

namespace Accounting.DataLayer.Repositories
{
    public interface ICustomersRepository
    {
        #region Query

        List<Customers> GetCustomers();
        IEnumerable<Customers> GetCustomerBySearch(string param);
        Customers GetCustomerById(int id);
        List<CustomerViewModel> GetCustomersName(string filter="");
        int GetCustomerIdByName(string name);
        string GetCustomerNameById(int Id);

        #endregion

        #region Command

        bool AddCustomer(Customers customer);
        bool UpdateCustomer(Customers customer);
        bool RemoveCustomer(Customers customer);
        bool RemoveCustomer(int id);

        #endregion
        
    }
}