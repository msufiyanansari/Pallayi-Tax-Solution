using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenseInventoryLogoBL;
using System.Data.SqlClient;
using System.Data;
using SenseInventoryLogoUI.Forms.Class;

namespace SenseInventoryLogoUI.Forms
{
    public partial class frmSearchPurchaseMaster : Form
    {
        int rollFKey;
        int cId;
        public frmSearchPurchaseMaster(int rollKey, int companyId)
        {
            InitializeComponent();
            rollFKey = rollKey;
            cId = companyId;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                SearchPurchaseMaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnAddItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SearchPurchaseMaster()
        {
            try
            {
                clsPurchaseMaster objSearch = new clsPurchaseMaster();
                objSearch.Mode           = "SELECTALL";
                objSearch.CompanyID      = cId;
                String FromDate          = dtpFromDate.Value.ToString("dd/MM/yyyy");
                if (DateTime.Now.ToString("dd/MM/yyyy") != FromDate)
                {
                    objSearch.FromDate = clsCommoan.GetDateInddMMYYYY(FromDate);
                }
                String ToDate = dtpToDate.Value.ToString("dd/MM/yyyy");
                if (DateTime.Now.ToString("dd/MM/yyyy") != ToDate)
                {
                    objSearch.ToDate = clsCommoan.GetDateInddMMYYYY(ToDate);
                }
                objSearch.PurchaseMasterSupplierFKeyName       = txtSupplierName.Text;
                objSearch.PurchaseMasterSupplierFKeyAddress    = txtSupplierAddress.Text;
                objSearch.PurchaseMasterType                   = cmbPurchaseType.Text;
                var ds                                         = objSearch.SearchPurchaseMaster();
                dgvPurchaseView.AutoGenerateColumns            = false;
                dgvPurchaseView.DataSource                     = ds.Tables[0];
                lblRecordCount.Text                            = ds.Tables[0].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SearchPurchaseMaster", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSearchPurchaseMaster_Load(object sender, EventArgs e)
        {
            try
            {
                cmbPurchaseType.Text = "ALL";
                dtpFromDate.Focus();
                SearchPurchaseMaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmSearchPurchaseMaster_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoToPurchaseMaster_Click(object sender, EventArgs e)
        {
            try
            {
                frmPurchaseMaster objPurchaseMaster = new frmPurchaseMaster(0,rollFKey,cId);
                objPurchaseMaster.MdiParent = this.MdiParent;
                objPurchaseMaster.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnGoToPurchaseMaster_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvPurchaseView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(0))
                {
                    frmPurchaseMaster objPurchaseEditMode = new frmPurchaseMaster(Convert.ToInt32(dgvPurchaseView.Rows[e.RowIndex].Cells[14].Value), rollFKey, cId);
                    objPurchaseEditMode.MdiParent      = this.MdiParent;
                    objPurchaseEditMode.Show();
                    this.Close();
                    objPurchaseEditMode.WindowState    = FormWindowState.Minimized;
                    objPurchaseEditMode.WindowState    = FormWindowState.Maximized;
                }
                //if (e.ColumnIndex.Equals(2))
                //{
                //    frmReportSelection objReportSelection = new frmReportSelection(Convert.ToInt32(dgvPurchaseView.Rows[e.RowIndex].Cells[19].Value),String.Empty,1,rollFKey);
                //    objReportSelection.MdiParent = this.MdiParent;
                //    this.Close();
                //    objReportSelection.Show();
                //    objReportSelection.WindowState = FormWindowState.Minimized;
                //    objReportSelection.WindowState = FormWindowState.Maximized;
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "dgvPurchaseView_CellContentClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                String MultiplePagePrimaryKey = String.Empty;
                int    NoChecked              = 0;
                foreach (DataGridViewRow row in dgvPurchaseView.Rows)
                {
                    NoChecked               += Convert.ToInt32(row.Cells["chkSelection"].Value);
                    if (Convert.ToInt32(row.Cells["chkSelection"].Value).Equals(1))
                    {
                        MultiplePagePrimaryKey = MultiplePagePrimaryKey.Length > 0 ? MultiplePagePrimaryKey + "," + row.Cells["PurchaseMasterKey"].Value.ToString() : row.Cells["PurchaseMasterKey"].Value.ToString();
                    }
                    //More code here
                }
                if (NoChecked.Equals(0))
                {
                    MessageBox.Show("For Single Selection Use Print Option and Multiple Selection So Checked At Least One CheckBox To Print", "dgvPurchaseView_CellContentClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    frmReportSelection objReportSelection = new frmReportSelection(0, MultiplePagePrimaryKey, NoChecked, rollFKey, cId);
                    objReportSelection.MdiParent          = this.MdiParent;
                    this.Close();
                    objReportSelection.Show();
                    objReportSelection.WindowState        = FormWindowState.Minimized;
                    objReportSelection.WindowState        = FormWindowState.Maximized;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnPrint_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
