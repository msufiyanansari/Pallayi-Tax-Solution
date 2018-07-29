namespace PdfPrintLibraryTest
{
    partial class PreviewWatermark
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
            this.pbPreview = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).BeginInit();
            this.SuspendLayout();
            // 
            // pbA4
            // 
            this.pbPreview.BackColor = System.Drawing.Color.White;
            this.pbPreview.Location = new System.Drawing.Point(20, 20);
            this.pbPreview.Name = "pbA4";
            this.pbPreview.Size = new System.Drawing.Size(446, 631);
            this.pbPreview.TabIndex = 0;
            this.pbPreview.TabStop = false;
            this.pbPreview.Paint += new System.Windows.Forms.PaintEventHandler(this.pbPreview_Paint);
            // 
            // PreviewWatermark
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 669);
            this.Controls.Add(this.pbPreview);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PreviewWatermark";
            this.ShowIcon = false;
            this.Text = "Preview Watermark on A4 paper size at 75%";
            this.Load += new System.EventHandler(this.PreviewWatermark_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbPreview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbPreview;
    }
}