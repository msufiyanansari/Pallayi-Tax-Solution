using Microsoft.Reporting.WinForms;
using SenseInventoryLogoBL;
using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
using PdfPrintingNet;
using PdfViewerNet;
namespace SenseInventoryLogoUI.Forms
{
    public partial class frmPaymentReportViewer : Form
    {
        string sReportEmbeddedResource;
        string sName, sSubreportDataSourceName;
        string DirectImageFilePath = string.Empty;
        DataTable dValue, dValueSubreport;
        DataSet dsMainReport = new DataSet();
        ReportParameter[] pParams;
        int PagePrimaryKey = 0;
        String ReportName = String.Empty;
        private System.Drawing.Font         printFont;
        private StreamReader streamToPrint;
        static string        filePath;
        String MultipleKeys;
        int    MultiplePrimaryKey;
        int    EachNoofKey  = 0;
        int    NoReport;
        int    BlankRow     = 0;
        int rollFKey;
        int cId;
        public frmPaymentReportViewer(int Key, int companyId)
        {
            InitializeComponent();
            PagePrimaryKey          = Key;
            cId                     = companyId;
        }
        private void frmPaymentReportViewer_Load(object sender, EventArgs e)
        {
            try
            {
                SetReportData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmPaymentReportViewer_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.rvSalesViewer.RefreshReport();
        }
        public void SetReportData()
        {
            try
            {
                    if (PagePrimaryKey != 0)
                    {
                        clsSalesTransactionPaymentMember objLoad = new clsSalesTransactionPaymentMember();
                        objLoad.Mode                             = "SELECTONE";
                        objLoad.SalesTransactionPayKey           = PagePrimaryKey;
                        objLoad.CompanyID                        =  cId;  
                        var dsReportData                         = objLoad.Report_PaymentDetail();
                        SetReportValue("SenseInventoryLogoUI.Reports.PaymentReport.rdlc", "dsPrint", dsReportData, "Payment Report", null, "");
                        LoadReportData();
                    }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SetReportData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void SetReportValue(string ReportEmbeddedResource, string Name, DataSet Value, string ReportTitle, ReportParameter[] Params = null, string SubreportDataSourceName = "")
        {
            try
            {
                sSubreportDataSourceName    = SubreportDataSourceName;
                sReportEmbeddedResource     = ReportEmbeddedResource;
                dsMainReport                = Value;
                sName                       = Name;
                dValue                      = Value.Tables[0];
                pParams                     = Params;
                rvSalesViewer.Dock          = DockStyle.Fill;
                rvSalesViewer.Visible       = true;
                Text                        = ReportTitle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SaveFormData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public void LoadReportData()
        {
                this.rvSalesViewer.Reset();
                this.rvSalesViewer.LocalReport.DataSources.Clear();
                try
                {
                    if (dsMainReport.Tables.Count > 0)
                    {
                        if (dsMainReport.Tables.Count > 1)
                        {
                            if (dsMainReport.Tables[1].Rows.Count > 0)
                            {
                                dValueSubreport = dsMainReport.Tables[1];
                                rvSalesViewer.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(SetSubDataSource);
                            }
                        }
                        rvSalesViewer.LocalReport.ReportEmbeddedResource = sReportEmbeddedResource;
                        ReportDataSource sReportDataSource               = new ReportDataSource();
                        sReportDataSource.Name                           = sName;
                        sReportDataSource.Value                          = dValue;
                        rvSalesViewer.LocalReport.DataSources.Add(sReportDataSource);
                        rvSalesViewer.LocalReport.EnableExternalImages = true;
                        rvSalesViewer.RefreshReport();
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

           