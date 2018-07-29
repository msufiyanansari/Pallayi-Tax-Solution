namespace PdfPrintLibraryMultiDocumentPrintTest
{
    partial class PDFPrintPropertiesForm
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
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCentered = new System.Windows.Forms.CheckBox();
            this.cbAutoRotate = new System.Windows.Forms.CheckBox();
            this.gbPrinterSettings = new System.Windows.Forms.GroupBox();
            this.panelPrinterSettings = new System.Windows.Forms.Panel();
            this.gbOrientation = new System.Windows.Forms.GroupBox();
            this.rbPortrait = new System.Windows.Forms.RadioButton();
            this.rbLandscape = new System.Windows.Forms.RadioButton();
            this.cbDefaultPrintOrientation = new System.Windows.Forms.CheckBox();
            this.gbPaperSize = new System.Windows.Forms.GroupBox();
            this.cmbxPaperSize = new System.Windows.Forms.ComboBox();
            this.lPaperSizes = new System.Windows.Forms.Label();
            this.cbDefaultPaperSize = new System.Windows.Forms.CheckBox();
            this.gbPrinterResolution = new System.Windows.Forms.GroupBox();
            this.cmbxPrinterResolutions = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbDefaultPrinterResolution = new System.Windows.Forms.CheckBox();
            this.gbPaperSource = new System.Windows.Forms.GroupBox();
            this.cmbxPaperSource = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbDefaultPaperSource = new System.Windows.Forms.CheckBox();
            this.gbPrintInColor = new System.Windows.Forms.GroupBox();
            this.cbDefaultPrintInColor = new System.Windows.Forms.CheckBox();
            this.cbPrintInColor = new System.Windows.Forms.CheckBox();
            this.cbUsePrinterSettings = new System.Windows.Forms.CheckBox();
            this.btnSetPrinterSettings = new System.Windows.Forms.Button();
            this.cbUseWatermark = new System.Windows.Forms.CheckBox();
            this.btnSetWatermark = new System.Windows.Forms.Button();
            this.cbIsStream = new System.Windows.Forms.CheckBox();
            this.gbScale = new System.Windows.Forms.GroupBox();
            this.rbScaleShrink = new System.Windows.Forms.RadioButton();
            this.rbScaleFit = new System.Windows.Forms.RadioButton();
            this.rbScaleActualSize = new System.Windows.Forms.RadioButton();
            this.gbPrintRange = new System.Windows.Forms.GroupBox();
            this.rbPrintOdd = new System.Windows.Forms.RadioButton();
            this.rbPrintEven = new System.Windows.Forms.RadioButton();
            this.rbPrintEvenOdd = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.tbPrintPages = new System.Windows.Forms.TextBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.gbPrinterSettings.SuspendLayout();
            this.panelPrinterSettings.SuspendLayout();
            this.gbOrientation.SuspendLayout();
            this.gbPaperSize.SuspendLayout();
            this.gbPrinterResolution.SuspendLayout();
            this.gbPaperSource.SuspendLayout();
            this.gbPrintInColor.SuspendLayout();
            this.gbScale.SuspendLayout();
            this.gbPrintRange.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCentered);
            this.groupBox2.Controls.Add(this.cbAutoRotate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(15, 453);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 44);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Content Orientation";
            // 
            // cbCentered
            // 
            this.cbCentered.AutoSize = true;
            this.cbCentered.Checked = true;
            this.cbCentered.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbCentered.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCentered.Location = new System.Drawing.Point(306, 19);
            this.cbCentered.Name = "cbCentered";
            this.cbCentered.Size = new System.Drawing.Size(69, 17);
            this.cbCentered.TabIndex = 2;
            this.cbCentered.Text = "Centered";
            this.cbCentered.UseVisualStyleBackColor = true;
            // 
            // cbAutoRotate
            // 
            this.cbAutoRotate.AutoSize = true;
            this.cbAutoRotate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbAutoRotate.Location = new System.Drawing.Point(9, 20);
            this.cbAutoRotate.Name = "cbAutoRotate";
            this.cbAutoRotate.Size = new System.Drawing.Size(277, 17);
            this.cbAutoRotate.TabIndex = 1;
            this.cbAutoRotate.Text = "Auto Rotate (if set, this will override Paper orientation)";
            this.cbAutoRotate.UseVisualStyleBackColor = true;
            // 
            // gbPrinterSettings
            // 
            this.gbPrinterSettings.Controls.Add(this.panelPrinterSettings);
            this.gbPrinterSettings.Controls.Add(this.cbUsePrinterSettings);
            this.gbPrinterSettings.Controls.Add(this.btnSetPrinterSettings);
            this.gbPrinterSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPrinterSettings.Location = new System.Drawing.Point(12, 12);
            this.gbPrinterSettings.Name = "gbPrinterSettings";
            this.gbPrinterSettings.Size = new System.Drawing.Size(750, 289);
            this.gbPrinterSettings.TabIndex = 9;
            this.gbPrinterSettings.TabStop = false;
            this.gbPrinterSettings.Text = "Printer Settings";
            // 
            // panelPrinterSettings
            // 
            this.panelPrinterSettings.Controls.Add(this.gbOrientation);
            this.panelPrinterSettings.Controls.Add(this.gbPaperSize);
            this.panelPrinterSettings.Controls.Add(this.gbPrinterResolution);
            this.panelPrinterSettings.Controls.Add(this.gbPaperSource);
            this.panelPrinterSettings.Controls.Add(this.gbPrintInColor);
            this.panelPrinterSettings.Location = new System.Drawing.Point(3, 15);
            this.panelPrinterSettings.Name = "panelPrinterSettings";
            this.panelPrinterSettings.Size = new System.Drawing.Size(741, 236);
            this.panelPrinterSettings.TabIndex = 1;
            // 
            // gbOrientation
            // 
            this.gbOrientation.Controls.Add(this.rbPortrait);
            this.gbOrientation.Controls.Add(this.rbLandscape);
            this.gbOrientation.Controls.Add(this.cbDefaultPrintOrientation);
            this.gbOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbOrientation.Location = new System.Drawing.Point(386, 14);
            this.gbOrientation.Name = "gbOrientation";
            this.gbOrientation.Size = new System.Drawing.Size(286, 51);
            this.gbOrientation.TabIndex = 9;
            this.gbOrientation.TabStop = false;
            this.gbOrientation.Text = "Paper orientation:";
            // 
            // rbPortrait
            // 
            this.rbPortrait.AutoSize = true;
            this.rbPortrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPortrait.Location = new System.Drawing.Point(221, 19);
            this.rbPortrait.Name = "rbPortrait";
            this.rbPortrait.Size = new System.Drawing.Size(58, 17);
            this.rbPortrait.TabIndex = 3;
            this.rbPortrait.TabStop = true;
            this.rbPortrait.Text = "Portrait";
            this.rbPortrait.UseVisualStyleBackColor = true;
            // 
            // rbLandscape
            // 
            this.rbLandscape.AutoSize = true;
            this.rbLandscape.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbLandscape.Location = new System.Drawing.Point(128, 19);
            this.rbLandscape.Name = "rbLandscape";
            this.rbLandscape.Size = new System.Drawing.Size(78, 17);
            this.rbLandscape.TabIndex = 2;
            this.rbLandscape.TabStop = true;
            this.rbLandscape.Text = "Landscape";
            this.rbLandscape.UseVisualStyleBackColor = true;
            // 
            // cbDefaultPrintOrientation
            // 
            this.cbDefaultPrintOrientation.AutoSize = true;
            this.cbDefaultPrintOrientation.Checked = true;
            this.cbDefaultPrintOrientation.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultPrintOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultPrintOrientation.Location = new System.Drawing.Point(6, 19);
            this.cbDefaultPrintOrientation.Name = "cbDefaultPrintOrientation";
            this.cbDefaultPrintOrientation.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultPrintOrientation.TabIndex = 1;
            this.cbDefaultPrintOrientation.Text = "Use printer default";
            this.cbDefaultPrintOrientation.UseVisualStyleBackColor = true;
            this.cbDefaultPrintOrientation.CheckedChanged += new System.EventHandler(this.cbDefault_Changed);
            // 
            // gbPaperSize
            // 
            this.gbPaperSize.Controls.Add(this.cmbxPaperSize);
            this.gbPaperSize.Controls.Add(this.lPaperSizes);
            this.gbPaperSize.Controls.Add(this.cbDefaultPaperSize);
            this.gbPaperSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPaperSize.Location = new System.Drawing.Point(8, 175);
            this.gbPaperSize.Name = "gbPaperSize";
            this.gbPaperSize.Size = new System.Drawing.Size(730, 52);
            this.gbPaperSize.TabIndex = 8;
            this.gbPaperSize.TabStop = false;
            this.gbPaperSize.Text = "Paper size";
            // 
            // cmbxPaperSize
            // 
            this.cmbxPaperSize.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPaperSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbxPaperSize.FormattingEnabled = true;
            this.cmbxPaperSize.Location = new System.Drawing.Point(209, 19);
            this.cmbxPaperSize.Name = "cmbxPaperSize";
            this.cmbxPaperSize.Size = new System.Drawing.Size(516, 21);
            this.cmbxPaperSize.TabIndex = 2;
            // 
            // lPaperSizes
            // 
            this.lPaperSizes.AutoSize = true;
            this.lPaperSizes.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lPaperSizes.Location = new System.Drawing.Point(146, 20);
            this.lPaperSizes.Name = "lPaperSizes";
            this.lPaperSizes.Size = new System.Drawing.Size(59, 13);
            this.lPaperSizes.TabIndex = 2;
            this.lPaperSizes.Text = "Paper size:";
            // 
            // cbDefaultPaperSize
            // 
            this.cbDefaultPaperSize.AutoSize = true;
            this.cbDefaultPaperSize.Checked = true;
            this.cbDefaultPaperSize.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultPaperSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultPaperSize.Location = new System.Drawing.Point(7, 19);
            this.cbDefaultPaperSize.Name = "cbDefaultPaperSize";
            this.cbDefaultPaperSize.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultPaperSize.TabIndex = 1;
            this.cbDefaultPaperSize.Text = "Use printer default";
            this.cbDefaultPaperSize.UseVisualStyleBackColor = true;
            this.cbDefaultPaperSize.CheckedChanged += new System.EventHandler(this.cbDefault_Changed);
            // 
            // gbPrinterResolution
            // 
            this.gbPrinterResolution.Controls.Add(this.cmbxPrinterResolutions);
            this.gbPrinterResolution.Controls.Add(this.label8);
            this.gbPrinterResolution.Controls.Add(this.cbDefaultPrinterResolution);
            this.gbPrinterResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPrinterResolution.Location = new System.Drawing.Point(8, 123);
            this.gbPrinterResolution.Name = "gbPrinterResolution";
            this.gbPrinterResolution.Size = new System.Drawing.Size(730, 46);
            this.gbPrinterResolution.TabIndex = 7;
            this.gbPrinterResolution.TabStop = false;
            this.gbPrinterResolution.Text = "Printer resolution";
            // 
            // cmbxPrinterResolutions
            // 
            this.cmbxPrinterResolutions.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPrinterResolutions.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbxPrinterResolutions.FormattingEnabled = true;
            this.cmbxPrinterResolutions.Location = new System.Drawing.Point(209, 20);
            this.cmbxPrinterResolutions.Name = "cmbxPrinterResolutions";
            this.cmbxPrinterResolutions.Size = new System.Drawing.Size(516, 21);
            this.cmbxPrinterResolutions.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.Location = new System.Drawing.Point(145, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(60, 13);
            this.label8.TabIndex = 2;
            this.label8.Text = "Resolution:";
            // 
            // cbDefaultPrinterResolution
            // 
            this.cbDefaultPrinterResolution.AutoSize = true;
            this.cbDefaultPrinterResolution.Checked = true;
            this.cbDefaultPrinterResolution.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultPrinterResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultPrinterResolution.Location = new System.Drawing.Point(7, 19);
            this.cbDefaultPrinterResolution.Name = "cbDefaultPrinterResolution";
            this.cbDefaultPrinterResolution.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultPrinterResolution.TabIndex = 1;
            this.cbDefaultPrinterResolution.Text = "Use printer default";
            this.cbDefaultPrinterResolution.UseVisualStyleBackColor = true;
            this.cbDefaultPrinterResolution.CheckedChanged += new System.EventHandler(this.cbDefault_Changed);
            // 
            // gbPaperSource
            // 
            this.gbPaperSource.Controls.Add(this.cmbxPaperSource);
            this.gbPaperSource.Controls.Add(this.label13);
            this.gbPaperSource.Controls.Add(this.cbDefaultPaperSource);
            this.gbPaperSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPaperSource.Location = new System.Drawing.Point(8, 71);
            this.gbPaperSource.Name = "gbPaperSource";
            this.gbPaperSource.Size = new System.Drawing.Size(730, 46);
            this.gbPaperSource.TabIndex = 6;
            this.gbPaperSource.TabStop = false;
            this.gbPaperSource.Text = "Paper source";
            // 
            // cmbxPaperSource
            // 
            this.cmbxPaperSource.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPaperSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbxPaperSource.FormattingEnabled = true;
            this.cmbxPaperSource.Location = new System.Drawing.Point(209, 17);
            this.cmbxPaperSource.Name = "cmbxPaperSource";
            this.cmbxPaperSource.Size = new System.Drawing.Size(516, 21);
            this.cmbxPaperSource.TabIndex = 2;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label13.Location = new System.Drawing.Point(130, 17);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(73, 13);
            this.label13.TabIndex = 2;
            this.label13.Text = "Paper source:";
            // 
            // cbDefaultPaperSource
            // 
            this.cbDefaultPaperSource.AutoSize = true;
            this.cbDefaultPaperSource.Checked = true;
            this.cbDefaultPaperSource.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultPaperSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultPaperSource.Location = new System.Drawing.Point(7, 17);
            this.cbDefaultPaperSource.Name = "cbDefaultPaperSource";
            this.cbDefaultPaperSource.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultPaperSource.TabIndex = 1;
            this.cbDefaultPaperSource.Text = "Use printer default";
            this.cbDefaultPaperSource.UseVisualStyleBackColor = true;
            this.cbDefaultPaperSource.CheckedChanged += new System.EventHandler(this.cbDefault_Changed);
            // 
            // gbPrintInColor
            // 
            this.gbPrintInColor.Controls.Add(this.cbDefaultPrintInColor);
            this.gbPrintInColor.Controls.Add(this.cbPrintInColor);
            this.gbPrintInColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPrintInColor.Location = new System.Drawing.Point(8, 14);
            this.gbPrintInColor.Name = "gbPrintInColor";
            this.gbPrintInColor.Size = new System.Drawing.Size(348, 51);
            this.gbPrintInColor.TabIndex = 4;
            this.gbPrintInColor.TabStop = false;
            this.gbPrintInColor.Text = "Print in color or no?";
            // 
            // cbDefaultPrintInColor
            // 
            this.cbDefaultPrintInColor.AutoSize = true;
            this.cbDefaultPrintInColor.Checked = true;
            this.cbDefaultPrintInColor.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultPrintInColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultPrintInColor.Location = new System.Drawing.Point(7, 24);
            this.cbDefaultPrintInColor.Name = "cbDefaultPrintInColor";
            this.cbDefaultPrintInColor.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultPrintInColor.TabIndex = 1;
            this.cbDefaultPrintInColor.Text = "Use printer default";
            this.cbDefaultPrintInColor.UseVisualStyleBackColor = true;
            this.cbDefaultPrintInColor.CheckedChanged += new System.EventHandler(this.cbDefault_Changed);
            // 
            // cbPrintInColor
            // 
            this.cbPrintInColor.AutoSize = true;
            this.cbPrintInColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPrintInColor.Location = new System.Drawing.Point(224, 24);
            this.cbPrintInColor.Name = "cbPrintInColor";
            this.cbPrintInColor.Size = new System.Drawing.Size(84, 17);
            this.cbPrintInColor.TabIndex = 2;
            this.cbPrintInColor.Text = "Print in color";
            this.cbPrintInColor.UseVisualStyleBackColor = true;
            // 
            // cbUsePrinterSettings
            // 
            this.cbUsePrinterSettings.AutoSize = true;
            this.cbUsePrinterSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbUsePrinterSettings.Location = new System.Drawing.Point(9, 257);
            this.cbUsePrinterSettings.Name = "cbUsePrinterSettings";
            this.cbUsePrinterSettings.Size = new System.Drawing.Size(157, 17);
            this.cbUsePrinterSettings.TabIndex = 2;
            this.cbUsePrinterSettings.Text = "Use defined Printer Settings";
            this.cbUsePrinterSettings.UseVisualStyleBackColor = true;
            this.cbUsePrinterSettings.CheckedChanged += new System.EventHandler(this.cbUsePrinterSettings_CheckedChanged);
            // 
            // btnSetPrinterSettings
            // 
            this.btnSetPrinterSettings.Enabled = false;
            this.btnSetPrinterSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSetPrinterSettings.Location = new System.Drawing.Point(184, 257);
            this.btnSetPrinterSettings.Name = "btnSetPrinterSettings";
            this.btnSetPrinterSettings.Size = new System.Drawing.Size(107, 23);
            this.btnSetPrinterSettings.TabIndex = 3;
            this.btnSetPrinterSettings.Text = "Set Printer Settings";
            this.btnSetPrinterSettings.UseVisualStyleBackColor = true;
            this.btnSetPrinterSettings.Click += new System.EventHandler(this.btnSetPrinterSettings_Click);
            // 
            // cbUseWatermark
            // 
            this.cbUseWatermark.AutoSize = true;
            this.cbUseWatermark.Location = new System.Drawing.Point(143, 512);
            this.cbUseWatermark.Name = "cbUseWatermark";
            this.cbUseWatermark.Size = new System.Drawing.Size(100, 17);
            this.cbUseWatermark.TabIndex = 14;
            this.cbUseWatermark.Text = "Use Watermark";
            this.cbUseWatermark.UseVisualStyleBackColor = true;
            this.cbUseWatermark.CheckedChanged += new System.EventHandler(this.cbUseWatermark_CheckedChanged);
            // 
            // btnSetWatermark
            // 
            this.btnSetWatermark.Enabled = false;
            this.btnSetWatermark.Location = new System.Drawing.Point(247, 508);
            this.btnSetWatermark.Name = "btnSetWatermark";
            this.btnSetWatermark.Size = new System.Drawing.Size(108, 23);
            this.btnSetWatermark.TabIndex = 15;
            this.btnSetWatermark.Text = "Set Watermark";
            this.btnSetWatermark.UseVisualStyleBackColor = true;
            this.btnSetWatermark.Click += new System.EventHandler(this.btnSetWatermark_Click);
            // 
            // cbIsStream
            // 
            this.cbIsStream.AutoSize = true;
            this.cbIsStream.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbIsStream.Location = new System.Drawing.Point(15, 512);
            this.cbIsStream.Name = "cbIsStream";
            this.cbIsStream.Size = new System.Drawing.Size(110, 17);
            this.cbIsStream.TabIndex = 13;
            this.cbIsStream.Text = "Send file as byte[]";
            this.cbIsStream.UseVisualStyleBackColor = true;
            // 
            // gbScale
            // 
            this.gbScale.Controls.Add(this.rbScaleShrink);
            this.gbScale.Controls.Add(this.rbScaleFit);
            this.gbScale.Controls.Add(this.rbScaleActualSize);
            this.gbScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbScale.Location = new System.Drawing.Point(15, 403);
            this.gbScale.Name = "gbScale";
            this.gbScale.Size = new System.Drawing.Size(749, 44);
            this.gbScale.TabIndex = 11;
            this.gbScale.TabStop = false;
            this.gbScale.Text = "Scale";
            // 
            // rbScaleShrink
            // 
            this.rbScaleShrink.AutoSize = true;
            this.rbScaleShrink.Checked = true;
            this.rbScaleShrink.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbScaleShrink.Location = new System.Drawing.Point(305, 18);
            this.rbScaleShrink.Name = "rbScaleShrink";
            this.rbScaleShrink.Size = new System.Drawing.Size(106, 17);
            this.rbScaleShrink.TabIndex = 3;
            this.rbScaleShrink.TabStop = true;
            this.rbScaleShrink.Text = "Shrink to margins";
            this.rbScaleShrink.UseVisualStyleBackColor = true;
            // 
            // rbScaleFit
            // 
            this.rbScaleFit.AutoSize = true;
            this.rbScaleFit.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbScaleFit.Location = new System.Drawing.Point(163, 18);
            this.rbScaleFit.Name = "rbScaleFit";
            this.rbScaleFit.Size = new System.Drawing.Size(87, 17);
            this.rbScaleFit.TabIndex = 2;
            this.rbScaleFit.Text = "Fit to margins";
            this.rbScaleFit.UseVisualStyleBackColor = true;
            // 
            // rbScaleActualSize
            // 
            this.rbScaleActualSize.AutoSize = true;
            this.rbScaleActualSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbScaleActualSize.Location = new System.Drawing.Point(7, 18);
            this.rbScaleActualSize.Name = "rbScaleActualSize";
            this.rbScaleActualSize.Size = new System.Drawing.Size(97, 17);
            this.rbScaleActualSize.TabIndex = 1;
            this.rbScaleActualSize.Text = "Use actual size";
            this.rbScaleActualSize.UseVisualStyleBackColor = true;
            // 
            // gbPrintRange
            // 
            this.gbPrintRange.Controls.Add(this.rbPrintOdd);
            this.gbPrintRange.Controls.Add(this.rbPrintEven);
            this.gbPrintRange.Controls.Add(this.rbPrintEvenOdd);
            this.gbPrintRange.Controls.Add(this.label7);
            this.gbPrintRange.Controls.Add(this.tbPrintPages);
            this.gbPrintRange.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPrintRange.Location = new System.Drawing.Point(13, 307);
            this.gbPrintRange.Name = "gbPrintRange";
            this.gbPrintRange.Size = new System.Drawing.Size(749, 90);
            this.gbPrintRange.TabIndex = 10;
            this.gbPrintRange.TabStop = false;
            this.gbPrintRange.Text = "Print range";
            // 
            // rbPrintOdd
            // 
            this.rbPrintOdd.AutoSize = true;
            this.rbPrintOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPrintOdd.Location = new System.Drawing.Point(305, 60);
            this.rbPrintOdd.Name = "rbPrintOdd";
            this.rbPrintOdd.Size = new System.Drawing.Size(121, 17);
            this.rbPrintOdd.TabIndex = 4;
            this.rbPrintOdd.Text = "Print only odd pages";
            this.rbPrintOdd.UseVisualStyleBackColor = true;
            // 
            // rbPrintEven
            // 
            this.rbPrintEven.AutoSize = true;
            this.rbPrintEven.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPrintEven.Location = new System.Drawing.Point(163, 60);
            this.rbPrintEven.Name = "rbPrintEven";
            this.rbPrintEven.Size = new System.Drawing.Size(127, 17);
            this.rbPrintEven.TabIndex = 3;
            this.rbPrintEven.Text = "Print only even pages";
            this.rbPrintEven.UseVisualStyleBackColor = true;
            // 
            // rbPrintEvenOdd
            // 
            this.rbPrintEvenOdd.AutoSize = true;
            this.rbPrintEvenOdd.Checked = true;
            this.rbPrintEvenOdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPrintEvenOdd.Location = new System.Drawing.Point(7, 60);
            this.rbPrintEvenOdd.Name = "rbPrintEvenOdd";
            this.rbPrintEvenOdd.Size = new System.Drawing.Size(147, 17);
            this.rbPrintEvenOdd.TabIndex = 2;
            this.rbPrintEvenOdd.TabStop = true;
            this.rbPrintEvenOdd.Text = "Print even and odd pages";
            this.rbPrintEvenOdd.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.Location = new System.Drawing.Point(7, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(467, 13);
            this.label7.TabIndex = 18;
            this.label7.Text = "Print pages: (e.g. 1-3;4,7 - if empty it will print all pages). Reverse range is " +
    "also supported (e.g. 5-2)";
            // 
            // tbPrintPages
            // 
            this.tbPrintPages.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPrintPages.Location = new System.Drawing.Point(8, 33);
            this.tbPrintPages.Name = "tbPrintPages";
            this.tbPrintPages.Size = new System.Drawing.Size(717, 20);
            this.tbPrintPages.TabIndex = 1;
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(521, 512);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(232, 20);
            this.tbPassword.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(458, 512);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "Password:";
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(351, 549);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 18;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // PDFPrintPropertiesForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(770, 584);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.gbPrinterSettings);
            this.Controls.Add(this.cbUseWatermark);
            this.Controls.Add(this.btnSetWatermark);
            this.Controls.Add(this.cbIsStream);
            this.Controls.Add(this.gbScale);
            this.Controls.Add(this.gbPrintRange);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "PDFPrintPropertiesForm";
            this.Text = "PDFPrintProperties";
            this.Load += new System.EventHandler(this.PDFPrintProperties_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbPrinterSettings.ResumeLayout(false);
            this.gbPrinterSettings.PerformLayout();
            this.panelPrinterSettings.ResumeLayout(false);
            this.gbOrientation.ResumeLayout(false);
            this.gbOrientation.PerformLayout();
            this.gbPaperSize.ResumeLayout(false);
            this.gbPaperSize.PerformLayout();
            this.gbPrinterResolution.ResumeLayout(false);
            this.gbPrinterResolution.PerformLayout();
            this.gbPaperSource.ResumeLayout(false);
            this.gbPaperSource.PerformLayout();
            this.gbPrintInColor.ResumeLayout(false);
            this.gbPrintInColor.PerformLayout();
            this.gbScale.ResumeLayout(false);
            this.gbScale.PerformLayout();
            this.gbPrintRange.ResumeLayout(false);
            this.gbPrintRange.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbCentered;
        private System.Windows.Forms.CheckBox cbAutoRotate;
        private System.Windows.Forms.GroupBox gbPrinterSettings;
        private System.Windows.Forms.Panel panelPrinterSettings;
        private System.Windows.Forms.GroupBox gbOrientation;
        private System.Windows.Forms.RadioButton rbPortrait;
        private System.Windows.Forms.RadioButton rbLandscape;
        private System.Windows.Forms.CheckBox cbDefaultPrintOrientation;
        private System.Windows.Forms.GroupBox gbPaperSize;
        private System.Windows.Forms.ComboBox cmbxPaperSize;
        private System.Windows.Forms.Label lPaperSizes;
        private System.Windows.Forms.CheckBox cbDefaultPaperSize;
        private System.Windows.Forms.GroupBox gbPrinterResolution;
        private System.Windows.Forms.ComboBox cmbxPrinterResolutions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox cbDefaultPrinterResolution;
        private System.Windows.Forms.GroupBox gbPaperSource;
        private System.Windows.Forms.ComboBox cmbxPaperSource;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.CheckBox cbDefaultPaperSource;
        private System.Windows.Forms.GroupBox gbPrintInColor;
        private System.Windows.Forms.CheckBox cbDefaultPrintInColor;
        private System.Windows.Forms.CheckBox cbPrintInColor;
        private System.Windows.Forms.CheckBox cbUsePrinterSettings;
        private System.Windows.Forms.Button btnSetPrinterSettings;
        private System.Windows.Forms.CheckBox cbUseWatermark;
        private System.Windows.Forms.Button btnSetWatermark;
        private System.Windows.Forms.CheckBox cbIsStream;
        private System.Windows.Forms.GroupBox gbScale;
        private System.Windows.Forms.RadioButton rbScaleShrink;
        private System.Windows.Forms.RadioButton rbScaleFit;
        private System.Windows.Forms.RadioButton rbScaleActualSize;
        private System.Windows.Forms.GroupBox gbPrintRange;
        private System.Windows.Forms.RadioButton rbPrintOdd;
        private System.Windows.Forms.RadioButton rbPrintEven;
        private System.Windows.Forms.RadioButton rbPrintEvenOdd;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tbPrintPages;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnOK;
    }
}