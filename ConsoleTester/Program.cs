using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

namespace ConsoleTester
{
    class Program
    {
       
        static void Main(string[] args)
        {
            UnitOfWork db = new UnitOfWork();

            var listCustomer = db.CustomersRepository.GetCustomers();
            //Customers customer = new Customers()
            //{
            //    FullName = "Peyman Fashandi",
            //    Address = "accc",
            //    CustomerImg = "No Photo",
            //    Phone = "09999999999"
            //};
            //_customersRepository.AddCustomer(customer);
            //_customersRepository.Save();

            //var customerList = _customersRepository.GetCustomers();
        }
    }
}
