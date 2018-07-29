using Microsoft.Reporting.WinForms;
using SenseInventoryLogoBL;
using SenseInventoryLogoUI.Forms.Class;
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
    public partial class frmSearchPurchaseMasterReport : Form
    {
        string sReportEmbeddedResource;
        string sName, sSubreportDataSourceName;
        string DirectImageFilePath = string.Empty;
        DataTable dValue, dValueSubreport;
        DataSet dsMainReport = new DataSet();
        ReportParameter[] pParams;
        int PagePrimaryKey = 0;
        String ReportName = String.Empty;
        int rollFKey;
        int cId;
        public frmSearchPurchaseMasterReport(int rollKey, int companyId)
        {
            InitializeComponent();
            rollFKey = rollKey;
            cId      = companyId;
        }

        public void BindSupplierComboBox()
        {
            try
            {
                /*****************      Bind the Supplier Combo*******************/
                clsSupplierMaster objLoad = new clsSupplierMaster();
                objLoad.Mode = "SELECTALL";
                objLoad.CompanyID   = cId;
                var dsSupplier = objLoad.GetAllSupplier();
                DataTable dtSupplier = dsSupplier.Tables[0];
                DataRow dr = dtSupplier.NewRow();
                dr["SupplierID"] = "0";
                dr["SupplierName"] = "All";
                dtSupplier.Rows.InsertAt(dr, 0);
                cmbSupplier.DataSource = dtSupplier;
                cmbSupplier.DisplayMember = "SupplierName";
                cmbSupplier.ValueMember = "SupplierID";
                cmbSupplier.Text = "All";
                /*****************      Bind the Supplier Combo*******************/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "BindSupplierComboBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmSearchPurchaseMasterReport_Load(object sender, EventArgs e)
        {
            try
            {
                cmbPurchaseType.Text = "ALL";
                BindSupplierComboBox();
                SearchPurchaseMaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmSearchPurchaseMasterReport_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                objSearch.Mode              = "SELECTALL";
                String showBillTotal;
                objSearch.CompanyID         = cId;
                String FromDate = dtpFromDate.Value.ToString("dd/MM/yyyy");
                if (DateTime.Now.ToString("dd/MM/yyyy") != FromDate)
                {
                    objSearch.FromDate = clsCommoan.GetDateInddMMYYYY(FromDate);
                }
                String ToDate = dtpToDate.Value.ToString("dd/MM/yyyy");
                if (DateTime.Now.ToString("dd/MM/yyyy") != ToDate)
                {
                    objSearch.ToDate   = clsCommoan.GetDateInddMMYYYY(ToDate);
                }
                objSearch.PurchaseMasterSupplierFKeyAddress = txtSupplierAddress.Text;
                int isAvaibleinListItem = cmbSupplier.FindStringExact(cmbSupplier.Text);
                if (isAvaibleinListItem.Equals(-1))
                {
                    objSearch.PurchaseMasterSupplierFKey = 0;
                }
                else
                {
                    objSearch.PurchaseMasterSupplierFKey = Convert.ToInt32(cmbSupplier.SelectedValue);
                }
                if (objSearch.PurchaseMasterSupplierFKey.Equals(0))
                {
                    showBillTotal = "No";
                }
                else
                {
                    showBillTotal = "Yes";
                }
                var ds = objSearch.SearchPurchaseMasterItemPurchasePaymentReport();
                SetReportValue("SenseInventoryLogoUI.Reports.SenseInventoryPurchasePaymentReport.rdlc", "dsPrint", ds, "Star Purchase Item and Payment Report", null, "");
                LoadReportData(showBillTotal);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SearchPurchaseMaster", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void SetReportValue(string ReportEmbeddedResource, string Name, DataSet Value, string ReportTitle, ReportParameter[] Params = null, string SubreportDataSourceName = "")
        {
            try
            {
                sSubreportDataSourceName = SubreportDataSourceName;
                sReportEmbeddedResource = ReportEmbeddedResource;
                dsMainReport = Value;
                sName = Name;
                dValue = Value.Tables[0];
                pParams = Params;
                rvPurchaseViewer.Dock = DockStyle.Fill;
                rvPurchaseViewer.Visible = true;
                Text = ReportTitle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SaveFormData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void LoadReportData(string showBillTotal)
        {
            this.rvPurchaseViewer.Reset();
            this.rvPurchaseViewer.LocalReport.DataSources.Clear();
            try
            {
                if (dsMainReport.Tables.Count > 0)
                {
                    if (dsMainReport.Tables.Count > 1)
                    {
                        if (dsMainReport.Tables[1].Rows.Count > 0)
                        {
                            dValueSubreport = dsMainReport.Tables[1];
                            rvPurchaseViewer.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SetSubDataSource);
                        }
                    }
                    rvPurchaseViewer.LocalReport.ReportEmbeddedResource = sReportEmbeddedResource;
                    ReportDataSource sReportDataSource                  = new ReportDataSource();
                    ReportParameter[] reportDetail                      = new ReportParameter[1];
                    reportDetail[0] = new ReportParameter("ShowTotalBillAmount", showBillTotal);
                    sReportDataSource.Name = sName;
                    sReportDataSource.Value = dValue;
                    rvPurchaseViewer.LocalReport.DataSources.Add(sReportDataSource);
                    rvPurchaseViewer.LocalReport.EnableExternalImages = true;
                    rvPurchaseViewer.LocalReport.SetParameters(reportDetail);
                    rvPurchaseViewer.RefreshReport();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "LoadReportData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetSubDataSource(object sender, SubreportProcessingEventArgs e)
        {
            try
            {
                e.DataSources.Add(new ReportDataSource(sSubreportDataSourceName, dValueSubreport));
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        
    }
}
