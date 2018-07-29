namespace SenseInventoryLogoUI.Forms
{
    partial class frmSalesRegisterReport
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.rvSalesViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label28 = new System.Windows.Forms.Label();
            this.cmbSalesType = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rvSalesViewer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 78);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 582);
            this.panel1.TabIndex = 23;
            // 
            // rvSalesViewer
            // 
            this.rvSalesViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvSalesViewer.Location = new System.Drawing.Point(0, 0);
            this.rvSalesViewer.Name = "rvSalesViewer";
            this.rvSalesViewer.Size = new System.Drawing.Size(1002, 582);
            this.rvSalesViewer.TabIndex = 0;
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(341, 43);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 30);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Search";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(4, 10);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(62, 13);
            this.label13.TabIndex = 42;
            this.label13.Text = "From Date.:";
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Location = new System.Drawing.Point(82, 7);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(135, 20);
            this.dtpFromDate.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(234, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 44;
            this.label2.Text = "To Date.:";
            // 
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Location = new System.Drawing.Point(312, 7);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(135, 20);
            this.dtpToDate.TabIndex = 2;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = " Customer Name.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(732, 3);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 13);
            this.label3.TabIndex = 50;
            this.label3.Text = "Address.:";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(776, 3);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(223, 42);
            this.txtCustomerAddress.TabIndex = 4;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 51);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 13);
            this.label28.TabIndex = 51;
            this.label28.Text = "Sales Type:";
            // 
            // cmbSalesType
            // 
            this.cmbSalesType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSalesType.FormattingEnabled = true;
            this.cmbSalesType.Items.AddRange(new object[] {
            "ALL",
            "Retail Invoice",
            "Tax Invoice"});
            this.cmbSalesType.Location = new System.Drawing.Point(82, 49);
            this.cmbSalesType.Name = "cmbSalesType";
            this.cmbSalesType.Size = new System.Drawing.Size(137, 21);
            this.cmbSalesType.TabIndex = 5;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.txtCustomerName);
            this.panel3.Controls.Add(this.cmbSalesType);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.txtCustomerAddress);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dtpToDate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpFromDate);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.btnAddItem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 78);
            this.panel3.TabIndex = 22;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(541, 3);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(176, 28);
            this.txtCustomerName.TabIndex = 52;
            // 
            // frmSalesRegisterReport
            // 
            this.AcceptButton = this.btnAddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "frmSalesRegisterReport";
            this.Text = "frmSalesRegisterReport";
            this.Load += new System.EventHandler(this.frmSalesRegisterReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rvSalesViewer;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.ComboBox cmbSalesType;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtCustomerName;

    }
}