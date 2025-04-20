using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.ViewModels.CustomerVm;

namespace Accounting.DataLayer.Services
{
    public class CustomersRepository : ICustomersRepository
    {

        private AccountingDbContext _context;

        public CustomersRepository(AccountingDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Customers> GetCustomerBySearch(string param)
        {
           return _context.Customers.Where(it =>
                    it.FullName.Contains(param) || it.Phone.Contains(param) || it.Email.Contains(param)).ToList();
        }

        public Customers GetCustomerById(int customerId)
        {
            return _context.Customers.Find(customerId);
        }

        public List<CustomerViewModel> GetCustomersName(string filter = "")
        {
            if (filter == null)
            {
              return _context.Customers.Select(n => new CustomerViewModel()
              {
                  Id = n.CustomerID,
                  FullName = n.FullName
              }).ToList();
            }

            return _context.Customers.Where(c => c.FullName.Contains(filter)).Select(n => new CustomerViewModel()
            {
                Id = n.CustomerID,
                FullName = n.FullName

            }).ToList();
        }

        public int GetCustomerIdByName(string name)
        {
           return _context.Customers.First(c => c.FullName == name).CustomerID;
        }

        public List<Customers> GetCustomers()
        {
            return _context.Customers.ToList();
        }
        public bool AddCustomer(Customers customer)
        {
            try
            {
                _context.Customers.Add(customer);
                return true;
            } 
            catch 
            {
                return false;
            }
        }
        public bool UpdateCustomer(Customers customer)
        {
            var local = _context.Set<Customers>().Local.FirstOrDefault(c => c.CustomerID == customer.CustomerID);
            if (local != null)
            {
                _context.Entry(local).State = EntityState.Detached;
            }
           
                _context.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                return true;
        }
        
        public bool RemoveCustomer(Customers customer)
        {
            try
            {
                _context.Entry(customer).State = System.Data.Entity.EntityState.Deleted;
                return true;
            }
            catch
            {
                return false;
            }
        }

        public bool RemoveCustomer(int id)
        {
            var customer = GetCustomerById(id);
            RemoveCustomer(customer);
            return true;
        }

        

       
    }
}
