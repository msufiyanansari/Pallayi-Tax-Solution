namespace PdfPrintLibraryTest
{
    partial class WatermarkForm
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
            this.tbImagePath = new System.Windows.Forms.TextBox();
            this.btnOpenWatermarkImage = new System.Windows.Forms.Button();
            this.tbText = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.btnSetFont = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.btnSetColor = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.tbY = new System.Windows.Forms.TextBox();
            this.tbRotationAngle = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.tbX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.cbUseRelativePercPosition = new System.Windows.Forms.CheckBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lSelectedColor = new System.Windows.Forms.Label();
            this.lSelectedFont = new System.Windows.Forms.Label();
            this.btnPreview = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label10 = new System.Windows.Forms.Label();
            this.tbPaperHeight = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.tbPaperWidth = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.label11 = new System.Windows.Forms.Label();
            this.tbOpacity = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Image Path:";
            // 
            // tbImagePath
            // 
            this.tbImagePath.Location = new System.Drawing.Point(19, 32);
            this.tbImagePath.Name = "tbImagePath";
            this.tbImagePath.Size = new System.Drawing.Size(565, 20);
            this.tbImagePath.TabIndex = 1;
            // 
            // btnOpenWatermarkImage
            // 
            this.btnOpenWatermarkImage.Location = new System.Drawing.Point(587, 30);
            this.btnOpenWatermarkImage.Name = "btnOpenWatermarkImage";
            this.btnOpenWatermarkImage.Size = new System.Drawing.Size(34, 23);
            this.btnOpenWatermarkImage.TabIndex = 2;
            this.btnOpenWatermarkImage.Text = "...";
            this.btnOpenWatermarkImage.UseVisualStyleBackColor = true;
            this.btnOpenWatermarkImage.Click += new System.EventHandler(this.btnOpenWatermarkImage_Click);
            // 
            // tbText
            // 
            this.tbText.Location = new System.Drawing.Point(6, 35);
            this.tbText.Name = "tbText";
            this.tbText.Size = new System.Drawing.Size(580, 20);
            this.tbText.TabIndex = 1;
            this.tbText.Text = "Test sample.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Text:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(7, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Selected Font:";
            // 
            // btnSetFont
            // 
            this.btnSetFont.Location = new System.Drawing.Point(10, 78);
            this.btnSetFont.Name = "btnSetFont";
            this.btnSetFont.Size = new System.Drawing.Size(75, 23);
            this.btnSetFont.TabIndex = 2;
            this.btnSetFont.Text = "Set Font";
            this.btnSetFont.UseVisualStyleBackColor = true;
            this.btnSetFont.Click += new System.EventHandler(this.btnSetFont_Click);
            // 
            // btnSetColor
            // 
            this.btnSetColor.Location = new System.Drawing.Point(9, 126);
            this.btnSetColor.Name = "btnSetColor";
            this.btnSetColor.Size = new System.Drawing.Size(75, 23);
            this.btnSetColor.TabIndex = 3;
            this.btnSetColor.Text = "Set Color";
            this.btnSetColor.UseVisualStyleBackColor = true;
            this.btnSetColor.Click += new System.EventHandler(this.btnSetColor_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 110);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Selected Color:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(236, 409);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnCancel.Location = new System.Drawing.Point(330, 409);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.tbY);
            this.groupBox1.Controls.Add(this.tbRotationAngle);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.tbX);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cbUseRelativePercPosition);
            this.groupBox1.Location = new System.Drawing.Point(19, 261);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(599, 53);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Position";
            // 
            // tbY
            // 
            this.tbY.Location = new System.Drawing.Point(518, 19);
            this.tbY.Name = "tbY";
            this.tbY.Size = new System.Drawing.Size(50, 20);
            this.tbY.TabIndex = 4;
            this.tbY.Text = "50";
            // 
            // tbRotationAngle
            // 
            this.tbRotationAngle.Location = new System.Drawing.Point(96, 19);
            this.tbRotationAngle.Name = "tbRotationAngle";
            this.tbRotationAngle.Size = new System.Drawing.Size(50, 20);
            this.tbRotationAngle.TabIndex = 1;
            this.tbRotationAngle.Text = "0";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(495, 19);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(17, 13);
            this.label6.TabIndex = 3;
            this.label6.Text = "Y:";
            // 
            // tbX
            // 
            this.tbX.Location = new System.Drawing.Point(417, 19);
            this.tbX.Name = "tbX";
            this.tbX.Size = new System.Drawing.Size(50, 20);
            this.tbX.TabIndex = 3;
            this.tbX.Text = "50";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 19);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Rotation Angle:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(394, 19);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(17, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "X:";
            // 
            // cbUseRelativePercPosition
            // 
            this.cbUseRelativePercPosition.AutoSize = true;
            this.cbUseRelativePercPosition.Location = new System.Drawing.Point(236, 19);
            this.cbUseRelativePercPosition.Name = "cbUseRelativePercPosition";
            this.cbUseRelativePercPosition.Size = new System.Drawing.Size(138, 17);
            this.cbUseRelativePercPosition.TabIndex = 2;
            this.cbUseRelativePercPosition.Text = "Use Relative % Position";
            this.cbUseRelativePercPosition.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tbOpacity);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.lSelectedColor);
            this.groupBox2.Controls.Add(this.lSelectedFont);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.tbText);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.btnSetFont);
            this.groupBox2.Controls.Add(this.btnSetColor);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(19, 62);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(599, 193);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Watermark Text";
            // 
            // lSelectedColor
            // 
            this.lSelectedColor.AutoSize = true;
            this.lSelectedColor.Location = new System.Drawing.Point(93, 110);
            this.lSelectedColor.Name = "lSelectedColor";
            this.lSelectedColor.Size = new System.Drawing.Size(41, 13);
            this.lSelectedColor.TabIndex = 12;
            this.lSelectedColor.Text = "Not set";
            // 
            // lSelectedFont
            // 
            this.lSelectedFont.AutoSize = true;
            this.lSelectedFont.Location = new System.Drawing.Point(89, 62);
            this.lSelectedFont.Name = "lSelectedFont";
            this.lSelectedFont.Size = new System.Drawing.Size(43, 13);
            this.lSelectedFont.TabIndex = 9;
            this.lSelectedFont.Text = "Not Set";
            // 
            // btnPreview
            // 
            this.btnPreview.Location = new System.Drawing.Point(507, 16);
            this.btnPreview.Name = "btnPreview";
            this.btnPreview.Size = new System.Drawing.Size(79, 23);
            this.btnPreview.TabIndex = 3;
            this.btnPreview.Text = "Preview";
            this.btnPreview.UseVisualStyleBackColor = true;
            this.btnPreview.Click += new System.EventHandler(this.btnPreview_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label10);
            this.groupBox3.Controls.Add(this.tbPaperHeight);
            this.groupBox3.Controls.Add(this.btnPreview);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.tbPaperWidth);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Location = new System.Drawing.Point(19, 322);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(599, 79);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Preview";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(15, 55);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(383, 13);
            this.label10.TabIndex = 14;
            this.label10.Text = "Paper size is in inches. For example A4 is 8.27\" X 11.69\", Letter is 8.5\" x 11\", " +
    "...\r\n";
            // 
            // tbPaperHeight
            // 
            this.tbPaperHeight.Location = new System.Drawing.Point(311, 19);
            this.tbPaperHeight.Name = "tbPaperHeight";
            this.tbPaperHeight.Size = new System.Drawing.Size(50, 20);
            this.tbPaperHeight.TabIndex = 2;
            this.tbPaperHeight.Text = "11.69";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(234, 20);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(70, 13);
            this.label9.TabIndex = 2;
            this.label9.Text = "Paper height:";
            // 
            // tbPaperWidth
            // 
            this.tbPaperWidth.Location = new System.Drawing.Point(92, 20);
            this.tbPaperWidth.Name = "tbPaperWidth";
            this.tbPaperWidth.Size = new System.Drawing.Size(50, 20);
            this.tbPaperWidth.TabIndex = 1;
            this.tbPaperWidth.Text = "8.27";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(13, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(69, 13);
            this.label8.TabIndex = 0;
            this.label8.Text = "Paper Width:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Filter = "Image Files (*.bmp, *.jpg, *.gif, *.png)|*.bmp;*.jpg;*.gif;*.png";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(13, 161);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(57, 13);
            this.label11.TabIndex = 13;
            this.label11.Text = "Opacity %:";
            // 
            // tbOpacity
            // 
            this.tbOpacity.Location = new System.Drawing.Point(96, 161);
            this.tbOpacity.Name = "tbOpacity";
            this.tbOpacity.Size = new System.Drawing.Size(50, 20);
            this.tbOpacity.TabIndex = 14;
            // 
            // WatermarkForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(636, 438);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.btnOpenWatermarkImage);
            this.Controls.Add(this.tbImagePath);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WatermarkForm";
            this.ShowIcon = false;
            this.Text = "Set Watermark";
            this.Load += new System.EventHandler(this.WatermarkForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbImagePath;
        private System.Windows.Forms.Button btnOpenWatermarkImage;
        private System.Windows.Forms.TextBox tbText;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.Button btnSetFont;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Button btnSetColor;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbUseRelativePercPosition;
        private System.Windows.Forms.TextBox tbY;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox tbX;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lSelectedFont;
        private System.Windows.Forms.TextBox tbRotationAngle;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnPreview;
        private System.Windows.Forms.Label lSelectedColor;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox tbPaperHeight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbPaperWidth;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox tbOpacity;
        private System.Windows.Forms.Label label11;
    }
}