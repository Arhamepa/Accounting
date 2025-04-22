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

namespace Accounting.App.Login
{
    public partial class LoginFrm: Form
    {
        public bool IsEditMode = false;
        public LoginFrm()
        {
            InitializeComponent();
        }

        private void LoginFrm_Load(object sender, EventArgs e)
        {
            if (IsEditMode)
            {
                this.Text = "تنظیمات ورود به برنامه";
                saveBtn.Text = "ذخیره تغییرات";
                using (UnitOfWork _context = new UnitOfWork())
                {
                    var logintable = _context.LoginRepository.GetAll().First();
                    userNameTxt.Text = logintable.UserName;
                    passwordTxt.Text = logintable.Password;
                }
            }
           
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (BaseValidator.IsFormValid(this.components))
            {
                using (UnitOfWork _context = new UnitOfWork())
                {
                    if (IsEditMode)
                    {
                        var logintable = _context.LoginRepository.GetAll().First();
                         logintable.UserName = userNameTxt.Text;
                         logintable.Password= passwordTxt.Text;
                         _context.LoginRepository.Update(logintable);
                         _context.Save();
                         Application.Restart();

                    }
                    else
                    {
                        if (_context.LoginRepository
                            .GetAll(u => u.UserName == userNameTxt.Text && u.Password == passwordTxt.Text)
                            .Any())
                        {
                            DialogResult = DialogResult.OK;
                        }
                        else
                        {
                            RtlMessageBox.Show("کاربر یافت نشد!");
                        }
                    }
                }
            }
        }
    }
}
