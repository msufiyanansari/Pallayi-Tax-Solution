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
    public partial class frmGSTSalesRegisterReport : Form
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
        public frmGSTSalesRegisterReport(int rollKey, int companyId)
        {
            InitializeComponent();
            rollFKey = rollKey;
            cId = companyId;
        }

        private void frmGSTSalesRegisterReport_Load(object sender, EventArgs e)
        {
            try
            {
                BindCustomerComboBox();
                SearchSalesMaster();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmGSTSalesRegisterReport_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void BindCustomerComboBox()
        {
            try
            {
                /*****************      Bind the Customer Combo*******************/
                clsCustomerMaster objLoad = new clsCustomerMaster();
                objLoad.Mode = "SELECTALL";
                objLoad.CompanyID = cId;
                var dsCustomer = objLoad.GetAllCustomer();
                DataTable dtCustomer = dsCustomer.Tables[0];
                DataRow dr = dtCustomer.NewRow();
                dr["CustomerID"] = "0";
                dr["CustomerName"] = "All";
                dtCustomer.Rows.InsertAt(dr, 0);
                cmbCustomer.DataSource = dtCustomer;
                cmbCustomer.DisplayMember = "CustomerName";
                cmbCustomer.ValueMember = "CustomerID";
                cmbCustomer.Text = "All";
                /*****************      Bind the Customer Combo*******************/
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "BindCustomerComboBox", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                String showBillTotal;
                clsSalesMaster objSearch = new clsSalesMaster();
                objSearch.Mode           = "SELECTALL";
                objSearch.CompanyID      = cId;
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
                int isAvaibleinListItem = cmbCustomer.FindStringExact(cmbCustomer.Text);
                if (isAvaibleinListItem.Equals(-1))
                {
                    objSearch.SalesMasterCustomerFKey = 0;
                }
                else
                {
                    objSearch.SalesMasterCustomerFKey = Convert.ToInt32(cmbCustomer.SelectedValue);
                }
                var ds = objSearch.Report_SalesGSTReport();
                SetReportValue("SenseInventoryLogoUI.Reports.SenseSalesGSTRegisterReport.rdlc", "dsPrint", ds, "GST Summary Reort", null, "");
                LoadReportData(String.Empty);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SearchSalesMaster", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                rvSalesViewer.Dock = DockStyle.Fill;
                rvSalesViewer.Visible = true;
                Text = ReportTitle;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "SaveFormData", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public void LoadReportData(string showBillTotal)
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
                    ReportParameter[] reportDetail = new ReportParameter[1];
                    reportDetail[0] = new ReportParameter("ShowTotalBillAmount", showBillTotal);

                    sReportDataSource.Name = sName;
                    sReportDataSource.Value = dValue;

                    rvSalesViewer.LocalReport.DataSources.Add(sReportDataSource);
                    rvSalesViewer.LocalReport.EnableExternalImages = true;
                    //rvSalesViewer.LocalReport.SetParameters(reportDetail);
                    //rvSalesViewer.LocalReport
                    if (pParams != null)
                    {
                        if (pParams.Length > 0)
                        {
                            rvSalesViewer.LocalReport.SetParameters(pParams);
                        }
                    }

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
