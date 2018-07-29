namespace SenseInventoryLogoUI.Forms
{
    partial class frmSearchPurchaseMaster
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
            this.dgvPurchaseView = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.cmbPurchaseType = new System.Windows.Forms.ComboBox();
            this.label28 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.txtSupplierAddress = new System.Windows.Forms.TextBox();
            this.lblCaptionRecord = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtSupplierName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.Action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PurchaseMasterType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseMasterDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseMasterBillBookNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseMasterInvoiceNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseMasterSupplierFKeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseMasterSupplierFKeyAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseMasterVatPerc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseMasterVatAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseMasterAddTaxPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseMasterAddTaxAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGSTPER = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IGSTAMT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseMasterGrossTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseMasterKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlMain.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseView)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlMain
            // 
            this.pnlMain.Controls.Add(this.dgvPurchaseView);
            this.pnlMain.Controls.Add(this.panel3);
            this.pnlMain.Controls.Add(this.panel2);
            this.pnlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlMain.Location = new System.Drawing.Point(0, 0);
            this.pnlMain.Name = "pnlMain";
            this.pnlMain.Size = new System.Drawing.Size(1002, 660);
            this.pnlMain.TabIndex = 0;
            // 
            // dgvPurchaseView
            // 
            this.dgvPurchaseView.AllowUserToAddRows = false;
            this.dgvPurchaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.PurchaseMasterType,
            this.PurchaseMasterDate,
            this.PurchaseMasterBillBookNo,
            this.PurchaseMasterInvoiceNo,
            this.PurchaseMasterSupplierFKeyName,
            this.PurchaseMasterSupplierFKeyAddress,
            this.PurchaseMasterVatPerc,
            this.PurchaseMasterVatAmount,
            this.PurchaseMasterAddTaxPer,
            this.PurchaseMasterAddTaxAmt,
            this.IGSTPER,
            this.IGSTAMT,
            this.PurchaseMasterGrossTotal,
            this.PurchaseMasterKey});
            this.dgvPurchaseView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPurchaseView.Location = new System.Drawing.Point(0, 171);
            this.dgvPurchaseView.Name = "dgvPurchaseView";
            this.dgvPurchaseView.Size = new System.Drawing.Size(1002, 489);
            this.dgvPurchaseView.TabIndex = 35;
            this.dgvPurchaseView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseView_CellContentClick);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.cmbPurchaseType);
            this.panel3.Controls.Add(this.label28);
            this.panel3.Controls.Add(this.lblRecordCount);
            this.panel3.Controls.Add(this.txtSupplierAddress);
            this.panel3.Controls.Add(this.lblCaptionRecord);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.txtSupplierName);
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
            this.label28.Location = new System.Drawing.Point(10, 51);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(82, 13);
            this.label28.TabIndex = 51;
            this.label28.Text = "Purchase Type:";
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
            // txtSupplierAddress
            // 
            this.txtSupplierAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierAddress.Location = new System.Drawing.Point(776, 3);
            this.txtSupplierAddress.Multiline = true;
            this.txtSupplierAddress.Name = "txtSupplierAddress";
            this.txtSupplierAddress.Size = new System.Drawing.Size(223, 42);
            this.txtSupplierAddress.TabIndex = 4;
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
            // txtSupplierName
            // 
            this.txtSupplierName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSupplierName.Location = new System.Drawing.Point(552, 3);
            this.txtSupplierName.Multiline = true;
            this.txtSupplierName.Name = "txtSupplierName";
            this.txtSupplierName.Size = new System.Drawing.Size(174, 29);
            this.txtSupplierName.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(453, 10);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(85, 13);
            this.label9.TabIndex = 47;
            this.label9.Text = " Supplier Name.:";
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
            this.label1.Size = new System.Drawing.Size(343, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Search Purchase Master:";
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Text = "Edit";
            this.Action.UseColumnTextForLinkValue = true;
            this.Action.Width = 50;
            // 
            // PurchaseMasterType
            // 
            this.PurchaseMasterType.DataPropertyName = "PurchaseMasterType";
            this.PurchaseMasterType.HeaderText = "Type";
            this.PurchaseMasterType.Name = "PurchaseMasterType";
            this.PurchaseMasterType.Width = 70;
            // 
            // PurchaseMasterDate
            // 
            this.PurchaseMasterDate.DataPropertyName = "PurchaseMasterDate";
            this.PurchaseMasterDate.HeaderText = "Date";
            this.PurchaseMasterDate.Name = "PurchaseMasterDate";
            // 
            // PurchaseMasterBillBookNo
            // 
            this.PurchaseMasterBillBookNo.DataPropertyName = "PurchaseMasterBillBookNo";
            this.PurchaseMasterBillBookNo.HeaderText = "Bill Book No";
            this.PurchaseMasterBillBookNo.Name = "PurchaseMasterBillBookNo";
            this.PurchaseMasterBillBookNo.Width = 90;
            // 
            // PurchaseMasterInvoiceNo
            // 
            this.PurchaseMasterInvoiceNo.DataPropertyName = "PurchaseMasterInvoiceNo";
            this.PurchaseMasterInvoiceNo.HeaderText = "Bill No";
            this.PurchaseMasterInvoiceNo.Name = "PurchaseMasterInvoiceNo";
            this.PurchaseMasterInvoiceNo.Width = 80;
            // 
            // PurchaseMasterSupplierFKeyName
            // 
            this.PurchaseMasterSupplierFKeyName.DataPropertyName = "PurchaseMasterSupplierFKeyName";
            this.PurchaseMasterSupplierFKeyName.HeaderText = "Name";
            this.PurchaseMasterSupplierFKeyName.Name = "PurchaseMasterSupplierFKeyName";
            this.PurchaseMasterSupplierFKeyName.Width = 290;
            // 
            // PurchaseMasterSupplierFKeyAddress
            // 
            this.PurchaseMasterSupplierFKeyAddress.DataPropertyName = "PurchaseMasterSupplierFKeyAddress";
            this.PurchaseMasterSupplierFKeyAddress.HeaderText = "Address";
            this.PurchaseMasterSupplierFKeyAddress.Name = "PurchaseMasterSupplierFKeyAddress";
            this.PurchaseMasterSupplierFKeyAddress.Width = 300;
            // 
            // PurchaseMasterVatPerc
            // 
            this.PurchaseMasterVatPerc.DataPropertyName = "PurchaseMasterVatPerc";
            this.PurchaseMasterVatPerc.HeaderText = "CGST Per";
            this.PurchaseMasterVatPerc.Name = "PurchaseMasterVatPerc";
            this.PurchaseMasterVatPerc.Visible = false;
            this.PurchaseMasterVatPerc.Width = 80;
            // 
            // PurchaseMasterVatAmount
            // 
            this.PurchaseMasterVatAmount.DataPropertyName = "PurchaseMasterVatAmount";
            this.PurchaseMasterVatAmount.HeaderText = "CGST Amt";
            this.PurchaseMasterVatAmount.Name = "PurchaseMasterVatAmount";
            this.PurchaseMasterVatAmount.Width = 85;
            // 
            // PurchaseMasterAddTaxPer
            // 
            this.PurchaseMasterAddTaxPer.DataPropertyName = "PurchaseMasterAddTaxPer";
            this.PurchaseMasterAddTaxPer.HeaderText = "SGST Per";
            this.PurchaseMasterAddTaxPer.Name = "PurchaseMasterAddTaxPer";
            this.PurchaseMasterAddTaxPer.Visible = false;
            this.PurchaseMasterAddTaxPer.Width = 80;
            // 
            // PurchaseMasterAddTaxAmt
            // 
            this.PurchaseMasterAddTaxAmt.DataPropertyName = "PurchaseMasterAddTaxAmt";
            this.PurchaseMasterAddTaxAmt.HeaderText = "SGST Amt";
            this.PurchaseMasterAddTaxAmt.Name = "PurchaseMasterAddTaxAmt";
            this.PurchaseMasterAddTaxAmt.Width = 85;
            // 
            // IGSTPER
            // 
            this.IGSTPER.DataPropertyName = "PurchaseMasterISGTPer";
            this.IGSTPER.HeaderText = "IGST Per";
            this.IGSTPER.Name = "IGSTPER";
            this.IGSTPER.Visible = false;
            this.IGSTPER.Width = 80;
            // 
            // IGSTAMT
            // 
            this.IGSTAMT.DataPropertyName = "PurchaseMasterISGTAmount";
            this.IGSTAMT.HeaderText = "IGST Amt";
            this.IGSTAMT.Name = "IGSTAMT";
            this.IGSTAMT.Width = 80;
            // 
            // PurchaseMasterGrossTotal
            // 
            this.PurchaseMasterGrossTotal.DataPropertyName = "PurchaseMasterGrossTotal";
            this.PurchaseMasterGrossTotal.HeaderText = "Gross Total";
            this.PurchaseMasterGrossTotal.Name = "PurchaseMasterGrossTotal";
            this.PurchaseMasterGrossTotal.Width = 85;
            // 
            // PurchaseMasterKey
            // 
            this.PurchaseMasterKey.DataPropertyName = "PurchaseMasterKey";
            this.PurchaseMasterKey.HeaderText = "PurchaseMasterKey";
            this.PurchaseMasterKey.Name = "PurchaseMasterKey";
            this.PurchaseMasterKey.Visible = false;
            this.PurchaseMasterKey.Width = 10;
            // 
            // frmSearchPurchaseMaster
            // 
            this.AcceptButton = this.btnAddItem;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1002, 660);
            this.Controls.Add(this.pnlMain);
            this.Name = "frmSearchPurchaseMaster";
            this.Text = "frmSearchPurchaseMaster";
            this.Load += new System.EventHandler(this.frmSearchPurchaseMaster_Load);
            this.pnlMain.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseView)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvPurchaseView;
        private System.Windows.Forms.TextBox txtSupplierName;
        private System.Windows.Forms.TextBox txtSupplierAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblCaptionRecord;
        private System.Windows.Forms.ComboBox cmbPurchaseType;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridViewLinkColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseMasterType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseMasterDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseMasterBillBookNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseMasterInvoiceNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseMasterSupplierFKeyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseMasterSupplierFKeyAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseMasterVatPerc;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseMasterVatAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseMasterAddTaxPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseMasterAddTaxAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGSTPER;
        private System.Windows.Forms.DataGridViewTextBoxColumn IGSTAMT;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseMasterGrossTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseMasterKey;

    }
}