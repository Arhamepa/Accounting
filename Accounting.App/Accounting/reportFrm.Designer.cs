namespace Accounting.App.Accounting
{
    partial class reportFrm
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
            this.stiReport = new System.Windows.Forms.ToolStrip();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.removeReportBtn = new System.Windows.Forms.ToolStripButton();
            this.refreshReportBtn = new System.Windows.Forms.ToolStripButton();
            this.printReportBtn = new System.Windows.Forms.ToolStripButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.submitFilter = new System.Windows.Forms.Button();
            this.toDate = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.fromDate = new System.Windows.Forms.MaskedTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.customerDropdown = new System.Windows.Forms.ComboBox();
            this.customerLabel = new System.Windows.Forms.Label();
            this.reportGridView = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stiReports = new Stimulsoft.Report.StiReport();
            this.stiReport.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // stiReport
            // 
            this.stiReport.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.stiReport.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stiReport.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton4,
            this.removeReportBtn,
            this.refreshReportBtn,
            this.printReportBtn});
            this.stiReport.Location = new System.Drawing.Point(0, 0);
            this.stiReport.Name = "stiReport";
            this.stiReport.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.stiReport.Size = new System.Drawing.Size(678, 64);
            this.stiReport.TabIndex = 0;
            this.stiReport.Text = "stiReport";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.Image = global::Accounting.App.Properties.Resources._1371475973_document_edit;
            this.toolStripButton4.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.toolStripButton4.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.Size = new System.Drawing.Size(53, 61);
            this.toolStripButton4.Text = "ویرایش";
            this.toolStripButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton4.Click += new System.EventHandler(this.toolStripButton4_Click);
            // 
            // removeReportBtn
            // 
            this.removeReportBtn.Image = global::Accounting.App.Properties.Resources._1371476007_Close_Box_Red;
            this.removeReportBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.removeReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.removeReportBtn.Name = "removeReportBtn";
            this.removeReportBtn.Size = new System.Drawing.Size(44, 61);
            this.removeReportBtn.Text = "حذف";
            this.removeReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.removeReportBtn.Click += new System.EventHandler(this.removeReportBtn_Click);
            // 
            // refreshReportBtn
            // 
            this.refreshReportBtn.Image = global::Accounting.App.Properties.Resources._1371476342_Refresh;
            this.refreshReportBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.refreshReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.refreshReportBtn.Name = "refreshReportBtn";
            this.refreshReportBtn.Size = new System.Drawing.Size(74, 61);
            this.refreshReportBtn.Text = "بروزرسانی";
            this.refreshReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.refreshReportBtn.Click += new System.EventHandler(this.refreshReportBtn_Click);
            // 
            // printReportBtn
            // 
            this.printReportBtn.Image = global::Accounting.App.Properties.Resources._1371476276_Print;
            this.printReportBtn.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.printReportBtn.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.printReportBtn.Name = "printReportBtn";
            this.printReportBtn.Size = new System.Drawing.Size(44, 61);
            this.printReportBtn.Text = "پرینت";
            this.printReportBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.printReportBtn.ToolTipText = "پرینت";
            this.printReportBtn.Click += new System.EventHandler(this.printReportBtn_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.submitFilter);
            this.groupBox1.Controls.Add(this.toDate);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.fromDate);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.customerDropdown);
            this.groupBox1.Controls.Add(this.customerLabel);
            this.groupBox1.Location = new System.Drawing.Point(0, 67);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupBox1.Size = new System.Drawing.Size(678, 85);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "جستجو";
            // 
            // submitFilter
            // 
            this.submitFilter.BackColor = System.Drawing.SystemColors.ControlDark;
            this.submitFilter.Location = new System.Drawing.Point(6, 39);
            this.submitFilter.Name = "submitFilter";
            this.submitFilter.Size = new System.Drawing.Size(78, 25);
            this.submitFilter.TabIndex = 6;
            this.submitFilter.Text = "انجام";
            this.submitFilter.UseVisualStyleBackColor = false;
            this.submitFilter.Click += new System.EventHandler(this.submitFilter_Click);
            // 
            // toDate
            // 
            this.toDate.Location = new System.Drawing.Point(90, 39);
            this.toDate.Mask = "0000/00/00";
            this.toDate.Name = "toDate";
            this.toDate.Size = new System.Drawing.Size(100, 24);
            this.toDate.TabIndex = 5;
            this.toDate.ValidatingType = typeof(System.DateTime);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(196, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "تا تاریخ:";
            // 
            // fromDate
            // 
            this.fromDate.Location = new System.Drawing.Point(266, 39);
            this.fromDate.Mask = "0000/00/00";
            this.fromDate.Name = "fromDate";
            this.fromDate.Size = new System.Drawing.Size(100, 24);
            this.fromDate.TabIndex = 3;
            this.fromDate.ValidatingType = typeof(System.DateTime);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(372, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "از تاریخ:";
            // 
            // customerDropdown
            // 
            this.customerDropdown.FormattingEnabled = true;
            this.customerDropdown.Location = new System.Drawing.Point(430, 39);
            this.customerDropdown.Name = "customerDropdown";
            this.customerDropdown.Size = new System.Drawing.Size(153, 25);
            this.customerDropdown.TabIndex = 1;
            // 
            // customerLabel
            // 
            this.customerLabel.AutoSize = true;
            this.customerLabel.Location = new System.Drawing.Point(589, 42);
            this.customerLabel.Name = "customerLabel";
            this.customerLabel.Size = new System.Drawing.Size(83, 17);
            this.customerLabel.TabIndex = 0;
            this.customerLabel.Text = "طرف حساب:";
            // 
            // reportGridView
            // 
            this.reportGridView.AllowUserToAddRows = false;
            this.reportGridView.AllowUserToDeleteRows = false;
            this.reportGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.reportGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.reportGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1});
            this.reportGridView.Location = new System.Drawing.Point(0, 158);
            this.reportGridView.Name = "reportGridView";
            this.reportGridView.ReadOnly = true;
            this.reportGridView.RowHeadersWidth = 51;
            this.reportGridView.RowTemplate.Height = 24;
            this.reportGridView.Size = new System.Drawing.Size(678, 275);
            this.reportGridView.TabIndex = 2;
            // 
            // ID
            // 
            this.ID.HeaderText = "id";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Visible = false;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "CustomerId";
            this.Column2.HeaderText = "مشتری";
            this.Column2.MinimumWidth = 6;
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Amount";
            this.Column3.HeaderText = "مبلغ";
            this.Column3.MinimumWidth = 6;
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "DateTime";
            this.Column4.HeaderText = "تاریخ";
            this.Column4.MinimumWidth = 6;
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Description";
            this.Column1.HeaderText = "بابت";
            this.Column1.MinimumWidth = 6;
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // stiReports
            // 
            this.stiReports.CookieContainer = null;
            this.stiReports.EngineVersion = Stimulsoft.Report.Engine.StiEngineVersion.EngineV2;
            this.stiReports.ReferencedAssemblies = new string[] {
        "System.Dll",
        "System.Drawing.Dll",
        "System.Windows.Forms.Dll",
        "System.Data.Dll",
        "System.Xml.Dll",
        "Stimulsoft.Controls.Dll",
        "Stimulsoft.Base.Dll",
        "Stimulsoft.Report.Dll"};
            this.stiReports.ReportAlias = "Report";
            this.stiReports.ReportGuid = "407a640deed2496d9c9c3dfc295c95f5";
            this.stiReports.ReportName = "Report";
            this.stiReports.ReportSource = null;
            this.stiReports.ReportUnit = Stimulsoft.Report.StiReportUnitType.Inches;
            this.stiReports.ScriptLanguage = Stimulsoft.Report.StiReportLanguageType.CSharp;
            this.stiReports.UseProgressInThread = false;
            // 
            // reportFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 434);
            this.Controls.Add(this.reportGridView);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.stiReport);
            this.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "reportFrm";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "reportFrm";
            this.Load += new System.EventHandler(this.reportFrm_Load);
            this.stiReport.ResumeLayout(false);
            this.stiReport.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.reportGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip stiReport;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripButton removeReportBtn;
        private System.Windows.Forms.ToolStripButton refreshReportBtn;
        private System.Windows.Forms.ToolStripButton printReportBtn;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label customerLabel;
        private System.Windows.Forms.ComboBox customerDropdown;
        private System.Windows.Forms.MaskedTextBox toDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.MaskedTextBox fromDate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView reportGridView;
        private System.Windows.Forms.Button submitFilter;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private Stimulsoft.Report.StiReport stiReports;
    }
}