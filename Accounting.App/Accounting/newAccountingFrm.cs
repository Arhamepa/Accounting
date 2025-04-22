using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer.Context;
using ValidationComponents;

namespace Accounting.App.Accounting
{
    public partial class newAccountingFrm : Form
    {
        public int AcountId = 0;
        private UnitOfWork _context;
        public newAccountingFrm()
        {
            InitializeComponent();
        }

        private void customersGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            txtNameBox.Text = customersGridView.CurrentRow.Cells[0].Value.ToString();
        }

        private void newAccountingFrm_Load(object sender, EventArgs e)
        {
            _context = new UnitOfWork();
            customersGridView.AutoGenerateColumns = false;
            customersGridView.DataSource = _context.CustomersRepository.GetCustomersName();
            if (AcountId != 0)
            {
                
                this.Text= "ویرایش";
                saveBtn.Text= "ویرایش";
                var account = _context.AccountingRepository.GetById(AcountId);
                txtAmount.Text = account.Amount.ToString();
                txtDescription.Text = account.Description.ToString();
                
                if (account.TypeId == 1)
                {
                    withrawRb.Checked=true;
                }
                else
                {
                    payRb.Checked =true;
                }
                txtNameBox.Text= _context.CustomersRepository.GetCustomerNameById(account.CustomerId);
                
                _context.Dispose();
            }
        }

        private void accSearchByNameBtn_TextChanged(object sender, EventArgs e)
        {
            customersGridView.AutoGenerateColumns = false;
            customersGridView.DataSource = _context.CustomersRepository.GetCustomersName(accSearchByNameBtn.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
             _context = new UnitOfWork();
            if (BaseValidator.IsFormValid(this.components))
            {
                if (payRb.Checked || withrawRb.Checked)
                {
                    DataLayer.Accounting accounting = new DataLayer.Accounting()
                    {
                        TypeId = (payRb.Checked)? 2:1,
                        DateTime = DateTime.Now,
                        Description = txtDescription.Text,
                        Amount = int.Parse(txtAmount.Value.ToString()),
                        CustomerId = _context.CustomersRepository.GetCustomerIdByName(txtNameBox.Text)
                    };
                    if (AcountId == 0)
                    {
                        _context.AccountingRepository.Add(accounting);
                    }
                    else
                    {
                        accounting.ID = AcountId;
                        _context.AccountingRepository.Update(accounting);
                    }
                    _context.Save();
                    _context.Dispose();
                    DialogResult=DialogResult.OK;
                }
                else
                {
                    RtlMessageBox.Show("لطفا نوع تراکنش را مشخص کنید!");
                }


            }
        }
    }
}
