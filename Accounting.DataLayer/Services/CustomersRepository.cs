using Accounting.DataLayer.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accounting.DataLayer.Services
{
    public class CustomersRepository : ICustomersRepository
    {

        private Accounting_dbEntities _context;

        public CustomersRepository(Accounting_dbEntities context)
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
            try
            {
                _context.Entry(customer).State = System.Data.Entity.EntityState.Modified;
                return true;
            }
            catch
            {
                return false;
            }
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
