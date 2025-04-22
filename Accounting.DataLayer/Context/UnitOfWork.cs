using System;
using Accounting.DataLayer.Repositories;
using Accounting.DataLayer.Services;

namespace Accounting.DataLayer.Context
{
    public class UnitOfWork:IDisposable
    {
        AccountingDbContext _context = new AccountingDbContext();


        #region Interfaces

        private ICustomersRepository _customersRepository;
        public ICustomersRepository CustomersRepository => _customersRepository ??
                                                           (_customersRepository = new CustomersRepository(_context));

        private Repository<Accounting> _accountingRepository;

        public Repository<Accounting> AccountingRepository => _accountingRepository ??
                                                              (_accountingRepository = new Repository<Accounting>(_context));
        private Repository<Login> _loginRepository;

        public Repository<Login> LoginRepository =>
            _loginRepository ?? (_loginRepository = new Repository<Login>(_context));

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