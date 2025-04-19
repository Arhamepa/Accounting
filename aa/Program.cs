using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Accounting.DataLayer.Context;

namespace aa
{
    class Program
    {
        static void Main(string[] args)
        {
            UnitOfWork db = new UnitOfWork();
            Console.WriteLine(db.CustomersRepository.GetCustomerById(2).FullName);
        }
    }
}
