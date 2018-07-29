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
    public partial class frmReportViewer : Form
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
        public frmReportViewer(int Key, String reportName, String MultiKeys, int NoofReport, int rollKey, int companyId)
        {
            InitializeComponent();
            PagePrimaryKey          = Key;
            ReportName              = reportName;
            MultipleKeys            = MultiKeys;
            NoReport                = NoofReport;
            rollFKey                = rollKey;
            cId                     = companyId;
        }
        private void frmReportViewer_Load(object sender, EventArgs e)
        {
            try
            {
                SetReportData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmReportViewer_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.rvSalesViewer.RefreshReport();
        }
        public void SetReportData()
        {
            try
            {
                if (MultipleKeys.Length > 0)
                {
                    int i;
                    
                        clsSalesMaster objLoad          = new clsSalesMaster();
                        objLoad.Mode                    = "SELECTALL";
                        objLoad.CompanyID               = cId;
                        objLoad.SalesMasterKey          = 0;
                        objLoad.SalesMasterNoofKey      = MultipleKeys;
                        var dsReportData                = objLoad.GetSalesMasterReport();
                        for (i = 1; i <= NoReport; i++)
                        {
                            var dsFinalDataset              = InsertBlanckRowForFormate(dsReportData, "Multiple",i);
                            SetReportValue("SenseInventoryLogoUI.Reports.NewSenseInventorySalesReport.rdlc", "dsPrint", dsFinalDataset, "Star Sales Report", null, "");
                            LoadReportData(BlankRow, "Multiple");
                        }
                }
                else
                {
                    if (PagePrimaryKey != 0)
                    {
                        int noofActualRow;
                        clsSalesMaster objLoad      = new clsSalesMaster();
                        objLoad.Mode                = "SELECTONE";
                        objLoad.CompanyID           = cId;
                        objLoad.SalesMasterKey      = PagePrimaryKey;
                        var dsReportData            = objLoad.GetSalesMasterReport();
                        noofActualRow               = dsReportData.Tables[0].Rows.Count;
                        var dsFinalDataset          = InsertBlanckRowForFormate(dsReportData,"Single",1);
                        SetReportValue("SenseInventoryLogoUI.Reports.NewSenseInventorySalesReport.rdlc", "dsPrint", dsFinalDataset, "Star Sales Report", null, "");
                        LoadReportData(noofActualRow, "Single");
                    }
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
        public void LoadReportData(int secondnoofActualrowRptParameter,String LoadType)
        {
            if (LoadType.Equals("Single"))
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
                        ReportDataSource sReportDataSource = new ReportDataSource();
                        ReportParameter[] reportSelection = new ReportParameter[2];
                        reportSelection[0] = new ReportParameter("ReportName", ReportName);
                        reportSelection[1] = new ReportParameter("ActualItem", secondnoofActualrowRptParameter.ToString());
                        //ReportParameter("ReportName",ReportName)
                        //ReportParameter reportActualRow = new ReportParameter("ActualItem",secondnoofActualrowRptParameter.ToString());
                        sReportDataSource.Name = sName;
                        sReportDataSource.Value = dValue;
                        rvSalesViewer.LocalReport.DataSources.Add(sReportDataSource);
                        rvSalesViewer.LocalReport.EnableExternalImages = true;
                        rvSalesViewer.LocalReport.SetParameters(reportSelection);
                        //rvSalesViewer.LocalReport
                        if (pParams != null)
                        {
                            if (pParams.Length > 0)
                            {
                                rvSalesViewer.LocalReport.SetParameters(pParams);
                            }
                        }
                        //SavePDF(rvSalesViewer, "D:\\Client Software\\DeskTopApplication\\StarEngineering\\SenseInventoryLogoUI\\bin\\Debug\\InvoiceReport.pdf");
                        //filePath = "D:\\Client Software\\DeskTopApplication\\StarEngineering\\SenseInventoryLogoUI\\bin\\Debug\\InvoiceReport.pdf";
                        //rvSalesViewer.LocalReport.Refresh();
                        rvSalesViewer.RefreshReport();
                        //clsRigths.sDirectSalesBill == 0
                        //if (sReportEmbeddedResource.Equals("AsianTubesInvcMail.Reports.Test.rdlc") && sReportEmbeddedResource.Equals("POS.Reports.SingleQuotation.rdlc"))
                        //{
                        //    Export(rvSalesViewer.LocalReport);
                        //}
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "LoadReportData", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
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
                        ReportDataSource sReportDataSource = new ReportDataSource();
                        ReportParameter[] reportSelection = new ReportParameter[2];
                        reportSelection[0] = new ReportParameter("ReportName", ReportName);
                        reportSelection[1] = new ReportParameter("ActualItem", secondnoofActualrowRptParameter.ToString());
                        //ReportParameter("ReportName",ReportName)
                        //ReportParameter reportActualRow = new ReportParameter("ActualItem",secondnoofActualrowRptParameter.ToString());
                        sReportDataSource.Name = sName;
                        sReportDataSource.Value = dValue;
                        rvSalesViewer.LocalReport.DataSources.Add(sReportDataSource);
                        rvSalesViewer.LocalReport.EnableExternalImages = true;
                        rvSalesViewer.LocalReport.SetParameters(reportSelection);
                        //rvSalesViewer.LocalReport
                        if (pParams != null)
                        {
                            if (pParams.Length > 0)
                            {
                                rvSalesViewer.LocalReport.SetParameters(pParams);
                            }
                        }
                        SavePDF(rvSalesViewer, "D:\\Client Software\\DeskTopApplication\\StarEngineering\\SenseInventoryLogoUI\\bin\\Debug\\InvoiceReport.pdf");
                        rvSalesViewer.RefreshReport();
                        PrintReport();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message.ToString(), "LoadReportData", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
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
        public DataSet InsertBlanckRowForFormate(DataSet spDataSet , String singleMultiple , int noofReport)
        {
            try
            {
                if (singleMultiple.Equals("Single"))
                {
                    if (spDataSet.Tables[0].Rows.Count <= 10)
                    {
                        int noofRowInsert;
                        noofRowInsert = 10 - spDataSet.Tables[0].Rows.Count;
                        DataTable dt        = spDataSet.Tables[0];
                        int noofRow         = spDataSet.Tables[0].Rows.Count;
                        for (int i = 1; i <= noofRowInsert; i++)
                        {
                            DataRow dr = dt.NewRow();
                            dr["SalesMasterKey"] = dt.Rows[0]["SalesMasterKey"];
                            dr["SalesMasterType"] = dt.Rows[0]["SalesMasterType"];
                            dr["SalesTransactionQty"] = 0;
                            dr["SalesTransactionRate"] = 0;
                            dr["SalesTransactionTotal"] = 0;
                            dr["SalesTransactionItemDescription"] = "";
                            dr["Index"] = noofRow + 1;
                            noofRow     = Convert.ToInt32(dr["Index"]);
                            dt.Rows.InsertAt(dr, dt.Rows.Count + 1);
                        }
                    }
                    return spDataSet;
                }
                else
                {
                    DataSet          dsFinal                    = new DataSet();
                    if (noofReport.Equals(1))
                    {
                        MultiplePrimaryKey                      = Convert.ToInt32(spDataSet.Tables[0].Rows[0][0]);
                    }
                    else
                    {
                        MultiplePrimaryKey                      = Convert.ToInt32(spDataSet.Tables[0].Rows[EachNoofKey][0]);
                    }
                    DataTable dtSingleReport                    = new DataTable();
                    dtSingleReport                              = spDataSet.Tables[0].Clone();
                    DataRow[] NoofRowToImport;
                    NoofRowToImport                             = spDataSet.Tables[0].Select("SalesMasterKey='" + MultiplePrimaryKey.ToString() + "'");
                    EachNoofKey                                 = EachNoofKey + NoofRowToImport.Length; 
                    BlankRow                                    = NoofRowToImport.Length; 
                    foreach (DataRow ExactRow in NoofRowToImport)
                    {
                        dtSingleReport.ImportRow(ExactRow);
                    }
                    int noofRowInsert;
                    noofRowInsert                               = 13 - dtSingleReport.Rows.Count;
                    int noofRow                                 = dtSingleReport.Rows.Count;
                    for (int i = 1; i <= noofRowInsert; i++)
                    {
                        DataRow dr                              = dtSingleReport.NewRow();
                        dr["SalesMasterKey"]                    = dtSingleReport.Rows[0]["SalesMasterKey"];
                        dr["SalesMasterType"]                   = dtSingleReport.Rows[0]["SalesMasterType"];
                        dr["SalesTransactionQty"]               = 0;
                        dr["SalesTransactionRate"]              = 0;
                        dr["SalesTransactionTotal"]             = 0;
                        dr["SalesTransactionItemDescription"]   = "";
                        dr["Index"]                             = noofRow + 1;
                        noofRow                                 = Convert.ToInt32(dr["Index"]);
                        dtSingleReport.Rows.InsertAt(dr, dtSingleReport.Rows.Count + 1);
                    }
                    dsFinal.Tables.Add(dtSingleReport);
                    return dsFinal;
                }
            }
            catch (Exception ex)
            {
              MessageBox.Show(ex.Message.ToString(), "InsertBlanckRowForFormate", MessageBoxButtons.OK, MessageBoxIcon.Error);
              return spDataSet;
            }
        }

        public void SavePDF(ReportViewer viewer, string savePath)
        {
            byte[] Bytes = viewer.LocalReport.Render(format: "PDF", deviceInfo: "");

            using (FileStream stream = new FileStream(savePath, FileMode.Create))
            {
                stream.Write(Bytes, 0, Bytes.Length);
            }
        }
        #region PrintDocument
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                PrintReport();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void PrintReport()
        {
            try
            {
                var pdfPrint                = new PdfPrint("demoCompany", "demoKey");
                pdfPrint.PrinterName        = "XYZ";
                pdfPrint.Watermark.Text     = String.Empty;
                var status                  = pdfPrint.Print("D:\\Client Software\\DeskTopApplication\\StarEngineering\\SenseInventoryLogoUI\\bin\\Debug\\InvoiceReport.pdf");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void PdfViewer_DocumentLoaded(object sender, DocumentLoadedEventArgs e)
        {
            MessageBox.Show("Document " + e.FileName + " was loaded");
        }
        #endregion
    }
}

           