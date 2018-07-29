namespace SimplePDFPrintLibraryTest
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnPrint = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.cmbxScale = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbIsContentCentered = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(653, 69);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(149, 39);
            this.btnPrint.TabIndex = 0;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "PDF file:";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(13, 30);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(698, 20);
            this.tbFileName.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(13, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "PDF Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(15, 69);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(115, 20);
            this.tbPassword.TabIndex = 4;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(717, 27);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(85, 23);
            this.btnOpenFile.TabIndex = 5;
            this.btnOpenFile.Text = "Open File";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // cmbxScale
            // 
            this.cmbxScale.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxScale.FormattingEnabled = true;
            this.cmbxScale.Items.AddRange(new object[] {
            "FitToMargins",
            "None",
            "Shrink"});
            this.cmbxScale.Location = new System.Drawing.Point(195, 69);
            this.cmbxScale.Name = "cmbxScale";
            this.cmbxScale.Size = new System.Drawing.Size(121, 21);
            this.cmbxScale.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(192, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "Scale Content:";
            // 
            // cbIsContentCentered
            // 
            this.cbIsContentCentered.AutoSize = true;
            this.cbIsContentCentered.Checked = true;
            this.cbIsContentCentered.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIsContentCentered.Location = new System.Drawing.Point(360, 69);
            this.cbIsContentCentered.Name = "cbIsContentCentered";
            this.cbIsContentCentered.Size = new System.Drawing.Size(120, 17);
            this.cbIsContentCentered.TabIndex = 8;
            this.cbIsContentCentered.Text = "Is Content Centered";
            this.cbIsContentCentered.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(831, 126);
            this.Controls.Add(this.cbIsContentCentered);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cmbxScale);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrint);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "TerminalWorks - Simple PDFPrinting.Net test -";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.ComboBox cmbxScale;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox cbIsContentCentered;
    }
}

