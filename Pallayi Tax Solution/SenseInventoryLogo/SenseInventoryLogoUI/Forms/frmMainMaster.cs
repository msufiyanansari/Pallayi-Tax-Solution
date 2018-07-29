using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SenseInventoryLogoUI.Forms
{
    public partial class frmMainMaster : Form
    {
        int rollFKey;
        int cId;
        public frmMainMaster(int rollKey, int companyId)
        {
            InitializeComponent();
            rollFKey   = rollKey;
            cId        = companyId;
        }

        private void accountSettingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmAccountSetting objAccountSetting = new frmAccountSetting(rollFKey,cId);
            objAccountSetting.MdiParent = this;
            objAccountSetting.Show();
            objAccountSetting.WindowState = FormWindowState.Minimized;
            objAccountSetting.WindowState = FormWindowState.Maximized;
        }

        private void frmMainMaster_Load(object sender, EventArgs e)
        {
            UserRightShowHideMenu();
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmCategoryMaster objform = new frmCategoryMaster(rollFKey, cId);
            objform.MdiParent = this;
            objform.Show();
            objform.WindowState     =   FormWindowState.Minimized;
            objform.WindowState     =   FormWindowState.Maximized;

        }

        private void customerMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmCustomer objform = new frmCustomer(rollFKey, cId);
            objform.MdiParent = this;
            objform.Show();
            objform.WindowState = FormWindowState.Minimized;
            objform.WindowState = FormWindowState.Maximized;
        }

        private void itemMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmItemMaster objform = new frmItemMaster("No", rollFKey, cId);
            objform.MdiParent = this;
            objform.Show();
            objform.WindowState = FormWindowState.Minimized;
            objform.WindowState = FormWindowState.Maximized;
        }

        private void salesMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmSalesMaster objform = new frmSalesMaster(0, rollFKey, cId);
            objform.MdiParent      = this;
            objform.Show();
            objform.WindowState    = FormWindowState.Minimized;
            objform.WindowState    = FormWindowState.Maximized;

        }

        public void CloseAllOpenedChildForm()
        {
            try
            {
                foreach (Form child in this.MdiChildren)
                {
                    if (!child.Focused)
                    {
                        child.Close();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void searchSalesMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmSearchSalesMaster objform = new frmSearchSalesMaster(rollFKey, cId);
            objform.MdiParent = this;
            objform.Show();
            objform.WindowState = FormWindowState.Minimized;
            objform.WindowState = FormWindowState.Maximized;
        }

        private void categoryMasterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmCategoryMaster objform = new frmCategoryMaster(rollFKey, cId);
            objform.MdiParent = this;
            objform.Show();
            objform.WindowState = FormWindowState.Minimized;
            objform.WindowState = FormWindowState.Maximized;
        }

        private void itemMasterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmItemMaster objform = new frmItemMaster("No", rollFKey, cId);
            objform.MdiParent = this;
            objform.Show();
            objform.WindowState = FormWindowState.Minimized;
            objform.WindowState = FormWindowState.Maximized;

        }

        private void customerMasterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmCustomer objform = new frmCustomer(rollFKey, cId);
            objform.MdiParent = this;
            objform.Show();
            objform.WindowState = FormWindowState.Minimized;
            objform.WindowState = FormWindowState.Maximized;
        }

        private void salesMasterToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmSalesMaster objform = new frmSalesMaster(0, rollFKey, cId);
            objform.MdiParent = this;
            objform.Show();
            objform.WindowState = FormWindowState.Minimized;
            objform.WindowState = FormWindowState.Maximized;
        }

        private void accountSettingToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmAccountSetting objAccountSetting = new frmAccountSetting(rollFKey, cId);
            objAccountSetting.MdiParent = this;
            objAccountSetting.Show();
            objAccountSetting.WindowState = FormWindowState.Minimized;
            objAccountSetting.WindowState = FormWindowState.Maximized;
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void toolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmSearchSalesMasterReport objLoadReport = new frmSearchSalesMasterReport(rollFKey, cId);
            objLoadReport.MdiParent = this;
            objLoadReport.Show();
            objLoadReport.WindowState = FormWindowState.Minimized;
            objLoadReport.WindowState = FormWindowState.Maximized;
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmSupplier objform = new frmSupplier(rollFKey, cId);
            objform.MdiParent = this;
            objform.Show();
            objform.WindowState = FormWindowState.Minimized;
            objform.WindowState = FormWindowState.Maximized;
        }

        private void toolStripMenuItem3_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmPurchaseMaster objform = new frmPurchaseMaster(0, rollFKey, cId);
            objform.MdiParent = this;
            objform.Show();
            objform.WindowState = FormWindowState.Minimized;
            objform.WindowState = FormWindowState.Maximized;
        }

        private void toolStripMenuItem4_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmSearchPurchaseMaster objform = new frmSearchPurchaseMaster(rollFKey, cId);
            objform.MdiParent = this;
            objform.Show();
            objform.WindowState = FormWindowState.Minimized;
            objform.WindowState = FormWindowState.Maximized;
        }

        private void CompanySetting_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmCompanySetting objform = new frmCompanySetting(rollFKey);
            objform.MdiParent = this;
            objform.Show();
            objform.WindowState = FormWindowState.Minimized;
            objform.WindowState = FormWindowState.Maximized;
        }
        public void UserRightShowHideMenu()
        {
            try
            {
                if (rollFKey.Equals(-100))
                {
                    companySettingMenu.Visible = true;      
                }
                else
                {
                    companySettingMenu.Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "UserRightShowHideMenu", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmSalesRegisterReport objLoadReport = new frmSalesRegisterReport(rollFKey, cId);
                objLoadReport.MdiParent = this;
                objLoadReport.Show();
                objLoadReport.WindowState = FormWindowState.Minimized;
                objLoadReport.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "toolStripMenuItem5_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmPurchaseItemMaster objform = new frmPurchaseItemMaster("No", rollFKey,cId);
            objform.MdiParent = this;
            objform.Show();
            objform.WindowState = FormWindowState.Minimized;
            objform.WindowState = FormWindowState.Maximized;
        }

        

        private void frmMainMaster_Click(object sender, EventArgs e)
        {

        }

        private void purchase_Reigster_Click(object sender, EventArgs e)
        {
            CloseAllOpenedChildForm();
            frmPurchaseRegisterReport objLoadReport = new frmPurchaseRegisterReport(rollFKey, cId);
            objLoadReport.MdiParent = this;
            objLoadReport.Show();
            objLoadReport.WindowState = FormWindowState.Minimized;
            objLoadReport.WindowState = FormWindowState.Maximized;
        }

        

        

        

        

        private void toolStripMenuItem1_Click_2(object sender, EventArgs e)
        {
            try
            {
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void toolStripMenuItem2_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem4_Click_1(object sender, EventArgs e)
        {

        }

        private void toolStripMenuItem8_Click(object sender, EventArgs e)
        {

        }
        /***************** Menu Event Start ****************************/ 
        private void categoryMenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmCategoryMaster objform = new frmCategoryMaster(rollFKey, cId);
                objform.MdiParent = this;
                objform.Show();
                objform.WindowState = FormWindowState.Minimized;
                objform.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "categoryMenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customerMenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmCustomer objform = new frmCustomer(rollFKey, cId);
                objform.MdiParent = this;
                objform.Show();
                objform.WindowState = FormWindowState.Minimized;
                objform.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "customerMenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void supplierMenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmSupplier objform = new frmSupplier(rollFKey, cId);
                objform.MdiParent = this;
                objform.Show();
                objform.WindowState = FormWindowState.Minimized;
                objform.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "supplierMenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void itemMasterMenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmItemMaster objform = new frmItemMaster("No", rollFKey, cId);
                objform.MdiParent = this;
                objform.Show();
                objform.WindowState = FormWindowState.Minimized;
                objform.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "itemMasterMenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void purchaseItemMenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmPurchaseItemMaster objform = new frmPurchaseItemMaster("No", rollFKey, cId);
                objform.MdiParent = this;
                objform.Show();
                objform.WindowState = FormWindowState.Minimized;
                objform.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "purchaseItemMenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void salesMenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmSalesMaster objform = new frmSalesMaster(0, rollFKey, cId);
                objform.MdiParent = this;
                objform.Show();
                objform.WindowState = FormWindowState.Minimized;
                objform.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "salesMenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void purchasemenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmPurchaseMaster objform = new frmPurchaseMaster(0, rollFKey, cId);
                objform.MdiParent = this;
                objform.Show();
                objform.WindowState = FormWindowState.Minimized;
                objform.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "purchasemenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        

        private void searchSalesMenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmSearchSalesMaster objform = new frmSearchSalesMaster(rollFKey, cId);
                objform.MdiParent = this;
                objform.Show();
                objform.WindowState = FormWindowState.Minimized;
                objform.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "searchSalesMenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void searchPurchaseMenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmSearchPurchaseMaster objform = new frmSearchPurchaseMaster(rollFKey, cId);
                objform.MdiParent = this;
                objform.Show();
                objform.WindowState = FormWindowState.Minimized;
                objform.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "searchPurchaseMenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void salesDetailReportMenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmSalesRegisterReport objLoadReport = new frmSalesRegisterReport(rollFKey, cId);
                objLoadReport.MdiParent = this;
                objLoadReport.Show();
                objLoadReport.WindowState = FormWindowState.Minimized;
                objLoadReport.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "salesDetailReportMenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void purchaseDetailReportMenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmPurchaseRegisterReport objLoadReport = new frmPurchaseRegisterReport(rollFKey, cId);
                objLoadReport.MdiParent = this;
                objLoadReport.Show();
                objLoadReport.WindowState = FormWindowState.Minimized;
                objLoadReport.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "purchaseDetailReportMenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void salesSummaryReportMenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmSearchSalesMasterReport objLoadReport = new frmSearchSalesMasterReport(rollFKey, cId);
                objLoadReport.MdiParent = this;
                objLoadReport.Show();
                objLoadReport.WindowState = FormWindowState.Minimized;
                objLoadReport.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "salesSummaryReportMenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void purchaseSummaryReportMenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmSearchPurchaseMasterReport objLoadReport = new frmSearchPurchaseMasterReport(rollFKey, cId);
                objLoadReport.MdiParent = this;
                objLoadReport.Show();
                objLoadReport.WindowState = FormWindowState.Minimized;
                objLoadReport.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "purchaseSummaryReportMenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void accountSettingMenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmAccountSetting objAccountSetting = new frmAccountSetting(rollFKey, cId);
                objAccountSetting.MdiParent = this;
                objAccountSetting.Show();
                objAccountSetting.WindowState = FormWindowState.Minimized;
                objAccountSetting.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "accountSettingMenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void companySettingMenu_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmCompanySetting objform = new frmCompanySetting(rollFKey);
                objform.MdiParent = this;
                objform.Show();
                objform.WindowState = FormWindowState.Minimized;
                objform.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "companySettingMenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void eximenu_Click(object sender, EventArgs e)
        {
            try
            {
                Application.Exit();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "eximenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void toolStripMenuItem5_Click_1(object sender, EventArgs e)
        {

        }

        private void companyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmCompanyDetail objform = new frmCompanyDetail(cId);
                objform.MdiParent = this;
                objform.Show();
                objform.WindowState = FormWindowState.Minimized;
                objform.WindowState = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "manufacturermenu_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void logoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                this.Close();
                frmLoginForm objform = new frmLoginForm();
                objform.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "logoutToolStripMenuItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void gSTReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                CloseAllOpenedChildForm();
                frmGSTSalesRegisterReport objLoadReport = new frmGSTSalesRegisterReport(rollFKey, cId);
                objLoadReport.MdiParent                 = this;
                objLoadReport.Show();
                objLoadReport.WindowState               = FormWindowState.Minimized;
                objLoadReport.WindowState               = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "gSTReportToolStripMenuItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /***************** Menu Event Start ****************************/ 
    }
}
