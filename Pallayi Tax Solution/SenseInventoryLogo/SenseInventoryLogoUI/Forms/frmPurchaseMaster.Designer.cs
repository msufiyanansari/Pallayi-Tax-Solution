namespace SenseInventoryLogoUI.Forms
{
    partial class frmPurchaseMaster
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
            this.btnLoadSupplier = new System.Windows.Forms.Button();
            this.btnAddSupplier = new System.Windows.Forms.Button();
            this.txtVehicleNo = new System.Windows.Forms.TextBox();
            this.label39 = new System.Windows.Forms.Label();
            this.txtTransportDetail = new System.Windows.Forms.TextBox();
            this.cmbPurchaseType = new System.Windows.Forms.ComboBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.dtpChalanDt = new System.Windows.Forms.DateTimePicker();
            this.dtpDate = new System.Windows.Forms.DateTimePicker();
            this.label13 = new System.Windows.Forms.Label();
            this.txtChlnNo = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtInvoiceNo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.cmbSupplier = new System.Windows.Forms.ComboBox();
            this.lblSupplierDetail = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbReverseCharge = new System.Windows.Forms.ComboBox();
            this.label38 = new System.Windows.Forms.Label();
            this.txtBillNo = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnAddPurchase = new System.Windows.Forms.Button();
            this.btnDeletePurchase = new System.Windows.Forms.Button();
            this.dgvPaymentDetail = new System.Windows.Forms.DataGridView();
            this.dataGridViewLinkColumn1 = new System.Windows.Forms.DataGridViewLinkColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionPayType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionPayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionPayAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionPayBankFKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionPayBankFKeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionPayChequeDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionPayBankChequeNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionPayKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionPayPurchaseMasterFKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseActualTransactionPayDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseActualTransactionCheckDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.btnLoadBank = new System.Windows.Forms.Button();
            this.btnAddBank = new System.Windows.Forms.Button();
            this.txtChequeNo = new System.Windows.Forms.TextBox();
            this.lblChequeNo = new System.Windows.Forms.Label();
            this.dtpChequeDate = new System.Windows.Forms.DateTimePicker();
            this.dtpPaymentDate = new System.Windows.Forms.DateTimePicker();
            this.label37 = new System.Windows.Forms.Label();
            this.cmbPaymentMode = new System.Windows.Forms.ComboBox();
            this.label29 = new System.Windows.Forms.Label();
            this.txtPaymentIndex = new System.Windows.Forms.TextBox();
            this.txtPurchaseTransactionPayKey = new System.Windows.Forms.TextBox();
            this.btnDeletePayment = new System.Windows.Forms.Button();
            this.btnAddPayment = new System.Windows.Forms.Button();
            this.lblChequeDate = new System.Windows.Forms.Label();
            this.txtPayAmount = new System.Windows.Forms.TextBox();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.lblBankName = new System.Windows.Forms.Label();
            this.cmbBank = new System.Windows.Forms.ComboBox();
            this.dgvPurchaseView = new System.Windows.Forms.DataGridView();
            this.Action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.PurchaseTransactionItemGroupFKeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionItemFKeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionPoNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionTaxableAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionCGSTPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionCGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionSGSTPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionSGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionIGSTPer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionIGSTAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionItemFKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionSaleMasterFKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Index = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Mode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionItemGroupFKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PurchaseTransactionHsnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dicount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DicountAmt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.txtDiscountAmt = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtDiscountPer = new System.Windows.Forms.TextBox();
            this.label27 = new System.Windows.Forms.Label();
            this.txtGstAmt = new System.Windows.Forms.TextBox();
            this.label40 = new System.Windows.Forms.Label();
            this.txtIgstPer = new System.Windows.Forms.TextBox();
            this.label42 = new System.Windows.Forms.Label();
            this.txtTaxableValue = new System.Windows.Forms.TextBox();
            this.label47 = new System.Windows.Forms.Label();
            this.txtSgstAmt = new System.Windows.Forms.TextBox();
            this.label45 = new System.Windows.Forms.Label();
            this.txtSGSTPer = new System.Windows.Forms.TextBox();
            this.label46 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.txtCGSTAmt = new System.Windows.Forms.TextBox();
            this.label41 = new System.Windows.Forms.Label();
            this.txtCgstPer = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.txtHsnCode = new System.Windows.Forms.TextBox();
            this.label36 = new System.Windows.Forms.Label();
            this.txtPoNo = new System.Windows.Forms.TextBox();
            this.label34 = new System.Windows.Forms.Label();
            this.txtItemStock = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.cmbItemGroup = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.btnDeleteItem = new System.Windows.Forms.Button();
            this.btnAddItem = new System.Windows.Forms.Button();
            this.txtIndex = new System.Windows.Forms.TextBox();
            this.txtPurchaseTransactionKey = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label24 = new System.Windows.Forms.Label();
            this.txtRate = new System.Windows.Forms.TextBox();
            this.label22 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtPreviousRate = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.cmbItem = new System.Windows.Forms.ComboBox();
            this.txtIgstAmt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtPendingAmount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPaidAmount = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtAddTaxAmount = new System.Windows.Forms.TextBox();
            this.lblAddTaxAmt = new System.Windows.Forms.Label();
            this.txtVatAmt = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtGTotal = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtMainTotal = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.txtRoundoff = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cmbRounoffOption = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtCartage = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentDetail)).BeginInit();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseView)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnLoadSupplier);
            this.panel1.Controls.Add(this.btnAddSupplier);
            this.panel1.Controls.Add(this.txtVehicleNo);
            this.panel1.Controls.Add(this.label39);
            this.panel1.Controls.Add(this.txtTransportDetail);
            this.panel1.Controls.Add(this.cmbPurchaseType);
            this.panel1.Controls.Add(this.label31);
            this.panel1.Controls.Add(this.label28);
            this.panel1.Controls.Add(this.dtpChalanDt);
            this.panel1.Controls.Add(this.dtpDate);
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtChlnNo);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.txtInvoiceNo);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.cmbSupplier);
            this.panel1.Controls.Add(this.lblSupplierDetail);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1367, 101);
            this.panel1.TabIndex = 18;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnLoadSupplier
            // 
            this.btnLoadSupplier.Location = new System.Drawing.Point(956, 40);
            this.btnLoadSupplier.Name = "btnLoadSupplier";
            this.btnLoadSupplier.Size = new System.Drawing.Size(51, 24);
            this.btnLoadSupplier.TabIndex = 71;
            this.btnLoadSupplier.TabStop = false;
            this.btnLoadSupplier.Text = "Load";
            this.btnLoadSupplier.UseVisualStyleBackColor = true;
            this.btnLoadSupplier.Click += new System.EventHandler(this.btnLoadSupplier_Click);
            // 
            // btnAddSupplier
            // 
            this.btnAddSupplier.Location = new System.Drawing.Point(903, 41);
            this.btnAddSupplier.Name = "btnAddSupplier";
            this.btnAddSupplier.Size = new System.Drawing.Size(51, 24);
            this.btnAddSupplier.TabIndex = 70;
            this.btnAddSupplier.TabStop = false;
            this.btnAddSupplier.Text = "Add";
            this.btnAddSupplier.UseVisualStyleBackColor = true;
            this.btnAddSupplier.Click += new System.EventHandler(this.btnAddSupplier_Click);
            // 
            // txtVehicleNo
            // 
            this.txtVehicleNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehicleNo.Location = new System.Drawing.Point(76, 71);
            this.txtVehicleNo.Multiline = true;
            this.txtVehicleNo.Name = "txtVehicleNo";
            this.txtVehicleNo.Size = new System.Drawing.Size(112, 26);
            this.txtVehicleNo.TabIndex = 6;
            // 
            // label39
            // 
            this.label39.AutoSize = true;
            this.label39.Location = new System.Drawing.Point(4, 73);
            this.label39.Name = "label39";
            this.label39.Size = new System.Drawing.Size(62, 13);
            this.label39.TabIndex = 43;
            this.label39.Text = "Vehicle No:";
            // 
            // txtTransportDetail
            // 
            this.txtTransportDetail.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTransportDetail.Location = new System.Drawing.Point(628, 70);
            this.txtTransportDetail.Multiline = true;
            this.txtTransportDetail.Name = "txtTransportDetail";
            this.txtTransportDetail.Size = new System.Drawing.Size(112, 26);
            this.txtTransportDetail.TabIndex = 8;
            // 
            // cmbPurchaseType
            // 
            this.cmbPurchaseType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPurchaseType.FormattingEnabled = true;
            this.cmbPurchaseType.ItemHeight = 13;
            this.cmbPurchaseType.Items.AddRange(new object[] {
            "Select Type",
            "Tax Invoice"});
            this.cmbPurchaseType.Location = new System.Drawing.Point(76, 43);
            this.cmbPurchaseType.Name = "cmbPurchaseType";
            this.cmbPurchaseType.Size = new System.Drawing.Size(112, 21);
            this.cmbPurchaseType.TabIndex = 1;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Location = new System.Drawing.Point(539, 78);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(79, 13);
            this.label31.TabIndex = 39;
            this.label31.Text = "TransPortation ";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Location = new System.Drawing.Point(2, 46);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(82, 13);
            this.label28.TabIndex = 37;
            this.label28.Text = "Purchase Type:";
            // 
            // dtpChalanDt
            // 
            this.dtpChalanDt.CustomFormat = "dd/MM/yyyy";
            this.dtpChalanDt.Location = new System.Drawing.Point(1075, 44);
            this.dtpChalanDt.Name = "dtpChalanDt";
            this.dtpChalanDt.Size = new System.Drawing.Size(221, 20);
            this.dtpChalanDt.TabIndex = 5;
            // 
            // dtpDate
            // 
            this.dtpDate.CustomFormat = "dd/MM/yyyy";
            this.dtpDate.Location = new System.Drawing.Point(353, 44);
            this.dtpDate.Name = "dtpDate";
            this.dtpDate.Size = new System.Drawing.Size(180, 20);
            this.dtpDate.TabIndex = 3;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(1007, 47);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(71, 13);
            this.label13.TabIndex = 31;
            this.label13.Text = "Supply Date.:";
            // 
            // txtChlnNo
            // 
            this.txtChlnNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChlnNo.Location = new System.Drawing.Point(261, 73);
            this.txtChlnNo.Multiline = true;
            this.txtChlnNo.Name = "txtChlnNo";
            this.txtChlnNo.Size = new System.Drawing.Size(272, 24);
            this.txtChlnNo.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(191, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(72, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Place Supply:";
            // 
            // txtInvoiceNo
            // 
            this.txtInvoiceNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInvoiceNo.Location = new System.Drawing.Point(261, 40);
            this.txtInvoiceNo.Multiline = true;
            this.txtInvoiceNo.Name = "txtInvoiceNo";
            this.txtInvoiceNo.Size = new System.Drawing.Size(49, 29);
            this.txtInvoiceNo.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(196, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 13);
            this.label3.TabIndex = 27;
            this.label3.Text = "Invoice No:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(539, 47);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 13);
            this.label9.TabIndex = 25;
            this.label9.Text = " Select Supplier.:";
            // 
            // cmbSupplier
            // 
            this.cmbSupplier.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSupplier.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSupplier.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSupplier.FormattingEnabled = true;
            this.cmbSupplier.Location = new System.Drawing.Point(628, 43);
            this.cmbSupplier.Name = "cmbSupplier";
            this.cmbSupplier.Size = new System.Drawing.Size(263, 21);
            this.cmbSupplier.TabIndex = 4;
            this.cmbSupplier.SelectedIndexChanged += new System.EventHandler(this.cmbSupplier_SelectedIndexChanged);
            // 
            // lblSupplierDetail
            // 
            this.lblSupplierDetail.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblSupplierDetail.AutoSize = true;
            this.lblSupplierDetail.Location = new System.Drawing.Point(767, 70);
            this.lblSupplierDetail.Name = "lblSupplierDetail";
            this.lblSupplierDetail.Size = new System.Drawing.Size(218, 13);
            this.lblSupplierDetail.TabIndex = 2;
            this.lblSupplierDetail.Text = "Select the Supplier Show the Supplier Detail:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.txtKey);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1363, 38);
            this.panel2.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(544, 1);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 33);
            this.label1.TabIndex = 17;
            this.label1.Text = "Entry:";
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(1147, -2);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(114, 29);
            this.txtKey.TabIndex = 17;
            this.txtKey.Text = "0";
            this.txtKey.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(319, 47);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date.:";
            // 
            // cmbReverseCharge
            // 
            this.cmbReverseCharge.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbReverseCharge.FormattingEnabled = true;
            this.cmbReverseCharge.ItemHeight = 13;
            this.cmbReverseCharge.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.cmbReverseCharge.Location = new System.Drawing.Point(664, 126);
            this.cmbReverseCharge.Name = "cmbReverseCharge";
            this.cmbReverseCharge.Size = new System.Drawing.Size(112, 21);
            this.cmbReverseCharge.TabIndex = 9;
            this.cmbReverseCharge.Visible = false;
            // 
            // label38
            // 
            this.label38.AutoSize = true;
            this.label38.Location = new System.Drawing.Point(603, 127);
            this.label38.Name = "label38";
            this.label38.Size = new System.Drawing.Size(50, 13);
            this.label38.TabIndex = 41;
            this.label38.Text = "Reverse:";
            this.label38.Visible = false;
            // 
            // txtBillNo
            // 
            this.txtBillNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBillNo.Location = new System.Drawing.Point(196, 477);
            this.txtBillNo.Multiline = true;
            this.txtBillNo.Name = "txtBillNo";
            this.txtBillNo.Size = new System.Drawing.Size(48, 29);
            this.txtBillNo.TabIndex = 2;
            this.txtBillNo.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(129, 487);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 10;
            this.label8.Text = "Bill Book No:";
            this.label8.Visible = false;
            // 
            // btnAddPurchase
            // 
            this.btnAddPurchase.Location = new System.Drawing.Point(14, 544);
            this.btnAddPurchase.Name = "btnAddPurchase";
            this.btnAddPurchase.Size = new System.Drawing.Size(133, 30);
            this.btnAddPurchase.TabIndex = 30;
            this.btnAddPurchase.Text = "Add";
            this.btnAddPurchase.UseVisualStyleBackColor = true;
            this.btnAddPurchase.Click += new System.EventHandler(this.btnAddPurchase_Click);
            // 
            // btnDeletePurchase
            // 
            this.btnDeletePurchase.Location = new System.Drawing.Point(254, 542);
            this.btnDeletePurchase.Name = "btnDeletePurchase";
            this.btnDeletePurchase.Size = new System.Drawing.Size(131, 30);
            this.btnDeletePurchase.TabIndex = 31;
            this.btnDeletePurchase.Text = "Delete";
            this.btnDeletePurchase.UseVisualStyleBackColor = true;
            this.btnDeletePurchase.Click += new System.EventHandler(this.btnDeletePurchase_Click);
            // 
            // dgvPaymentDetail
            // 
            this.dgvPaymentDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPaymentDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewLinkColumn1,
            this.dataGridViewTextBoxColumn9,
            this.PurchaseTransactionPayType,
            this.PurchaseTransactionPayDate,
            this.PurchaseTransactionPayAmount,
            this.PurchaseTransactionPayBankFKey,
            this.PurchaseTransactionPayBankFKeyName,
            this.PurchaseTransactionPayChequeDate,
            this.PurchaseTransactionPayBankChequeNo,
            this.PurchaseTransactionPayKey,
            this.PurchaseTransactionPayPurchaseMasterFKey,
            this.dataGridViewTextBoxColumn10,
            this.PurchaseActualTransactionPayDate,
            this.PurchaseActualTransactionCheckDate});
            this.dgvPaymentDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvPaymentDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvPaymentDetail.Name = "dgvPaymentDetail";
            this.dgvPaymentDetail.Size = new System.Drawing.Size(581, 207);
            this.dgvPaymentDetail.TabIndex = 26;
            this.dgvPaymentDetail.TabStop = false;
            this.dgvPaymentDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPaymentDetail_CellContentClick);
            // 
            // dataGridViewLinkColumn1
            // 
            this.dataGridViewLinkColumn1.HeaderText = "Action";
            this.dataGridViewLinkColumn1.Name = "dataGridViewLinkColumn1";
            this.dataGridViewLinkColumn1.Text = "Edit";
            this.dataGridViewLinkColumn1.UseColumnTextForLinkValue = true;
            this.dataGridViewLinkColumn1.Width = 50;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.DataPropertyName = "Index";
            this.dataGridViewTextBoxColumn9.HeaderText = "Index";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.Visible = false;
            // 
            // PurchaseTransactionPayType
            // 
            this.PurchaseTransactionPayType.DataPropertyName = "PurchaseTransactionPayType";
            this.PurchaseTransactionPayType.HeaderText = "Type";
            this.PurchaseTransactionPayType.Name = "PurchaseTransactionPayType";
            this.PurchaseTransactionPayType.Width = 80;
            // 
            // PurchaseTransactionPayDate
            // 
            this.PurchaseTransactionPayDate.DataPropertyName = "PurchaseTransactionPayDate";
            this.PurchaseTransactionPayDate.HeaderText = "Date";
            this.PurchaseTransactionPayDate.Name = "PurchaseTransactionPayDate";
            this.PurchaseTransactionPayDate.Width = 70;
            // 
            // PurchaseTransactionPayAmount
            // 
            this.PurchaseTransactionPayAmount.DataPropertyName = "PurchaseTransactionPayAmount";
            this.PurchaseTransactionPayAmount.HeaderText = "Amount";
            this.PurchaseTransactionPayAmount.Name = "PurchaseTransactionPayAmount";
            this.PurchaseTransactionPayAmount.Width = 70;
            // 
            // PurchaseTransactionPayBankFKey
            // 
            this.PurchaseTransactionPayBankFKey.DataPropertyName = "PurchaseTransactionPayBankFKey";
            this.PurchaseTransactionPayBankFKey.HeaderText = "PurchaseTransactionPayBankFKey";
            this.PurchaseTransactionPayBankFKey.Name = "PurchaseTransactionPayBankFKey";
            this.PurchaseTransactionPayBankFKey.Visible = false;
            // 
            // PurchaseTransactionPayBankFKeyName
            // 
            this.PurchaseTransactionPayBankFKeyName.DataPropertyName = "PurchaseTransactionPayBankFKeyName";
            this.PurchaseTransactionPayBankFKeyName.HeaderText = "Bank Name";
            this.PurchaseTransactionPayBankFKeyName.Name = "PurchaseTransactionPayBankFKeyName";
            this.PurchaseTransactionPayBankFKeyName.Width = 150;
            // 
            // PurchaseTransactionPayChequeDate
            // 
            this.PurchaseTransactionPayChequeDate.DataPropertyName = "PurchaseTransactionPayChequeDate";
            this.PurchaseTransactionPayChequeDate.HeaderText = "Chq Date";
            this.PurchaseTransactionPayChequeDate.Name = "PurchaseTransactionPayChequeDate";
            this.PurchaseTransactionPayChequeDate.Width = 90;
            // 
            // PurchaseTransactionPayBankChequeNo
            // 
            this.PurchaseTransactionPayBankChequeNo.DataPropertyName = "PurchaseTransactionPayBankChequeNo";
            this.PurchaseTransactionPayBankChequeNo.HeaderText = "Chq No";
            this.PurchaseTransactionPayBankChequeNo.Name = "PurchaseTransactionPayBankChequeNo";
            this.PurchaseTransactionPayBankChequeNo.Width = 70;
            // 
            // PurchaseTransactionPayKey
            // 
            this.PurchaseTransactionPayKey.DataPropertyName = "PurchaseTransactionPayKey";
            this.PurchaseTransactionPayKey.HeaderText = "PurchaseTransactionPayKey";
            this.PurchaseTransactionPayKey.Name = "PurchaseTransactionPayKey";
            this.PurchaseTransactionPayKey.Visible = false;
            // 
            // PurchaseTransactionPayPurchaseMasterFKey
            // 
            this.PurchaseTransactionPayPurchaseMasterFKey.DataPropertyName = "PurchaseTransactionPayPurchaseMasterFKey";
            this.PurchaseTransactionPayPurchaseMasterFKey.HeaderText = "PurchaseTransactionPayPurchaseMasterFKey";
            this.PurchaseTransactionPayPurchaseMasterFKey.Name = "PurchaseTransactionPayPurchaseMasterFKey";
            this.PurchaseTransactionPayPurchaseMasterFKey.Visible = false;
            // 
            // dataGridViewTextBoxColumn10
            // 
            this.dataGridViewTextBoxColumn10.DataPropertyName = "Mode";
            this.dataGridViewTextBoxColumn10.HeaderText = "Mode";
            this.dataGridViewTextBoxColumn10.Name = "dataGridViewTextBoxColumn10";
            this.dataGridViewTextBoxColumn10.Visible = false;
            // 
            // PurchaseActualTransactionPayDate
            // 
            this.PurchaseActualTransactionPayDate.DataPropertyName = "PurchaseActualTransactionPayDate";
            this.PurchaseActualTransactionPayDate.HeaderText = "Pay Date";
            this.PurchaseActualTransactionPayDate.Name = "PurchaseActualTransactionPayDate";
            this.PurchaseActualTransactionPayDate.Visible = false;
            // 
            // PurchaseActualTransactionCheckDate
            // 
            this.PurchaseActualTransactionCheckDate.DataPropertyName = "PurchaseActualTransactionCheckDate";
            this.PurchaseActualTransactionCheckDate.HeaderText = "Check Date";
            this.PurchaseActualTransactionCheckDate.Name = "PurchaseActualTransactionCheckDate";
            this.PurchaseActualTransactionCheckDate.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.dgvPaymentDetail);
            this.panel5.Location = new System.Drawing.Point(782, 254);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(585, 211);
            this.panel5.TabIndex = 76;
            // 
            // panel6
            // 
            this.panel6.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel6.Controls.Add(this.btnLoadBank);
            this.panel6.Controls.Add(this.btnAddBank);
            this.panel6.Controls.Add(this.txtChequeNo);
            this.panel6.Controls.Add(this.lblChequeNo);
            this.panel6.Controls.Add(this.dtpChequeDate);
            this.panel6.Controls.Add(this.dtpPaymentDate);
            this.panel6.Controls.Add(this.label37);
            this.panel6.Controls.Add(this.cmbPaymentMode);
            this.panel6.Controls.Add(this.label29);
            this.panel6.Controls.Add(this.txtPaymentIndex);
            this.panel6.Controls.Add(this.txtPurchaseTransactionPayKey);
            this.panel6.Controls.Add(this.btnDeletePayment);
            this.panel6.Controls.Add(this.btnAddPayment);
            this.panel6.Controls.Add(this.lblChequeDate);
            this.panel6.Controls.Add(this.txtPayAmount);
            this.panel6.Controls.Add(this.label32);
            this.panel6.Controls.Add(this.label33);
            this.panel6.Controls.Add(this.lblBankName);
            this.panel6.Controls.Add(this.cmbBank);
            this.panel6.Location = new System.Drawing.Point(782, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(580, 154);
            this.panel6.TabIndex = 75;
            // 
            // btnLoadBank
            // 
            this.btnLoadBank.Location = new System.Drawing.Point(256, 49);
            this.btnLoadBank.Name = "btnLoadBank";
            this.btnLoadBank.Size = new System.Drawing.Size(51, 24);
            this.btnLoadBank.TabIndex = 73;
            this.btnLoadBank.Text = "Load";
            this.btnLoadBank.UseVisualStyleBackColor = true;
            this.btnLoadBank.Click += new System.EventHandler(this.btnLoadBank_Click);
            // 
            // btnAddBank
            // 
            this.btnAddBank.Location = new System.Drawing.Point(196, 49);
            this.btnAddBank.Name = "btnAddBank";
            this.btnAddBank.Size = new System.Drawing.Size(51, 24);
            this.btnAddBank.TabIndex = 72;
            this.btnAddBank.Text = "Add";
            this.btnAddBank.UseVisualStyleBackColor = true;
            this.btnAddBank.Click += new System.EventHandler(this.btnAddBank_Click);
            // 
            // txtChequeNo
            // 
            this.txtChequeNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChequeNo.Location = new System.Drawing.Point(105, 78);
            this.txtChequeNo.Multiline = true;
            this.txtChequeNo.Name = "txtChequeNo";
            this.txtChequeNo.Size = new System.Drawing.Size(81, 30);
            this.txtChequeNo.TabIndex = 24;
            // 
            // lblChequeNo
            // 
            this.lblChequeNo.AutoSize = true;
            this.lblChequeNo.Location = new System.Drawing.Point(1, 86);
            this.lblChequeNo.Name = "lblChequeNo";
            this.lblChequeNo.Size = new System.Drawing.Size(105, 13);
            this.lblChequeNo.TabIndex = 45;
            this.lblChequeNo.Text = "Cheque No:/Tran ID";
            // 
            // dtpChequeDate
            // 
            this.dtpChequeDate.CustomFormat = "dd/MM/yyyy";
            this.dtpChequeDate.Location = new System.Drawing.Point(390, 55);
            this.dtpChequeDate.Name = "dtpChequeDate";
            this.dtpChequeDate.Size = new System.Drawing.Size(128, 20);
            this.dtpChequeDate.TabIndex = 23;
            // 
            // dtpPaymentDate
            // 
            this.dtpPaymentDate.CustomFormat = "dd/MM/yyyy";
            this.dtpPaymentDate.Location = new System.Drawing.Point(274, 24);
            this.dtpPaymentDate.Name = "dtpPaymentDate";
            this.dtpPaymentDate.Size = new System.Drawing.Size(128, 20);
            this.dtpPaymentDate.TabIndex = 20;
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Location = new System.Drawing.Point(199, 25);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(80, 13);
            this.label37.TabIndex = 39;
            this.label37.Text = "Payment Date.:";
            // 
            // cmbPaymentMode
            // 
            this.cmbPaymentMode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbPaymentMode.FormattingEnabled = true;
            this.cmbPaymentMode.Items.AddRange(new object[] {
            "Select Mode",
            "Cash",
            "Bank"});
            this.cmbPaymentMode.Location = new System.Drawing.Point(93, 24);
            this.cmbPaymentMode.Name = "cmbPaymentMode";
            this.cmbPaymentMode.Size = new System.Drawing.Size(98, 21);
            this.cmbPaymentMode.TabIndex = 19;
            this.cmbPaymentMode.SelectedIndexChanged += new System.EventHandler(this.cmbPaymentMode_SelectedIndexChanged);
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Location = new System.Drawing.Point(7, 27);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(84, 13);
            this.label29.TabIndex = 24;
            this.label29.Text = "Payment Mode.:";
            // 
            // txtPaymentIndex
            // 
            this.txtPaymentIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaymentIndex.Location = new System.Drawing.Point(7, 3);
            this.txtPaymentIndex.Multiline = true;
            this.txtPaymentIndex.Name = "txtPaymentIndex";
            this.txtPaymentIndex.Size = new System.Drawing.Size(70, 20);
            this.txtPaymentIndex.TabIndex = 0;
            this.txtPaymentIndex.Text = "0";
            this.txtPaymentIndex.Visible = false;
            // 
            // txtPurchaseTransactionPayKey
            // 
            this.txtPurchaseTransactionPayKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseTransactionPayKey.Location = new System.Drawing.Point(82, 3);
            this.txtPurchaseTransactionPayKey.Multiline = true;
            this.txtPurchaseTransactionPayKey.Name = "txtPurchaseTransactionPayKey";
            this.txtPurchaseTransactionPayKey.Size = new System.Drawing.Size(73, 20);
            this.txtPurchaseTransactionPayKey.TabIndex = 0;
            this.txtPurchaseTransactionPayKey.Text = "0";
            this.txtPurchaseTransactionPayKey.Visible = false;
            // 
            // btnDeletePayment
            // 
            this.btnDeletePayment.Location = new System.Drawing.Point(343, 81);
            this.btnDeletePayment.Name = "btnDeletePayment";
            this.btnDeletePayment.Size = new System.Drawing.Size(75, 30);
            this.btnDeletePayment.TabIndex = 26;
            this.btnDeletePayment.Text = "Delete";
            this.btnDeletePayment.UseVisualStyleBackColor = true;
            this.btnDeletePayment.Visible = false;
            this.btnDeletePayment.Click += new System.EventHandler(this.btnDeletePayment_Click);
            // 
            // btnAddPayment
            // 
            this.btnAddPayment.Location = new System.Drawing.Point(199, 81);
            this.btnAddPayment.Name = "btnAddPayment";
            this.btnAddPayment.Size = new System.Drawing.Size(75, 30);
            this.btnAddPayment.TabIndex = 25;
            this.btnAddPayment.Text = "Add";
            this.btnAddPayment.UseVisualStyleBackColor = true;
            this.btnAddPayment.Click += new System.EventHandler(this.btnAddPayment_Click);
            // 
            // lblChequeDate
            // 
            this.lblChequeDate.AutoSize = true;
            this.lblChequeDate.Location = new System.Drawing.Point(311, 59);
            this.lblChequeDate.Name = "lblChequeDate";
            this.lblChequeDate.Size = new System.Drawing.Size(73, 13);
            this.lblChequeDate.TabIndex = 37;
            this.lblChequeDate.Text = "Cheque Date:";
            // 
            // txtPayAmount
            // 
            this.txtPayAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPayAmount.Location = new System.Drawing.Point(452, 18);
            this.txtPayAmount.Multiline = true;
            this.txtPayAmount.Name = "txtPayAmount";
            this.txtPayAmount.Size = new System.Drawing.Size(81, 29);
            this.txtPayAmount.TabIndex = 21;
            this.txtPayAmount.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtPayAmount_KeyUp);
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Location = new System.Drawing.Point(407, 26);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(46, 13);
            this.label32.TabIndex = 35;
            this.label32.Text = "Amount:";
            // 
            // label33
            // 
            this.label33.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.Location = new System.Drawing.Point(291, 3);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(111, 20);
            this.label33.TabIndex = 33;
            this.label33.Text = "Save Payment";
            // 
            // lblBankName
            // 
            this.lblBankName.AutoSize = true;
            this.lblBankName.Location = new System.Drawing.Point(3, 53);
            this.lblBankName.Name = "lblBankName";
            this.lblBankName.Size = new System.Drawing.Size(74, 13);
            this.lblBankName.TabIndex = 25;
            this.lblBankName.Text = " Select Bank.:";
            // 
            // cmbBank
            // 
            this.cmbBank.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbBank.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbBank.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbBank.FormattingEnabled = true;
            this.cmbBank.Location = new System.Drawing.Point(93, 51);
            this.cmbBank.Name = "cmbBank";
            this.cmbBank.Size = new System.Drawing.Size(98, 21);
            this.cmbBank.TabIndex = 22;
            // 
            // dgvPurchaseView
            // 
            this.dgvPurchaseView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPurchaseView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.PurchaseTransactionItemGroupFKeyName,
            this.PurchaseTransactionItemFKeyName,
            this.PurchaseTransactionPoNo,
            this.PurchaseTransactionQty,
            this.PurchaseTransactionRate,
            this.PurchaseTransactionTaxableAmt,
            this.PurchaseTransactionCGSTPer,
            this.PurchaseTransactionCGSTAmt,
            this.PurchaseTransactionSGSTPer,
            this.PurchaseTransactionSGSTAmt,
            this.PurchaseTransactionIGSTPer,
            this.PurchaseTransactionIGSTAmt,
            this.PurchaseTransactionTotal,
            this.PurchaseTransactionItemFKey,
            this.PurchaseTransactionKey,
            this.PurchaseTransactionSaleMasterFKey,
            this.Index,
            this.Mode,
            this.PurchaseTransactionItemGroupFKey,
            this.PurchaseTransactionHsnCode,
            this.Dicount,
            this.DicountAmt});
            this.dgvPurchaseView.Location = new System.Drawing.Point(-4, 253);
            this.dgvPurchaseView.Name = "dgvPurchaseView";
            this.dgvPurchaseView.Size = new System.Drawing.Size(788, 210);
            this.dgvPurchaseView.TabIndex = 86;
            this.dgvPurchaseView.TabStop = false;
            this.dgvPurchaseView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvPurchaseView_CellContentClick);
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Text = "Edit";
            this.Action.UseColumnTextForLinkValue = true;
            this.Action.Width = 30;
            // 
            // PurchaseTransactionItemGroupFKeyName
            // 
            this.PurchaseTransactionItemGroupFKeyName.DataPropertyName = "PurchaseTransactionItemGroupFKeyName";
            this.PurchaseTransactionItemGroupFKeyName.HeaderText = "Item Group";
            this.PurchaseTransactionItemGroupFKeyName.Name = "PurchaseTransactionItemGroupFKeyName";
            this.PurchaseTransactionItemGroupFKeyName.Visible = false;
            this.PurchaseTransactionItemGroupFKeyName.Width = 120;
            // 
            // PurchaseTransactionItemFKeyName
            // 
            this.PurchaseTransactionItemFKeyName.DataPropertyName = "PurchaseTransactionItemFKeyName";
            this.PurchaseTransactionItemFKeyName.HeaderText = "Item Name";
            this.PurchaseTransactionItemFKeyName.Name = "PurchaseTransactionItemFKeyName";
            this.PurchaseTransactionItemFKeyName.Width = 120;
            // 
            // PurchaseTransactionPoNo
            // 
            this.PurchaseTransactionPoNo.DataPropertyName = "PurchaseTransactionPoNo";
            this.PurchaseTransactionPoNo.HeaderText = "Po No";
            this.PurchaseTransactionPoNo.Name = "PurchaseTransactionPoNo";
            // 
            // PurchaseTransactionQty
            // 
            this.PurchaseTransactionQty.DataPropertyName = "PurchaseTransactionQty";
            this.PurchaseTransactionQty.HeaderText = "Qty";
            this.PurchaseTransactionQty.Name = "PurchaseTransactionQty";
            this.PurchaseTransactionQty.Width = 50;
            // 
            // PurchaseTransactionRate
            // 
            this.PurchaseTransactionRate.DataPropertyName = "PurchaseTransactionRate";
            this.PurchaseTransactionRate.HeaderText = "Rate";
            this.PurchaseTransactionRate.Name = "PurchaseTransactionRate";
            this.PurchaseTransactionRate.Width = 50;
            // 
            // PurchaseTransactionTaxableAmt
            // 
            this.PurchaseTransactionTaxableAmt.DataPropertyName = "PurchaseTransactionTaxableAmt";
            this.PurchaseTransactionTaxableAmt.HeaderText = "Taxable Value";
            this.PurchaseTransactionTaxableAmt.Name = "PurchaseTransactionTaxableAmt";
            // 
            // PurchaseTransactionCGSTPer
            // 
            this.PurchaseTransactionCGSTPer.DataPropertyName = "PurchaseTransactionCGSTPer";
            this.PurchaseTransactionCGSTPer.HeaderText = "C GST Per";
            this.PurchaseTransactionCGSTPer.Name = "PurchaseTransactionCGSTPer";
            // 
            // PurchaseTransactionCGSTAmt
            // 
            this.PurchaseTransactionCGSTAmt.DataPropertyName = "PurchaseTransactionCGSTAmt";
            this.PurchaseTransactionCGSTAmt.HeaderText = "CGST Amt";
            this.PurchaseTransactionCGSTAmt.Name = "PurchaseTransactionCGSTAmt";
            // 
            // PurchaseTransactionSGSTPer
            // 
            this.PurchaseTransactionSGSTPer.DataPropertyName = "PurchaseTransactionSGSTPer";
            this.PurchaseTransactionSGSTPer.HeaderText = "SGST Per";
            this.PurchaseTransactionSGSTPer.Name = "PurchaseTransactionSGSTPer";
            // 
            // PurchaseTransactionSGSTAmt
            // 
            this.PurchaseTransactionSGSTAmt.DataPropertyName = "PurchaseTransactionSGSTAmt";
            this.PurchaseTransactionSGSTAmt.HeaderText = "SGST Amt";
            this.PurchaseTransactionSGSTAmt.Name = "PurchaseTransactionSGSTAmt";
            // 
            // PurchaseTransactionIGSTPer
            // 
            this.PurchaseTransactionIGSTPer.DataPropertyName = "PurchaseTransactionIGSTPer";
            this.PurchaseTransactionIGSTPer.HeaderText = "IGST Per";
            this.PurchaseTransactionIGSTPer.Name = "PurchaseTransactionIGSTPer";
            // 
            // PurchaseTransactionIGSTAmt
            // 
            this.PurchaseTransactionIGSTAmt.DataPropertyName = "PurchaseTransactionIGSTAmt";
            this.PurchaseTransactionIGSTAmt.HeaderText = "IGST Amt";
            this.PurchaseTransactionIGSTAmt.Name = "PurchaseTransactionIGSTAmt";
            // 
            // PurchaseTransactionTotal
            // 
            this.PurchaseTransactionTotal.DataPropertyName = "PurchaseTransactionTotal";
            this.PurchaseTransactionTotal.HeaderText = "Total";
            this.PurchaseTransactionTotal.Name = "PurchaseTransactionTotal";
            // 
            // PurchaseTransactionItemFKey
            // 
            this.PurchaseTransactionItemFKey.DataPropertyName = "PurchaseTransactionItemFKey";
            this.PurchaseTransactionItemFKey.HeaderText = "ItemKey";
            this.PurchaseTransactionItemFKey.Name = "PurchaseTransactionItemFKey";
            this.PurchaseTransactionItemFKey.Visible = false;
            // 
            // PurchaseTransactionKey
            // 
            this.PurchaseTransactionKey.DataPropertyName = "PurchaseTransactionKey";
            this.PurchaseTransactionKey.HeaderText = "PurchaseTransactionKey";
            this.PurchaseTransactionKey.Name = "PurchaseTransactionKey";
            this.PurchaseTransactionKey.Visible = false;
            // 
            // PurchaseTransactionSaleMasterFKey
            // 
            this.PurchaseTransactionSaleMasterFKey.DataPropertyName = "PurchaseTransactionSaleMasterFKey";
            this.PurchaseTransactionSaleMasterFKey.HeaderText = "PurchaseMasterKey";
            this.PurchaseTransactionSaleMasterFKey.Name = "PurchaseTransactionSaleMasterFKey";
            this.PurchaseTransactionSaleMasterFKey.Visible = false;
            // 
            // Index
            // 
            this.Index.DataPropertyName = "Index";
            this.Index.HeaderText = "Index";
            this.Index.Name = "Index";
            this.Index.Visible = false;
            // 
            // Mode
            // 
            this.Mode.DataPropertyName = "Mode";
            this.Mode.HeaderText = "Mode";
            this.Mode.Name = "Mode";
            this.Mode.Visible = false;
            // 
            // PurchaseTransactionItemGroupFKey
            // 
            this.PurchaseTransactionItemGroupFKey.DataPropertyName = "PurchaseTransactionItemGroupFKey";
            this.PurchaseTransactionItemGroupFKey.HeaderText = "PurchaseTransactionItemGroupFKey";
            this.PurchaseTransactionItemGroupFKey.Name = "PurchaseTransactionItemGroupFKey";
            this.PurchaseTransactionItemGroupFKey.Visible = false;
            // 
            // PurchaseTransactionHsnCode
            // 
            this.PurchaseTransactionHsnCode.DataPropertyName = "PurchaseTransactionHsnCode";
            this.PurchaseTransactionHsnCode.HeaderText = "Hsn Code";
            this.PurchaseTransactionHsnCode.Name = "PurchaseTransactionHsnCode";
            // 
            // Dicount
            // 
            this.Dicount.DataPropertyName = "PurchaseTransactionDiscPer";
            this.Dicount.HeaderText = "Disc Per";
            this.Dicount.Name = "Dicount";
            // 
            // DicountAmt
            // 
            this.DicountAmt.DataPropertyName = "PurchaseTransactionDiscAmt";
            this.DicountAmt.HeaderText = "Disc Amt";
            this.DicountAmt.Name = "DicountAmt";
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.txtDiscountAmt);
            this.panel3.Controls.Add(this.label19);
            this.panel3.Controls.Add(this.txtDiscountPer);
            this.panel3.Controls.Add(this.label27);
            this.panel3.Controls.Add(this.txtGstAmt);
            this.panel3.Controls.Add(this.label40);
            this.panel3.Controls.Add(this.txtIgstPer);
            this.panel3.Controls.Add(this.label42);
            this.panel3.Controls.Add(this.cmbReverseCharge);
            this.panel3.Controls.Add(this.label38);
            this.panel3.Controls.Add(this.txtTaxableValue);
            this.panel3.Controls.Add(this.label47);
            this.panel3.Controls.Add(this.txtSgstAmt);
            this.panel3.Controls.Add(this.label45);
            this.panel3.Controls.Add(this.txtSGSTPer);
            this.panel3.Controls.Add(this.label46);
            this.panel3.Controls.Add(this.textBox2);
            this.panel3.Controls.Add(this.txtCGSTAmt);
            this.panel3.Controls.Add(this.label41);
            this.panel3.Controls.Add(this.txtCgstPer);
            this.panel3.Controls.Add(this.label18);
            this.panel3.Controls.Add(this.txtHsnCode);
            this.panel3.Controls.Add(this.label36);
            this.panel3.Controls.Add(this.txtPoNo);
            this.panel3.Controls.Add(this.label34);
            this.panel3.Controls.Add(this.txtItemStock);
            this.panel3.Controls.Add(this.label26);
            this.panel3.Controls.Add(this.cmbItemGroup);
            this.panel3.Controls.Add(this.label16);
            this.panel3.Controls.Add(this.btnDeleteItem);
            this.panel3.Controls.Add(this.btnAddItem);
            this.panel3.Controls.Add(this.txtIndex);
            this.panel3.Controls.Add(this.txtPurchaseTransactionKey);
            this.panel3.Controls.Add(this.txtTotal);
            this.panel3.Controls.Add(this.label24);
            this.panel3.Controls.Add(this.txtRate);
            this.panel3.Controls.Add(this.label22);
            this.panel3.Controls.Add(this.txtQty);
            this.panel3.Controls.Add(this.label23);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtPreviousRate);
            this.panel3.Controls.Add(this.label20);
            this.panel3.Controls.Add(this.label21);
            this.panel3.Controls.Add(this.cmbItem);
            this.panel3.Location = new System.Drawing.Point(0, 100);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(783, 154);
            this.panel3.TabIndex = 11;
            // 
            // txtDiscountAmt
            // 
            this.txtDiscountAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountAmt.Location = new System.Drawing.Point(682, 91);
            this.txtDiscountAmt.Multiline = true;
            this.txtDiscountAmt.Name = "txtDiscountAmt";
            this.txtDiscountAmt.ReadOnly = true;
            this.txtDiscountAmt.Size = new System.Drawing.Size(58, 26);
            this.txtDiscountAmt.TabIndex = 69;
            this.txtDiscountAmt.TabStop = false;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(619, 96);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(52, 13);
            this.label19.TabIndex = 71;
            this.label19.Text = "Disc Amt:";
            // 
            // txtDiscountPer
            // 
            this.txtDiscountPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountPer.Location = new System.Drawing.Point(552, 92);
            this.txtDiscountPer.Multiline = true;
            this.txtDiscountPer.Name = "txtDiscountPer";
            this.txtDiscountPer.Size = new System.Drawing.Size(59, 26);
            this.txtDiscountPer.TabIndex = 68;
            this.txtDiscountPer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtDiscountPer_KeyUp);
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Location = new System.Drawing.Point(484, 96);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(50, 13);
            this.label27.TabIndex = 70;
            this.label27.Text = "Disc Per:";
            // 
            // txtGstAmt
            // 
            this.txtGstAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGstAmt.Location = new System.Drawing.Point(200, 90);
            this.txtGstAmt.Multiline = true;
            this.txtGstAmt.Name = "txtGstAmt";
            this.txtGstAmt.ReadOnly = true;
            this.txtGstAmt.Size = new System.Drawing.Size(67, 26);
            this.txtGstAmt.TabIndex = 24;
            this.txtGstAmt.TabStop = false;
            // 
            // label40
            // 
            this.label40.AutoSize = true;
            this.label40.Location = new System.Drawing.Point(137, 95);
            this.label40.Name = "label40";
            this.label40.Size = new System.Drawing.Size(56, 13);
            this.label40.TabIndex = 67;
            this.label40.Text = "IGST Amt:";
            // 
            // txtIgstPer
            // 
            this.txtIgstPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgstPer.Location = new System.Drawing.Point(77, 90);
            this.txtIgstPer.Multiline = true;
            this.txtIgstPer.Name = "txtIgstPer";
            this.txtIgstPer.Size = new System.Drawing.Size(59, 26);
            this.txtIgstPer.TabIndex = 15;
            this.txtIgstPer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtIgstPer_KeyUp);
            // 
            // label42
            // 
            this.label42.AutoSize = true;
            this.label42.Location = new System.Drawing.Point(9, 94);
            this.label42.Name = "label42";
            this.label42.Size = new System.Drawing.Size(54, 13);
            this.label42.TabIndex = 65;
            this.label42.Text = "IGST Per:";
            // 
            // txtTaxableValue
            // 
            this.txtTaxableValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaxableValue.Location = new System.Drawing.Point(200, 57);
            this.txtTaxableValue.Multiline = true;
            this.txtTaxableValue.Name = "txtTaxableValue";
            this.txtTaxableValue.ReadOnly = true;
            this.txtTaxableValue.Size = new System.Drawing.Size(63, 26);
            this.txtTaxableValue.TabIndex = 18;
            this.txtTaxableValue.TabStop = false;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(126, 63);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(78, 13);
            this.label47.TabIndex = 63;
            this.label47.Text = "Taxable Value:";
            // 
            // txtSgstAmt
            // 
            this.txtSgstAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSgstAmt.Location = new System.Drawing.Point(702, 59);
            this.txtSgstAmt.Multiline = true;
            this.txtSgstAmt.Name = "txtSgstAmt";
            this.txtSgstAmt.ReadOnly = true;
            this.txtSgstAmt.Size = new System.Drawing.Size(58, 26);
            this.txtSgstAmt.TabIndex = 22;
            this.txtSgstAmt.TabStop = false;
            // 
            // label45
            // 
            this.label45.AutoSize = true;
            this.label45.Location = new System.Drawing.Point(639, 64);
            this.label45.Name = "label45";
            this.label45.Size = new System.Drawing.Size(60, 13);
            this.label45.TabIndex = 61;
            this.label45.Text = "SGST Amt:";
            // 
            // txtSGSTPer
            // 
            this.txtSGSTPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSGSTPer.Location = new System.Drawing.Point(572, 60);
            this.txtSGSTPer.Multiline = true;
            this.txtSGSTPer.Name = "txtSGSTPer";
            this.txtSGSTPer.Size = new System.Drawing.Size(59, 26);
            this.txtSGSTPer.TabIndex = 14;
            this.txtSGSTPer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSGSTPer_KeyUp);
            // 
            // label46
            // 
            this.label46.AutoSize = true;
            this.label46.Location = new System.Drawing.Point(504, 64);
            this.label46.Name = "label46";
            this.label46.Size = new System.Drawing.Size(58, 13);
            this.label46.TabIndex = 59;
            this.label46.Text = "SGST Per:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(-429, 213);
            this.textBox2.Multiline = true;
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(46, 24);
            this.textBox2.TabIndex = 56;
            // 
            // txtCGSTAmt
            // 
            this.txtCGSTAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCGSTAmt.Location = new System.Drawing.Point(437, 61);
            this.txtCGSTAmt.Multiline = true;
            this.txtCGSTAmt.Name = "txtCGSTAmt";
            this.txtCGSTAmt.ReadOnly = true;
            this.txtCGSTAmt.Size = new System.Drawing.Size(68, 24);
            this.txtCGSTAmt.TabIndex = 20;
            this.txtCGSTAmt.TabStop = false;
            // 
            // label41
            // 
            this.label41.AutoSize = true;
            this.label41.Location = new System.Drawing.Point(374, 66);
            this.label41.Name = "label41";
            this.label41.Size = new System.Drawing.Size(60, 13);
            this.label41.TabIndex = 53;
            this.label41.Text = "CGST Amt:";
            // 
            // txtCgstPer
            // 
            this.txtCgstPer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCgstPer.Location = new System.Drawing.Point(325, 60);
            this.txtCgstPer.Multiline = true;
            this.txtCgstPer.Name = "txtCgstPer";
            this.txtCgstPer.Size = new System.Drawing.Size(46, 26);
            this.txtCgstPer.TabIndex = 13;
            this.txtCgstPer.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCgstPer_KeyUp);
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(266, 64);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(58, 13);
            this.label18.TabIndex = 51;
            this.label18.Text = "CGST Per:";
            // 
            // txtHsnCode
            // 
            this.txtHsnCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHsnCode.Location = new System.Drawing.Point(433, 89);
            this.txtHsnCode.Multiline = true;
            this.txtHsnCode.Name = "txtHsnCode";
            this.txtHsnCode.Size = new System.Drawing.Size(42, 26);
            this.txtHsnCode.TabIndex = 16;
            // 
            // label36
            // 
            this.label36.AutoSize = true;
            this.label36.Location = new System.Drawing.Point(379, 95);
            this.label36.Name = "label36";
            this.label36.Size = new System.Drawing.Size(57, 13);
            this.label36.TabIndex = 49;
            this.label36.Text = "Hsn Code:";
            // 
            // txtPoNo
            // 
            this.txtPoNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPoNo.Location = new System.Drawing.Point(555, 22);
            this.txtPoNo.Multiline = true;
            this.txtPoNo.Name = "txtPoNo";
            this.txtPoNo.Size = new System.Drawing.Size(43, 26);
            this.txtPoNo.TabIndex = 10;
            // 
            // label34
            // 
            this.label34.AutoSize = true;
            this.label34.Location = new System.Drawing.Point(513, 28);
            this.label34.Name = "label34";
            this.label34.Size = new System.Drawing.Size(40, 13);
            this.label34.TabIndex = 47;
            this.label34.Text = "Po No:";
            // 
            // txtItemStock
            // 
            this.txtItemStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemStock.Location = new System.Drawing.Point(464, 22);
            this.txtItemStock.Multiline = true;
            this.txtItemStock.Name = "txtItemStock";
            this.txtItemStock.ReadOnly = true;
            this.txtItemStock.Size = new System.Drawing.Size(46, 24);
            this.txtItemStock.TabIndex = 14;
            this.txtItemStock.TabStop = false;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Location = new System.Drawing.Point(400, 30);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(38, 13);
            this.label26.TabIndex = 44;
            this.label26.Text = "Stock:";
            // 
            // cmbItemGroup
            // 
            this.cmbItemGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbItemGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbItemGroup.FormattingEnabled = true;
            this.cmbItemGroup.Location = new System.Drawing.Point(75, 125);
            this.cmbItemGroup.Name = "cmbItemGroup";
            this.cmbItemGroup.Size = new System.Drawing.Size(178, 21);
            this.cmbItemGroup.TabIndex = 12;
            this.cmbItemGroup.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(5, 128);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 13);
            this.label16.TabIndex = 24;
            this.label16.Text = "Item Group.:";
            this.label16.Visible = false;
            // 
            // btnDeleteItem
            // 
            this.btnDeleteItem.Location = new System.Drawing.Point(458, 117);
            this.btnDeleteItem.Name = "btnDeleteItem";
            this.btnDeleteItem.Size = new System.Drawing.Size(75, 30);
            this.btnDeleteItem.TabIndex = 18;
            this.btnDeleteItem.Text = "Delete";
            this.btnDeleteItem.UseVisualStyleBackColor = true;
            this.btnDeleteItem.Visible = false;
            this.btnDeleteItem.Click += new System.EventHandler(this.btnDeleteItem_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(352, 118);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(75, 30);
            this.btnAddItem.TabIndex = 17;
            this.btnAddItem.Text = "Add";
            this.btnAddItem.UseVisualStyleBackColor = true;
            this.btnAddItem.Click += new System.EventHandler(this.btnAddItem_Click);
            // 
            // txtIndex
            // 
            this.txtIndex.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIndex.Location = new System.Drawing.Point(7, 3);
            this.txtIndex.Multiline = true;
            this.txtIndex.Name = "txtIndex";
            this.txtIndex.Size = new System.Drawing.Size(128, 20);
            this.txtIndex.TabIndex = 0;
            this.txtIndex.Text = "0";
            this.txtIndex.Visible = false;
            // 
            // txtPurchaseTransactionKey
            // 
            this.txtPurchaseTransactionKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPurchaseTransactionKey.Location = new System.Drawing.Point(141, 3);
            this.txtPurchaseTransactionKey.Multiline = true;
            this.txtPurchaseTransactionKey.Name = "txtPurchaseTransactionKey";
            this.txtPurchaseTransactionKey.Size = new System.Drawing.Size(128, 20);
            this.txtPurchaseTransactionKey.TabIndex = 0;
            this.txtPurchaseTransactionKey.Text = "0";
            this.txtPurchaseTransactionKey.Visible = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(313, 89);
            this.txtTotal.Multiline = true;
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.ReadOnly = true;
            this.txtTotal.Size = new System.Drawing.Size(57, 26);
            this.txtTotal.TabIndex = 25;
            this.txtTotal.TabStop = false;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Location = new System.Drawing.Point(273, 98);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(34, 13);
            this.label24.TabIndex = 39;
            this.label24.Text = "Total:";
            // 
            // txtRate
            // 
            this.txtRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRate.Location = new System.Drawing.Point(77, 56);
            this.txtRate.Multiline = true;
            this.txtRate.Name = "txtRate";
            this.txtRate.Size = new System.Drawing.Size(46, 26);
            this.txtRate.TabIndex = 12;
            this.txtRate.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRate_KeyUp);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Location = new System.Drawing.Point(44, 62);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 13);
            this.label22.TabIndex = 37;
            this.label22.Text = "Rate:";
            // 
            // txtQty
            // 
            this.txtQty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQty.Location = new System.Drawing.Point(630, 20);
            this.txtQty.Multiline = true;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(48, 26);
            this.txtQty.TabIndex = 11;
            this.txtQty.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtQty_KeyUp);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(602, 26);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(26, 13);
            this.label23.TabIndex = 35;
            this.label23.Text = "Qty:";
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(291, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(81, 20);
            this.label10.TabIndex = 33;
            this.label10.Text = "Save Item";
            // 
            // txtPreviousRate
            // 
            this.txtPreviousRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPreviousRate.Location = new System.Drawing.Point(350, 23);
            this.txtPreviousRate.Multiline = true;
            this.txtPreviousRate.Name = "txtPreviousRate";
            this.txtPreviousRate.ReadOnly = true;
            this.txtPreviousRate.Size = new System.Drawing.Size(47, 29);
            this.txtPreviousRate.TabIndex = 13;
            this.txtPreviousRate.TabStop = false;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(299, 30);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(52, 13);
            this.label20.TabIndex = 27;
            this.label20.Text = "Pre Rate:";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Location = new System.Drawing.Point(5, 28);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(69, 13);
            this.label21.TabIndex = 25;
            this.label21.Text = " Select Item.:";
            // 
            // cmbItem
            // 
            this.cmbItem.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbItem.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItem.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbItem.FormattingEnabled = true;
            this.cmbItem.Location = new System.Drawing.Point(79, 26);
            this.cmbItem.Name = "cmbItem";
            this.cmbItem.Size = new System.Drawing.Size(206, 21);
            this.cmbItem.TabIndex = 9;
            this.cmbItem.SelectedIndexChanged += new System.EventHandler(this.cmbItem_SelectedIndexChanged);
            // 
            // txtIgstAmt
            // 
            this.txtIgstAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIgstAmt.Location = new System.Drawing.Point(1296, 471);
            this.txtIgstAmt.Multiline = true;
            this.txtIgstAmt.Name = "txtIgstAmt";
            this.txtIgstAmt.ReadOnly = true;
            this.txtIgstAmt.Size = new System.Drawing.Size(68, 27);
            this.txtIgstAmt.TabIndex = 98;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(1241, 476);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(59, 13);
            this.label14.TabIndex = 99;
            this.label14.Text = "IGST Amt :";
            // 
            // txtPendingAmount
            // 
            this.txtPendingAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPendingAmount.Location = new System.Drawing.Point(1152, 502);
            this.txtPendingAmount.Multiline = true;
            this.txtPendingAmount.Name = "txtPendingAmount";
            this.txtPendingAmount.ReadOnly = true;
            this.txtPendingAmount.Size = new System.Drawing.Size(83, 27);
            this.txtPendingAmount.TabIndex = 91;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1082, 507);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 97;
            this.label2.Text = "Pd Amount :";
            // 
            // txtPaidAmount
            // 
            this.txtPaidAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPaidAmount.Location = new System.Drawing.Point(990, 502);
            this.txtPaidAmount.Multiline = true;
            this.txtPaidAmount.Name = "txtPaidAmount";
            this.txtPaidAmount.ReadOnly = true;
            this.txtPaidAmount.Size = new System.Drawing.Size(87, 27);
            this.txtPaidAmount.TabIndex = 90;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(923, 507);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 96;
            this.label4.Text = "Paid Amt:";
            // 
            // txtAddTaxAmount
            // 
            this.txtAddTaxAmount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddTaxAmount.Location = new System.Drawing.Point(1152, 471);
            this.txtAddTaxAmount.Multiline = true;
            this.txtAddTaxAmount.Name = "txtAddTaxAmount";
            this.txtAddTaxAmount.ReadOnly = true;
            this.txtAddTaxAmount.Size = new System.Drawing.Size(83, 27);
            this.txtAddTaxAmount.TabIndex = 88;
            // 
            // lblAddTaxAmt
            // 
            this.lblAddTaxAmt.AutoSize = true;
            this.lblAddTaxAmt.Location = new System.Drawing.Point(1087, 476);
            this.lblAddTaxAmt.Name = "lblAddTaxAmt";
            this.lblAddTaxAmt.Size = new System.Drawing.Size(63, 13);
            this.lblAddTaxAmt.TabIndex = 95;
            this.lblAddTaxAmt.Text = "SGST Amt :";
            // 
            // txtVatAmt
            // 
            this.txtVatAmt.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVatAmt.Location = new System.Drawing.Point(985, 471);
            this.txtVatAmt.Multiline = true;
            this.txtVatAmt.Name = "txtVatAmt";
            this.txtVatAmt.ReadOnly = true;
            this.txtVatAmt.Size = new System.Drawing.Size(87, 27);
            this.txtVatAmt.TabIndex = 87;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Location = new System.Drawing.Point(919, 476);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(63, 13);
            this.label25.TabIndex = 94;
            this.label25.Text = "CGST Amt :";
            // 
            // txtGTotal
            // 
            this.txtGTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGTotal.Location = new System.Drawing.Point(817, 502);
            this.txtGTotal.Multiline = true;
            this.txtGTotal.Name = "txtGTotal";
            this.txtGTotal.ReadOnly = true;
            this.txtGTotal.Size = new System.Drawing.Size(88, 27);
            this.txtGTotal.TabIndex = 89;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(771, 511);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 93;
            this.label5.Text = "G.Total:";
            // 
            // txtMainTotal
            // 
            this.txtMainTotal.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMainTotal.Location = new System.Drawing.Point(817, 469);
            this.txtMainTotal.Multiline = true;
            this.txtMainTotal.Name = "txtMainTotal";
            this.txtMainTotal.ReadOnly = true;
            this.txtMainTotal.Size = new System.Drawing.Size(88, 27);
            this.txtMainTotal.TabIndex = 86;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(782, 474);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 92;
            this.label11.Text = "Total:";
            // 
            // txtRoundoff
            // 
            this.txtRoundoff.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoundoff.Location = new System.Drawing.Point(989, 542);
            this.txtRoundoff.Multiline = true;
            this.txtRoundoff.Name = "txtRoundoff";
            this.txtRoundoff.Size = new System.Drawing.Size(88, 27);
            this.txtRoundoff.TabIndex = 28;
            this.txtRoundoff.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtRoundoff_KeyUp);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(930, 551);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 101;
            this.label12.Text = "Round off:";
            // 
            // cmbRounoffOption
            // 
            this.cmbRounoffOption.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbRounoffOption.FormattingEnabled = true;
            this.cmbRounoffOption.ItemHeight = 13;
            this.cmbRounoffOption.Items.AddRange(new object[] {
            "Minus",
            "Plus"});
            this.cmbRounoffOption.Location = new System.Drawing.Point(816, 548);
            this.cmbRounoffOption.Name = "cmbRounoffOption";
            this.cmbRounoffOption.Size = new System.Drawing.Size(89, 21);
            this.cmbRounoffOption.TabIndex = 27;
            this.cmbRounoffOption.SelectedIndexChanged += new System.EventHandler(this.cmbRounoffOption_SelectedIndexChanged);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(760, 551);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(54, 13);
            this.label15.TabIndex = 103;
            this.label15.Text = "Round off";
            // 
            // txtCartage
            // 
            this.txtCartage.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCartage.Location = new System.Drawing.Point(1147, 537);
            this.txtCartage.Multiline = true;
            this.txtCartage.Name = "txtCartage";
            this.txtCartage.Size = new System.Drawing.Size(88, 27);
            this.txtCartage.TabIndex = 29;
            this.txtCartage.TextChanged += new System.EventHandler(this.txtCartage_TextChanged);
            this.txtCartage.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtCartage_KeyUp);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(1088, 546);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(47, 13);
            this.label17.TabIndex = 105;
            this.label17.Text = "Cartage:";
            this.label17.Click += new System.EventHandler(this.label17_Click);
            // 
            // frmPurchaseMaster
            // 
            this.AcceptButton = this.btnAddPurchase;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(1338, 673);
            this.Controls.Add(this.txtCartage);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.cmbRounoffOption);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtRoundoff);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtIgstAmt);
            this.Controls.Add(this.dgvPurchaseView);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.txtPendingAmount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtPaidAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtAddTaxAmount);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.lblAddTaxAmt);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.txtVatAmt);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.txtGTotal);
            this.Controls.Add(this.btnDeletePurchase);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnAddPurchase);
            this.Controls.Add(this.txtMainTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtBillNo);
            this.Controls.Add(this.label8);
            this.Name = "frmPurchaseMaster";
            this.Text = "frmPurchaseMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPurchaseMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPaymentDetail)).EndInit();
            this.panel5.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPurchaseView)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblSupplierDetail;
        private System.Windows.Forms.ComboBox cmbSupplier;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtBillNo;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtChlnNo;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker dtpDate;
        private System.Windows.Forms.DateTimePicker dtpChalanDt;
        private System.Windows.Forms.TextBox txtInvoiceNo;
        private System.Windows.Forms.Button btnAddPurchase;
        private System.Windows.Forms.Button btnDeletePurchase;
        private System.Windows.Forms.ComboBox cmbPurchaseType;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.DataGridView dgvPaymentDetail;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.TextBox txtPaymentIndex;
        private System.Windows.Forms.TextBox txtPurchaseTransactionPayKey;
        private System.Windows.Forms.Button btnDeletePayment;
        private System.Windows.Forms.Button btnAddPayment;
        private System.Windows.Forms.Label lblChequeDate;
        private System.Windows.Forms.TextBox txtPayAmount;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.Label lblBankName;
        private System.Windows.Forms.ComboBox cmbBank;
        private System.Windows.Forms.ComboBox cmbPaymentMode;
        private System.Windows.Forms.DateTimePicker dtpPaymentDate;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.TextBox txtChequeNo;
        private System.Windows.Forms.Label lblChequeNo;
        private System.Windows.Forms.DateTimePicker dtpChequeDate;
        private System.Windows.Forms.TextBox txtTransportDetail;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.ComboBox cmbReverseCharge;
        private System.Windows.Forms.Label label38;
        private System.Windows.Forms.TextBox txtVehicleNo;
        private System.Windows.Forms.Label label39;
        private System.Windows.Forms.DataGridView dgvPurchaseView;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox txtGstAmt;
        private System.Windows.Forms.Label label40;
        private System.Windows.Forms.TextBox txtIgstPer;
        private System.Windows.Forms.Label label42;
        private System.Windows.Forms.TextBox txtTaxableValue;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.TextBox txtSgstAmt;
        private System.Windows.Forms.Label label45;
        private System.Windows.Forms.TextBox txtSGSTPer;
        private System.Windows.Forms.Label label46;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtCGSTAmt;
        private System.Windows.Forms.Label label41;
        private System.Windows.Forms.TextBox txtCgstPer;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox txtHsnCode;
        private System.Windows.Forms.Label label36;
        private System.Windows.Forms.TextBox txtPoNo;
        private System.Windows.Forms.Label label34;
        private System.Windows.Forms.TextBox txtItemStock;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.ComboBox cmbItemGroup;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtIndex;
        private System.Windows.Forms.TextBox txtPurchaseTransactionKey;
        private System.Windows.Forms.Button btnDeleteItem;
        private System.Windows.Forms.Button btnAddItem;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtRate;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtPreviousRate;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox cmbItem;
        private System.Windows.Forms.TextBox txtIgstAmt;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtPendingAmount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPaidAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtAddTaxAmount;
        private System.Windows.Forms.Label lblAddTaxAmt;
        private System.Windows.Forms.TextBox txtVatAmt;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.TextBox txtGTotal;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtMainTotal;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtRoundoff;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox cmbRounoffOption;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Button btnLoadSupplier;
        private System.Windows.Forms.Button btnAddSupplier;
        private System.Windows.Forms.Button btnLoadBank;
        private System.Windows.Forms.Button btnAddBank;
        private System.Windows.Forms.TextBox txtCartage;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.DataGridViewLinkColumn dataGridViewLinkColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionPayType;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionPayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionPayAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionPayBankFKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionPayBankFKeyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionPayChequeDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionPayBankChequeNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionPayKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionPayPurchaseMasterFKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn10;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseActualTransactionPayDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseActualTransactionCheckDate;
        private System.Windows.Forms.TextBox txtDiscountAmt;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.TextBox txtDiscountPer;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.DataGridViewLinkColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionItemGroupFKeyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionItemFKeyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionPoNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionTaxableAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionCGSTPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionCGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionSGSTPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionSGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionIGSTPer;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionIGSTAmt;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionTotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionItemFKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionSaleMasterFKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn Index;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mode;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionItemGroupFKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn PurchaseTransactionHsnCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dicount;
        private System.Windows.Forms.DataGridViewTextBoxColumn DicountAmt;

    }
}