namespace Accounting.App
{
    partial class customersFrm
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
            this.addCustomerBtn = new System.Windows.Forms.ToolStripButton();
            this.editCustomerBtn = new System.Windows.Forms.ToolStripButton();
            this.removeCustomerBtn = new System.Windows.Forms.ToolStripButton();
            this.refreshCustomersBtn = new System.Windows.Forms.ToolStripButton();
            this.searchBy = new System.Windows.Forms.ToolStripTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.customersDatagv = new System.Windows.Forms.DataGridView();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.toolStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDatagv)).BeginInit();
            this.SuspendLayout();
            // 
            // addCustomerBtn
            // 
            this.addCustomerBtn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.addCustomerBtn.Image = global::Accounting.App.Properties.Resources._1371475930_filenew;
            this.addCustomerBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.addCustomerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.addCustomerBtn.Name = "addCustomerBtn";
            this.addCustomerBtn.Size = new System.Drawing.Size(49, 61);
            this.addCustomerBtn.Text = "افزودن";
            this.addCustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.addCustomerBtn.Click += new System.EventHandler(this.addCustomerBtn_Click);
            // 
            // editCustomerBtn
            // 
            this.editCustomerBtn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.editCustomerBtn.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
            this.editCustomerBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.editCustomerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.editCustomerBtn.Name = "editCustomerBtn";
            this.editCustomerBtn.Size = new System.Drawing.Size(53, 61);
            this.editCustomerBtn.Text = "ویرایش";
            this.editCustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.editCustomerBtn.Click += new System.EventHandler(this.editCustomerBtn_Click);
            // 
            // removeCustomerBtn
            // 
            this.removeCustomerBtn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.removeCustomerBtn.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.removeCustomerBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.removeCustomerBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeCustomerBtn.Name = "removeCustomerBtn";
            this.removeCustomerBtn.Size = new System.Drawing.Size(44, 61);
            this.removeCustomerBtn.Text = "حذف";
            this.removeCustomerBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.removeCustomerBtn.Click += new System.EventHandler(this.removeCustomerBtn_Click);
            // 
            // refreshCustomersBtn
            // 
            this.refreshCustomersBtn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.refreshCustomersBtn.Image = global::Accounting.App.Properties.Resources._1371476368_Synchronize;
            this.refreshCustomersBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refreshCustomersBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshCustomersBtn.Name = "refreshCustomersBtn";
            this.refreshCustomersBtn.Size = new System.Drawing.Size(74, 61);
            this.refreshCustomersBtn.Text = "بروزرسانی";
            this.refreshCustomersBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshCustomersBtn.Click += new System.EventHandler(this.refreshCustomersBtn_Click);
            // 
            // searchBy
            // 
            this.searchBy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.searchBy.Name = "searchBy";
            this.searchBy.Size = new System.Drawing.Size(100, 64);
            this.searchBy.Click += new System.EventHandler(this.toolStripTextBox1_Click);
            this.searchBy.TextChanged += new System.EventHandler(this.searchBy_TextChanged);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addCustomerBtn,
            this.editCustomerBtn,
            this.removeCustomerBtn,
            this.refreshCustomersBtn,
            this.searchBy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(582, 64);
            this.toolStrip1.TabIndex = 0;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // customersDatagv
            // 
            this.customersDatagv.AllowUserToAddRows = false;
            this.customersDatagv.AllowUserToDeleteRows = false;
            this.customersDatagv.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersDatagv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersDatagv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CustomerID,
            this.Column1,
            this.Column2,
            this.Column3});
            this.customersDatagv.Dock = System.Windows.Forms.DockStyle.Fill;
            this.customersDatagv.Location = new System.Drawing.Point(0, 64);
            this.customersDatagv.Name = "customersDatagv";
            this.customersDatagv.ReadOnly = true;
            this.customersDatagv.RowHeadersWidth = 51;
            this.customersDatagv.RowTemplate.Height = 24;
            this.customersDatagv.Size = new System.Drawing.Size(582, 289);
            this.customersDatagv.TabIndex = 1;
            this.customersDatagv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "Column1";
            this.CustomerID.MinimumWidth = 6;
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.ReadOnly = true;
            this.CustomerID.Visible = false;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "FullName";
            this.Column1.HeaderText = "نام";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "Phone";
            this.Column2.HeaderText = "موبایل";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Email";
            this.Column3.HeaderText = "ایمیل";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // customersFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 353);
            this.Controls.Add(this.customersDatagv);
            this.Controls.Add(this.toolStrip1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.Name = "customersFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "لیست مشتری ها";
            this.Load += new System.EventHandler(this.customersFrm_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersDatagv)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton addCustomerBtn;
        private System.Windows.Forms.ToolStripButton editCustomerBtn;
        private System.Windows.Forms.ToolStripButton removeCustomerBtn;
        private System.Windows.Forms.ToolStripButton refreshCustomersBtn;
        private System.Windows.Forms.ToolStripTextBox searchBy;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.DataGridView customersDatagv;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
    }
}