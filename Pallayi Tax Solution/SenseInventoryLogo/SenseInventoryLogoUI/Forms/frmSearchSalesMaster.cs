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
    public partial class frmSearchSalesMaster : Form
    {
        int rollFKey;
        int cId;
        public frmSearchSalesMaster(int rollKey, int companyId)
        {
            InitializeComponent();
            rollFKey = rollKey;
            cId      = companyId;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            try
            {
                SearchSalesMaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnAddItem_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SearchSalesMaster()
        {
            try
            {
                clsSalesMaster objSearch = new clsSalesMaster();
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
                objSearch.SalesMasterCustomerFKeyName       = txtCustomerName.Text;
                objSearch.SalesMasterCustomerFKeyAddress    = txtCustomerAddress.Text;
                objSearch.SalesMasterType                   = cmbSalesType.Text;
                var ds                                      = objSearch.SearchSalesMaster();
                dgvSalesView.AutoGenerateColumns            = false;
                dgvSalesView.DataSource                     = ds.Tables[0];
                lblRecordCount.Text                         = ds.Tables[0].Rows.Count.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SearchSalesMaster", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmSearchSalesMaster_Load(object sender, EventArgs e)
        {
            try
            {
                cmbSalesType.Text = "ALL";
                dtpFromDate.Focus();
                SearchSalesMaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmSearchSalesMaster_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoToSalesMaster_Click(object sender, EventArgs e)
        {
            try
            {
                frmSalesMaster objSalesMaster = new frmSalesMaster(0,rollFKey,cId);
                objSalesMaster.MdiParent = this.MdiParent;
                objSalesMaster.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnGoToSalesMaster_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dgvSalesView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.ColumnIndex.Equals(0))
                {
                    frmSalesMaster objSalesEditMode = new frmSalesMaster(Convert.ToInt32(dgvSalesView.Rows[e.RowIndex].Cells[15].Value),rollFKey,cId);
                    objSalesEditMode.MdiParent      = this.MdiParent;
                    objSalesEditMode.Show();
                    this.Close();
                    objSalesEditMode.WindowState    = FormWindowState.Minimized;
                    objSalesEditMode.WindowState    = FormWindowState.Maximized;
                }
                if (e.ColumnIndex.Equals(1))
                {
                    frmReportSelection objReportSelection = new frmReportSelection(Convert.ToInt32(dgvSalesView.Rows[e.RowIndex].Cells[15].Value), String.Empty, 1, rollFKey, cId);
                    objReportSelection.MdiParent = this.MdiParent;
                    this.Close();
                    objReportSelection.Show();
                    objReportSelection.WindowState = FormWindowState.Minimized;
                    objReportSelection.WindowState = FormWindowState.Maximized;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "dgvSalesView_CellContentClick", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
