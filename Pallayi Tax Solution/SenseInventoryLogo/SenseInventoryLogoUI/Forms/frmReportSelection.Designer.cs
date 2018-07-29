namespace SenseInventoryLogoUI.Forms
{
    partial class frmReportSelection
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
            this.label1 = new System.Windows.Forms.Label();
            this.rdbOrignal = new System.Windows.Forms.RadioButton();
            this.rdbDuplicate = new System.Windows.Forms.RadioButton();
            this.rdbTriplicate = new System.Windows.Forms.RadioButton();
            this.btnPrintReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(48, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(388, 26);
            this.label1.TabIndex = 1;
            this.label1.Text = "Select Below Report You Want to Print";
            // 
            // rdbOrignal
            // 
            this.rdbOrignal.AutoSize = true;
            this.rdbOrignal.Checked = true;
            this.rdbOrignal.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbOrignal.Location = new System.Drawing.Point(53, 65);
            this.rdbOrignal.Name = "rdbOrignal";
            this.rdbOrignal.Size = new System.Drawing.Size(100, 30);
            this.rdbOrignal.TabIndex = 1;
            this.rdbOrignal.TabStop = true;
            this.rdbOrignal.Text = "Orignal";
            this.rdbOrignal.UseVisualStyleBackColor = true;
            // 
            // rdbDuplicate
            // 
            this.rdbDuplicate.AutoSize = true;
            this.rdbDuplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbDuplicate.Location = new System.Drawing.Point(53, 106);
            this.rdbDuplicate.Name = "rdbDuplicate";
            this.rdbDuplicate.Size = new System.Drawing.Size(121, 30);
            this.rdbDuplicate.TabIndex = 2;
            this.rdbDuplicate.Text = "Duplicate";
            this.rdbDuplicate.UseVisualStyleBackColor = true;
            // 
            // rdbTriplicate
            // 
            this.rdbTriplicate.AutoSize = true;
            this.rdbTriplicate.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbTriplicate.Location = new System.Drawing.Point(53, 147);
            this.rdbTriplicate.Name = "rdbTriplicate";
            this.rdbTriplicate.Size = new System.Drawing.Size(117, 30);
            this.rdbTriplicate.TabIndex = 3;
            this.rdbTriplicate.Text = "Triplicate";
            this.rdbTriplicate.UseVisualStyleBackColor = true;
            // 
            // btnPrintReport
            // 
            this.btnPrintReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintReport.Location = new System.Drawing.Point(191, 184);
            this.btnPrintReport.Name = "btnPrintReport";
            this.btnPrintReport.Size = new System.Drawing.Size(116, 30);
            this.btnPrintReport.TabIndex = 4;
            this.btnPrintReport.Text = "Print Report";
            this.btnPrintReport.UseVisualStyleBackColor = true;
            this.btnPrintReport.Click += new System.EventHandler(this.btnPrintReport_Click);
            // 
            // frmReportSelection
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(488, 314);
            this.Controls.Add(this.btnPrintReport);
            this.Controls.Add(this.rdbTriplicate);
            this.Controls.Add(this.rdbDuplicate);
            this.Controls.Add(this.rdbOrignal);
            this.Controls.Add(this.label1);
            this.Name = "frmReportSelection";
            this.Text = "frmReportSelection";
            this.Load += new System.EventHandler(this.frmReportSelection_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rdbDuplicate;
        private System.Windows.Forms.RadioButton rdbTriplicate;
        private System.Windows.Forms.Button btnPrintReport;
        private System.Windows.Forms.RadioButton rdbOrignal;
    }
}