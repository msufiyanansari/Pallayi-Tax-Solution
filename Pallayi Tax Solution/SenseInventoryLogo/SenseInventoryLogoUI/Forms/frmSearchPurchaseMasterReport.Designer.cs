namespace SenseInventoryLogoUI.Forms
{
    partial class frmSearchPurchaseMasterReport
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
            this.cmbPurchaseType = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rvPurchaseViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cmbPurchaseType
            // 
            this.cmbPurchaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurchaseType.FormattingEnabled = true;
            this.cmbPurchaseType.Items.AddRange(new object[] {
            "ALL",
            "Retail Invoice",
            "Tax Invoice"});
            this.cmbPurchaseType.Location = new System.Drawing.Point(82, 49);
            this.cmbPurchaseType.Name = "cmbPurchaseType";
            this.cmbPurchaseType.Size = new System.Drawing.Size(137, 21);
            this.cmbPurchaseType.TabIndex = 5;
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(1, 51);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(82, 13);
            this.label28.TabIndex = 51;
            this.label28.Text = "Purchase Type:";
            // 
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierAddress.Location = new System.Drawing.Point(776, 3);
            this.txtSupplierAddress.Multiline = true;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(223, 42);
            this.txtSupplierAddress.TabIndex = 4;
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
            // dtpToDate
            // 
            this.dtpToDate.CustomFormat = "dd/MM/yyyy";
            this.dtpToDate.Location = new System.Drawing.Point(312, 7);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(135, 20);
            this.dtpToDate.TabIndex = 2;
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
            // dtpFromDate
            // 
            this.dtpFromDate.CustomFormat = "dd/MM/yyyy";
            this.dtpFromDate.Location = new System.Drawing.Point(82, 7);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(135, 20);
            this.dtpFromDate.TabIndex = 1;
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
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(225, 44);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 27);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Search";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbSupplier);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.cmbPurchaseType);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.txtSupplierAddress);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.dtpToDate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpFromDate);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.btnAddItem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 81);
            this.panel3.TabIndex = 22;
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(541, 6);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(185, 21);
            this.cmbSupplier.TabIndex = 54;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(450, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 53;
            this.label9.Text = " Supplier Name.:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rvPurchaseViewer);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 81);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1002, 579);
            this.panel1.TabIndex = 23;
            // 
            // rvPurchaseViewer
            // 
            this.rvPurchaseViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvPurchaseViewer.Location = new System.Drawing.Point(0, 0);
            this.rvPurchaseViewer.Name = "rvPurchaseViewer";
            this.rvPurchaseViewer.Size = new System.Drawing.Size(1002, 579);
            this.rvPurchaseViewer.TabIndex = 0;
            // 
            // frmSearchPurchaseMasterReport
            // 
            this.AcceptButton = this.btnAddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 660);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Name = "frmSearchPurchaseMasterReport";
            this.Text = "frmSearchPurchaseMasterReport";
            this.Load += new System.EventHandler(this.frmSearchPurchaseMasterReport_Load);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cmbPurchaseType;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel1;
        private Microsoft.Reporting.WinForms.ReportViewer rvPurchaseViewer;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label9;

    }
}