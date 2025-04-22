using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using Accounting.ViewModels.CustomerVm;

namespace Accounting.App.Accounting
{
    public partial class reportFrm : Form
    {
        public int TypeId = 0;

        public reportFrm()
        {
            InitializeComponent();
        }

        private void reportFrm_Load(object sender, EventArgs e)
        {
            using (UnitOfWork _context =new UnitOfWork() )
            {
                List<CustomerViewModel> customers = new List<CustomerViewModel>();
                customers.Add(new CustomerViewModel()
                {
                    Id = 0,
                    FullName = "انتخاب کنید"
                });
                customers.AddRange(_context.CustomersRepository.GetCustomersName());
                customerDropdown.DataSource = customers;
                customerDropdown.DisplayMember = "FullName";
                customerDropdown.ValueMember = "Id";
            }

            if (TypeId == 2)
            {
                this.Text = "گزارش پرداختی";
            }
            else
            {
                this.Text = "گزارش دریافتی";
            }
        }

        private void submitFilter_Click(object sender, EventArgs e)
        {
            Filter();
        }

        void Filter()
        {
            using (UnitOfWork _context = new UnitOfWork())
            {
                DateTime? startDate;
                DateTime? endDate;
                List<DataLayer.Accounting> accountingList = new List<DataLayer.Accounting>();
                if ((int)customerDropdown.SelectedValue != 0)
                {
                    var customerId = int.Parse(customerDropdown.SelectedValue.ToString());
                    accountingList.AddRange(_context.AccountingRepository.GetAll(a => a.TypeId == TypeId &&  a.CustomerId == customerId)
                    );
                }
                else
                {
                    accountingList.AddRange(_context.AccountingRepository.GetAll(a => a.TypeId == TypeId));
                }
                if (string.IsNullOrEmpty(fromDate.Text))
                {
                    startDate = Convert.ToDateTime(fromDate.Text);
                    startDate = DateConvertor.ToMiladi(startDate.Value);
                    accountingList = accountingList.Where(d => d.DateTime >= startDate.Value).ToList();
                }
                if (string.IsNullOrEmpty(toDate.Text))
                {
                    endDate = Convert.ToDateTime(fromDate.Text);
                    endDate = DateConvertor.ToMiladi(endDate.Value);
                    accountingList = accountingList.Where(d => d.DateTime <= endDate.Value).ToList();
                }
                //reportGridView.AutoGenerateColumns = false;
                //reportGridView.DataSource = result;
                reportGridView.Rows.Clear();
                foreach (var item in accountingList)
                {


                    string customerName = _context.CustomersRepository.GetCustomerNameById(item.CustomerId);
                    reportGridView.Rows.Add(item.ID, customerName, item.Amount, item.DateTime.ToShamsi(),
                        item.Description);
                }
            }
        }

        private void refreshReportBtn_Click(object sender, EventArgs e)
        {
            Filter();
        }

        private void removeReportBtn_Click(object sender, EventArgs e)
        {
            if (reportGridView.CurrentRow != null)
            {
                int currentId = int.Parse(reportGridView.CurrentRow.Cells[0].Value.ToString());
                if (RtlMessageBox.Show("آِیا از حذف مطمئن هستید؟", "هشدار", MessageBoxButtons.YesNo) ==
                    DialogResult.Yes)
                {
                    using (UnitOfWork _context = new UnitOfWork())
                    {
                        _context.AccountingRepository.Remove(currentId);
                        _context.Save();
                        Filter();
                    }
                }
            }
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            if (reportGridView.CurrentRow != null)
            {
                int currentId = int.Parse(reportGridView.CurrentRow.Cells[0].Value.ToString());
                newAccountingFrm newAccountingFrm = new newAccountingFrm();
                newAccountingFrm.AcountId = currentId;
                if (newAccountingFrm.ShowDialog() == DialogResult.OK)
                {
                    Filter();
                }
            }
        }

        private void printReportBtn_Click(object sender, EventArgs e)
        {

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Customer");
            dataTable.Columns.Add("Amount");
            dataTable.Columns.Add("Date");
            dataTable.Columns.Add("Description");
            foreach (DataGridViewRow item in reportGridView.Rows)
            {
                dataTable.Rows.Add(
                    item.Cells[0].Value.ToString(),
                    item.Cells[1].Value.ToString(),
                    item.Cells[2].Value.ToString(),
                    item.Cells[3].Value.ToString()
                    );
            }
            stiReports.Load(Application.StartupPath + "/Report.mrt");
            stiReports.RegData("DT" , dataTable);
            stiReports.Show();
        }
    }
}
