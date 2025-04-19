using System;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork:IDisposable
    {
        Accounting_dbEntities _context = new Accounting_dbEntities();


        #region Interfaces

        private ICustomersRepository _customersRepository;
        public ICustomersRepository CustomersRepository => _customersRepository ?? (_customersRepository = new CustomersRepository(_context));


        #endregion
        public void Save()
        {
            _context.SaveChanges();
        }
        public void Dispose()
        {
            _context.Dispose();
        }
    }
}