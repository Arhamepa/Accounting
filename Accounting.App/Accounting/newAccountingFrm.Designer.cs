namespace Accounting.App.Accounting
{
    partial class newAccountingFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(newAccountingFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.customersGridView = new System.Windows.Forms.DataGridView();
            this.accSearchByNameBtn = new System.Windows.Forms.TextBox();
            this.FullName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtName = new System.Windows.Forms.Label();
            this.txtNameBox = new System.Windows.Forms.TextBox();
            this.txtTransactionLabel = new System.Windows.Forms.Label();
            this.withrawRb = new System.Windows.Forms.RadioButton();
            this.payRb = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.txtAmount = new System.Windows.Forms.NumericUpDown();
            this.txtDescriptionLabel = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.saveBtn = new System.Windows.Forms.Button();
            this.rangeValidator1 = new ValidationComponents.RangeValidator(this.components);
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.customersGridView);
            this.groupBox1.Controls.Add(this.accSearchByNameBtn);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 351);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اشخاص";
            // 
            // customersGridView
            // 
            this.customersGridView.AllowUserToAddRows = false;
            this.customersGridView.AllowUserToDeleteRows = false;
            this.customersGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.customersGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customersGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.FullName});
            this.customersGridView.Location = new System.Drawing.Point(0, 62);
            this.customersGridView.Name = "customersGridView";
            this.customersGridView.ReadOnly = true;
            this.customersGridView.RowHeadersWidth = 51;
            this.customersGridView.RowTemplate.Height = 24;
            this.customersGridView.Size = new System.Drawing.Size(194, 283);
            this.customersGridView.TabIndex = 1;
            this.customersGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersGridView_CellContentClick);
            this.customersGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.customersGridView_CellContentClick);
            // 
            // accSearchByNameBtn
            // 
            this.accSearchByNameBtn.Location = new System.Drawing.Point(6, 23);
            this.accSearchByNameBtn.Name = "accSearchByNameBtn";
            this.accSearchByNameBtn.Size = new System.Drawing.Size(188, 24);
            this.accSearchByNameBtn.TabIndex = 0;
            this.accSearchByNameBtn.TextChanged += new System.EventHandler(this.accSearchByNameBtn_TextChanged);
            // 
            // FullName
            // 
            this.FullName.DataPropertyName = "FullName";
            this.FullName.HeaderText = "نام اشخاص";
            this.FullName.MinimumWidth = 6;
            this.FullName.Name = "FullName";
            this.FullName.ReadOnly = true;
            // 
            // txtName
            // 
            this.txtName.AutoSize = true;
            this.txtName.Location = new System.Drawing.Point(487, 12);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(83, 17);
            this.txtName.TabIndex = 1;
            this.txtName.Text = "طرف حساب:";
            // 
            // txtNameBox
            // 
            this.txtNameBox.Location = new System.Drawing.Point(218, 12);
            this.txtNameBox.Name = "txtNameBox";
            this.txtNameBox.ReadOnly = true;
            this.txtNameBox.Size = new System.Drawing.Size(263, 24);
            this.txtNameBox.TabIndex = 2;
            this.txtNameBox.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtTransactionLabel
            // 
            this.txtTransactionLabel.AutoSize = true;
            this.txtTransactionLabel.Location = new System.Drawing.Point(492, 74);
            this.txtTransactionLabel.Name = "txtTransactionLabel";
            this.txtTransactionLabel.Size = new System.Drawing.Size(78, 17);
            this.txtTransactionLabel.TabIndex = 3;
            this.txtTransactionLabel.Text = "نوع تراکنش:";
            // 
            // withrawRb
            // 
            this.withrawRb.AutoSize = true;
            this.withrawRb.Location = new System.Drawing.Point(402, 74);
            this.withrawRb.Name = "withrawRb";
            this.withrawRb.Size = new System.Drawing.Size(68, 21);
            this.withrawRb.TabIndex = 4;
            this.withrawRb.TabStop = true;
            this.withrawRb.Text = "دریافت";
            this.withrawRb.UseVisualStyleBackColor = true;
            // 
            // payRb
            // 
            this.payRb.AutoSize = true;
            this.payRb.Location = new System.Drawing.Point(303, 74);
            this.payRb.Name = "payRb";
            this.payRb.Size = new System.Drawing.Size(71, 21);
            this.payRb.TabIndex = 5;
            this.payRb.TabStop = true;
            this.payRb.Text = "پرداخت";
            this.payRb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(532, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 17);
            this.label1.TabIndex = 6;
            this.label1.Text = "مبلغ:";
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(218, 118);
            this.txtAmount.Maximum = new decimal(new int[] {
            99999999,
            0,
            0,
            0});
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(308, 24);
            this.txtAmount.TabIndex = 7;
            // 
            // txtDescriptionLabel
            // 
            this.txtDescriptionLabel.AutoSize = true;
            this.txtDescriptionLabel.Location = new System.Drawing.Point(528, 155);
            this.txtDescriptionLabel.Name = "txtDescriptionLabel";
            this.txtDescriptionLabel.Size = new System.Drawing.Size(42, 17);
            this.txtDescriptionLabel.TabIndex = 8;
            this.txtDescriptionLabel.Text = "شرح:";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(218, 167);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(304, 160);
            this.txtDescription.TabIndex = 9;
            // 
            // saveBtn
            // 
            this.saveBtn.Location = new System.Drawing.Point(438, 333);
            this.saveBtn.Name = "saveBtn";
            this.saveBtn.Size = new System.Drawing.Size(84, 30);
            this.saveBtn.TabIndex = 10;
            this.saveBtn.Text = "ثبت";
            this.saveBtn.UseVisualStyleBackColor = true;
            this.saveBtn.Click += new System.EventHandler(this.saveBtn_Click);
            // 
            // rangeValidator1
            // 
            this.rangeValidator1.CancelFocusChangeWhenInvalid = false;
            this.rangeValidator1.ControlToValidate = this.txtAmount;
            this.rangeValidator1.ErrorMessage = "مبلغ را وارد کنید";
            this.rangeValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("rangeValidator1.Icon")));
            this.rangeValidator1.MaximumValue = "99999999";
            this.rangeValidator1.MinimumValue = "1";
            this.rangeValidator1.Type = ValidationComponents.ValidationDataType.Integer;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtNameBox;
            this.requiredFieldValidator1.ErrorMessage = "اسم طرف حساب رو از لیست انتخاب کنید!";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // newAccountingFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(582, 375);
            this.Controls.Add(this.saveBtn);
            this.Controls.Add(this.txtDescription);
            this.Controls.Add(this.txtDescriptionLabel);
            this.Controls.Add(this.txtAmount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.payRb);
            this.Controls.Add(this.withrawRb);
            this.Controls.Add(this.txtTransactionLabel);
            this.Controls.Add(this.txtNameBox);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "newAccountingFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "تراکنش جدید";
            this.Load += new System.EventHandler(this.newAccountingFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.customersGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox accSearchByNameBtn;
        private System.Windows.Forms.DataGridView customersGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn FullName;
        private System.Windows.Forms.Label txtName;
        private System.Windows.Forms.TextBox txtNameBox;
        private System.Windows.Forms.Label txtTransactionLabel;
        private System.Windows.Forms.RadioButton withrawRb;
        private System.Windows.Forms.RadioButton payRb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown txtAmount;
        private System.Windows.Forms.Label txtDescriptionLabel;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.Button saveBtn;
        private ValidationComponents.RangeValidator rangeValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
    }
}