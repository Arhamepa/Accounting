using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.DataLayer;
using Accounting.DataLayer.Context;
using ValidationComponents;
using VARDESC = System.Runtime.InteropServices.ComTypes.VARDESC;

namespace Accounting.App.Customer
{
    public partial class addOrEditFrm: Form
    {
        public int CustomerId = 0;
        UnitOfWork  db = new UnitOfWork();
        public addOrEditFrm()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

      

        private void imageUploadBtn_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                pictureCustomer.ImageLocation = openFile.FileName;
            }
        }

        private void saveCustomerBtn_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                
                string fileName = Guid.NewGuid().ToString() + Path.GetExtension(pictureCustomer.ImageLocation);
                string path = Application.StartupPath + "/Images/";
          
                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }
                pictureCustomer.Image.Save(path+fileName);
                
                Customers customer = new Customers()
                {
                    FullName = txtFullName.Text,
                    Address = textAddress.Text,
                    Phone = textPhone.Text,
                    Email = txtEmail.Text,
                    CustomerImg = fileName
                };
                if (CustomerId == 0)
                {
                    db.CustomersRepository.AddCustomer(customer);
                }
                else
                {
                    customer.CustomerID = CustomerId;
                    db.CustomersRepository.UpdateCustomer(customer);
                }
                db.Save();
                DialogResult = DialogResult.OK;
            }
        }
        private void addOrEditFrm_Load(object sender, EventArgs e)
        {
            if (CustomerId != 0)
            {
               
                this.Text = "ویرایش مشتری";
                var customer = db.CustomersRepository.GetCustomerById(CustomerId);
                txtFullName.Text = customer.FullName;
                txtEmail.Text = customer.Email;
                textAddress.Text = customer.Address;
                textPhone.Text = customer.Phone;
                pictureCustomer.ImageLocation = Application.StartupPath + "/Images/" + customer.CustomerImg;
            }
        }
    }
}
