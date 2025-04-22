using System;
using System.Linq;
using Accounting.DataLayer.Context;
using Accounting.ViewModels.AccountingVm;

namespace Accounting.Service
{
    public class Account
    {
        public static ReportViewModel ReportFromMain()
        {
            ReportViewModel model = new ReportViewModel();
            using (UnitOfWork _context =new UnitOfWork())
            {
                DateTime startDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 01);
                DateTime endDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, 30);

                var receive = _context.AccountingRepository
                    .GetAll(a => a.TypeId == 1 && a.DateTime >= startDate && a.DateTime <= endDate)
                    .Select(it => it.Amount).ToList();

                var pay=_context.AccountingRepository
                    .GetAll(a => a.TypeId == 2 && a.DateTime >= startDate && a.DateTime <= endDate)
                    .Select(it => it.Amount).ToList();

                model.Recieve = receive.Sum();
                model.Pay = pay.Sum();
                model.Balance = (receive.Sum() - pay.Sum());

            }

            return model;
        }
    }
}