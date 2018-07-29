namespace SenseInventoryLogoUI.Forms
{
    partial class frmReportViewer
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
            this.pnlHeader = new System.Windows.Forms.Panel();
            this.pnlDetail = new System.Windows.Forms.Panel();
            this.rvSalesViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlHeader.SuspendLayout();
            this.pnlDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlHeader
            // 
            this.pnlHeader.Controls.Add(this.btnPrint);
            this.pnlHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlHeader.Location = new System.Drawing.Point(0, 0);
            this.pnlHeader.Name = "pnlHeader";
            this.pnlHeader.Size = new System.Drawing.Size(992, 37);
            this.pnlHeader.TabIndex = 1;
            // 
            // pnlDetail
            // 
            this.pnlDetail.Controls.Add(this.rvSalesViewer);
            this.pnlDetail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlDetail.Location = new System.Drawing.Point(0, 37);
            this.pnlDetail.Name = "pnlDetail";
            this.pnlDetail.Size = new System.Drawing.Size(992, 623);
            this.pnlDetail.TabIndex = 2;
            // 
            // rvSalesViewer
            // 
            this.rvSalesViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rvSalesViewer.Location = new System.Drawing.Point(0, 0);
            this.rvSalesViewer.Name = "rvSalesViewer";
            this.rvSalesViewer.Size = new System.Drawing.Size(992, 623);
            this.rvSalesViewer.TabIndex = 0;
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(444, 3);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(75, 32);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // frmReportViewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(992, 660);
            this.Controls.Add(this.pnlDetail);
            this.Controls.Add(this.pnlHeader);
            this.Name = "frmReportViewer";
            this.Text = "frmReportViewer";
            this.Load += new System.EventHandler(this.frmReportViewer_Load);
            this.pnlHeader.ResumeLayout(false);
            this.pnlDetail.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlHeader;
        private System.Windows.Forms.Panel pnlDetail;
        private Microsoft.Reporting.WinForms.ReportViewer rvSalesViewer;
        private System.Windows.Forms.Button btnPrint;
    }
}