namespace SenseInventoryLogoUI.Forms
{
    partial class frmCustomer
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
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtSearchAddress = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.btnSearch = new System.Windows.Forms.Button();
            this.txtSearchContactPerson = new System.Windows.Forms.TextBox();
            this.txtSearchCustomer = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dtpGstTinDate = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpCstTinDate = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblCaptionRecord = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.dgvCustomerMaster = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtCustomerAddress = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtContactPerson = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtContactNo = new System.Windows.Forms.TextBox();
            this.txtcstTinNo = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtGstTinNo = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label12 = new System.Windows.Forms.Label();
            this.txtCustomerPanNo = new System.Windows.Forms.TextBox();
            this.Action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.CustomerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerContactPerson = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerContactNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerGSTNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerGSTDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCSTNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerCSTDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerActualGSTDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CustomerActualCSTDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.PanNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerMaster)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.txtSearchAddress);
            this.panel2.Controls.Add(this.label16);
            this.panel2.Controls.Add(this.label14);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.txtSearchContactPerson);
            this.panel2.Controls.Add(this.txtSearchCustomer);
            this.panel2.Controls.Add(this.label11);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 93);
            this.panel2.TabIndex = 1;
            // 
            // txtSearchAddress
            // 
            this.txtSearchAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchAddress.Location = new System.Drawing.Point(339, 51);
            this.txtSearchAddress.Multiline = true;
            this.txtSearchAddress.Name = "txtSearchAddress";
            this.txtSearchAddress.Size = new System.Drawing.Size(212, 32);
            this.txtSearchAddress.TabIndex = 10;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(282, 60);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(51, 13);
            this.label16.TabIndex = 21;
            this.label16.Text = "Address.:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(557, 59);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(67, 13);
            this.label14.TabIndex = 18;
            this.label14.Text = "Contact No.:";
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(771, 53);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // txtSearchContactPerson
            // 
            this.txtSearchContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchContactPerson.Location = new System.Drawing.Point(629, 54);
            this.txtSearchContactPerson.Multiline = true;
            this.txtSearchContactPerson.Name = "txtSearchContactPerson";
            this.txtSearchContactPerson.Size = new System.Drawing.Size(126, 29);
            this.txtSearchContactPerson.TabIndex = 11;
            this.txtSearchContactPerson.TextChanged += new System.EventHandler(this.txtSearchContactPerson_TextChanged);
            // 
            // txtSearchCustomer
            // 
            this.txtSearchCustomer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchCustomer.Location = new System.Drawing.Point(95, 54);
            this.txtSearchCustomer.Multiline = true;
            this.txtSearchCustomer.Name = "txtSearchCustomer";
            this.txtSearchCustomer.Size = new System.Drawing.Size(182, 29);
            this.txtSearchCustomer.TabIndex = 9;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(1, 59);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(88, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Customer Name.:";
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.dtpGstTinDate);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.dtpCstTinDate);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1004, 44);
            this.panel4.TabIndex = 18;
            // 
            // dtpGstTinDate
            // 
            this.dtpGstTinDate.CustomFormat = "dd/MM/yyyy";
            this.dtpGstTinDate.Location = new System.Drawing.Point(162, 13);
            this.dtpGstTinDate.Name = "dtpGstTinDate";
            this.dtpGstTinDate.Size = new System.Drawing.Size(286, 20);
            this.dtpGstTinDate.TabIndex = 8;
            this.dtpGstTinDate.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(86, 14);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(70, 13);
            this.label7.TabIndex = 25;
            this.label7.Text = "Gst Tin Date:";
            this.label7.Visible = false;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(472, 4);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 33);
            this.label10.TabIndex = 17;
            this.label10.Text = "Search:";
            // 
            // dtpCstTinDate
            // 
            this.dtpCstTinDate.CustomFormat = "dd/MM/yyyy";
            this.dtpCstTinDate.Location = new System.Drawing.Point(808, 6);
            this.dtpCstTinDate.Name = "dtpCstTinDate";
            this.dtpCstTinDate.Size = new System.Drawing.Size(191, 20);
            this.dtpCstTinDate.TabIndex = 6;
            this.dtpCstTinDate.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(717, 13);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Cst Tin Date:";
            this.label6.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblRecordCount);
            this.panel5.Controls.Add(this.lblCaptionRecord);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 226);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1008, 44);
            this.panel5.TabIndex = 19;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(118, 21);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(18, 20);
            this.lblRecordCount.TabIndex = 31;
            this.lblRecordCount.Text = "0";
            // 
            // lblCaptionRecord
            // 
            this.lblCaptionRecord.AutoSize = true;
            this.lblCaptionRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionRecord.Location = new System.Drawing.Point(3, 21);
            this.lblCaptionRecord.Name = "lblCaptionRecord";
            this.lblCaptionRecord.Size = new System.Drawing.Size(120, 20);
            this.lblCaptionRecord.TabIndex = 30;
            this.lblCaptionRecord.Text = "Record Count : ";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(483, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 33);
            this.label13.TabIndex = 17;
            this.label13.Text = "Detail:";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dgvCustomerMaster);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel6.Location = new System.Drawing.Point(0, 270);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1008, 370);
            this.panel6.TabIndex = 20;
            // 
            // dgvCustomerMaster
            // 
            this.dgvCustomerMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomerMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.CustomerName,
            this.CustomerAddress,
            this.CustomerContactPerson,
            this.CustomerContactNo,
            this.CustomerGSTNo,
            this.CustomerGSTDate,
            this.CustomerCSTNo,
            this.CustomerCSTDate,
            this.CustomerID,
            this.CustomerActualGSTDate,
            this.CustomerActualCSTDate,
            this.PanNo});
            this.dgvCustomerMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCustomerMaster.Location = new System.Drawing.Point(0, 0);
            this.dgvCustomerMaster.Name = "dgvCustomerMaster";
            this.dgvCustomerMaster.Size = new System.Drawing.Size(1008, 370);
            this.dgvCustomerMaster.TabIndex = 0;
            this.dgvCustomerMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCustomerMaster_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Customer Name.:";
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerName.Location = new System.Drawing.Point(95, 53);
            this.txtCustomerName.Multiline = true;
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(182, 29);
            this.txtCustomerName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(282, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Address.:";
            // 
            // txtCustomerAddress
            // 
            this.txtCustomerAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerAddress.Location = new System.Drawing.Point(339, 53);
            this.txtCustomerAddress.Multiline = true;
            this.txtCustomerAddress.Name = "txtCustomerAddress";
            this.txtCustomerAddress.Size = new System.Drawing.Size(212, 40);
            this.txtCustomerAddress.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(557, 58);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "State Code.:";
            // 
            // txtContactPerson
            // 
            this.txtContactPerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactPerson.Location = new System.Drawing.Point(629, 53);
            this.txtContactPerson.Multiline = true;
            this.txtContactPerson.Name = "txtContactPerson";
            this.txtContactPerson.Size = new System.Drawing.Size(126, 29);
            this.txtContactPerson.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(759, 59);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Contact No.:";
            // 
            // txtContactNo
            // 
            this.txtContactNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContactNo.Location = new System.Drawing.Point(825, 53);
            this.txtContactNo.Multiline = true;
            this.txtContactNo.Name = "txtContactNo";
            this.txtContactNo.Size = new System.Drawing.Size(175, 29);
            this.txtContactNo.TabIndex = 4;
            // 
            // txtcstTinNo
            // 
            this.txtcstTinNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcstTinNo.Location = new System.Drawing.Point(95, 96);
            this.txtcstTinNo.Multiline = true;
            this.txtcstTinNo.Name = "txtcstTinNo";
            this.txtcstTinNo.Size = new System.Drawing.Size(182, 29);
            this.txtcstTinNo.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(771, 88);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(877, 87);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtKey);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1004, 44);
            this.panel3.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(478, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 33);
            this.label9.TabIndex = 17;
            this.label9.Text = "Entry:";
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(875, 6);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(125, 29);
            this.txtKey.TabIndex = 17;
            this.txtKey.Text = "0";
            this.txtKey.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(3, 91);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(38, 13);
            this.label5.TabIndex = 20;
            this.label5.Text = "State.:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(278, 96);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 23;
            this.label8.Text = "Gst Tin No.:";
            // 
            // txtGstTinNo
            // 
            this.txtGstTinNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGstTinNo.Location = new System.Drawing.Point(339, 96);
            this.txtGstTinNo.Multiline = true;
            this.txtGstTinNo.Name = "txtGstTinNo";
            this.txtGstTinNo.Size = new System.Drawing.Size(212, 29);
            this.txtGstTinNo.TabIndex = 6;
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.txtGstTinNo);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtCustomerPanNo);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtcstTinNo);
            this.panel1.Controls.Add(this.txtContactNo);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.txtContactPerson);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtCustomerAddress);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txtCustomerName);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 133);
            this.panel1.TabIndex = 0;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(562, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(49, 13);
            this.label12.TabIndex = 25;
            this.label12.Text = "Pan No.:";
            // 
            // txtCustomerPanNo
            // 
            this.txtCustomerPanNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerPanNo.Location = new System.Drawing.Point(629, 89);
            this.txtCustomerPanNo.Multiline = true;
            this.txtCustomerPanNo.Name = "txtCustomerPanNo";
            this.txtCustomerPanNo.Size = new System.Drawing.Size(126, 29);
            this.txtCustomerPanNo.TabIndex = 7;
            // 
            // Action
            // 
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Text = "Edit";
            this.Action.UseColumnTextForLinkValue = true;
            this.Action.Width = 50;
            // 
            // CustomerName
            // 
            this.CustomerName.DataPropertyName = "CustomerName";
            this.CustomerName.HeaderText = "Customer Name";
            this.CustomerName.Name = "CustomerName";
            this.CustomerName.Width = 250;
            // 
            // CustomerAddress
            // 
            this.CustomerAddress.DataPropertyName = "CustomerAddress";
            this.CustomerAddress.HeaderText = "Address";
            this.CustomerAddress.Name = "CustomerAddress";
            this.CustomerAddress.Width = 515;
            // 
            // CustomerContactPerson
            // 
            this.CustomerContactPerson.DataPropertyName = "CustomerContactPerson";
            this.CustomerContactPerson.HeaderText = "State Code";
            this.CustomerContactPerson.Name = "CustomerContactPerson";
            this.CustomerContactPerson.Width = 200;
            // 
            // CustomerContactNo
            // 
            this.CustomerContactNo.DataPropertyName = "CustomerContactNo";
            this.CustomerContactNo.HeaderText = "Contact No";
            this.CustomerContactNo.Name = "CustomerContactNo";
            // 
            // CustomerGSTNo
            // 
            this.CustomerGSTNo.DataPropertyName = "CustomerGSTNo";
            this.CustomerGSTNo.HeaderText = "GST No";
            this.CustomerGSTNo.Name = "CustomerGSTNo";
            // 
            // CustomerGSTDate
            // 
            this.CustomerGSTDate.DataPropertyName = "CustomerGSTDate";
            this.CustomerGSTDate.HeaderText = "Gst Date";
            this.CustomerGSTDate.Name = "CustomerGSTDate";
            this.CustomerGSTDate.Visible = false;
            // 
            // CustomerCSTNo
            // 
            this.CustomerCSTNo.DataPropertyName = "CustomerCSTNo";
            this.CustomerCSTNo.HeaderText = "State";
            this.CustomerCSTNo.Name = "CustomerCSTNo";
            // 
            // CustomerCSTDate
            // 
            this.CustomerCSTDate.DataPropertyName = "CustomerCSTDate";
            this.CustomerCSTDate.HeaderText = "Cst Date";
            this.CustomerCSTDate.Name = "CustomerCSTDate";
            this.CustomerCSTDate.Visible = false;
            // 
            // CustomerID
            // 
            this.CustomerID.DataPropertyName = "CustomerID";
            this.CustomerID.HeaderText = "CustomerKey";
            this.CustomerID.Name = "CustomerID";
            this.CustomerID.Visible = false;
            // 
            // CustomerActualGSTDate
            // 
            this.CustomerActualGSTDate.DataPropertyName = "CustomerActualGSTDate";
            this.CustomerActualGSTDate.HeaderText = "GDate";
            this.CustomerActualGSTDate.Name = "CustomerActualGSTDate";
            this.CustomerActualGSTDate.Visible = false;
            // 
            // CustomerActualCSTDate
            // 
            this.CustomerActualCSTDate.DataPropertyName = "CustomerActualCSTDate";
            this.CustomerActualCSTDate.HeaderText = "CDate";
            this.CustomerActualCSTDate.Name = "CustomerActualCSTDate";
            this.CustomerActualCSTDate.Visible = false;
            // 
            // PanNo
            // 
            this.PanNo.DataPropertyName = "CustomerPanNo";
            this.PanNo.HeaderText = "Pan No";
            this.PanNo.Name = "PanNo";
            // 
            // frmCustomer
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 640);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmCustomer";
            this.Text = "frmCustomer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCustomer_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomerMaster)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtSearchContactPerson;
        private System.Windows.Forms.TextBox txtSearchCustomer;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.DataGridView dgvCustomerMaster;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtSearchAddress;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCustomerAddress;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtContactPerson;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtContactNo;
        private System.Windows.Forms.TextBox txtcstTinNo;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker dtpCstTinDate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtGstTinNo;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker dtpGstTinDate;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblCaptionRecord;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtCustomerPanNo;
        private System.Windows.Forms.DataGridViewLinkColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerContactPerson;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerContactNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerGSTNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerGSTDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCSTNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerCSTDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerID;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerActualGSTDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn CustomerActualCSTDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn PanNo;

    }
}