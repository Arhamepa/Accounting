 namespace Accounting.App.Customer
{
    partial class addOrEditFrm
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
            System.Windows.Forms.Button saveCustomerBtn;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addOrEditFrm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textPhone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.ایمیل = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.imageUploadBtn = new System.Windows.Forms.Button();
            this.pictureCustomer = new System.Windows.Forms.PictureBox();
            this.requiredFieldValidator1 = new ValidationComponents.RequiredFieldValidator(this.components);
            this.requiredFieldValidator2 = new ValidationComponents.RequiredFieldValidator(this.components);
            saveCustomerBtn = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // saveCustomerBtn
            // 
            saveCustomerBtn.BackColor = System.Drawing.SystemColors.ActiveBorder;
            saveCustomerBtn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            saveCustomerBtn.Location = new System.Drawing.Point(348, 347);
            saveCustomerBtn.Name = "saveCustomerBtn";
            saveCustomerBtn.Size = new System.Drawing.Size(114, 32);
            saveCustomerBtn.TabIndex = 2;
            saveCustomerBtn.Text = "ثبت";
            saveCustomerBtn.UseVisualStyleBackColor = false;
            saveCustomerBtn.Click += new System.EventHandler(this.saveCustomerBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textAddress);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.textPhone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.ایمیل);
            this.groupBox1.Controls.Add(this.txtFullName);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox1.Location = new System.Drawing.Point(210, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(260, 329);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "اطلاعات مشتری";
            // 
            // textAddress
            // 
            this.textAddress.Location = new System.Drawing.Point(48, 258);
            this.textAddress.Multiline = true;
            this.textAddress.Name = "textAddress";
            this.textAddress.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textAddress.Size = new System.Drawing.Size(203, 65);
            this.textAddress.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label4.Location = new System.Drawing.Point(210, 227);
            this.label4.Name = "label4";
            this.label4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label4.Size = new System.Drawing.Size(45, 17);
            this.label4.TabIndex = 6;
            this.label4.Text = "آدرس:";
            // 
            // textPhone
            // 
            this.textPhone.Location = new System.Drawing.Point(48, 190);
            this.textPhone.Name = "textPhone";
            this.textPhone.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.textPhone.Size = new System.Drawing.Size(203, 24);
            this.textPhone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label3.Location = new System.Drawing.Point(206, 160);
            this.label3.Name = "label3";
            this.label3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label3.Size = new System.Drawing.Size(48, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "موبایل:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(48, 118);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtEmail.Size = new System.Drawing.Size(203, 24);
            this.txtEmail.TabIndex = 3;
            // 
            // ایمیل
            // 
            this.ایمیل.AutoSize = true;
            this.ایمیل.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.ایمیل.Location = new System.Drawing.Point(210, 88);
            this.ایمیل.Name = "ایمیل";
            this.ایمیل.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ایمیل.Size = new System.Drawing.Size(44, 17);
            this.ایمیل.TabIndex = 2;
            this.ایمیل.Text = "ایمیل:";
            this.ایمیل.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtFullName
            // 
            this.txtFullName.Location = new System.Drawing.Point(48, 50);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtFullName.Size = new System.Drawing.Size(203, 24);
            this.txtFullName.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.label1.Location = new System.Drawing.Point(225, 22);
            this.label1.Name = "label1";
            this.label1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label1.Size = new System.Drawing.Size(29, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "نام:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.imageUploadBtn);
            this.groupBox2.Controls.Add(this.pictureCustomer);
            this.groupBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.groupBox2.Location = new System.Drawing.Point(6, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox2.Size = new System.Drawing.Size(198, 329);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "تصویر";
            // 
            // imageUploadBtn
            // 
            this.imageUploadBtn.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.imageUploadBtn.Location = new System.Drawing.Point(6, 291);
            this.imageUploadBtn.Name = "imageUploadBtn";
            this.imageUploadBtn.Size = new System.Drawing.Size(186, 32);
            this.imageUploadBtn.TabIndex = 1;
            this.imageUploadBtn.Text = "انتخاب تصویر";
            this.imageUploadBtn.UseVisualStyleBackColor = true;
            this.imageUploadBtn.Click += new System.EventHandler(this.imageUploadBtn_Click);
            // 
            // pictureCustomer
            // 
            this.pictureCustomer.Image = global::Accounting.App.Properties.Resources.no_profile_image;
            this.pictureCustomer.InitialImage = null;
            this.pictureCustomer.Location = new System.Drawing.Point(6, 21);
            this.pictureCustomer.Name = "pictureCustomer";
            this.pictureCustomer.Size = new System.Drawing.Size(186, 263);
            this.pictureCustomer.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureCustomer.TabIndex = 0;
            this.pictureCustomer.TabStop = false;
            // 
            // requiredFieldValidator1
            // 
            this.requiredFieldValidator1.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator1.ControlToValidate = this.txtFullName;
            this.requiredFieldValidator1.ErrorMessage = "لطفا نام را پر کنید";
            this.requiredFieldValidator1.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator1.Icon")));
            // 
            // requiredFieldValidator2
            // 
            this.requiredFieldValidator2.CancelFocusChangeWhenInvalid = false;
            this.requiredFieldValidator2.ControlToValidate = this.textPhone;
            this.requiredFieldValidator2.ErrorMessage = "لطفا شماره موبایل را وارد کنید";
            this.requiredFieldValidator2.Icon = ((System.Drawing.Icon)(resources.GetObject("requiredFieldValidator2.Icon")));
            // 
            // addOrEditFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(482, 391);
            this.Controls.Add(saveCustomerBtn);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "addOrEditFrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "افزودن مشتری";
            this.Load += new System.EventHandler(this.addOrEditFrm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureCustomer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox textAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textPhone;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label ایمیل;
        private System.Windows.Forms.PictureBox pictureCustomer;
        private System.Windows.Forms.Button imageUploadBtn;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator1;
        private ValidationComponents.RequiredFieldValidator requiredFieldValidator2;
    }
}