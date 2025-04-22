namespace Accounting.App
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.toolStripDropDownButton1 = new System.Windows.Forms.ToolStripDropDownButton();
            this.loginSettingBtn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip2 = new System.Windows.Forms.ToolStrip();
            this.customersBtn = new System.Windows.Forms.ToolStripButton();
            this.newAccountingBtn = new System.Windows.Forms.ToolStripButton();
            this.payReportBtn = new System.Windows.Forms.ToolStripButton();
            this.withdrawReportBtn = new System.Windows.Forms.ToolStripButton();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblDate = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.recieveLbl = new System.Windows.Forms.Label();
            this.payLbl = new System.Windows.Forms.Label();
            this.balanceLbl = new System.Windows.Forms.Label();
            this.toolStrip1.SuspendLayout();
            this.toolStrip2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripDropDownButton1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(782, 31);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // toolStripDropDownButton1
            // 
            this.toolStripDropDownButton1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripDropDownButton1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loginSettingBtn});
            this.toolStripDropDownButton1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.toolStripDropDownButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripDropDownButton1.Image")));
            this.toolStripDropDownButton1.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripDropDownButton1.Name = "toolStripDropDownButton1";
            this.toolStripDropDownButton1.Size = new System.Drawing.Size(70, 28);
            this.toolStripDropDownButton1.Text = "تنظیمات";
            this.toolStripDropDownButton1.Click += new System.EventHandler(this.loginSettingBtn_Click);
            this.toolStripDropDownButton1.DoubleClick += new System.EventHandler(this.loginSettingBtn_Click);
            // 
            // loginSettingBtn
            // 
            this.loginSettingBtn.Name = "loginSettingBtn";
            this.loginSettingBtn.Size = new System.Drawing.Size(166, 26);
            this.loginSettingBtn.Text = "تنظیمات ورود";
            // 
            // toolStrip2
            // 
            this.toolStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.customersBtn,
            this.newAccountingBtn,
            this.payReportBtn,
            this.withdrawReportBtn});
            this.toolStrip2.Location = new System.Drawing.Point(0, 31);
            this.toolStrip2.Name = "toolStrip2";
            this.toolStrip2.Size = new System.Drawing.Size(782, 67);
            this.toolStrip2.TabIndex = 1;
            this.toolStrip2.Text = "toolStrip2";
            // 
            // customersBtn
            // 
            this.customersBtn.Image = global::Accounting.App.Properties.Resources._1371476468_preferences_contact_list;
            this.customersBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.customersBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.customersBtn.Name = "customersBtn";
            this.customersBtn.Size = new System.Drawing.Size(56, 64);
            this.customersBtn.Text = "مشتری";
            this.customersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.customersBtn.Click += new System.EventHandler(this.customersBtn_Click);
            // 
            // newAccountingBtn
            // 
            this.newAccountingBtn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.newAccountingBtn.Image = global::Accounting.App.Properties.Resources._1371476499_todo_list;
            this.newAccountingBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.newAccountingBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.newAccountingBtn.Name = "newAccountingBtn";
            this.newAccountingBtn.Size = new System.Drawing.Size(88, 64);
            this.newAccountingBtn.Text = "تراکنش جدید";
            this.newAccountingBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.newAccountingBtn.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // payReportBtn
            // 
            this.payReportBtn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.payReportBtn.Image = global::Accounting.App.Properties.Resources.servicesCosts;
            this.payReportBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.payReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.payReportBtn.Name = "payReportBtn";
            this.payReportBtn.Size = new System.Drawing.Size(119, 64);
            this.payReportBtn.Text = "گزارش پرداختی ها";
            this.payReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.payReportBtn.Click += new System.EventHandler(this.payReportBtn_Click);
            // 
            // withdrawReportBtn
            // 
            this.withdrawReportBtn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.withdrawReportBtn.Image = global::Accounting.App.Properties.Resources._1370791030_credit_card;
            this.withdrawReportBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.withdrawReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.withdrawReportBtn.Name = "withdrawReportBtn";
            this.withdrawReportBtn.Size = new System.Drawing.Size(116, 64);
            this.withdrawReportBtn.Text = "گزارش ذریافتی ها";
            this.withdrawReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.withdrawReportBtn.Click += new System.EventHandler(this.reportBtn_Click);
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // statusStrip1
            // 
            this.statusStrip1.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.statusStrip1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblDate,
            this.lblTime});
            this.statusStrip1.Location = new System.Drawing.Point(0, 530);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(782, 23);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblDate
            // 
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(137, 17);
            this.lblDate.Text = "toolStripStatusLabel1";
            // 
            // lblTime
            // 
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(137, 17);
            this.lblTime.Text = "toolStripStatusLabel2";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-106, 228);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(529, 299);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.balanceLbl);
            this.groupBox1.Controls.Add(this.payLbl);
            this.groupBox1.Controls.Add(this.recieveLbl);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(417, 106);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 160);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "گزارش ماهیانه";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(272, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "دریافتی ها:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(272, 65);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "پرداختی ها:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(272, 103);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "مانده:";
            // 
            // recieveLbl
            // 
            this.recieveLbl.Location = new System.Drawing.Point(6, 30);
            this.recieveLbl.Name = "recieveLbl";
            this.recieveLbl.Size = new System.Drawing.Size(260, 17);
            this.recieveLbl.TabIndex = 3;
            this.recieveLbl.Text = "0";
            this.recieveLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // payLbl
            // 
            this.payLbl.Location = new System.Drawing.Point(6, 65);
            this.payLbl.Name = "payLbl";
            this.payLbl.Size = new System.Drawing.Size(260, 17);
            this.payLbl.TabIndex = 4;
            this.payLbl.Text = "0";
            this.payLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // balanceLbl
            // 
            this.balanceLbl.Location = new System.Drawing.Point(6, 103);
            this.balanceLbl.Name = "balanceLbl";
            this.balanceLbl.Size = new System.Drawing.Size(260, 17);
            this.balanceLbl.TabIndex = 5;
            this.balanceLbl.Text = "0";
            this.balanceLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.toolStrip2);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "حسابداری شخصی من";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.toolStrip2.ResumeLayout(false);
            this.toolStrip2.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButton1;
        private System.Windows.Forms.ToolStrip toolStrip2;
        private System.Windows.Forms.ToolStripButton customersBtn;
        private System.Windows.Forms.ToolStripButton newAccountingBtn;
        private System.Windows.Forms.ToolStripButton withdrawReportBtn;
        private System.Windows.Forms.ToolStripButton payReportBtn;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblDate;
        private System.Windows.Forms.ToolStripStatusLabel lblTime;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ToolStripMenuItem loginSettingBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label recieveLbl;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label balanceLbl;
        private System.Windows.Forms.Label payLbl;
    }
}

