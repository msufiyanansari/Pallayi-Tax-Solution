namespace SenseInventoryLogoUI.Forms
{
    partial class frmItemMaster
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
            this.txtHsnCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtItemWeight = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.btnBrowse = new System.Windows.Forms.Button();
            this.pctBoxItemImage = new System.Windows.Forms.PictureBox();
            this.txtItemStock = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemDescription = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cmbItemGroup = new System.Windows.Forms.ComboBox();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.txtItemRate = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblCaptionRecord = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchItemRate = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cmbSearchItemGroup = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSearchItemName = new System.Windows.Forms.TextBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvItemMaster = new System.Windows.Forms.DataGridView();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.Action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.ItemMasterKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemMasterGroupFKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemMasterGroupFKeyName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemMasterName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemMasterRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemMasterDescription = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemMasterStock = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemWeight = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HsnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxItemImage)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemMaster)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtHsnCode);
            this.panel1.Controls.Add(this.label12);
            this.panel1.Controls.Add(this.btnBrowse);
            this.panel1.Controls.Add(this.pctBoxItemImage);
            this.panel1.Controls.Add(this.txtItemStock);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.txtItemDescription);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.btnDelete);
            this.panel1.Controls.Add(this.btnAdd);
            this.panel1.Controls.Add(this.txtItemRate);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.txtItemName);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1008, 134);
            this.panel1.TabIndex = 1;
            // 
            // txtHsnCode
            // 
            this.txtHsnCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHsnCode.Location = new System.Drawing.Point(930, 53);
            this.txtHsnCode.Multiline = true;
            this.txtHsnCode.Name = "txtHsnCode";
            this.txtHsnCode.Size = new System.Drawing.Size(75, 29);
            this.txtHsnCode.TabIndex = 5;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(869, 59);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(60, 13);
            this.label12.TabIndex = 27;
            this.label12.Text = "Hsn Code.:";
            // 
            // txtItemWeight
            // 
            this.txtItemWeight.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemWeight.Location = new System.Drawing.Point(730, 10);
            this.txtItemWeight.Multiline = true;
            this.txtItemWeight.Name = "txtItemWeight";
            this.txtItemWeight.Size = new System.Drawing.Size(117, 29);
            this.txtItemWeight.TabIndex = 6;
            this.txtItemWeight.Visible = false;
            this.txtItemWeight.TextChanged += new System.EventHandler(this.txtItemWeight_TextChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(652, 19);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(70, 13);
            this.label11.TabIndex = 25;
            this.label11.Text = "Item Weight.:";
            this.label11.Visible = false;
            // 
            // btnBrowse
            // 
            this.btnBrowse.Location = new System.Drawing.Point(700, 248);
            this.btnBrowse.Name = "btnBrowse";
            this.btnBrowse.Size = new System.Drawing.Size(93, 27);
            this.btnBrowse.TabIndex = 23;
            this.btnBrowse.Text = "Browse";
            this.btnBrowse.UseVisualStyleBackColor = true;
            this.btnBrowse.Visible = false;
            this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
            // 
            // pctBoxItemImage
            // 
            this.pctBoxItemImage.Image = global::SenseInventoryLogoUI.Properties.Resources.blankImage;
            this.pctBoxItemImage.Location = new System.Drawing.Point(655, 212);
            this.pctBoxItemImage.Name = "pctBoxItemImage";
            this.pctBoxItemImage.Size = new System.Drawing.Size(173, 30);
            this.pctBoxItemImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pctBoxItemImage.TabIndex = 22;
            this.pctBoxItemImage.TabStop = false;
            this.pctBoxItemImage.Visible = false;
            // 
            // txtItemStock
            // 
            this.txtItemStock.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemStock.Location = new System.Drawing.Point(769, 53);
            this.txtItemStock.Multiline = true;
            this.txtItemStock.Name = "txtItemStock";
            this.txtItemStock.Size = new System.Drawing.Size(100, 29);
            this.txtItemStock.TabIndex = 4;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(706, 61);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(64, 13);
            this.label8.TabIndex = 21;
            this.label8.Text = "Item Stock.:";
            this.label8.Click += new System.EventHandler(this.label8_Click);
            // 
            // txtItemDescription
            // 
            this.txtItemDescription.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemDescription.Location = new System.Drawing.Point(525, 53);
            this.txtItemDescription.Multiline = true;
            this.txtItemDescription.Name = "txtItemDescription";
            this.txtItemDescription.Size = new System.Drawing.Size(178, 41);
            this.txtItemDescription.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(460, 58);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Description.:";
            // 
            // cmbItemGroup
            // 
            this.cmbItemGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbItemGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbItemGroup.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cmbItemGroup.FormattingEnabled = true;
            this.cmbItemGroup.Location = new System.Drawing.Point(76, 10);
            this.cmbItemGroup.Name = "cmbItemGroup";
            this.cmbItemGroup.Size = new System.Drawing.Size(269, 21);
            this.cmbItemGroup.TabIndex = 1;
            this.cmbItemGroup.Visible = false;
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(875, 3);
            this.txtKey.Multiline = true;
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(125, 29);
            this.txtKey.TabIndex = 17;
            this.txtKey.Text = "0";
            this.txtKey.Visible = false;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.txtKey);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1008, 44);
            this.panel3.TabIndex = 16;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(436, 2);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 33);
            this.label9.TabIndex = 17;
            this.label9.Text = "Entry:";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(545, 98);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 30);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Visible = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(330, 96);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 30);
            this.btnAdd.TabIndex = 7;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // txtItemRate
            // 
            this.txtItemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemRate.Location = new System.Drawing.Point(340, 55);
            this.txtItemRate.Multiline = true;
            this.txtItemRate.Name = "txtItemRate";
            this.txtItemRate.Size = new System.Drawing.Size(117, 29);
            this.txtItemRate.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(275, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Item Rate.:";
            // 
            // txtItemName
            // 
            this.txtItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtItemName.Location = new System.Drawing.Point(68, 54);
            this.txtItemName.Multiline = true;
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(202, 42);
            this.txtItemName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Item Name.:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Item Group.:";
            this.label1.Visible = false;
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel5.Controls.Add(this.lblRecordCount);
            this.panel5.Controls.Add(this.lblCaptionRecord);
            this.panel5.Controls.Add(this.label13);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 224);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1008, 38);
            this.panel5.TabIndex = 22;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(118, 16);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(18, 20);
            this.lblRecordCount.TabIndex = 33;
            this.lblRecordCount.Text = "0";
            // 
            // lblCaptionRecord
            // 
            this.lblCaptionRecord.AutoSize = true;
            this.lblCaptionRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionRecord.Location = new System.Drawing.Point(3, 16);
            this.lblCaptionRecord.Name = "lblCaptionRecord";
            this.lblCaptionRecord.Size = new System.Drawing.Size(120, 20);
            this.lblCaptionRecord.TabIndex = 32;
            this.lblCaptionRecord.Text = "Record Count : ";
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(427, 1);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(98, 33);
            this.label13.TabIndex = 17;
            this.label13.Text = "Detail:";
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtSearchItemRate);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.cmbSearchItemGroup);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.txtSearchItemName);
            this.panel2.Controls.Add(this.btnSearch);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 134);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1008, 90);
            this.panel2.TabIndex = 21;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(8, 56);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "Item Name.:";
            // 
            // txtSearchItemRate
            // 
            this.txtSearchItemRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItemRate.Location = new System.Drawing.Point(378, 53);
            this.txtSearchItemRate.Multiline = true;
            this.txtSearchItemRate.Name = "txtSearchItemRate";
            this.txtSearchItemRate.Size = new System.Drawing.Size(117, 29);
            this.txtSearchItemRate.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(322, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(59, 13);
            this.label6.TabIndex = 21;
            this.label6.Text = "Item Rate.:";
            // 
            // cmbSearchItemGroup
            // 
            this.cmbSearchItemGroup.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.cmbSearchItemGroup.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbSearchItemGroup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSearchItemGroup.FormattingEnabled = true;
            this.cmbSearchItemGroup.ItemHeight = 13;
            this.cmbSearchItemGroup.Location = new System.Drawing.Point(671, 53);
            this.cmbSearchItemGroup.Name = "cmbSearchItemGroup";
            this.cmbSearchItemGroup.Size = new System.Drawing.Size(269, 21);
            this.cmbSearchItemGroup.TabIndex = 8;
            this.cmbSearchItemGroup.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(600, 64);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 13);
            this.label5.TabIndex = 22;
            this.label5.Text = "Item Group.:";
            this.label5.Visible = false;
            // 
            // txtSearchItemName
            // 
            this.txtSearchItemName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearchItemName.Location = new System.Drawing.Point(73, 51);
            this.txtSearchItemName.Multiline = true;
            this.txtSearchItemName.Name = "txtSearchItemName";
            this.txtSearchItemName.Size = new System.Drawing.Size(245, 33);
            this.txtSearchItemName.TabIndex = 10;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(504, 51);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 30);
            this.btnSearch.TabIndex = 12;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // panel4
            // 
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel4.Controls.Add(this.label10);
            this.panel4.Controls.Add(this.txtItemWeight);
            this.panel4.Controls.Add(this.label11);
            this.panel4.Controls.Add(this.cmbItemGroup);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1004, 44);
            this.panel4.TabIndex = 18;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(412, 3);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(115, 33);
            this.label10.TabIndex = 17;
            this.label10.Text = "Search:";
            // 
            // dgvItemMaster
            // 
            this.dgvItemMaster.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dgvItemMaster.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvItemMaster.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.ItemMasterKey,
            this.ItemMasterGroupFKey,
            this.ItemMasterGroupFKeyName,
            this.ItemMasterName,
            this.ItemMasterRate,
            this.ItemMasterDescription,
            this.ItemMasterStock,
            this.ItemWeight,
            this.HsnCode});
            this.dgvItemMaster.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvItemMaster.Location = new System.Drawing.Point(0, 262);
            this.dgvItemMaster.Name = "dgvItemMaster";
            this.dgvItemMaster.Size = new System.Drawing.Size(1008, 378);
            this.dgvItemMaster.TabIndex = 23;
            this.dgvItemMaster.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvItemMaster_CellContentClick);
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Item Image";
            this.dataGridViewImageColumn1.Image = global::SenseInventoryLogoUI.Properties.Resources.blankImage;
            this.dataGridViewImageColumn1.ImageLayout = System.Windows.Forms.DataGridViewImageCellLayout.Stretch;
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Action.FillWeight = 50F;
            this.Action.Frozen = true;
            this.Action.HeaderText = "Action";
            this.Action.Name = "Action";
            this.Action.Text = "Edit";
            this.Action.UseColumnTextForLinkValue = true;
            this.Action.Width = 50;
            // 
            // ItemMasterKey
            // 
            this.ItemMasterKey.DataPropertyName = "ItemMasterKey";
            this.ItemMasterKey.HeaderText = "ItemMasterKey";
            this.ItemMasterKey.Name = "ItemMasterKey";
            this.ItemMasterKey.Visible = false;
            // 
            // ItemMasterGroupFKey
            // 
            this.ItemMasterGroupFKey.DataPropertyName = "ItemMasterGroupFKey";
            this.ItemMasterGroupFKey.HeaderText = "ItemMasterGroupFKey";
            this.ItemMasterGroupFKey.Name = "ItemMasterGroupFKey";
            this.ItemMasterGroupFKey.Visible = false;
            // 
            // ItemMasterGroupFKeyName
            // 
            this.ItemMasterGroupFKeyName.DataPropertyName = "ItemMasterGroupFKeyName";
            this.ItemMasterGroupFKeyName.HeaderText = "Item Group";
            this.ItemMasterGroupFKeyName.Name = "ItemMasterGroupFKeyName";
            this.ItemMasterGroupFKeyName.Visible = false;
            this.ItemMasterGroupFKeyName.Width = 220;
            // 
            // ItemMasterName
            // 
            this.ItemMasterName.DataPropertyName = "ItemMasterName";
            this.ItemMasterName.HeaderText = "Item Name";
            this.ItemMasterName.Name = "ItemMasterName";
            this.ItemMasterName.Width = 835;
            // 
            // ItemMasterRate
            // 
            this.ItemMasterRate.DataPropertyName = "ItemMasterRate";
            this.ItemMasterRate.HeaderText = "Rate";
            this.ItemMasterRate.Name = "ItemMasterRate";
            // 
            // ItemMasterDescription
            // 
            this.ItemMasterDescription.DataPropertyName = "ItemMasterDescription";
            this.ItemMasterDescription.HeaderText = "Description";
            this.ItemMasterDescription.Name = "ItemMasterDescription";
            // 
            // ItemMasterStock
            // 
            this.ItemMasterStock.DataPropertyName = "ItemMasterStock";
            this.ItemMasterStock.HeaderText = "Stock";
            this.ItemMasterStock.Name = "ItemMasterStock";
            // 
            // ItemWeight
            // 
            this.ItemWeight.DataPropertyName = "ItemWeight";
            this.ItemWeight.HeaderText = "Item Weight";
            this.ItemWeight.Name = "ItemWeight";
            this.ItemWeight.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Programmatic;
            this.ItemWeight.Visible = false;
            // 
            // HsnCode
            // 
            this.HsnCode.DataPropertyName = "ItemMasterHsnCode";
            this.HsnCode.HeaderText = "H S N Code";
            this.HsnCode.Name = "HsnCode";
            this.HsnCode.Width = 130;
            // 
            // frmItemMaster
            // 
            this.AcceptButton = this.btnAdd;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 640);
            this.Controls.Add(this.dgvItemMaster);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "frmItemMaster";
            this.Text = "frmItemMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmItemMaster_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pctBoxItemImage)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvItemMaster)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.TextBox txtItemRate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbItemGroup;
        private System.Windows.Forms.TextBox txtItemDescription;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox txtSearchItemName;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbSearchItemGroup;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSearchItemRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridView dgvItemMaster;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblCaptionRecord;
        private System.Windows.Forms.TextBox txtItemStock;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pctBoxItemImage;
        private System.Windows.Forms.Button btnBrowse;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.TextBox txtItemWeight;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtHsnCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridViewLinkColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemMasterKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemMasterGroupFKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemMasterGroupFKeyName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemMasterName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemMasterRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemMasterDescription;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemMasterStock;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemWeight;
        private System.Windows.Forms.DataGridViewTextBoxColumn HsnCode;

    }
}