namespace SenseInventoryLogoUI.Forms
{
    partial class frmCategoryMaster
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.txtHsnCode = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.lblRecordCount = new System.Windows.Forms.Label();
            this.lblCaptionRecord = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.btnDeleteCategory = new System.Windows.Forms.Button();
            this.chkActiveInActive = new System.Windows.Forms.CheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbCategory = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnAddCategory = new System.Windows.Forms.Button();
            this.lblCategoryHeader = new System.Windows.Forms.Label();
            this.txtCategoryValue = new System.Windows.Forms.TextBox();
            this.lblCategory = new System.Windows.Forms.Label();
            this.pnlBody = new System.Windows.Forms.Panel();
            this.dgvCategoryDetail = new System.Windows.Forms.DataGridView();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.Action = new System.Windows.Forms.DataGridViewLinkColumn();
            this.CategoryMasterCatName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryMasterCatVal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryMasterCatIsActiveValue = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryMasterCatKey = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryMasterCatIsActive = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CategoryMasterHsnCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlHeader.SuspendLayout();
            this.pnlBody.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlHeader.Controls.Add(this.txtHsnCode);
            this.pnlHeader.Controls.Add(this.label3);
            this.pnlHeader.Controls.Add(this.lblRecordCount);
            this.pnlHeader.Controls.Add(this.lblCaptionRecord);
            this.pnlHeader.Controls.Add(this.txtKey);
            this.pnlHeader.Controls.Add(this.btnDeleteCategory);
            this.pnlHeader.Controls.Add(this.chkActiveInActive);
            this.pnlHeader.Controls.Add(this.label2);
            this.pnlHeader.Controls.Add(this.cmbCategory);
            this.pnlHeader.Controls.Add(this.label1);
            this.pnlHeader.Controls.Add(this.btnAddCategory);
            this.pnlHeader.Controls.Add(this.lblCategoryHeader);
            this.pnlHeader.Controls.Add(this.txtCategoryValue);
            this.pnlHeader.Controls.Add(this.lblCategory);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(1008, 152);
            this.pnlHeader.TabIndex = 0;
            // 
            // txtHsnCode
            // 
            this.txtHsnCode.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtHsnCode.Location = new System.Drawing.Point(387, 223);
            this.txtHsnCode.Name = "txtHsnCode";
            this.txtHsnCode.Size = new System.Drawing.Size(379, 26);
            this.txtHsnCode.TabIndex = 3;
            this.txtHsnCode.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(231, 235);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(94, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "H S N Code.: ";
            this.label3.Visible = false;
            // 
            // lblRecordCount
            // 
            this.lblRecordCount.AutoSize = true;
            this.lblRecordCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRecordCount.Location = new System.Drawing.Point(112, 151);
            this.lblRecordCount.Name = "lblRecordCount";
            this.lblRecordCount.Size = new System.Drawing.Size(18, 20);
            this.lblRecordCount.TabIndex = 29;
            this.lblRecordCount.Text = "0";
            // 
            // lblCaptionRecord
            // 
            this.lblCaptionRecord.AutoSize = true;
            this.lblCaptionRecord.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCaptionRecord.Location = new System.Drawing.Point(-3, 151);
            this.lblCaptionRecord.Name = "lblCaptionRecord";
            this.lblCaptionRecord.Size = new System.Drawing.Size(120, 20);
            this.lblCaptionRecord.TabIndex = 28;
            this.lblCaptionRecord.Text = "Record Count : ";
            // 
            // txtKey
            // 
            this.txtKey.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKey.Location = new System.Drawing.Point(879, 3);
            this.txtKey.Name = "txtKey";
            this.txtKey.Size = new System.Drawing.Size(123, 26);
            this.txtKey.TabIndex = 27;
            this.txtKey.Text = "0";
            this.txtKey.Visible = false;
            // 
            // btnDeleteCategory
            // 
            this.btnDeleteCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCategory.Location = new System.Drawing.Point(666, 116);
            this.btnDeleteCategory.Name = "btnDeleteCategory";
            this.btnDeleteCategory.Size = new System.Drawing.Size(82, 28);
            this.btnDeleteCategory.TabIndex = 6;
            this.btnDeleteCategory.Text = "Delete";
            this.btnDeleteCategory.UseVisualStyleBackColor = true;
            this.btnDeleteCategory.Visible = false;
            this.btnDeleteCategory.Click += new System.EventHandler(this.btnDeleteCategory_Click);
            // 
            // chkActiveInActive
            // 
            this.chkActiveInActive.AutoSize = true;
            this.chkActiveInActive.Location = new System.Drawing.Point(368, 92);
            this.chkActiveInActive.Name = "chkActiveInActive";
            this.chkActiveInActive.Size = new System.Drawing.Size(56, 17);
            this.chkActiveInActive.TabIndex = 4;
            this.chkActiveInActive.Text = "Active";
            this.chkActiveInActive.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(230, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 24;
            this.label2.Text = "Status.: ";
            // 
            // cmbCategory
            // 
            this.cmbCategory.DisplayMember = "CategoryMasterCatKey";
            this.cmbCategory.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategory.FormattingEnabled = true;
            this.cmbCategory.Location = new System.Drawing.Point(369, 33);
            this.cmbCategory.Name = "cmbCategory";
            this.cmbCategory.Size = new System.Drawing.Size(379, 21);
            this.cmbCategory.TabIndex = 1;
            this.cmbCategory.ValueMember = "CategoryMasterCatKey";
            this.cmbCategory.SelectedIndexChanged += new System.EventHandler(this.cmbCategory_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(231, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 22;
            this.label1.Text = "Select Category.: ";
            // 
            // btnAddCategory
            // 
            this.btnAddCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCategory.Location = new System.Drawing.Point(368, 116);
            this.btnAddCategory.Name = "btnAddCategory";
            this.btnAddCategory.Size = new System.Drawing.Size(82, 28);
            this.btnAddCategory.TabIndex = 5;
            this.btnAddCategory.Text = "Add";
            this.btnAddCategory.UseVisualStyleBackColor = true;
            this.btnAddCategory.Click += new System.EventHandler(this.btnAddCategory_Click);
            // 
            // lblCategoryHeader
            // 
            this.lblCategoryHeader.AutoSize = true;
            this.lblCategoryHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoryHeader.Location = new System.Drawing.Point(461, 4);
            this.lblCategoryHeader.Name = "lblCategoryHeader";
            this.lblCategoryHeader.Size = new System.Drawing.Size(172, 26);
            this.lblCategoryHeader.TabIndex = 8;
            this.lblCategoryHeader.Text = "Category Master";
            // 
            // txtCategoryValue
            // 
            this.txtCategoryValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCategoryValue.Location = new System.Drawing.Point(369, 60);
            this.txtCategoryValue.Name = "txtCategoryValue";
            this.txtCategoryValue.Size = new System.Drawing.Size(379, 26);
            this.txtCategoryValue.TabIndex = 2;
            // 
            // lblCategory
            // 
            this.lblCategory.AutoSize = true;
            this.lblCategory.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategory.Location = new System.Drawing.Point(231, 66);
            this.lblCategory.Name = "lblCategory";
            this.lblCategory.Size = new System.Drawing.Size(117, 17);
            this.lblCategory.TabIndex = 6;
            this.lblCategory.Text = "Category Value.: ";
            // 
            // pnlBody
            // 
            this.pnlBody.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pnlBody.Controls.Add(this.dgvCategoryDetail);
            this.pnlBody.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlBody.Location = new System.Drawing.Point(0, 152);
            this.pnlBody.Name = "pnlBody";
            this.pnlBody.Size = new System.Drawing.Size(1008, 577);
            this.pnlBody.TabIndex = 1;
            // 
            // dgvCategoryDetail
            // 
            this.dgvCategoryDetail.BackgroundColor = System.Drawing.SystemColors.Control;
            this.dgvCategoryDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoryDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Action,
            this.CategoryMasterCatName,
            this.CategoryMasterCatVal,
            this.CategoryMasterCatIsActiveValue,
            this.CategoryMasterCatKey,
            this.CategoryMasterCatIsActive,
            this.CategoryMasterHsnCode});
            this.dgvCategoryDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvCategoryDetail.Location = new System.Drawing.Point(0, 0);
            this.dgvCategoryDetail.Name = "dgvCategoryDetail";
            this.dgvCategoryDetail.Size = new System.Drawing.Size(1004, 573);
            this.dgvCategoryDetail.TabIndex = 0;
            this.dgvCategoryDetail.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategoryDetail_CellContentClick);
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // Action
            // 
            this.Action.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.Action.DataPropertyName = "none";
            this.Action.FillWeight = 5F;
            this.Action.HeaderText = "Edit";
            this.Action.Name = "Action";
            this.Action.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.Action.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.Action.Text = "Edit";
            this.Action.ToolTipText = "Click Edit Link Update Value";
            this.Action.UseColumnTextForLinkValue = true;
            this.Action.Width = 50;
            // 
            // CategoryMasterCatName
            // 
            this.CategoryMasterCatName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CategoryMasterCatName.DataPropertyName = "CategoryMasterCatName";
            this.CategoryMasterCatName.FillWeight = 5F;
            this.CategoryMasterCatName.HeaderText = "CategoryName";
            this.CategoryMasterCatName.Name = "CategoryMasterCatName";
            this.CategoryMasterCatName.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryMasterCatName.Width = 400;
            // 
            // CategoryMasterCatVal
            // 
            this.CategoryMasterCatVal.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CategoryMasterCatVal.DataPropertyName = "CategoryMasterCatVal";
            this.CategoryMasterCatVal.FillWeight = 5F;
            this.CategoryMasterCatVal.HeaderText = "Category Value";
            this.CategoryMasterCatVal.Name = "CategoryMasterCatVal";
            this.CategoryMasterCatVal.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryMasterCatVal.Width = 660;
            // 
            // CategoryMasterCatIsActiveValue
            // 
            this.CategoryMasterCatIsActiveValue.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CategoryMasterCatIsActiveValue.DataPropertyName = "CategoryMasterCatIsActiveValue";
            this.CategoryMasterCatIsActiveValue.FillWeight = 5F;
            this.CategoryMasterCatIsActiveValue.HeaderText = "Status";
            this.CategoryMasterCatIsActiveValue.Name = "CategoryMasterCatIsActiveValue";
            this.CategoryMasterCatIsActiveValue.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryMasterCatIsActiveValue.Width = 200;
            // 
            // CategoryMasterCatKey
            // 
            this.CategoryMasterCatKey.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CategoryMasterCatKey.DataPropertyName = "CategoryMasterCatKey";
            this.CategoryMasterCatKey.FillWeight = 5F;
            this.CategoryMasterCatKey.HeaderText = "CategoryMasterCatKey";
            this.CategoryMasterCatKey.Name = "CategoryMasterCatKey";
            this.CategoryMasterCatKey.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryMasterCatKey.Visible = false;
            this.CategoryMasterCatKey.Width = 50;
            // 
            // CategoryMasterCatIsActive
            // 
            this.CategoryMasterCatIsActive.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.None;
            this.CategoryMasterCatIsActive.DataPropertyName = "CategoryMasterCatIsActive";
            this.CategoryMasterCatIsActive.FillWeight = 5F;
            this.CategoryMasterCatIsActive.HeaderText = "CategoryMasterCatIsActive";
            this.CategoryMasterCatIsActive.Name = "CategoryMasterCatIsActive";
            this.CategoryMasterCatIsActive.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.CategoryMasterCatIsActive.Visible = false;
            this.CategoryMasterCatIsActive.Width = 50;
            // 
            // CategoryMasterHsnCode
            // 
            this.CategoryMasterHsnCode.DataPropertyName = "CategoryMasterHsnCode";
            this.CategoryMasterHsnCode.HeaderText = "H S N Code";
            this.CategoryMasterHsnCode.Name = "CategoryMasterHsnCode";
            this.CategoryMasterHsnCode.Visible = false;
            // 
            // frmCategoryMaster
            // 
            this.AcceptButton = this.btnAddCategory;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 729);
            this.Controls.Add(this.pnlBody);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmCategoryMaster";
            this.Text = "frmCategoryMaster";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCategoryMaster_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlHeader.PerformLayout();
            this.pnlBody.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoryDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.TextBox txtCategoryValue;
        private System.Windows.Forms.Label lblCategory;
        private System.Windows.Forms.Label lblCategoryHeader;
        private System.Windows.Forms.Button btnAddCategory;
        private System.Windows.Forms.Panel pnlBody;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbCategory;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox chkActiveInActive;
        private System.Windows.Forms.DataGridView dgvCategoryDetail;
        private System.Windows.Forms.Button btnDeleteCategory;
        private System.Windows.Forms.TextBox txtKey;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.Label lblRecordCount;
        private System.Windows.Forms.Label lblCaptionRecord;
        private System.Windows.Forms.TextBox txtHsnCode;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridViewLinkColumn Action;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryMasterCatName;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryMasterCatVal;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryMasterCatIsActiveValue;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryMasterCatKey;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryMasterCatIsActive;
        private System.Windows.Forms.DataGridViewTextBoxColumn CategoryMasterHsnCode;
    }
}