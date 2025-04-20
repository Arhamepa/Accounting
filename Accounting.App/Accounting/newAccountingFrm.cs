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
        private UnitOfWork _context = new UnitOfWork();
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
            customersGridView.AutoGenerateColumns = false;
            customersGridView.DataSource = _context.CustomersRepository.GetCustomersName();
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
            if (BaseValidator.IsFormValid(this.components))
            {
                if (payRb.Checked || withrawRb.Checked)
                {
                    DataLayer.Accounting accounting = new DataLayer.Accounting()
                    {
                        TypeId = (payRb.Checked)? 2:1,
                        DateTime = DateTime.Now,
                        Description = txtDescriptionLabel.Text,
                        Amount = int.Parse(txtAmount.Value.ToString()),
                        CustomerId = _context.CustomersRepository.GetCustomerIdByName(txtNameBox.Text)
                    };
                    _context.AccountingRepository.Add(accounting);
                    _context.Save();
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
