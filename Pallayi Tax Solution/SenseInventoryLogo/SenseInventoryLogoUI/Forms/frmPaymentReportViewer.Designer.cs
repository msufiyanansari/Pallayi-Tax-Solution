namespace SenseInventoryLogoUI.Forms
{
    partial class frmPaymentReportViewer
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
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.rvSalesViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.pnlDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.rvSalesViewer);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 0);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(992, 660);
            this.pnlDetail.TabIndex = 2;
            // 
            // rvSalesViewer
            // 
            this.rvSalesViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvSalesViewer.Location = new System.Drawing.Point(0, 0);
            this.rvSalesViewer.Name = "rvSalesViewer";
            this.rvSalesViewer.Size = new System.Drawing.Size(992, 660);
            this.rvSalesViewer.TabIndex = 0;
            // 
            // frmPaymentReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 660);
            this.Controls.Add(this.pnlDetail);
            this.Name = "frmPaymentReportViewer";
            this.Text = "frmReportViewer";
            this.Load += new System.EventHandler(this.frmPaymentReportViewer_Load);
            this.pnlDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlDetail;
        private Microsoft.Reporting.WinForms.ReportViewer rvSalesViewer;
    }
}