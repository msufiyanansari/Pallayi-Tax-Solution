using Microsoft.Reporting.WinForms;
using SenseInventoryLogoBL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SenseInventoryLogoUI.Forms.Class;
using System.IO;
namespace SenseInventoryLogoUI.Forms
{
    public partial class frmPurchaseRegisterReport : Form
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
        public frmPurchaseRegisterReport(int rollKey, int companyId)
        {
            InitializeComponent();
            rollFKey = rollKey;
            cId      = companyId;
        }
        private void frmPurchaseRegisterReport_Load(object sender, EventArgs e)
        {
            try
            {
                cmbPurchaseType.Text = "ALL";
                SearchPurchaseMaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmPurchaseRegisterReport_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                String showBillTotal;
                clsPurchaseMaster objSearch = new clsPurchaseMaster();
                objSearch.Mode = "SELECTALL";
                objSearch.CompanyID = cId;
                String FromDate = dtpFromDate.Value.ToString("dd/MM/yyyy");
                if (DateTime.Now.ToString("dd/MM/yyyy") != FromDate)
                {
                    objSearch.FromDate = clsCommoan.GetDateInddMMYYYY(FromDate);
                }
                String ToDate = dtpToDate.Value.ToString("dd/MM/yyyy");
                if (DateTime.Now.ToString("dd/MM/yyyy") != ToDate)
                {
                    objSearch.ToDate = clsCommoan.GetDateInddMMYYYY(ToDate);
                }
                objSearch.PurchaseMasterSupplierFKeyAddress = txtSupplierAddress.Text;
                objSearch.PurchaseMasterType = cmbPurchaseType.Text;
                objSearch.PurchaseMasterSupplierFKeyName = txtSupplier.Text;     
                var ds = objSearch.Report_PurchaseRegister();
                SetReportValue("SenseInventoryLogoUI.Reports.SensePurchaseRegisterReport.rdlc", "dsPrint", ds, "Sales Purchase Register Report", null, "");
                LoadReportData(String.Empty);
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
                    ReportDataSource sReportDataSource = new ReportDataSource();

                    sReportDataSource.Name = sName;
                    sReportDataSource.Value = dValue;

                    rvPurchaseViewer.LocalReport.DataSources.Add(sReportDataSource);
                    rvPurchaseViewer.LocalReport.EnableExternalImages = true;
                    //rvPurchaseViewer.LocalReport
                    if (pParams != null)
                    {
                        if (pParams.Length > 0)
                        {
                            rvPurchaseViewer.LocalReport.SetParameters(pParams);
                        }
                    }

                    //rvPurchaseViewer.LocalReport.Refresh();
                    rvPurchaseViewer.RefreshReport();
                    //clsRigths.sDirectPurchaseBill == 0
                    //if (sReportEmbeddedResource.Equals("AsianTubesInvcMail.Reports.Test.rdlc") && sReportEmbeddedResource.Equals("POS.Reports.SingleQuotation.rdlc"))
                    //{
                    //    Export(rvPurchaseViewer.LocalReport);
                    //}
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
