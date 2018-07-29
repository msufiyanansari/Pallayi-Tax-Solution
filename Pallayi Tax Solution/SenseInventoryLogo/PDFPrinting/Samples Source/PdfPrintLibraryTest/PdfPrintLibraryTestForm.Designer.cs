namespace PdfPrintLibraryTest
{
    partial class PdfPrintLibraryTestForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfPrintLibraryTestForm));
            this.btnPrint = new System.Windows.Forms.Button();
            this.lSelectPdfFile = new System.Windows.Forms.Label();
            this.tbFileName = new System.Windows.Forms.TextBox();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.openPDFFileDialog = new System.Windows.Forms.OpenFileDialog();
            this.btnSavePdfAsImage = new System.Windows.Forms.Button();
            this.gbImageSettings = new System.Windows.Forms.GroupBox();
            this.gbMultiTiff = new System.Windows.Forms.GroupBox();
            this.cmbxTiffCompression = new System.Windows.Forms.ComboBox();
            this.cbxMultiTiff = new System.Windows.Forms.CheckBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.numYResolution = new System.Windows.Forms.NumericUpDown();
            this.label6 = new System.Windows.Forms.Label();
            this.lXResolution = new System.Windows.Forms.Label();
            this.numXResolution = new System.Windows.Forms.NumericUpDown();
            this.btnImageFileName = new System.Windows.Forms.Button();
            this.tbImageFileName = new System.Windows.Forms.TextBox();
            this.lImageFileName = new System.Windows.Forms.Label();
            this.lZoomFactor = new System.Windows.Forms.Label();
            this.numZoom = new System.Windows.Forms.NumericUpDown();
            this.numToPage = new System.Windows.Forms.NumericUpDown();
            this.ltoPage = new System.Windows.Forms.Label();
            this.numFrom = new System.Windows.Forms.NumericUpDown();
            this.lFromPage = new System.Windows.Forms.Label();
            this.lImageQuality = new System.Windows.Forms.Label();
            this.numQuality = new System.Windows.Forms.NumericUpDown();
            this.gbColorType = new System.Windows.Forms.GroupBox();
            this.rbAsItIsInPDF = new System.Windows.Forms.RadioButton();
            this.rbGray = new System.Windows.Forms.RadioButton();
            this.rbBlackAndWhite = new System.Windows.Forms.RadioButton();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.tab = new System.Windows.Forms.TabControl();
            this.tabPagePrintPDF = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cbCentered = new System.Windows.Forms.CheckBox();
            this.cbAutoRotate = new System.Windows.Forms.CheckBox();
            this.gbPrinterSettings = new System.Windows.Forms.GroupBox();
            this.panelPrinterSettings = new System.Windows.Forms.Panel();
            this.gbCopies = new System.Windows.Forms.GroupBox();
            this.cbDefaultNumCopies = new System.Windows.Forms.CheckBox();
            this.lCopies = new System.Windows.Forms.Label();
            this.numCopies = new System.Windows.Forms.NumericUpDown();
            this.label5 = new System.Windows.Forms.Label();
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
            this.cmbxPrinterNames = new System.Windows.Forms.ComboBox();
            this.gbCollate = new System.Windows.Forms.GroupBox();
            this.cbCollate = new System.Windows.Forms.CheckBox();
            this.cbDefaultCollate = new System.Windows.Forms.CheckBox();
            this.gbPaperSource = new System.Windows.Forms.GroupBox();
            this.cmbxPaperSource = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbDefaultPaperSource = new System.Windows.Forms.CheckBox();
            this.gbPrintInColor = new System.Windows.Forms.GroupBox();
            this.cbDefaultPrintInColor = new System.Windows.Forms.CheckBox();
            this.cbPrintInColor = new System.Windows.Forms.CheckBox();
            this.gbDuplexType = new System.Windows.Forms.GroupBox();
            this.rbDuplexVertical = new System.Windows.Forms.RadioButton();
            this.rbDuplexSimplex = new System.Windows.Forms.RadioButton();
            this.rbDuplexHorizontal = new System.Windows.Forms.RadioButton();
            this.cbDefaultDuplex = new System.Windows.Forms.CheckBox();
            this.cbUsePrinterSettings = new System.Windows.Forms.CheckBox();
            this.cbUsePrintDialog = new System.Windows.Forms.CheckBox();
            this.btnSetPrinterSettings = new System.Windows.Forms.Button();
            this.cbUseWatermark = new System.Windows.Forms.CheckBox();
            this.btnSetWatermark = new System.Windows.Forms.Button();
            this.tbDocumentName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
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
            this.tabPagePrintWithAdobe = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cbAutoRotateAdobe = new System.Windows.Forms.CheckBox();
            this.gbPrinterSettingsAdobe = new System.Windows.Forms.GroupBox();
            this.panelPrinterSettingsAdobe = new System.Windows.Forms.Panel();
            this.gbCopiesAdobe = new System.Windows.Forms.GroupBox();
            this.cbDefaultNumCopiesAdobe = new System.Windows.Forms.CheckBox();
            this.label16 = new System.Windows.Forms.Label();
            this.numCopiesAdobe = new System.Windows.Forms.NumericUpDown();
            this.label17 = new System.Windows.Forms.Label();
            this.cmbxPrinterNamesAdobe = new System.Windows.Forms.ComboBox();
            this.gbPrintInColorAdobe = new System.Windows.Forms.GroupBox();
            this.cbDefaultPrintInColorAdobe = new System.Windows.Forms.CheckBox();
            this.cbPrintInColorAdobe = new System.Windows.Forms.CheckBox();
            this.gbDuplexTypeAdobe = new System.Windows.Forms.GroupBox();
            this.rbDuplexVerticalAdobe = new System.Windows.Forms.RadioButton();
            this.rbDuplexSimplexAdobe = new System.Windows.Forms.RadioButton();
            this.rbDuplexHorizontalAdobe = new System.Windows.Forms.RadioButton();
            this.cbDefaultDuplexAdobe = new System.Windows.Forms.CheckBox();
            this.gbPaperSourceAdobe = new System.Windows.Forms.GroupBox();
            this.cmbxPaperSourceAdobe = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.cbDefaultPaperSourceAdobe = new System.Windows.Forms.CheckBox();
            this.gbCollateAdobe = new System.Windows.Forms.GroupBox();
            this.cbCollateAdobe = new System.Windows.Forms.CheckBox();
            this.cbDefaultCollateAdobe = new System.Windows.Forms.CheckBox();
            this.gbPaperSizeAdobe = new System.Windows.Forms.GroupBox();
            this.cmbxPaperSizeAdobe = new System.Windows.Forms.ComboBox();
            this.label15 = new System.Windows.Forms.Label();
            this.cbDefaultPaperSizeAdobe = new System.Windows.Forms.CheckBox();
            this.gbPrinterResolutionAdobe = new System.Windows.Forms.GroupBox();
            this.cmbxPrinterResolutionsAdobe = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbDefaultPrinterResolutionAdobe = new System.Windows.Forms.CheckBox();
            this.gbOrientationAdobe = new System.Windows.Forms.GroupBox();
            this.rbPortraitAdobe = new System.Windows.Forms.RadioButton();
            this.rbLandscapeAdobe = new System.Windows.Forms.RadioButton();
            this.cbDefaultPrintOrientationAdobe = new System.Windows.Forms.CheckBox();
            this.cbUsePrintDialogAdobe = new System.Windows.Forms.CheckBox();
            this.cbUsePrinterSettingsAdobe = new System.Windows.Forms.CheckBox();
            this.btnSetPrinterSettingsAdobe = new System.Windows.Forms.Button();
            this.btnPrintWithAdobe = new System.Windows.Forms.Button();
            this.gbScaleAdobe = new System.Windows.Forms.GroupBox();
            this.rbScaleShrinkAdobe = new System.Windows.Forms.RadioButton();
            this.rbScaleActualSizeAdobe = new System.Windows.Forms.RadioButton();
            this.gbPrintRangeAdobe = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.tbPrintPagesAdobe = new System.Windows.Forms.TextBox();
            this.tabPageSaveImages = new System.Windows.Forms.TabPage();
            this.cbIsStreamImage = new System.Windows.Forms.CheckBox();
            this.lPassword = new System.Windows.Forms.Label();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.gbImageSettings.SuspendLayout();
            this.gbMultiTiff.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXResolution)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToPage)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality)).BeginInit();
            this.gbColorType.SuspendLayout();
            this.tab.SuspendLayout();
            this.tabPagePrintPDF.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.gbPrinterSettings.SuspendLayout();
            this.panelPrinterSettings.SuspendLayout();
            this.gbCopies.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).BeginInit();
            this.gbOrientation.SuspendLayout();
            this.gbPaperSize.SuspendLayout();
            this.gbPrinterResolution.SuspendLayout();
            this.gbCollate.SuspendLayout();
            this.gbPaperSource.SuspendLayout();
            this.gbPrintInColor.SuspendLayout();
            this.gbDuplexType.SuspendLayout();
            this.gbScale.SuspendLayout();
            this.gbPrintRange.SuspendLayout();
            this.tabPagePrintWithAdobe.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.gbPrinterSettingsAdobe.SuspendLayout();
            this.panelPrinterSettingsAdobe.SuspendLayout();
            this.gbCopiesAdobe.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopiesAdobe)).BeginInit();
            this.gbPrintInColorAdobe.SuspendLayout();
            this.gbDuplexTypeAdobe.SuspendLayout();
            this.gbPaperSourceAdobe.SuspendLayout();
            this.gbCollateAdobe.SuspendLayout();
            this.gbPaperSizeAdobe.SuspendLayout();
            this.gbPrinterResolutionAdobe.SuspendLayout();
            this.gbOrientationAdobe.SuspendLayout();
            this.gbScaleAdobe.SuspendLayout();
            this.gbPrintRangeAdobe.SuspendLayout();
            this.tabPageSaveImages.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnPrint
            // 
            this.btnPrint.Location = new System.Drawing.Point(652, 627);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(88, 23);
            this.btnPrint.TabIndex = 9;
            this.btnPrint.Text = "Print";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // lSelectPdfFile
            // 
            this.lSelectPdfFile.AutoSize = true;
            this.lSelectPdfFile.Location = new System.Drawing.Point(13, 22);
            this.lSelectPdfFile.Name = "lSelectPdfFile";
            this.lSelectPdfFile.Size = new System.Drawing.Size(89, 13);
            this.lSelectPdfFile.TabIndex = 1;
            this.lSelectPdfFile.Text = "Select a PDF file:";
            // 
            // tbFileName
            // 
            this.tbFileName.Location = new System.Drawing.Point(13, 39);
            this.tbFileName.Name = "tbFileName";
            this.tbFileName.Size = new System.Drawing.Size(633, 20);
            this.tbFileName.TabIndex = 1;
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(665, 39);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(42, 23);
            this.btnOpenFile.TabIndex = 2;
            this.btnOpenFile.Text = "...";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // openPDFFileDialog
            // 
            this.openPDFFileDialog.FileName = "*.pdf";
            // 
            // btnSavePdfAsImage
            // 
            this.btnSavePdfAsImage.Location = new System.Drawing.Point(261, 461);
            this.btnSavePdfAsImage.Name = "btnSavePdfAsImage";
            this.btnSavePdfAsImage.Size = new System.Drawing.Size(178, 23);
            this.btnSavePdfAsImage.TabIndex = 3;
            this.btnSavePdfAsImage.Text = "Save PDF page(s) as image(s)";
            this.btnSavePdfAsImage.UseVisualStyleBackColor = true;
            this.btnSavePdfAsImage.Click += new System.EventHandler(this.btnSavePdfAsImage_Click);
            // 
            // gbImageSettings
            // 
            this.gbImageSettings.Controls.Add(this.gbMultiTiff);
            this.gbImageSettings.Controls.Add(this.label4);
            this.gbImageSettings.Controls.Add(this.label3);
            this.gbImageSettings.Controls.Add(this.label2);
            this.gbImageSettings.Controls.Add(this.label1);
            this.gbImageSettings.Controls.Add(this.numYResolution);
            this.gbImageSettings.Controls.Add(this.label6);
            this.gbImageSettings.Controls.Add(this.lXResolution);
            this.gbImageSettings.Controls.Add(this.numXResolution);
            this.gbImageSettings.Controls.Add(this.btnImageFileName);
            this.gbImageSettings.Controls.Add(this.tbImageFileName);
            this.gbImageSettings.Controls.Add(this.lImageFileName);
            this.gbImageSettings.Controls.Add(this.lZoomFactor);
            this.gbImageSettings.Controls.Add(this.numZoom);
            this.gbImageSettings.Controls.Add(this.numToPage);
            this.gbImageSettings.Controls.Add(this.ltoPage);
            this.gbImageSettings.Controls.Add(this.numFrom);
            this.gbImageSettings.Controls.Add(this.lFromPage);
            this.gbImageSettings.Controls.Add(this.lImageQuality);
            this.gbImageSettings.Controls.Add(this.numQuality);
            this.gbImageSettings.Controls.Add(this.gbColorType);
            this.gbImageSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbImageSettings.Location = new System.Drawing.Point(28, 19);
            this.gbImageSettings.Name = "gbImageSettings";
            this.gbImageSettings.Size = new System.Drawing.Size(704, 400);
            this.gbImageSettings.TabIndex = 1;
            this.gbImageSettings.TabStop = false;
            this.gbImageSettings.Text = "Image settings";
            // 
            // gbMultiTiff
            // 
            this.gbMultiTiff.Controls.Add(this.cmbxTiffCompression);
            this.gbMultiTiff.Controls.Add(this.cbxMultiTiff);
            this.gbMultiTiff.Controls.Add(this.label10);
            this.gbMultiTiff.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbMultiTiff.Location = new System.Drawing.Point(303, 330);
            this.gbMultiTiff.Name = "gbMultiTiff";
            this.gbMultiTiff.Size = new System.Drawing.Size(383, 55);
            this.gbMultiTiff.TabIndex = 22;
            this.gbMultiTiff.TabStop = false;
            this.gbMultiTiff.Text = "Multi page tiff file";
            // 
            // cmbxTiffCompression
            // 
            this.cmbxTiffCompression.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxTiffCompression.FormattingEnabled = true;
            this.cmbxTiffCompression.Items.AddRange(new object[] {
            "LZW",
            "CCITT3",
            "CCITT4",
            "None"});
            this.cmbxTiffCompression.Location = new System.Drawing.Point(256, 26);
            this.cmbxTiffCompression.Name = "cmbxTiffCompression";
            this.cmbxTiffCompression.Size = new System.Drawing.Size(121, 21);
            this.cmbxTiffCompression.TabIndex = 11;
            // 
            // cbxMultiTiff
            // 
            this.cbxMultiTiff.AutoSize = true;
            this.cbxMultiTiff.Location = new System.Drawing.Point(6, 26);
            this.cbxMultiTiff.Name = "cbxMultiTiff";
            this.cbxMultiTiff.Size = new System.Drawing.Size(138, 17);
            this.cbxMultiTiff.TabIndex = 10;
            this.cbxMultiTiff.Text = "Create multi page tiff file";
            this.cbxMultiTiff.UseVisualStyleBackColor = true;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(165, 26);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(88, 13);
            this.label10.TabIndex = 21;
            this.label10.Text = "Tiff Compression:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(22, 253);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(530, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "(Example: From page = 2, To Page = 4,  outputfilename = test.jpg it will create f" +
    "iles test2.jpg, test3.jpg, test4.jpg)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(22, 236);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(528, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "If creating images from more than one page,  name of output file will be output i" +
    "mage file name + page number. ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(19, 219);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(502, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Type of image file is determined by filename extension. If extension is omitted t" +
    "han it will be saved as bmp.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(185, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(275, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "It has effect just in some image formats. (For example jpg)";
            // 
            // numYResolution
            // 
            this.numYResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numYResolution.Location = new System.Drawing.Point(234, 330);
            this.numYResolution.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numYResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numYResolution.Name = "numYResolution";
            this.numYResolution.Size = new System.Drawing.Size(48, 20);
            this.numYResolution.TabIndex = 9;
            this.numYResolution.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.Location = new System.Drawing.Point(162, 330);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Y resolution:";
            // 
            // lXResolution
            // 
            this.lXResolution.AutoSize = true;
            this.lXResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lXResolution.Location = new System.Drawing.Point(15, 330);
            this.lXResolution.Name = "lXResolution";
            this.lXResolution.Size = new System.Drawing.Size(65, 13);
            this.lXResolution.TabIndex = 13;
            this.lXResolution.Text = "X resolution:";
            // 
            // numXResolution
            // 
            this.numXResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numXResolution.Location = new System.Drawing.Point(83, 330);
            this.numXResolution.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numXResolution.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numXResolution.Name = "numXResolution";
            this.numXResolution.Size = new System.Drawing.Size(48, 20);
            this.numXResolution.TabIndex = 8;
            this.numXResolution.Value = new decimal(new int[] {
            200,
            0,
            0,
            0});
            // 
            // btnImageFileName
            // 
            this.btnImageFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnImageFileName.Location = new System.Drawing.Point(644, 300);
            this.btnImageFileName.Name = "btnImageFileName";
            this.btnImageFileName.Size = new System.Drawing.Size(42, 23);
            this.btnImageFileName.TabIndex = 7;
            this.btnImageFileName.Text = "...";
            this.btnImageFileName.UseVisualStyleBackColor = true;
            this.btnImageFileName.Click += new System.EventHandler(this.btnImageFileName_Click);
            // 
            // tbImageFileName
            // 
            this.tbImageFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbImageFileName.Location = new System.Drawing.Point(16, 302);
            this.tbImageFileName.Name = "tbImageFileName";
            this.tbImageFileName.Size = new System.Drawing.Size(622, 20);
            this.tbImageFileName.TabIndex = 6;
            // 
            // lImageFileName
            // 
            this.lImageFileName.AutoSize = true;
            this.lImageFileName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lImageFileName.Location = new System.Drawing.Point(19, 285);
            this.lImageFileName.Name = "lImageFileName";
            this.lImageFileName.Size = new System.Drawing.Size(118, 13);
            this.lImageFileName.TabIndex = 9;
            this.lImageFileName.Text = "Output image file name:";
            // 
            // lZoomFactor
            // 
            this.lZoomFactor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lZoomFactor.Location = new System.Drawing.Point(23, 124);
            this.lZoomFactor.Name = "lZoomFactor";
            this.lZoomFactor.Size = new System.Drawing.Size(69, 23);
            this.lZoomFactor.TabIndex = 8;
            this.lZoomFactor.Text = "Zoom factor:";
            // 
            // numZoom
            // 
            this.numZoom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numZoom.Location = new System.Drawing.Point(98, 124);
            this.numZoom.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numZoom.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numZoom.Name = "numZoom";
            this.numZoom.Size = new System.Drawing.Size(48, 20);
            this.numZoom.TabIndex = 3;
            this.numZoom.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // numToPage
            // 
            this.numToPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numToPage.Location = new System.Drawing.Point(233, 156);
            this.numToPage.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numToPage.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numToPage.Name = "numToPage";
            this.numToPage.Size = new System.Drawing.Size(48, 20);
            this.numToPage.TabIndex = 5;
            this.numToPage.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // ltoPage
            // 
            this.ltoPage.AutoSize = true;
            this.ltoPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.ltoPage.Location = new System.Drawing.Point(182, 156);
            this.ltoPage.Name = "ltoPage";
            this.ltoPage.Size = new System.Drawing.Size(50, 13);
            this.ltoPage.TabIndex = 3;
            this.ltoPage.Text = "To page:";
            // 
            // numFrom
            // 
            this.numFrom.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numFrom.Location = new System.Drawing.Point(98, 156);
            this.numFrom.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numFrom.Name = "numFrom";
            this.numFrom.Size = new System.Drawing.Size(48, 20);
            this.numFrom.TabIndex = 4;
            this.numFrom.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // lFromPage
            // 
            this.lFromPage.AutoSize = true;
            this.lFromPage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lFromPage.Location = new System.Drawing.Point(32, 156);
            this.lFromPage.Name = "lFromPage";
            this.lFromPage.Size = new System.Drawing.Size(60, 13);
            this.lFromPage.TabIndex = 3;
            this.lFromPage.Text = "From page:";
            // 
            // lImageQuality
            // 
            this.lImageQuality.AutoSize = true;
            this.lImageQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lImageQuality.Location = new System.Drawing.Point(20, 90);
            this.lImageQuality.Name = "lImageQuality";
            this.lImageQuality.Size = new System.Drawing.Size(72, 13);
            this.lImageQuality.TabIndex = 2;
            this.lImageQuality.Text = "Image quality:";
            // 
            // numQuality
            // 
            this.numQuality.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numQuality.Location = new System.Drawing.Point(98, 90);
            this.numQuality.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numQuality.Name = "numQuality";
            this.numQuality.Size = new System.Drawing.Size(48, 20);
            this.numQuality.TabIndex = 2;
            this.numQuality.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
            // 
            // gbColorType
            // 
            this.gbColorType.Controls.Add(this.rbAsItIsInPDF);
            this.gbColorType.Controls.Add(this.rbGray);
            this.gbColorType.Controls.Add(this.rbBlackAndWhite);
            this.gbColorType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbColorType.Location = new System.Drawing.Point(16, 29);
            this.gbColorType.Name = "gbColorType";
            this.gbColorType.Size = new System.Drawing.Size(325, 44);
            this.gbColorType.TabIndex = 1;
            this.gbColorType.TabStop = false;
            this.gbColorType.Text = "Color Type";
            // 
            // rbAsItIsInPDF
            // 
            this.rbAsItIsInPDF.AutoSize = true;
            this.rbAsItIsInPDF.Checked = true;
            this.rbAsItIsInPDF.Location = new System.Drawing.Point(217, 19);
            this.rbAsItIsInPDF.Name = "rbAsItIsInPDF";
            this.rbAsItIsInPDF.Size = new System.Drawing.Size(90, 17);
            this.rbAsItIsInPDF.TabIndex = 2;
            this.rbAsItIsInPDF.TabStop = true;
            this.rbAsItIsInPDF.Text = "As it is in PDF";
            this.rbAsItIsInPDF.UseVisualStyleBackColor = true;
            // 
            // rbGray
            // 
            this.rbGray.AutoSize = true;
            this.rbGray.Location = new System.Drawing.Point(126, 19);
            this.rbGray.Name = "rbGray";
            this.rbGray.Size = new System.Drawing.Size(47, 17);
            this.rbGray.TabIndex = 1;
            this.rbGray.Text = "Gray";
            this.rbGray.UseVisualStyleBackColor = true;
            // 
            // rbBlackAndWhite
            // 
            this.rbBlackAndWhite.AutoSize = true;
            this.rbBlackAndWhite.Location = new System.Drawing.Point(7, 20);
            this.rbBlackAndWhite.Name = "rbBlackAndWhite";
            this.rbBlackAndWhite.Size = new System.Drawing.Size(101, 17);
            this.rbBlackAndWhite.TabIndex = 0;
            this.rbBlackAndWhite.Text = "Black and white";
            this.rbBlackAndWhite.UseVisualStyleBackColor = true;
            // 
            // tab
            // 
            this.tab.Controls.Add(this.tabPagePrintPDF);
            this.tab.Controls.Add(this.tabPagePrintWithAdobe);
            this.tab.Controls.Add(this.tabPageSaveImages);
            this.tab.Location = new System.Drawing.Point(12, 94);
            this.tab.Name = "tab";
            this.tab.SelectedIndex = 0;
            this.tab.Size = new System.Drawing.Size(773, 681);
            this.tab.TabIndex = 4;
            // 
            // tabPagePrintPDF
            // 
            this.tabPagePrintPDF.Controls.Add(this.groupBox2);
            this.tabPagePrintPDF.Controls.Add(this.gbPrinterSettings);
            this.tabPagePrintPDF.Controls.Add(this.cbUseWatermark);
            this.tabPagePrintPDF.Controls.Add(this.btnSetWatermark);
            this.tabPagePrintPDF.Controls.Add(this.tbDocumentName);
            this.tabPagePrintPDF.Controls.Add(this.label9);
            this.tabPagePrintPDF.Controls.Add(this.cbIsStream);
            this.tabPagePrintPDF.Controls.Add(this.gbScale);
            this.tabPagePrintPDF.Controls.Add(this.gbPrintRange);
            this.tabPagePrintPDF.Controls.Add(this.btnPrint);
            this.tabPagePrintPDF.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrintPDF.Name = "tabPagePrintPDF";
            this.tabPagePrintPDF.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrintPDF.Size = new System.Drawing.Size(765, 655);
            this.tabPagePrintPDF.TabIndex = 0;
            this.tabPagePrintPDF.Text = "Print PDF";
            this.tabPagePrintPDF.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbCentered);
            this.groupBox2.Controls.Add(this.cbAutoRotate);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox2.Location = new System.Drawing.Point(6, 549);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(750, 44);
            this.groupBox2.TabIndex = 4;
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
            this.gbPrinterSettings.Controls.Add(this.cbUsePrintDialog);
            this.gbPrinterSettings.Controls.Add(this.btnSetPrinterSettings);
            this.gbPrinterSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPrinterSettings.Location = new System.Drawing.Point(6, 6);
            this.gbPrinterSettings.Name = "gbPrinterSettings";
            this.gbPrinterSettings.Size = new System.Drawing.Size(750, 392);
            this.gbPrinterSettings.TabIndex = 1;
            this.gbPrinterSettings.TabStop = false;
            this.gbPrinterSettings.Text = "Printer Settings";
            // 
            // panelPrinterSettings
            // 
            this.panelPrinterSettings.Controls.Add(this.gbCopies);
            this.panelPrinterSettings.Controls.Add(this.label5);
            this.panelPrinterSettings.Controls.Add(this.gbOrientation);
            this.panelPrinterSettings.Controls.Add(this.gbPaperSize);
            this.panelPrinterSettings.Controls.Add(this.gbPrinterResolution);
            this.panelPrinterSettings.Controls.Add(this.cmbxPrinterNames);
            this.panelPrinterSettings.Controls.Add(this.gbCollate);
            this.panelPrinterSettings.Controls.Add(this.gbPaperSource);
            this.panelPrinterSettings.Controls.Add(this.gbPrintInColor);
            this.panelPrinterSettings.Controls.Add(this.gbDuplexType);
            this.panelPrinterSettings.Location = new System.Drawing.Point(3, 15);
            this.panelPrinterSettings.Name = "panelPrinterSettings";
            this.panelPrinterSettings.Size = new System.Drawing.Size(741, 351);
            this.panelPrinterSettings.TabIndex = 1;
            // 
            // gbCopies
            // 
            this.gbCopies.Controls.Add(this.cbDefaultNumCopies);
            this.gbCopies.Controls.Add(this.lCopies);
            this.gbCopies.Controls.Add(this.numCopies);
            this.gbCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbCopies.Location = new System.Drawing.Point(6, 29);
            this.gbCopies.Name = "gbCopies";
            this.gbCopies.Size = new System.Drawing.Size(348, 51);
            this.gbCopies.TabIndex = 2;
            this.gbCopies.TabStop = false;
            this.gbCopies.Text = "Number of copies";
            // 
            // cbDefaultNumCopies
            // 
            this.cbDefaultNumCopies.AutoSize = true;
            this.cbDefaultNumCopies.Checked = true;
            this.cbDefaultNumCopies.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultNumCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultNumCopies.Location = new System.Drawing.Point(7, 20);
            this.cbDefaultNumCopies.Name = "cbDefaultNumCopies";
            this.cbDefaultNumCopies.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultNumCopies.TabIndex = 1;
            this.cbDefaultNumCopies.Text = "Use printer default";
            this.cbDefaultNumCopies.UseVisualStyleBackColor = true;
            this.cbDefaultNumCopies.CheckedChanged += new System.EventHandler(this.cbDefault_CheckedChanged);
            // 
            // lCopies
            // 
            this.lCopies.AutoSize = true;
            this.lCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lCopies.Location = new System.Drawing.Point(125, 20);
            this.lCopies.Name = "lCopies";
            this.lCopies.Size = new System.Drawing.Size(120, 13);
            this.lCopies.TabIndex = 7;
            this.lCopies.Text = "or set number of copies:";
            // 
            // numCopies
            // 
            this.numCopies.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numCopies.Location = new System.Drawing.Point(251, 20);
            this.numCopies.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCopies.Name = "numCopies";
            this.numCopies.Size = new System.Drawing.Size(58, 20);
            this.numCopies.TabIndex = 2;
            this.numCopies.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.Location = new System.Drawing.Point(3, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(69, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Printer name:";
            // 
            // gbOrientation
            // 
            this.gbOrientation.Controls.Add(this.rbPortrait);
            this.gbOrientation.Controls.Add(this.rbLandscape);
            this.gbOrientation.Controls.Add(this.cbDefaultPrintOrientation);
            this.gbOrientation.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbOrientation.Location = new System.Drawing.Point(6, 310);
            this.gbOrientation.Name = "gbOrientation";
            this.gbOrientation.Size = new System.Drawing.Size(730, 36);
            this.gbOrientation.TabIndex = 9;
            this.gbOrientation.TabStop = false;
            this.gbOrientation.Text = "Paper orientation:";
            // 
            // rbPortrait
            // 
            this.rbPortrait.AutoSize = true;
            this.rbPortrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPortrait.Location = new System.Drawing.Point(351, 13);
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
            this.rbLandscape.Location = new System.Drawing.Point(251, 13);
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
            this.cbDefaultPrintOrientation.Location = new System.Drawing.Point(128, 13);
            this.cbDefaultPrintOrientation.Name = "cbDefaultPrintOrientation";
            this.cbDefaultPrintOrientation.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultPrintOrientation.TabIndex = 1;
            this.cbDefaultPrintOrientation.Text = "Use printer default";
            this.cbDefaultPrintOrientation.UseVisualStyleBackColor = true;
            this.cbDefaultPrintOrientation.CheckedChanged += new System.EventHandler(this.cbDefault_CheckedChanged);
            // 
            // gbPaperSize
            // 
            this.gbPaperSize.Controls.Add(this.cmbxPaperSize);
            this.gbPaperSize.Controls.Add(this.lPaperSizes);
            this.gbPaperSize.Controls.Add(this.cbDefaultPaperSize);
            this.gbPaperSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPaperSize.Location = new System.Drawing.Point(6, 252);
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
            this.cbDefaultPaperSize.CheckedChanged += new System.EventHandler(this.cbDefault_CheckedChanged);
            // 
            // gbPrinterResolution
            // 
            this.gbPrinterResolution.Controls.Add(this.cmbxPrinterResolutions);
            this.gbPrinterResolution.Controls.Add(this.label8);
            this.gbPrinterResolution.Controls.Add(this.cbDefaultPrinterResolution);
            this.gbPrinterResolution.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPrinterResolution.Location = new System.Drawing.Point(6, 196);
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
            this.cbDefaultPrinterResolution.CheckedChanged += new System.EventHandler(this.cbDefault_CheckedChanged);
            // 
            // cmbxPrinterNames
            // 
            this.cmbxPrinterNames.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPrinterNames.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbxPrinterNames.FormattingEnabled = true;
            this.cmbxPrinterNames.Location = new System.Drawing.Point(85, 3);
            this.cmbxPrinterNames.Name = "cmbxPrinterNames";
            this.cmbxPrinterNames.Size = new System.Drawing.Size(646, 21);
            this.cmbxPrinterNames.TabIndex = 1;
            this.cmbxPrinterNames.SelectedIndexChanged += new System.EventHandler(this.cmbxPrinterNames_SelectedIndexChanged);
            // 
            // gbCollate
            // 
            this.gbCollate.Controls.Add(this.cbCollate);
            this.gbCollate.Controls.Add(this.cbDefaultCollate);
            this.gbCollate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbCollate.Location = new System.Drawing.Point(358, 87);
            this.gbCollate.Name = "gbCollate";
            this.gbCollate.Size = new System.Drawing.Size(372, 51);
            this.gbCollate.TabIndex = 5;
            this.gbCollate.TabStop = false;
            this.gbCollate.Text = "Collate";
            // 
            // cbCollate
            // 
            this.cbCollate.AutoSize = true;
            this.cbCollate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCollate.Location = new System.Drawing.Point(264, 24);
            this.cbCollate.Name = "cbCollate";
            this.cbCollate.Size = new System.Drawing.Size(58, 17);
            this.cbCollate.TabIndex = 2;
            this.cbCollate.Text = "Collate";
            this.cbCollate.UseVisualStyleBackColor = true;
            // 
            // cbDefaultCollate
            // 
            this.cbDefaultCollate.AutoSize = true;
            this.cbDefaultCollate.Checked = true;
            this.cbDefaultCollate.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultCollate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultCollate.Location = new System.Drawing.Point(7, 24);
            this.cbDefaultCollate.Name = "cbDefaultCollate";
            this.cbDefaultCollate.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultCollate.TabIndex = 1;
            this.cbDefaultCollate.Text = "Use printer default";
            this.cbDefaultCollate.UseVisualStyleBackColor = true;
            this.cbDefaultCollate.CheckedChanged += new System.EventHandler(this.cbDefault_CheckedChanged);
            // 
            // gbPaperSource
            // 
            this.gbPaperSource.Controls.Add(this.cmbxPaperSource);
            this.gbPaperSource.Controls.Add(this.label13);
            this.gbPaperSource.Controls.Add(this.cbDefaultPaperSource);
            this.gbPaperSource.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPaperSource.Location = new System.Drawing.Point(6, 144);
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
            this.cbDefaultPaperSource.CheckedChanged += new System.EventHandler(this.cbDefault_CheckedChanged);
            // 
            // gbPrintInColor
            // 
            this.gbPrintInColor.Controls.Add(this.cbDefaultPrintInColor);
            this.gbPrintInColor.Controls.Add(this.cbPrintInColor);
            this.gbPrintInColor.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPrintInColor.Location = new System.Drawing.Point(6, 87);
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
            this.cbDefaultPrintInColor.CheckedChanged += new System.EventHandler(this.cbDefault_CheckedChanged);
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
            // gbDuplexType
            // 
            this.gbDuplexType.Controls.Add(this.rbDuplexVertical);
            this.gbDuplexType.Controls.Add(this.rbDuplexSimplex);
            this.gbDuplexType.Controls.Add(this.rbDuplexHorizontal);
            this.gbDuplexType.Controls.Add(this.cbDefaultDuplex);
            this.gbDuplexType.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbDuplexType.Location = new System.Drawing.Point(358, 30);
            this.gbDuplexType.Name = "gbDuplexType";
            this.gbDuplexType.Size = new System.Drawing.Size(372, 50);
            this.gbDuplexType.TabIndex = 3;
            this.gbDuplexType.TabStop = false;
            this.gbDuplexType.Text = "Duplex type";
            // 
            // rbDuplexVertical
            // 
            this.rbDuplexVertical.AutoSize = true;
            this.rbDuplexVertical.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbDuplexVertical.Location = new System.Drawing.Point(269, 20);
            this.rbDuplexVertical.Name = "rbDuplexVertical";
            this.rbDuplexVertical.Size = new System.Drawing.Size(60, 17);
            this.rbDuplexVertical.TabIndex = 4;
            this.rbDuplexVertical.TabStop = true;
            this.rbDuplexVertical.Text = "Vertical";
            this.rbDuplexVertical.UseVisualStyleBackColor = true;
            // 
            // rbDuplexSimplex
            // 
            this.rbDuplexSimplex.AutoSize = true;
            this.rbDuplexSimplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbDuplexSimplex.Location = new System.Drawing.Point(200, 20);
            this.rbDuplexSimplex.Name = "rbDuplexSimplex";
            this.rbDuplexSimplex.Size = new System.Drawing.Size(61, 17);
            this.rbDuplexSimplex.TabIndex = 3;
            this.rbDuplexSimplex.TabStop = true;
            this.rbDuplexSimplex.Text = "Simplex";
            this.rbDuplexSimplex.UseVisualStyleBackColor = true;
            // 
            // rbDuplexHorizontal
            // 
            this.rbDuplexHorizontal.AutoSize = true;
            this.rbDuplexHorizontal.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbDuplexHorizontal.Location = new System.Drawing.Point(122, 20);
            this.rbDuplexHorizontal.Name = "rbDuplexHorizontal";
            this.rbDuplexHorizontal.Size = new System.Drawing.Size(72, 17);
            this.rbDuplexHorizontal.TabIndex = 2;
            this.rbDuplexHorizontal.TabStop = true;
            this.rbDuplexHorizontal.Text = "Horizontal";
            this.rbDuplexHorizontal.UseVisualStyleBackColor = true;
            // 
            // cbDefaultDuplex
            // 
            this.cbDefaultDuplex.AutoSize = true;
            this.cbDefaultDuplex.Checked = true;
            this.cbDefaultDuplex.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultDuplex.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultDuplex.Location = new System.Drawing.Point(6, 20);
            this.cbDefaultDuplex.Name = "cbDefaultDuplex";
            this.cbDefaultDuplex.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultDuplex.TabIndex = 1;
            this.cbDefaultDuplex.Text = "Use printer default";
            this.cbDefaultDuplex.UseVisualStyleBackColor = true;
            this.cbDefaultDuplex.CheckedChanged += new System.EventHandler(this.cbDefault_CheckedChanged);
            // 
            // cbUsePrinterSettings
            // 
            this.cbUsePrinterSettings.AutoSize = true;
            this.cbUsePrinterSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbUsePrinterSettings.Location = new System.Drawing.Point(11, 369);
            this.cbUsePrinterSettings.Name = "cbUsePrinterSettings";
            this.cbUsePrinterSettings.Size = new System.Drawing.Size(157, 17);
            this.cbUsePrinterSettings.TabIndex = 2;
            this.cbUsePrinterSettings.Text = "Use defined Printer Settings";
            this.cbUsePrinterSettings.UseVisualStyleBackColor = true;
            this.cbUsePrinterSettings.CheckedChanged += new System.EventHandler(this.cbUsePrinterSettings_CheckedChanged);
            // 
            // cbUsePrintDialog
            // 
            this.cbUsePrintDialog.AutoSize = true;
            this.cbUsePrintDialog.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbUsePrintDialog.Location = new System.Drawing.Point(558, 369);
            this.cbUsePrintDialog.Name = "cbUsePrintDialog";
            this.cbUsePrintDialog.Size = new System.Drawing.Size(171, 17);
            this.cbUsePrintDialog.TabIndex = 4;
            this.cbUsePrintDialog.Text = "Use Printer Preferences Dialog";
            this.cbUsePrintDialog.UseVisualStyleBackColor = true;
            // 
            // btnSetPrinterSettings
            // 
            this.btnSetPrinterSettings.Enabled = false;
            this.btnSetPrinterSettings.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSetPrinterSettings.Location = new System.Drawing.Point(174, 367);
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
            this.cbUseWatermark.Location = new System.Drawing.Point(170, 631);
            this.cbUseWatermark.Name = "cbUseWatermark";
            this.cbUseWatermark.Size = new System.Drawing.Size(100, 17);
            this.cbUseWatermark.TabIndex = 7;
            this.cbUseWatermark.Text = "Use Watermark";
            this.cbUseWatermark.UseVisualStyleBackColor = true;
            this.cbUseWatermark.CheckedChanged += new System.EventHandler(this.cbUseWatermark_CheckedChanged);
            // 
            // btnSetWatermark
            // 
            this.btnSetWatermark.Enabled = false;
            this.btnSetWatermark.Location = new System.Drawing.Point(273, 627);
            this.btnSetWatermark.Name = "btnSetWatermark";
            this.btnSetWatermark.Size = new System.Drawing.Size(108, 23);
            this.btnSetWatermark.TabIndex = 8;
            this.btnSetWatermark.Text = "Set Watermark";
            this.btnSetWatermark.UseVisualStyleBackColor = true;
            this.btnSetWatermark.Click += new System.EventHandler(this.btnSetWatermark_Click);
            // 
            // tbDocumentName
            // 
            this.tbDocumentName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbDocumentName.Location = new System.Drawing.Point(112, 600);
            this.tbDocumentName.Name = "tbDocumentName";
            this.tbDocumentName.Size = new System.Drawing.Size(628, 20);
            this.tbDocumentName.TabIndex = 5;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.Location = new System.Drawing.Point(15, 603);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Printer Job Name:";
            // 
            // cbIsStream
            // 
            this.cbIsStream.AutoSize = true;
            this.cbIsStream.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbIsStream.Location = new System.Drawing.Point(17, 631);
            this.cbIsStream.Name = "cbIsStream";
            this.cbIsStream.Size = new System.Drawing.Size(110, 17);
            this.cbIsStream.TabIndex = 6;
            this.cbIsStream.Text = "Send file as byte[]";
            this.cbIsStream.UseVisualStyleBackColor = true;
            // 
            // gbScale
            // 
            this.gbScale.Controls.Add(this.rbScaleShrink);
            this.gbScale.Controls.Add(this.rbScaleFit);
            this.gbScale.Controls.Add(this.rbScaleActualSize);
            this.gbScale.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbScale.Location = new System.Drawing.Point(7, 498);
            this.gbScale.Name = "gbScale";
            this.gbScale.Size = new System.Drawing.Size(749, 44);
            this.gbScale.TabIndex = 3;
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
            this.gbPrintRange.Location = new System.Drawing.Point(7, 404);
            this.gbPrintRange.Name = "gbPrintRange";
            this.gbPrintRange.Size = new System.Drawing.Size(749, 90);
            this.gbPrintRange.TabIndex = 2;
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
            // tabPagePrintWithAdobe
            // 
            this.tabPagePrintWithAdobe.Controls.Add(this.groupBox3);
            this.tabPagePrintWithAdobe.Controls.Add(this.gbPrinterSettingsAdobe);
            this.tabPagePrintWithAdobe.Controls.Add(this.btnPrintWithAdobe);
            this.tabPagePrintWithAdobe.Controls.Add(this.gbScaleAdobe);
            this.tabPagePrintWithAdobe.Controls.Add(this.gbPrintRangeAdobe);
            this.tabPagePrintWithAdobe.Location = new System.Drawing.Point(4, 22);
            this.tabPagePrintWithAdobe.Name = "tabPagePrintWithAdobe";
            this.tabPagePrintWithAdobe.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePrintWithAdobe.Size = new System.Drawing.Size(765, 655);
            this.tabPagePrintWithAdobe.TabIndex = 2;
            this.tabPagePrintWithAdobe.Text = "Print PDF With Adobe";
            this.tabPagePrintWithAdobe.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cbAutoRotateAdobe);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.groupBox3.Location = new System.Drawing.Point(7, 530);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(752, 44);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Content Orientation";
            // 
            // cbAutoRotateAdobe
            // 
            this.cbAutoRotateAdobe.AutoSize = true;
            this.cbAutoRotateAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbAutoRotateAdobe.Location = new System.Drawing.Point(9, 20);
            this.cbAutoRotateAdobe.Name = "cbAutoRotateAdobe";
            this.cbAutoRotateAdobe.Size = new System.Drawing.Size(277, 17);
            this.cbAutoRotateAdobe.TabIndex = 0;
            this.cbAutoRotateAdobe.Text = "Auto Rotate (if set, this will override Paper orientation)";
            this.cbAutoRotateAdobe.UseVisualStyleBackColor = true;
            // 
            // gbPrinterSettingsAdobe
            // 
            this.gbPrinterSettingsAdobe.Controls.Add(this.panelPrinterSettingsAdobe);
            this.gbPrinterSettingsAdobe.Controls.Add(this.cbUsePrintDialogAdobe);
            this.gbPrinterSettingsAdobe.Controls.Add(this.cbUsePrinterSettingsAdobe);
            this.gbPrinterSettingsAdobe.Controls.Add(this.btnSetPrinterSettingsAdobe);
            this.gbPrinterSettingsAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPrinterSettingsAdobe.Location = new System.Drawing.Point(6, 6);
            this.gbPrinterSettingsAdobe.Name = "gbPrinterSettingsAdobe";
            this.gbPrinterSettingsAdobe.Size = new System.Drawing.Size(752, 406);
            this.gbPrinterSettingsAdobe.TabIndex = 1;
            this.gbPrinterSettingsAdobe.TabStop = false;
            this.gbPrinterSettingsAdobe.Text = "Printer Settings";
            // 
            // panelPrinterSettingsAdobe
            // 
            this.panelPrinterSettingsAdobe.Controls.Add(this.gbCopiesAdobe);
            this.panelPrinterSettingsAdobe.Controls.Add(this.label17);
            this.panelPrinterSettingsAdobe.Controls.Add(this.cmbxPrinterNamesAdobe);
            this.panelPrinterSettingsAdobe.Controls.Add(this.gbPrintInColorAdobe);
            this.panelPrinterSettingsAdobe.Controls.Add(this.gbDuplexTypeAdobe);
            this.panelPrinterSettingsAdobe.Controls.Add(this.gbPaperSourceAdobe);
            this.panelPrinterSettingsAdobe.Controls.Add(this.gbCollateAdobe);
            this.panelPrinterSettingsAdobe.Controls.Add(this.gbPaperSizeAdobe);
            this.panelPrinterSettingsAdobe.Controls.Add(this.gbPrinterResolutionAdobe);
            this.panelPrinterSettingsAdobe.Controls.Add(this.gbOrientationAdobe);
            this.panelPrinterSettingsAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.panelPrinterSettingsAdobe.Location = new System.Drawing.Point(3, 15);
            this.panelPrinterSettingsAdobe.Name = "panelPrinterSettingsAdobe";
            this.panelPrinterSettingsAdobe.Size = new System.Drawing.Size(738, 349);
            this.panelPrinterSettingsAdobe.TabIndex = 29;
            // 
            // gbCopiesAdobe
            // 
            this.gbCopiesAdobe.Controls.Add(this.cbDefaultNumCopiesAdobe);
            this.gbCopiesAdobe.Controls.Add(this.label16);
            this.gbCopiesAdobe.Controls.Add(this.numCopiesAdobe);
            this.gbCopiesAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbCopiesAdobe.Location = new System.Drawing.Point(3, 27);
            this.gbCopiesAdobe.Name = "gbCopiesAdobe";
            this.gbCopiesAdobe.Size = new System.Drawing.Size(348, 51);
            this.gbCopiesAdobe.TabIndex = 12;
            this.gbCopiesAdobe.TabStop = false;
            this.gbCopiesAdobe.Text = "Number of copies";
            // 
            // cbDefaultNumCopiesAdobe
            // 
            this.cbDefaultNumCopiesAdobe.AutoSize = true;
            this.cbDefaultNumCopiesAdobe.Checked = true;
            this.cbDefaultNumCopiesAdobe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultNumCopiesAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultNumCopiesAdobe.Location = new System.Drawing.Point(7, 20);
            this.cbDefaultNumCopiesAdobe.Name = "cbDefaultNumCopiesAdobe";
            this.cbDefaultNumCopiesAdobe.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultNumCopiesAdobe.TabIndex = 0;
            this.cbDefaultNumCopiesAdobe.Text = "Use printer default";
            this.cbDefaultNumCopiesAdobe.UseVisualStyleBackColor = true;
            this.cbDefaultNumCopiesAdobe.CheckedChanged += new System.EventHandler(this.cbDefaultAdobe_CheckedChanged);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label16.Location = new System.Drawing.Point(125, 21);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(120, 13);
            this.label16.TabIndex = 7;
            this.label16.Text = "or set number of copies:";
            // 
            // numCopiesAdobe
            // 
            this.numCopiesAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.numCopiesAdobe.Location = new System.Drawing.Point(251, 19);
            this.numCopiesAdobe.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.numCopiesAdobe.Name = "numCopiesAdobe";
            this.numCopiesAdobe.Size = new System.Drawing.Size(58, 20);
            this.numCopiesAdobe.TabIndex = 8;
            this.numCopiesAdobe.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label17.Location = new System.Drawing.Point(6, 4);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(69, 13);
            this.label17.TabIndex = 17;
            this.label17.Text = "Printer name:";
            // 
            // cmbxPrinterNamesAdobe
            // 
            this.cmbxPrinterNamesAdobe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPrinterNamesAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbxPrinterNamesAdobe.FormattingEnabled = true;
            this.cmbxPrinterNamesAdobe.Location = new System.Drawing.Point(88, 4);
            this.cmbxPrinterNamesAdobe.Name = "cmbxPrinterNamesAdobe";
            this.cmbxPrinterNamesAdobe.Size = new System.Drawing.Size(645, 21);
            this.cmbxPrinterNamesAdobe.TabIndex = 11;
            this.cmbxPrinterNamesAdobe.SelectedIndexChanged += new System.EventHandler(this.cmbxPrinterNamesAdobe_SelectedIndexChanged);
            // 
            // gbPrintInColorAdobe
            // 
            this.gbPrintInColorAdobe.Controls.Add(this.cbDefaultPrintInColorAdobe);
            this.gbPrintInColorAdobe.Controls.Add(this.cbPrintInColorAdobe);
            this.gbPrintInColorAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPrintInColorAdobe.Location = new System.Drawing.Point(3, 85);
            this.gbPrintInColorAdobe.Name = "gbPrintInColorAdobe";
            this.gbPrintInColorAdobe.Size = new System.Drawing.Size(348, 51);
            this.gbPrintInColorAdobe.TabIndex = 14;
            this.gbPrintInColorAdobe.TabStop = false;
            this.gbPrintInColorAdobe.Text = "Print in color or no?";
            // 
            // cbDefaultPrintInColorAdobe
            // 
            this.cbDefaultPrintInColorAdobe.AutoSize = true;
            this.cbDefaultPrintInColorAdobe.Checked = true;
            this.cbDefaultPrintInColorAdobe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultPrintInColorAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultPrintInColorAdobe.Location = new System.Drawing.Point(7, 24);
            this.cbDefaultPrintInColorAdobe.Name = "cbDefaultPrintInColorAdobe";
            this.cbDefaultPrintInColorAdobe.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultPrintInColorAdobe.TabIndex = 13;
            this.cbDefaultPrintInColorAdobe.Text = "Use printer default";
            this.cbDefaultPrintInColorAdobe.UseVisualStyleBackColor = true;
            this.cbDefaultPrintInColorAdobe.CheckedChanged += new System.EventHandler(this.cbDefaultAdobe_CheckedChanged);
            // 
            // cbPrintInColorAdobe
            // 
            this.cbPrintInColorAdobe.AutoSize = true;
            this.cbPrintInColorAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbPrintInColorAdobe.Location = new System.Drawing.Point(224, 24);
            this.cbPrintInColorAdobe.Name = "cbPrintInColorAdobe";
            this.cbPrintInColorAdobe.Size = new System.Drawing.Size(84, 17);
            this.cbPrintInColorAdobe.TabIndex = 12;
            this.cbPrintInColorAdobe.Text = "Print in color";
            this.cbPrintInColorAdobe.UseVisualStyleBackColor = true;
            // 
            // gbDuplexTypeAdobe
            // 
            this.gbDuplexTypeAdobe.Controls.Add(this.rbDuplexVerticalAdobe);
            this.gbDuplexTypeAdobe.Controls.Add(this.rbDuplexSimplexAdobe);
            this.gbDuplexTypeAdobe.Controls.Add(this.rbDuplexHorizontalAdobe);
            this.gbDuplexTypeAdobe.Controls.Add(this.cbDefaultDuplexAdobe);
            this.gbDuplexTypeAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbDuplexTypeAdobe.Location = new System.Drawing.Point(361, 28);
            this.gbDuplexTypeAdobe.Name = "gbDuplexTypeAdobe";
            this.gbDuplexTypeAdobe.Size = new System.Drawing.Size(372, 50);
            this.gbDuplexTypeAdobe.TabIndex = 13;
            this.gbDuplexTypeAdobe.TabStop = false;
            this.gbDuplexTypeAdobe.Text = "Duplex type";
            // 
            // rbDuplexVerticalAdobe
            // 
            this.rbDuplexVerticalAdobe.AutoSize = true;
            this.rbDuplexVerticalAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbDuplexVerticalAdobe.Location = new System.Drawing.Point(273, 21);
            this.rbDuplexVerticalAdobe.Name = "rbDuplexVerticalAdobe";
            this.rbDuplexVerticalAdobe.Size = new System.Drawing.Size(60, 17);
            this.rbDuplexVerticalAdobe.TabIndex = 4;
            this.rbDuplexVerticalAdobe.TabStop = true;
            this.rbDuplexVerticalAdobe.Text = "Vertical";
            this.rbDuplexVerticalAdobe.UseVisualStyleBackColor = true;
            // 
            // rbDuplexSimplexAdobe
            // 
            this.rbDuplexSimplexAdobe.AutoSize = true;
            this.rbDuplexSimplexAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbDuplexSimplexAdobe.Location = new System.Drawing.Point(204, 21);
            this.rbDuplexSimplexAdobe.Name = "rbDuplexSimplexAdobe";
            this.rbDuplexSimplexAdobe.Size = new System.Drawing.Size(61, 17);
            this.rbDuplexSimplexAdobe.TabIndex = 3;
            this.rbDuplexSimplexAdobe.TabStop = true;
            this.rbDuplexSimplexAdobe.Text = "Simplex";
            this.rbDuplexSimplexAdobe.UseVisualStyleBackColor = true;
            // 
            // rbDuplexHorizontalAdobe
            // 
            this.rbDuplexHorizontalAdobe.AutoSize = true;
            this.rbDuplexHorizontalAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbDuplexHorizontalAdobe.Location = new System.Drawing.Point(126, 21);
            this.rbDuplexHorizontalAdobe.Name = "rbDuplexHorizontalAdobe";
            this.rbDuplexHorizontalAdobe.Size = new System.Drawing.Size(72, 17);
            this.rbDuplexHorizontalAdobe.TabIndex = 2;
            this.rbDuplexHorizontalAdobe.TabStop = true;
            this.rbDuplexHorizontalAdobe.Text = "Horizontal";
            this.rbDuplexHorizontalAdobe.UseVisualStyleBackColor = true;
            // 
            // cbDefaultDuplexAdobe
            // 
            this.cbDefaultDuplexAdobe.AutoSize = true;
            this.cbDefaultDuplexAdobe.Checked = true;
            this.cbDefaultDuplexAdobe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultDuplexAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultDuplexAdobe.Location = new System.Drawing.Point(10, 21);
            this.cbDefaultDuplexAdobe.Name = "cbDefaultDuplexAdobe";
            this.cbDefaultDuplexAdobe.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultDuplexAdobe.TabIndex = 1;
            this.cbDefaultDuplexAdobe.Text = "Use printer default";
            this.cbDefaultDuplexAdobe.UseVisualStyleBackColor = true;
            this.cbDefaultDuplexAdobe.CheckedChanged += new System.EventHandler(this.cbDefaultAdobe_CheckedChanged);
            // 
            // gbPaperSourceAdobe
            // 
            this.gbPaperSourceAdobe.Controls.Add(this.cmbxPaperSourceAdobe);
            this.gbPaperSourceAdobe.Controls.Add(this.label12);
            this.gbPaperSourceAdobe.Controls.Add(this.cbDefaultPaperSourceAdobe);
            this.gbPaperSourceAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPaperSourceAdobe.Location = new System.Drawing.Point(3, 142);
            this.gbPaperSourceAdobe.Name = "gbPaperSourceAdobe";
            this.gbPaperSourceAdobe.Size = new System.Drawing.Size(730, 46);
            this.gbPaperSourceAdobe.TabIndex = 16;
            this.gbPaperSourceAdobe.TabStop = false;
            this.gbPaperSourceAdobe.Text = "Paper source";
            // 
            // cmbxPaperSourceAdobe
            // 
            this.cmbxPaperSourceAdobe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPaperSourceAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbxPaperSourceAdobe.FormattingEnabled = true;
            this.cmbxPaperSourceAdobe.Location = new System.Drawing.Point(190, 15);
            this.cmbxPaperSourceAdobe.Name = "cmbxPaperSourceAdobe";
            this.cmbxPaperSourceAdobe.Size = new System.Drawing.Size(525, 21);
            this.cmbxPaperSourceAdobe.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.Location = new System.Drawing.Point(120, 20);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(73, 13);
            this.label12.TabIndex = 2;
            this.label12.Text = "Paper source:";
            // 
            // cbDefaultPaperSourceAdobe
            // 
            this.cbDefaultPaperSourceAdobe.AutoSize = true;
            this.cbDefaultPaperSourceAdobe.Checked = true;
            this.cbDefaultPaperSourceAdobe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultPaperSourceAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultPaperSourceAdobe.Location = new System.Drawing.Point(7, 19);
            this.cbDefaultPaperSourceAdobe.Name = "cbDefaultPaperSourceAdobe";
            this.cbDefaultPaperSourceAdobe.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultPaperSourceAdobe.TabIndex = 1;
            this.cbDefaultPaperSourceAdobe.Text = "Use printer default";
            this.cbDefaultPaperSourceAdobe.UseVisualStyleBackColor = true;
            this.cbDefaultPaperSourceAdobe.CheckedChanged += new System.EventHandler(this.cbDefaultAdobe_CheckedChanged);
            // 
            // gbCollateAdobe
            // 
            this.gbCollateAdobe.Controls.Add(this.cbCollateAdobe);
            this.gbCollateAdobe.Controls.Add(this.cbDefaultCollateAdobe);
            this.gbCollateAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbCollateAdobe.Location = new System.Drawing.Point(361, 85);
            this.gbCollateAdobe.Name = "gbCollateAdobe";
            this.gbCollateAdobe.Size = new System.Drawing.Size(372, 51);
            this.gbCollateAdobe.TabIndex = 15;
            this.gbCollateAdobe.TabStop = false;
            this.gbCollateAdobe.Text = "Collate";
            // 
            // cbCollateAdobe
            // 
            this.cbCollateAdobe.AutoSize = true;
            this.cbCollateAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbCollateAdobe.Location = new System.Drawing.Point(264, 19);
            this.cbCollateAdobe.Name = "cbCollateAdobe";
            this.cbCollateAdobe.Size = new System.Drawing.Size(58, 17);
            this.cbCollateAdobe.TabIndex = 3;
            this.cbCollateAdobe.Text = "Collate";
            this.cbCollateAdobe.UseVisualStyleBackColor = true;
            // 
            // cbDefaultCollateAdobe
            // 
            this.cbDefaultCollateAdobe.AutoSize = true;
            this.cbDefaultCollateAdobe.Checked = true;
            this.cbDefaultCollateAdobe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultCollateAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultCollateAdobe.Location = new System.Drawing.Point(10, 19);
            this.cbDefaultCollateAdobe.Name = "cbDefaultCollateAdobe";
            this.cbDefaultCollateAdobe.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultCollateAdobe.TabIndex = 2;
            this.cbDefaultCollateAdobe.Text = "Use printer default";
            this.cbDefaultCollateAdobe.UseVisualStyleBackColor = true;
            this.cbDefaultCollateAdobe.CheckedChanged += new System.EventHandler(this.cbDefaultAdobe_CheckedChanged);
            // 
            // gbPaperSizeAdobe
            // 
            this.gbPaperSizeAdobe.Controls.Add(this.cmbxPaperSizeAdobe);
            this.gbPaperSizeAdobe.Controls.Add(this.label15);
            this.gbPaperSizeAdobe.Controls.Add(this.cbDefaultPaperSizeAdobe);
            this.gbPaperSizeAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPaperSizeAdobe.Location = new System.Drawing.Point(3, 247);
            this.gbPaperSizeAdobe.Name = "gbPaperSizeAdobe";
            this.gbPaperSizeAdobe.Size = new System.Drawing.Size(730, 52);
            this.gbPaperSizeAdobe.TabIndex = 22;
            this.gbPaperSizeAdobe.TabStop = false;
            this.gbPaperSizeAdobe.Text = "Paper size";
            // 
            // cmbxPaperSizeAdobe
            // 
            this.cmbxPaperSizeAdobe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPaperSizeAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbxPaperSizeAdobe.FormattingEnabled = true;
            this.cmbxPaperSizeAdobe.Location = new System.Drawing.Point(190, 19);
            this.cmbxPaperSizeAdobe.Name = "cmbxPaperSizeAdobe";
            this.cmbxPaperSizeAdobe.Size = new System.Drawing.Size(525, 21);
            this.cmbxPaperSizeAdobe.TabIndex = 3;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label15.Location = new System.Drawing.Point(127, 20);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(59, 13);
            this.label15.TabIndex = 2;
            this.label15.Text = "Paper size:";
            // 
            // cbDefaultPaperSizeAdobe
            // 
            this.cbDefaultPaperSizeAdobe.AutoSize = true;
            this.cbDefaultPaperSizeAdobe.Checked = true;
            this.cbDefaultPaperSizeAdobe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultPaperSizeAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultPaperSizeAdobe.Location = new System.Drawing.Point(7, 19);
            this.cbDefaultPaperSizeAdobe.Name = "cbDefaultPaperSizeAdobe";
            this.cbDefaultPaperSizeAdobe.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultPaperSizeAdobe.TabIndex = 1;
            this.cbDefaultPaperSizeAdobe.Text = "Use printer default";
            this.cbDefaultPaperSizeAdobe.UseVisualStyleBackColor = true;
            this.cbDefaultPaperSizeAdobe.CheckedChanged += new System.EventHandler(this.cbDefaultAdobe_CheckedChanged);
            // 
            // gbPrinterResolutionAdobe
            // 
            this.gbPrinterResolutionAdobe.Controls.Add(this.cmbxPrinterResolutionsAdobe);
            this.gbPrinterResolutionAdobe.Controls.Add(this.label14);
            this.gbPrinterResolutionAdobe.Controls.Add(this.cbDefaultPrinterResolutionAdobe);
            this.gbPrinterResolutionAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPrinterResolutionAdobe.Location = new System.Drawing.Point(3, 195);
            this.gbPrinterResolutionAdobe.Name = "gbPrinterResolutionAdobe";
            this.gbPrinterResolutionAdobe.Size = new System.Drawing.Size(730, 46);
            this.gbPrinterResolutionAdobe.TabIndex = 21;
            this.gbPrinterResolutionAdobe.TabStop = false;
            this.gbPrinterResolutionAdobe.Text = "Printer resolution";
            // 
            // cmbxPrinterResolutionsAdobe
            // 
            this.cmbxPrinterResolutionsAdobe.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbxPrinterResolutionsAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cmbxPrinterResolutionsAdobe.FormattingEnabled = true;
            this.cmbxPrinterResolutionsAdobe.Location = new System.Drawing.Point(190, 20);
            this.cmbxPrinterResolutionsAdobe.Name = "cmbxPrinterResolutionsAdobe";
            this.cmbxPrinterResolutionsAdobe.Size = new System.Drawing.Size(525, 21);
            this.cmbxPrinterResolutionsAdobe.TabIndex = 3;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label14.Location = new System.Drawing.Point(126, 20);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(60, 13);
            this.label14.TabIndex = 2;
            this.label14.Text = "Resolution:";
            // 
            // cbDefaultPrinterResolutionAdobe
            // 
            this.cbDefaultPrinterResolutionAdobe.AutoSize = true;
            this.cbDefaultPrinterResolutionAdobe.Checked = true;
            this.cbDefaultPrinterResolutionAdobe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultPrinterResolutionAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultPrinterResolutionAdobe.Location = new System.Drawing.Point(7, 19);
            this.cbDefaultPrinterResolutionAdobe.Name = "cbDefaultPrinterResolutionAdobe";
            this.cbDefaultPrinterResolutionAdobe.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultPrinterResolutionAdobe.TabIndex = 1;
            this.cbDefaultPrinterResolutionAdobe.Text = "Use printer default";
            this.cbDefaultPrinterResolutionAdobe.UseVisualStyleBackColor = true;
            this.cbDefaultPrinterResolutionAdobe.CheckedChanged += new System.EventHandler(this.cbDefaultAdobe_CheckedChanged);
            // 
            // gbOrientationAdobe
            // 
            this.gbOrientationAdobe.Controls.Add(this.rbPortraitAdobe);
            this.gbOrientationAdobe.Controls.Add(this.rbLandscapeAdobe);
            this.gbOrientationAdobe.Controls.Add(this.cbDefaultPrintOrientationAdobe);
            this.gbOrientationAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbOrientationAdobe.Location = new System.Drawing.Point(3, 305);
            this.gbOrientationAdobe.Name = "gbOrientationAdobe";
            this.gbOrientationAdobe.Size = new System.Drawing.Size(730, 36);
            this.gbOrientationAdobe.TabIndex = 20;
            this.gbOrientationAdobe.TabStop = false;
            this.gbOrientationAdobe.Text = "Paper orientation:";
            // 
            // rbPortraitAdobe
            // 
            this.rbPortraitAdobe.AutoSize = true;
            this.rbPortraitAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbPortraitAdobe.Location = new System.Drawing.Point(351, 13);
            this.rbPortraitAdobe.Name = "rbPortraitAdobe";
            this.rbPortraitAdobe.Size = new System.Drawing.Size(58, 17);
            this.rbPortraitAdobe.TabIndex = 16;
            this.rbPortraitAdobe.TabStop = true;
            this.rbPortraitAdobe.Text = "Portrait";
            this.rbPortraitAdobe.UseVisualStyleBackColor = true;
            // 
            // rbLandscapeAdobe
            // 
            this.rbLandscapeAdobe.AutoSize = true;
            this.rbLandscapeAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbLandscapeAdobe.Location = new System.Drawing.Point(251, 13);
            this.rbLandscapeAdobe.Name = "rbLandscapeAdobe";
            this.rbLandscapeAdobe.Size = new System.Drawing.Size(78, 17);
            this.rbLandscapeAdobe.TabIndex = 15;
            this.rbLandscapeAdobe.TabStop = true;
            this.rbLandscapeAdobe.Text = "Landscape";
            this.rbLandscapeAdobe.UseVisualStyleBackColor = true;
            // 
            // cbDefaultPrintOrientationAdobe
            // 
            this.cbDefaultPrintOrientationAdobe.AutoSize = true;
            this.cbDefaultPrintOrientationAdobe.Checked = true;
            this.cbDefaultPrintOrientationAdobe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbDefaultPrintOrientationAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbDefaultPrintOrientationAdobe.Location = new System.Drawing.Point(128, 13);
            this.cbDefaultPrintOrientationAdobe.Name = "cbDefaultPrintOrientationAdobe";
            this.cbDefaultPrintOrientationAdobe.Size = new System.Drawing.Size(112, 17);
            this.cbDefaultPrintOrientationAdobe.TabIndex = 14;
            this.cbDefaultPrintOrientationAdobe.Text = "Use printer default";
            this.cbDefaultPrintOrientationAdobe.UseVisualStyleBackColor = true;
            this.cbDefaultPrintOrientationAdobe.CheckedChanged += new System.EventHandler(this.cbDefaultAdobe_CheckedChanged);
            // 
            // cbUsePrintDialogAdobe
            // 
            this.cbUsePrintDialogAdobe.AutoSize = true;
            this.cbUsePrintDialogAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbUsePrintDialogAdobe.Location = new System.Drawing.Point(571, 380);
            this.cbUsePrintDialogAdobe.Name = "cbUsePrintDialogAdobe";
            this.cbUsePrintDialogAdobe.Size = new System.Drawing.Size(171, 17);
            this.cbUsePrintDialogAdobe.TabIndex = 27;
            this.cbUsePrintDialogAdobe.Text = "Use Printer Preferences Dialog";
            this.cbUsePrintDialogAdobe.UseVisualStyleBackColor = true;
            // 
            // cbUsePrinterSettingsAdobe
            // 
            this.cbUsePrinterSettingsAdobe.AutoSize = true;
            this.cbUsePrinterSettingsAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.cbUsePrinterSettingsAdobe.Location = new System.Drawing.Point(6, 374);
            this.cbUsePrinterSettingsAdobe.Name = "cbUsePrinterSettingsAdobe";
            this.cbUsePrinterSettingsAdobe.Size = new System.Drawing.Size(157, 17);
            this.cbUsePrinterSettingsAdobe.TabIndex = 28;
            this.cbUsePrinterSettingsAdobe.Text = "Use defined Printer Settings";
            this.cbUsePrinterSettingsAdobe.UseVisualStyleBackColor = true;
            this.cbUsePrinterSettingsAdobe.CheckedChanged += new System.EventHandler(this.cbUsePrinterSettingsAdobe_CheckedChanged);
            // 
            // btnSetPrinterSettingsAdobe
            // 
            this.btnSetPrinterSettingsAdobe.Enabled = false;
            this.btnSetPrinterSettingsAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.btnSetPrinterSettingsAdobe.Location = new System.Drawing.Point(180, 374);
            this.btnSetPrinterSettingsAdobe.Name = "btnSetPrinterSettingsAdobe";
            this.btnSetPrinterSettingsAdobe.Size = new System.Drawing.Size(127, 23);
            this.btnSetPrinterSettingsAdobe.TabIndex = 26;
            this.btnSetPrinterSettingsAdobe.Text = "Set Printer Settings";
            this.btnSetPrinterSettingsAdobe.UseVisualStyleBackColor = true;
            this.btnSetPrinterSettingsAdobe.Click += new System.EventHandler(this.btnSetPrinterSettingsAdobe_Click);
            // 
            // btnPrintWithAdobe
            // 
            this.btnPrintWithAdobe.Location = new System.Drawing.Point(313, 618);
            this.btnPrintWithAdobe.Name = "btnPrintWithAdobe";
            this.btnPrintWithAdobe.Size = new System.Drawing.Size(117, 23);
            this.btnPrintWithAdobe.TabIndex = 5;
            this.btnPrintWithAdobe.Text = "Print with Adobe";
            this.btnPrintWithAdobe.UseVisualStyleBackColor = true;
            this.btnPrintWithAdobe.Click += new System.EventHandler(this.btnPrintWithAdobe_Click);
            // 
            // gbScaleAdobe
            // 
            this.gbScaleAdobe.Controls.Add(this.rbScaleShrinkAdobe);
            this.gbScaleAdobe.Controls.Add(this.rbScaleActualSizeAdobe);
            this.gbScaleAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbScaleAdobe.Location = new System.Drawing.Point(7, 486);
            this.gbScaleAdobe.Name = "gbScaleAdobe";
            this.gbScaleAdobe.Size = new System.Drawing.Size(752, 38);
            this.gbScaleAdobe.TabIndex = 3;
            this.gbScaleAdobe.TabStop = false;
            this.gbScaleAdobe.Text = "Scale";
            // 
            // rbScaleShrinkAdobe
            // 
            this.rbScaleShrinkAdobe.AutoSize = true;
            this.rbScaleShrinkAdobe.Checked = true;
            this.rbScaleShrinkAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbScaleShrinkAdobe.Location = new System.Drawing.Point(163, 14);
            this.rbScaleShrinkAdobe.Name = "rbScaleShrinkAdobe";
            this.rbScaleShrinkAdobe.Size = new System.Drawing.Size(106, 17);
            this.rbScaleShrinkAdobe.TabIndex = 2;
            this.rbScaleShrinkAdobe.TabStop = true;
            this.rbScaleShrinkAdobe.Text = "Shrink to margins";
            this.rbScaleShrinkAdobe.UseVisualStyleBackColor = true;
            // 
            // rbScaleActualSizeAdobe
            // 
            this.rbScaleActualSizeAdobe.AutoSize = true;
            this.rbScaleActualSizeAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.rbScaleActualSizeAdobe.Location = new System.Drawing.Point(7, 14);
            this.rbScaleActualSizeAdobe.Name = "rbScaleActualSizeAdobe";
            this.rbScaleActualSizeAdobe.Size = new System.Drawing.Size(97, 17);
            this.rbScaleActualSizeAdobe.TabIndex = 0;
            this.rbScaleActualSizeAdobe.Text = "Use actual size";
            this.rbScaleActualSizeAdobe.UseVisualStyleBackColor = true;
            // 
            // gbPrintRangeAdobe
            // 
            this.gbPrintRangeAdobe.Controls.Add(this.label11);
            this.gbPrintRangeAdobe.Controls.Add(this.tbPrintPagesAdobe);
            this.gbPrintRangeAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.gbPrintRangeAdobe.Location = new System.Drawing.Point(7, 420);
            this.gbPrintRangeAdobe.Name = "gbPrintRangeAdobe";
            this.gbPrintRangeAdobe.Size = new System.Drawing.Size(752, 63);
            this.gbPrintRangeAdobe.TabIndex = 2;
            this.gbPrintRangeAdobe.TabStop = false;
            this.gbPrintRangeAdobe.Text = "Print range";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.Location = new System.Drawing.Point(7, 16);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(669, 13);
            this.label11.TabIndex = 18;
            this.label11.Text = "Print pages: (e.g. 1-3 or exact page number). Multiple ranges separated by \",\" ar" +
    "en\'t supported (e.g. 1-3.5). If not set, all pages will be printed.";
            // 
            // tbPrintPagesAdobe
            // 
            this.tbPrintPagesAdobe.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tbPrintPagesAdobe.Location = new System.Drawing.Point(5, 32);
            this.tbPrintPagesAdobe.Name = "tbPrintPagesAdobe";
            this.tbPrintPagesAdobe.Size = new System.Drawing.Size(711, 20);
            this.tbPrintPagesAdobe.TabIndex = 3;
            // 
            // tabPageSaveImages
            // 
            this.tabPageSaveImages.Controls.Add(this.cbIsStreamImage);
            this.tabPageSaveImages.Controls.Add(this.gbImageSettings);
            this.tabPageSaveImages.Controls.Add(this.btnSavePdfAsImage);
            this.tabPageSaveImages.Location = new System.Drawing.Point(4, 22);
            this.tabPageSaveImages.Name = "tabPageSaveImages";
            this.tabPageSaveImages.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSaveImages.Size = new System.Drawing.Size(765, 655);
            this.tabPageSaveImages.TabIndex = 1;
            this.tabPageSaveImages.Text = "Save PDF pages as images";
            this.tabPageSaveImages.UseVisualStyleBackColor = true;
            // 
            // cbIsStreamImage
            // 
            this.cbIsStreamImage.AutoSize = true;
            this.cbIsStreamImage.Location = new System.Drawing.Point(28, 425);
            this.cbIsStreamImage.Name = "cbIsStreamImage";
            this.cbIsStreamImage.Size = new System.Drawing.Size(110, 17);
            this.cbIsStreamImage.TabIndex = 2;
            this.cbIsStreamImage.Text = "Send file as byte[]";
            this.cbIsStreamImage.UseVisualStyleBackColor = true;
            // 
            // lPassword
            // 
            this.lPassword.AutoSize = true;
            this.lPassword.Location = new System.Drawing.Point(13, 66);
            this.lPassword.Name = "lPassword";
            this.lPassword.Size = new System.Drawing.Size(56, 13);
            this.lPassword.TabIndex = 8;
            this.lPassword.Text = "Password:";
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(69, 66);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(576, 20);
            this.tbPassword.TabIndex = 3;
            // 
            // PdfPrintLibraryTestForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(791, 796);
            this.Controls.Add(this.tbPassword);
            this.Controls.Add(this.lPassword);
            this.Controls.Add(this.tab);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.tbFileName);
            this.Controls.Add(this.lSelectPdfFile);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "PdfPrintLibraryTestForm";
            this.Text = "TerminalWorks - PdfPrinting.Net Test -";
            this.Load += new System.EventHandler(this.PdfPrintLibraryTestForm_Load);
            this.gbImageSettings.ResumeLayout(false);
            this.gbImageSettings.PerformLayout();
            this.gbMultiTiff.ResumeLayout(false);
            this.gbMultiTiff.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numYResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numXResolution)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numZoom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numToPage)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFrom)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numQuality)).EndInit();
            this.gbColorType.ResumeLayout(false);
            this.gbColorType.PerformLayout();
            this.tab.ResumeLayout(false);
            this.tabPagePrintPDF.ResumeLayout(false);
            this.tabPagePrintPDF.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.gbPrinterSettings.ResumeLayout(false);
            this.gbPrinterSettings.PerformLayout();
            this.panelPrinterSettings.ResumeLayout(false);
            this.panelPrinterSettings.PerformLayout();
            this.gbCopies.ResumeLayout(false);
            this.gbCopies.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopies)).EndInit();
            this.gbOrientation.ResumeLayout(false);
            this.gbOrientation.PerformLayout();
            this.gbPaperSize.ResumeLayout(false);
            this.gbPaperSize.PerformLayout();
            this.gbPrinterResolution.ResumeLayout(false);
            this.gbPrinterResolution.PerformLayout();
            this.gbCollate.ResumeLayout(false);
            this.gbCollate.PerformLayout();
            this.gbPaperSource.ResumeLayout(false);
            this.gbPaperSource.PerformLayout();
            this.gbPrintInColor.ResumeLayout(false);
            this.gbPrintInColor.PerformLayout();
            this.gbDuplexType.ResumeLayout(false);
            this.gbDuplexType.PerformLayout();
            this.gbScale.ResumeLayout(false);
            this.gbScale.PerformLayout();
            this.gbPrintRange.ResumeLayout(false);
            this.gbPrintRange.PerformLayout();
            this.tabPagePrintWithAdobe.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.gbPrinterSettingsAdobe.ResumeLayout(false);
            this.gbPrinterSettingsAdobe.PerformLayout();
            this.panelPrinterSettingsAdobe.ResumeLayout(false);
            this.panelPrinterSettingsAdobe.PerformLayout();
            this.gbCopiesAdobe.ResumeLayout(false);
            this.gbCopiesAdobe.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numCopiesAdobe)).EndInit();
            this.gbPrintInColorAdobe.ResumeLayout(false);
            this.gbPrintInColorAdobe.PerformLayout();
            this.gbDuplexTypeAdobe.ResumeLayout(false);
            this.gbDuplexTypeAdobe.PerformLayout();
            this.gbPaperSourceAdobe.ResumeLayout(false);
            this.gbPaperSourceAdobe.PerformLayout();
            this.gbCollateAdobe.ResumeLayout(false);
            this.gbCollateAdobe.PerformLayout();
            this.gbPaperSizeAdobe.ResumeLayout(false);
            this.gbPaperSizeAdobe.PerformLayout();
            this.gbPrinterResolutionAdobe.ResumeLayout(false);
            this.gbPrinterResolutionAdobe.PerformLayout();
            this.gbOrientationAdobe.ResumeLayout(false);
            this.gbOrientationAdobe.PerformLayout();
            this.gbScaleAdobe.ResumeLayout(false);
            this.gbScaleAdobe.PerformLayout();
            this.gbPrintRangeAdobe.ResumeLayout(false);
            this.gbPrintRangeAdobe.PerformLayout();
            this.tabPageSaveImages.ResumeLayout(false);
            this.tabPageSaveImages.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label lSelectPdfFile;
        private System.Windows.Forms.TextBox tbFileName;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.OpenFileDialog openPDFFileDialog;
        private System.Windows.Forms.Button btnSavePdfAsImage;
        private System.Windows.Forms.GroupBox gbImageSettings;
        private System.Windows.Forms.Button btnImageFileName;
        private System.Windows.Forms.TextBox tbImageFileName;
        private System.Windows.Forms.Label lImageFileName;
        private System.Windows.Forms.Label lZoomFactor;
        private System.Windows.Forms.NumericUpDown numZoom;
        private System.Windows.Forms.NumericUpDown numToPage;
        private System.Windows.Forms.Label ltoPage;
        private System.Windows.Forms.NumericUpDown numFrom;
        private System.Windows.Forms.Label lFromPage;
        private System.Windows.Forms.Label lImageQuality;
        private System.Windows.Forms.NumericUpDown numQuality;
        private System.Windows.Forms.GroupBox gbColorType;
        private System.Windows.Forms.RadioButton rbAsItIsInPDF;
        private System.Windows.Forms.RadioButton rbGray;
        private System.Windows.Forms.RadioButton rbBlackAndWhite;
        private System.Windows.Forms.NumericUpDown numYResolution;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lXResolution;
        private System.Windows.Forms.NumericUpDown numXResolution;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabControl tab;
        private System.Windows.Forms.TabPage tabPagePrintPDF;
        private System.Windows.Forms.TabPage tabPageSaveImages;
        private System.Windows.Forms.CheckBox cbxMultiTiff;
        private System.Windows.Forms.GroupBox gbPrintInColor;
        private System.Windows.Forms.CheckBox cbDefaultPrintInColor;
        private System.Windows.Forms.CheckBox cbPrintInColor;
        private System.Windows.Forms.GroupBox gbCopies;
        private System.Windows.Forms.CheckBox cbDefaultNumCopies;
        private System.Windows.Forms.Label lCopies;
        private System.Windows.Forms.NumericUpDown numCopies;
        private System.Windows.Forms.ComboBox cmbxPrinterNames;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox gbPrinterResolution;
        private System.Windows.Forms.CheckBox cbDefaultPrinterResolution;
        private System.Windows.Forms.GroupBox gbPaperSize;
        private System.Windows.Forms.CheckBox cbDefaultPaperSize;
        private System.Windows.Forms.GroupBox gbPaperSource;
        private System.Windows.Forms.CheckBox cbDefaultPaperSource;
        private System.Windows.Forms.GroupBox gbDuplexType;
        private System.Windows.Forms.CheckBox cbDefaultDuplex;
        private System.Windows.Forms.GroupBox gbOrientation;
        private System.Windows.Forms.CheckBox cbDefaultPrintOrientation;
        private System.Windows.Forms.RadioButton rbDuplexVertical;
        private System.Windows.Forms.RadioButton rbDuplexSimplex;
        private System.Windows.Forms.RadioButton rbDuplexHorizontal;
        private System.Windows.Forms.ComboBox cmbxPaperSize;
        private System.Windows.Forms.Label lPaperSizes;
        private System.Windows.Forms.ComboBox cmbxPaperSource;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.GroupBox gbCollate;
        private System.Windows.Forms.CheckBox cbCollate;
        private System.Windows.Forms.CheckBox cbDefaultCollate;
        private System.Windows.Forms.ComboBox cmbxPrinterResolutions;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RadioButton rbPortrait;
        private System.Windows.Forms.RadioButton rbLandscape;
        private System.Windows.Forms.TextBox tbPrintPages;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.GroupBox gbPrintRange;
        private System.Windows.Forms.RadioButton rbPrintOdd;
        private System.Windows.Forms.RadioButton rbPrintEven;
        private System.Windows.Forms.RadioButton rbPrintEvenOdd;
        private System.Windows.Forms.GroupBox gbScale;
        private System.Windows.Forms.RadioButton rbScaleShrink;
        private System.Windows.Forms.RadioButton rbScaleFit;
        private System.Windows.Forms.RadioButton rbScaleActualSize;
        private System.Windows.Forms.Label lPassword;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.CheckBox cbIsStream;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbDocumentName;
        private System.Windows.Forms.CheckBox cbIsStreamImage;
        private System.Windows.Forms.Button btnSetPrinterSettings;
        private System.Windows.Forms.CheckBox cbCentered;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox cmbxTiffCompression;
        private System.Windows.Forms.GroupBox gbMultiTiff;
        private System.Windows.Forms.Button btnSetWatermark;
        private System.Windows.Forms.TabPage tabPagePrintWithAdobe;
        private System.Windows.Forms.Button btnPrintWithAdobe;
        private System.Windows.Forms.GroupBox gbScaleAdobe;
        private System.Windows.Forms.RadioButton rbScaleShrinkAdobe;
        private System.Windows.Forms.RadioButton rbScaleActualSizeAdobe;
        private System.Windows.Forms.GroupBox gbPrintRangeAdobe;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox tbPrintPagesAdobe;
        private System.Windows.Forms.GroupBox gbCollateAdobe;
        private System.Windows.Forms.CheckBox cbCollateAdobe;
        private System.Windows.Forms.CheckBox cbDefaultCollateAdobe;
        private System.Windows.Forms.GroupBox gbPaperSourceAdobe;
        private System.Windows.Forms.ComboBox cmbxPaperSourceAdobe;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.CheckBox cbDefaultPaperSourceAdobe;
        private System.Windows.Forms.GroupBox gbPrinterResolutionAdobe;
        private System.Windows.Forms.ComboBox cmbxPrinterResolutionsAdobe;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.CheckBox cbDefaultPrinterResolutionAdobe;
        private System.Windows.Forms.GroupBox gbPaperSizeAdobe;
        private System.Windows.Forms.ComboBox cmbxPaperSizeAdobe;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.CheckBox cbDefaultPaperSizeAdobe;
        private System.Windows.Forms.GroupBox gbDuplexTypeAdobe;
        private System.Windows.Forms.RadioButton rbDuplexVerticalAdobe;
        private System.Windows.Forms.RadioButton rbDuplexSimplexAdobe;
        private System.Windows.Forms.RadioButton rbDuplexHorizontalAdobe;
        private System.Windows.Forms.CheckBox cbDefaultDuplexAdobe;
        private System.Windows.Forms.GroupBox gbOrientationAdobe;
        private System.Windows.Forms.RadioButton rbPortraitAdobe;
        private System.Windows.Forms.RadioButton rbLandscapeAdobe;
        private System.Windows.Forms.CheckBox cbDefaultPrintOrientationAdobe;
        private System.Windows.Forms.GroupBox gbPrintInColorAdobe;
        private System.Windows.Forms.CheckBox cbDefaultPrintInColorAdobe;
        private System.Windows.Forms.CheckBox cbPrintInColorAdobe;
        private System.Windows.Forms.GroupBox gbCopiesAdobe;
        private System.Windows.Forms.CheckBox cbDefaultNumCopiesAdobe;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.NumericUpDown numCopiesAdobe;
        private System.Windows.Forms.ComboBox cmbxPrinterNamesAdobe;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Button btnSetPrinterSettingsAdobe;
        private System.Windows.Forms.CheckBox cbUseWatermark;
        private System.Windows.Forms.CheckBox cbUsePrinterSettings;
        private System.Windows.Forms.CheckBox cbUsePrintDialog;
        private System.Windows.Forms.CheckBox cbUsePrinterSettingsAdobe;
        private System.Windows.Forms.CheckBox cbUsePrintDialogAdobe;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox cbAutoRotate;
        private System.Windows.Forms.GroupBox gbPrinterSettings;
        private System.Windows.Forms.Panel panelPrinterSettings;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.CheckBox cbAutoRotateAdobe;
        private System.Windows.Forms.GroupBox gbPrinterSettingsAdobe;
        private System.Windows.Forms.Panel panelPrinterSettingsAdobe;
    }
}

