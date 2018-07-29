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
    public partial class frmReportSelection : Form
    {
        int     PagePrimaryKey = 0;
        String  MultipleKeys;
        int     NoofReport;
        int rollFKey;
        int cId;
        public frmReportSelection(int Key, String MultiKeys, int NoChecked, int rollKey, int companyId)
        {
            InitializeComponent();
            PagePrimaryKey = Key;
            MultipleKeys   = MultiKeys;
            NoofReport     = NoChecked;
            rollFKey       = rollKey;
            cId            = companyId;
        }
        private void frmReportSelection_Load(object sender, EventArgs e)
        {
            try
            {
                rdbOrignal.Checked = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "frmReportSelection_Load", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnPrintReport_Click(object sender, EventArgs e)
        {
            try
            {
                String reportName;
                if(rdbOrignal.Checked==true)
                {
                    reportName = rdbOrignal.Text;
                }
                else if(rdbDuplicate.Checked==true)
                { 
                    reportName  = rdbDuplicate.Text;
                }
                else
                {
                    reportName  = rdbTriplicate.Text;
                }
                frmReportViewer objLoadReport = new frmReportViewer(PagePrimaryKey, reportName, MultipleKeys, NoofReport, rollFKey, cId);
                objLoadReport.MdiParent       = this.MdiParent;
                objLoadReport.Show();
                objLoadReport.WindowState     = FormWindowState.Minimized;
                objLoadReport.WindowState     = FormWindowState.Maximized;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "btnPrintReport_Click", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
