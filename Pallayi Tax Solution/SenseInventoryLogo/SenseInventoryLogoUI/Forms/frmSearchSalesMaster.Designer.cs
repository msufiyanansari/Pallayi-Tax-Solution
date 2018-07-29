namespace SenseInventoryLogoUI.Forms
{
    partial class frmSearchSalesMaster
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
            this.pnlMain = new System.Windows.Forms.Panel();
            this.dgvSalesView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbSalesType = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.lblCaptionRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PrintReport = new System.Windows.Forms.DataGridViewLinkColumn();
            this.SalesMasterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesMasterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesMasterBillBookNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesMasterInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesMasterCustomerFKeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesMasterCustomerFKeyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesMasterVatPerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesMasterVatAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesMasterAddTaxPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesMasterAddTaxAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGSTPER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGSTAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesMasterGrossTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SalesMasterKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvSalesView);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1002, 660);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvSalesView
            // 
            this.dgvSalesView.AllowUserToAddRows = false;
            this.dgvSalesView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalesView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.PrintReport,
            this.SalesMasterType,
            this.SalesMasterDate,
            this.SalesMasterBillBookNo,
            this.SalesMasterInvoiceNo,
            this.SalesMasterCustomerFKeyName,
            this.SalesMasterCustomerFKeyAddress,
            this.SalesMasterVatPerc,
            this.SalesMasterVatAmount,
            this.SalesMasterAddTaxPer,
            this.SalesMasterAddTaxAmt,
            this.IGSTPER,
            this.IGSTAMT,
            this.SalesMasterGrossTotal,
            this.SalesMasterKey});
            this.dgvSalesView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvSalesView.Location = new System.Drawing.Point(0, 171);
            this.dgvSalesView.Name = "dgvSalesView";
            this.dgvSalesView.Size = new System.Drawing.Size(1002, 489);
            this.dgvSalesView.TabIndex = 35;
            this.dgvSalesView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSalesView_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbSalesType);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.lblRecordCount);
            this.panel3.Controls.Add(this.txtCustomerAddress);
            this.panel3.Controls.Add(this.lblCaptionRecord);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtCustomerName);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.dtpToDate);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Controls.Add(this.dtpFromDate);
            this.panel3.Controls.Add(this.label13);
            this.panel3.Controls.Add(this.btnAddItem);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 44);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1002, 127);
            this.panel3.TabIndex = 20;
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
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(10, 51);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(63, 13);
            this.label28.TabIndex = 51;
            this.label28.Text = "Sales Type:";
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(118, 103);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(18, 20);
            this.lblRecordCount.TabIndex = 37;
            this.lblRecordCount.Text = "0";
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
            // lblCaptionRecord
            // 
            this.lblCaptionRecord.AutoSize = true;
            this.lblCaptionRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionRecord.Location = new System.Drawing.Point(3, 103);
            this.lblCaptionRecord.Name = "lblCaptionRecord";
            this.lblCaptionRecord.Size = new System.Drawing.Size(120, 20);
            this.lblCaptionRecord.TabIndex = 36;
            this.lblCaptionRecord.Text = "Record Count : ";
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
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(552, 3);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(174, 29);
            this.txtCustomerName.TabIndex = 3;
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
            this.btnAddItem.Location = new System.Drawing.Point(341, 43);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 30);
            this.btnAddItem.TabIndex = 6;
            this.btnAddItem.Text = "Search";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1002, 44);
            this.panel2.TabIndex = 18;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(340, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(293, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search Sales Master:";
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Text = "Edit";
            this.Action.UseColumnTextForLinkValue = true;
            this.Action.Width = 50;
            // 
            // PrintReport
            // 
            this.PrintReport.HeaderText = "Print";
            this.PrintReport.Name = "PrintReport";
            this.PrintReport.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.PrintReport.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.PrintReport.Text = "Print Report";
            this.PrintReport.UseColumnTextForLinkValue = true;
            // 
            // SalesMasterType
            // 
            this.SalesMasterType.DataPropertyName = "SalesMasterType";
            this.SalesMasterType.HeaderText = "Type";
            this.SalesMasterType.Name = "SalesMasterType";
            this.SalesMasterType.Width = 70;
            // 
            // SalesMasterDate
            // 
            this.SalesMasterDate.DataPropertyName = "SalesMasterDate";
            this.SalesMasterDate.HeaderText = "Date";
            this.SalesMasterDate.Name = "SalesMasterDate";
            // 
            // SalesMasterBillBookNo
            // 
            this.SalesMasterBillBookNo.DataPropertyName = "SalesMasterBillBookNo";
            this.SalesMasterBillBookNo.HeaderText = "Bill Book No";
            this.SalesMasterBillBookNo.Name = "SalesMasterBillBookNo";
            this.SalesMasterBillBookNo.Width = 90;
            // 
            // SalesMasterInvoiceNo
            // 
            this.SalesMasterInvoiceNo.DataPropertyName = "SalesMasterInvoiceNo";
            this.SalesMasterInvoiceNo.HeaderText = "Bill No";
            this.SalesMasterInvoiceNo.Name = "SalesMasterInvoiceNo";
            this.SalesMasterInvoiceNo.Width = 80;
            // 
            // SalesMasterCustomerFKeyName
            // 
            this.SalesMasterCustomerFKeyName.DataPropertyName = "SalesMasterCustomerFKeyName";
            this.SalesMasterCustomerFKeyName.HeaderText = "Name";
            this.SalesMasterCustomerFKeyName.Name = "SalesMasterCustomerFKeyName";
            this.SalesMasterCustomerFKeyName.Width = 290;
            // 
            // SalesMasterCustomerFKeyAddress
            // 
            this.SalesMasterCustomerFKeyAddress.DataPropertyName = "SalesMasterCustomerFKeyAddress";
            this.SalesMasterCustomerFKeyAddress.HeaderText = "Address";
            this.SalesMasterCustomerFKeyAddress.Name = "SalesMasterCustomerFKeyAddress";
            this.SalesMasterCustomerFKeyAddress.Width = 300;
            // 
            // SalesMasterVatPerc
            // 
            this.SalesMasterVatPerc.DataPropertyName = "SalesMasterVatPerc";
            this.SalesMasterVatPerc.HeaderText = "CGST Per";
            this.SalesMasterVatPerc.Name = "SalesMasterVatPerc";
            this.SalesMasterVatPerc.Visible = false;
            this.SalesMasterVatPerc.Width = 80;
            // 
            // SalesMasterVatAmount
            // 
            this.SalesMasterVatAmount.DataPropertyName = "SalesMasterVatAmount";
            this.SalesMasterVatAmount.HeaderText = "CGST Amt";
            this.SalesMasterVatAmount.Name = "SalesMasterVatAmount";
            this.SalesMasterVatAmount.Width = 85;
            // 
            // SalesMasterAddTaxPer
            // 
            this.SalesMasterAddTaxPer.DataPropertyName = "SalesMasterAddTaxPer";
            this.SalesMasterAddTaxPer.HeaderText = "SGST Per";
            this.SalesMasterAddTaxPer.Name = "SalesMasterAddTaxPer";
            this.SalesMasterAddTaxPer.Visible = false;
            this.SalesMasterAddTaxPer.Width = 80;
            // 
            // SalesMasterAddTaxAmt
            // 
            this.SalesMasterAddTaxAmt.DataPropertyName = "SalesMasterAddTaxAmt";
            this.SalesMasterAddTaxAmt.HeaderText = "SGST Amt";
            this.SalesMasterAddTaxAmt.Name = "SalesMasterAddTaxAmt";
            this.SalesMasterAddTaxAmt.Width = 85;
            // 
            // IGSTPER
            // 
            this.IGSTPER.DataPropertyName = "SalesMasterISGTPer";
            this.IGSTPER.HeaderText = "IGST Per";
            this.IGSTPER.Name = "IGSTPER";
            this.IGSTPER.Visible = false;
            this.IGSTPER.Width = 80;
            // 
            // IGSTAMT
            // 
            this.IGSTAMT.DataPropertyName = "SalesMasterISGTAmount";
            this.IGSTAMT.HeaderText = "IGST Amt";
            this.IGSTAMT.Name = "IGSTAMT";
            this.IGSTAMT.Width = 80;
            // 
            // SalesMasterGrossTotal
            // 
            this.SalesMasterGrossTotal.DataPropertyName = "SalesMasterGrossTotal";
            this.SalesMasterGrossTotal.HeaderText = "Gross Total";
            this.SalesMasterGrossTotal.Name = "SalesMasterGrossTotal";
            this.SalesMasterGrossTotal.Width = 85;
            // 
            // SalesMasterKey
            // 
            this.SalesMasterKey.DataPropertyName = "SalesMasterKey";
            this.SalesMasterKey.HeaderText = "SalesMasterKey";
            this.SalesMasterKey.Name = "SalesMasterKey";
            this.SalesMasterKey.Visible = false;
            this.SalesMasterKey.Width = 10;
            // 
            // frmSearchSalesMaster
            // 
            this.AcceptButton = this.btnAddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 660);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmSearchSalesMaster";
            this.Text = "frmSearchSalesMaster";
            this.Load += new System.EventHandler(this.frmSearchSalesMaster_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalesView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMain;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridView dgvSalesView;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblCaptionRecord;
        private System.Windows.Forms.ComboBox cmbSalesType;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridViewLinkColumn Action;
        private System.Windows.Forms.DataGridViewLinkColumn PrintReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesMasterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesMasterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesMasterBillBookNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesMasterInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesMasterCustomerFKeyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesMasterCustomerFKeyAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesMasterVatPerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesMasterVatAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesMasterAddTaxPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesMasterAddTaxAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGSTPER;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGSTAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesMasterGrossTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn SalesMasterKey;

    }
}