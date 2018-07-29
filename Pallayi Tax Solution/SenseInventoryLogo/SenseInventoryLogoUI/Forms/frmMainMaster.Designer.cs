namespace SenseInventoryLogoUI.Forms
{
    partial class frmMainMaster
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
            System.Windows.Forms.ToolStripMenuItem eximenu;
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.categoryMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.customerMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.supplierMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.itemMasterMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseItemMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.companyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.salesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.purchasemenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
            this.searchSalesMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.searchPurchaseMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
            this.salesDetailReportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseDetailReportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.salesSummaryReportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.purchaseSummaryReportMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
            this.accountSettingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.companySettingMenu = new System.Windows.Forms.ToolStripMenuItem();
            this.logoutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gSTReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            eximenu = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // eximenu
            // 
            eximenu.Name = "eximenu";
            eximenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.T)));
            eximenu.Size = new System.Drawing.Size(37, 20);
            eximenu.Text = "Exit";
            eximenu.Click += new System.EventHandler(this.eximenu_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.toolStripMenuItem2,
            this.toolStripMenuItem8,
            this.toolStripMenuItem4,
            this.toolStripMenuItem5,
            eximenu});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1020, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.categoryMenu,
            this.customerMenu,
            this.supplierMenu,
            this.itemMasterMenu,
            this.purchaseItemMenu,
            this.companyToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.toolStripMenuItem1.ShortcutKeyDisplayString = "";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(55, 20);
            this.toolStripMenuItem1.Text = "Master";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click_2);
            // 
            // categoryMenu
            // 
            this.categoryMenu.Name = "categoryMenu";
            this.categoryMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.A)));
            this.categoryMenu.Size = new System.Drawing.Size(185, 22);
            this.categoryMenu.Text = "Category";
            this.categoryMenu.Click += new System.EventHandler(this.categoryMenu_Click);
            // 
            // customerMenu
            // 
            this.customerMenu.Name = "customerMenu";
            this.customerMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.B)));
            this.customerMenu.Size = new System.Drawing.Size(185, 22);
            this.customerMenu.Text = "Customer";
            this.customerMenu.Click += new System.EventHandler(this.customerMenu_Click);
            // 
            // supplierMenu
            // 
            this.supplierMenu.Name = "supplierMenu";
            this.supplierMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.C)));
            this.supplierMenu.Size = new System.Drawing.Size(185, 22);
            this.supplierMenu.Text = "Supplier";
            this.supplierMenu.Click += new System.EventHandler(this.supplierMenu_Click);
            // 
            // itemMasterMenu
            // 
            this.itemMasterMenu.Name = "itemMasterMenu";
            this.itemMasterMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.D)));
            this.itemMasterMenu.Size = new System.Drawing.Size(185, 22);
            this.itemMasterMenu.Text = "Item Master";
            this.itemMasterMenu.Click += new System.EventHandler(this.itemMasterMenu_Click);
            // 
            // purchaseItemMenu
            // 
            this.purchaseItemMenu.Checked = true;
            this.purchaseItemMenu.CheckState = System.Windows.Forms.CheckState.Checked;
            this.purchaseItemMenu.Name = "purchaseItemMenu";
            this.purchaseItemMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.E)));
            this.purchaseItemMenu.Size = new System.Drawing.Size(185, 22);
            this.purchaseItemMenu.Text = "Purchase Item";
            this.purchaseItemMenu.Visible = false;
            this.purchaseItemMenu.Click += new System.EventHandler(this.purchaseItemMenu_Click);
            // 
            // companyToolStripMenuItem
            // 
            this.companyToolStripMenuItem.Name = "companyToolStripMenuItem";
            this.companyToolStripMenuItem.Size = new System.Drawing.Size(185, 22);
            this.companyToolStripMenuItem.Text = "Company";
            this.companyToolStripMenuItem.Click += new System.EventHandler(this.companyToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesMenu,
            this.purchasemenu});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.toolStripMenuItem2.Size = new System.Drawing.Size(81, 20);
            this.toolStripMenuItem2.Text = "Transaction";
            this.toolStripMenuItem2.Click += new System.EventHandler(this.toolStripMenuItem2_Click_1);
            // 
            // salesMenu
            // 
            this.salesMenu.Name = "salesMenu";
            this.salesMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.G)));
            this.salesMenu.Size = new System.Drawing.Size(161, 22);
            this.salesMenu.Text = "Sales";
            this.salesMenu.Click += new System.EventHandler(this.salesMenu_Click);
            // 
            // purchasemenu
            // 
            this.purchasemenu.Name = "purchasemenu";
            this.purchasemenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.H)));
            this.purchasemenu.Size = new System.Drawing.Size(161, 22);
            this.purchasemenu.Text = "Purchase";
            this.purchasemenu.Click += new System.EventHandler(this.purchasemenu_Click);
            // 
            // toolStripMenuItem8
            // 
            this.toolStripMenuItem8.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.searchSalesMenu,
            this.searchPurchaseMenu});
            this.toolStripMenuItem8.Name = "toolStripMenuItem8";
            this.toolStripMenuItem8.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.toolStripMenuItem8.Size = new System.Drawing.Size(54, 20);
            this.toolStripMenuItem8.Text = "Search";
            this.toolStripMenuItem8.Click += new System.EventHandler(this.toolStripMenuItem8_Click);
            // 
            // searchSalesMenu
            // 
            this.searchSalesMenu.Name = "searchSalesMenu";
            this.searchSalesMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.I)));
            this.searchSalesMenu.Size = new System.Drawing.Size(159, 22);
            this.searchSalesMenu.Text = "Sales ";
            this.searchSalesMenu.Click += new System.EventHandler(this.searchSalesMenu_Click);
            // 
            // searchPurchaseMenu
            // 
            this.searchPurchaseMenu.Name = "searchPurchaseMenu";
            this.searchPurchaseMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.J)));
            this.searchPurchaseMenu.Size = new System.Drawing.Size(159, 22);
            this.searchPurchaseMenu.Text = "Purchase ";
            this.searchPurchaseMenu.Click += new System.EventHandler(this.searchPurchaseMenu_Click);
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.salesDetailReportMenu,
            this.purchaseDetailReportMenu,
            this.salesSummaryReportMenu,
            this.purchaseSummaryReportMenu,
            this.gSTReportToolStripMenuItem});
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.toolStripMenuItem4.Size = new System.Drawing.Size(59, 20);
            this.toolStripMenuItem4.Text = "Reports";
            this.toolStripMenuItem4.Click += new System.EventHandler(this.toolStripMenuItem4_Click_1);
            // 
            // salesDetailReportMenu
            // 
            this.salesDetailReportMenu.Name = "salesDetailReportMenu";
            this.salesDetailReportMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.L)));
            this.salesDetailReportMenu.Size = new System.Drawing.Size(213, 22);
            this.salesDetailReportMenu.Text = "Sales Detail";
            this.salesDetailReportMenu.Click += new System.EventHandler(this.salesDetailReportMenu_Click);
            // 
            // purchaseDetailReportMenu
            // 
            this.purchaseDetailReportMenu.Name = "purchaseDetailReportMenu";
            this.purchaseDetailReportMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.M)));
            this.purchaseDetailReportMenu.Size = new System.Drawing.Size(213, 22);
            this.purchaseDetailReportMenu.Text = "Purchase Detail";
            this.purchaseDetailReportMenu.Click += new System.EventHandler(this.purchaseDetailReportMenu_Click);
            // 
            // salesSummaryReportMenu
            // 
            this.salesSummaryReportMenu.Name = "salesSummaryReportMenu";
            this.salesSummaryReportMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.O)));
            this.salesSummaryReportMenu.Size = new System.Drawing.Size(213, 22);
            this.salesSummaryReportMenu.Text = "Sales Summary";
            this.salesSummaryReportMenu.Click += new System.EventHandler(this.salesSummaryReportMenu_Click);
            // 
            // purchaseSummaryReportMenu
            // 
            this.purchaseSummaryReportMenu.Name = "purchaseSummaryReportMenu";
            this.purchaseSummaryReportMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.P)));
            this.purchaseSummaryReportMenu.Size = new System.Drawing.Size(213, 22);
            this.purchaseSummaryReportMenu.Text = "Purchase Summary";
            this.purchaseSummaryReportMenu.Click += new System.EventHandler(this.purchaseSummaryReportMenu_Click);
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.accountSettingMenu,
            this.companySettingMenu,
            this.logoutToolStripMenuItem});
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(60, 20);
            this.toolStripMenuItem5.Text = "Settting";
            this.toolStripMenuItem5.Click += new System.EventHandler(this.toolStripMenuItem5_Click_1);
            // 
            // accountSettingMenu
            // 
            this.accountSettingMenu.Name = "accountSettingMenu";
            this.accountSettingMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.R)));
            this.accountSettingMenu.Size = new System.Drawing.Size(162, 22);
            this.accountSettingMenu.Text = "Account";
            this.accountSettingMenu.Click += new System.EventHandler(this.accountSettingMenu_Click);
            // 
            // companySettingMenu
            // 
            this.companySettingMenu.Name = "companySettingMenu";
            this.companySettingMenu.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.S)));
            this.companySettingMenu.Size = new System.Drawing.Size(162, 22);
            this.companySettingMenu.Text = "Company";
            this.companySettingMenu.Click += new System.EventHandler(this.companySettingMenu_Click);
            // 
            // logoutToolStripMenuItem
            // 
            this.logoutToolStripMenuItem.Name = "logoutToolStripMenuItem";
            this.logoutToolStripMenuItem.Size = new System.Drawing.Size(162, 22);
            this.logoutToolStripMenuItem.Text = "Logout";
            this.logoutToolStripMenuItem.Click += new System.EventHandler(this.logoutToolStripMenuItem_Click);
            // 
            // gSTReportToolStripMenuItem
            // 
            this.gSTReportToolStripMenuItem.Name = "gSTReportToolStripMenuItem";
            this.gSTReportToolStripMenuItem.Size = new System.Drawing.Size(213, 22);
            this.gSTReportToolStripMenuItem.Text = "GST Report";
            this.gSTReportToolStripMenuItem.Click += new System.EventHandler(this.gSTReportToolStripMenuItem_Click);
            // 
            // frmMainMaster
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.BackgroundImage = global::SenseInventoryLogoUI.Properties.Resources.BackgroundImage2;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1020, 661);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMainMaster";
            this.Text = "Main Master";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMainMaster_Load);
            this.Click += new System.EventHandler(this.frmMainMaster_Click);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem8;
        private System.Windows.Forms.ToolStripMenuItem searchSalesMenu;
        private System.Windows.Forms.ToolStripMenuItem searchPurchaseMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem4;
        private System.Windows.Forms.ToolStripMenuItem salesDetailReportMenu;
        private System.Windows.Forms.ToolStripMenuItem purchaseDetailReportMenu;
        private System.Windows.Forms.ToolStripMenuItem salesSummaryReportMenu;
        private System.Windows.Forms.ToolStripMenuItem purchaseSummaryReportMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem5;
        private System.Windows.Forms.ToolStripMenuItem accountSettingMenu;
        private System.Windows.Forms.ToolStripMenuItem companySettingMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem categoryMenu;
        private System.Windows.Forms.ToolStripMenuItem customerMenu;
        private System.Windows.Forms.ToolStripMenuItem supplierMenu;
        private System.Windows.Forms.ToolStripMenuItem itemMasterMenu;
        private System.Windows.Forms.ToolStripMenuItem purchaseItemMenu;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem salesMenu;
        private System.Windows.Forms.ToolStripMenuItem purchasemenu;
        private System.Windows.Forms.ToolStripMenuItem companyToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logoutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gSTReportToolStripMenuItem;

    }
}