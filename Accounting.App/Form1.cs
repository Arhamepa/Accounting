using Accounting.App.Accounting;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Accounting.App.Login;
using Accounting.Service;
using Accounting.ViewModels.AccountingVm;

namespace Accounting.App
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Hide();
            LoginFrm login = new LoginFrm();
            if (login.ShowDialog() == DialogResult.OK)
            {
                this.Show();
                lblDate.Text = DateTime.Now.ToShamsi();
                lblTime.Text = DateTime.Now.ToString("hh:mm:ss");

                Report();

            }
            else
            {
                Application.Exit();
            }
        }

        void Report()
        {
            ReportViewModel report = Account.ReportFromMain();
            payLbl.Text = report.Pay.ToString("#,0");
            recieveLbl.Text = report.Recieve.ToString("#,0");
            balanceLbl.Text = report.Balance.ToString("#,0");



        }
        private void timerMain_Tick(object sender, EventArgs e)
        {
            lblTime.Text = DateTime.Now.ToString("hh:mm:ss");
        }
        private void customersBtn_Click(object sender, EventArgs e)
        {
            customersFrm customerFrm = new customersFrm();
            customerFrm.ShowDialog();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            newAccountingFrm newAccountingFrm = new newAccountingFrm();
            newAccountingFrm.ShowDialog();
        }

        

        private void payReportBtn_Click(object sender, EventArgs e)
        {
            reportFrm payReportFrm = new reportFrm();
            payReportFrm.TypeId = 2;
            payReportFrm.ShowDialog();
        }

        private void reportBtn_Click(object sender, EventArgs e)
        {
            reportFrm withdrawReportFrm = new reportFrm();
            withdrawReportFrm.TypeId = 1;
            withdrawReportFrm.ShowDialog();
        }
        private void loginSettingBtn_Click(object sender, EventArgs e)
        {
            LoginFrm loginFrm = new LoginFrm();
            loginFrm.IsEditMode = true;
            loginFrm.ShowDialog();
        }
    }
}
