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

namespace Accounting.App
{
    public partial class customersFrm: Form
    {
        public customersFrm()
        {
            InitializeComponent();
        }

        private void toolStripTextBox1_Click(object sender, EventArgs e)
        {
            GridViewDataBind();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        void GridViewDataBind()
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                customersDatagv.AutoGenerateColumns = false;
                customersDatagv.DataSource = db.CustomersRepository.GetCustomers();
            }
        }

        private void refreshCustomersBtn_Click(object sender, EventArgs e)
        {
            searchBy.Text = "";
            GridViewDataBind();
        }

        private void customersFrm_Load(object sender, EventArgs e)
        {
            GridViewDataBind();
        }

        private void searchBy_TextChanged(object sender, EventArgs e)
        {
            using (UnitOfWork db = new UnitOfWork())
            {
                customersDatagv.DataSource = db.CustomersRepository.GetCustomerBySearch(searchBy.Text);
            }
        }

        private void removeCustomerBtn_Click(object sender, EventArgs e)
        {
            if (customersDatagv.CurrentRow != null)
            {
                using (UnitOfWork db =new UnitOfWork())
                {
                    var customer = int.Parse(customersDatagv.CurrentRow.Cells[0].Value.ToString());
                    db.CustomersRepository.RemoveCustomer(customer);
                    db.Save();
                    GridViewDataBind();
                }
            }
            else
            {
                MessageBox.Show("اگر قصد حذف مشتری را دارید باید انتخابش کنید!");
            }
        }
    }
}
