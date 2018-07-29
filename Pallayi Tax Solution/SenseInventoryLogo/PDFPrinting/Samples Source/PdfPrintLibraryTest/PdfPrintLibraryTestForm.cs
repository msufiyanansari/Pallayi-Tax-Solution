using System;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using PdfPrintingNet;
using System.Collections.Generic;
using System.Collections;
using System.Threading;

namespace PdfPrintLibraryTest
{
    public partial class PdfPrintLibraryTestForm : Form
    {               
        private string _previewPaperWidth = "";
        private string _previewPaperHeight = "";
        private string _previewImagePath = "";
        private PdfWatermark _watermark = new PdfWatermark();
        private WatermarkForm _watermarkForm;

        private ConfigFile _configFile = new ConfigFile();

        public PdfPrintLibraryTestForm()
        {
            InitializeComponent();           
        }

        private void FillPrinters()
        {
            var installedPrinters = PrinterSettings.InstalledPrinters;
            var printerSettings = new PrinterSettings();
            string defaultPrinter = printerSettings.PrinterName;
            cmbxPrinterNames.SelectedIndexChanged -= cmbxPrinterNames_SelectedIndexChanged;
            PdfPrintTest.FillComboBox(cmbxPrinterNames, installedPrinters, defaultPrinter);

            cmbxPrinterNamesAdobe.SelectedIndexChanged -= cmbxPrinterNamesAdobe_SelectedIndexChanged;
            PdfPrintTest.FillComboBox(cmbxPrinterNamesAdobe, installedPrinters, defaultPrinter);
            
            cmbxPrinterNames.SelectedIndexChanged += cmbxPrinterNames_SelectedIndexChanged;
            cmbxPrinterNamesAdobe.SelectedIndexChanged += cmbxPrinterNamesAdobe_SelectedIndexChanged;
        }

        private bool SetSettingsFromGUI(PdfPrint printLibrary)
        {            
            if (!cbUsePrinterSettings.Checked)
            {
                if (cmbxPrinterNames.SelectedItem == null)
                {
                    MessageBox.Show("Select printer.");
                    return false;
                }

                if (!cbDefaultPrintInColor.Checked)
                    printLibrary.PrintInColor = cbPrintInColor.Checked;

                if (!cbDefaultCollate.Checked)
                    printLibrary.Collate = cbCollate.Checked;

                if (!cbDefaultPrintOrientation.Checked)
                {
                    if (rbLandscape.Checked)
                        printLibrary.IsLandscape = true;
                    if (rbPortrait.Checked)
                        printLibrary.IsLandscape = false;
                }

                if (!cbDefaultDuplex.Checked)
                {
                    if (rbDuplexHorizontal.Checked)
                        printLibrary.DuplexType = Duplex.Horizontal;
                    if (rbDuplexVertical.Checked)
                        printLibrary.DuplexType = Duplex.Vertical;
                    if (rbDuplexSimplex.Checked)
                        printLibrary.DuplexType = Duplex.Simplex;
                }

                if (!cbDefaultNumCopies.Checked)
                    printLibrary.Copies = (short)numCopies.Value;

                var printerSettings = new PrinterSettings();
                var defaultPrinter = printerSettings.PrinterName;
                PdfPrintTest.SetDefaultPrinter(cmbxPrinterNames.SelectedItem.ToString());
                var newPrinterSettings = new PrinterSettings();

                if (!cbDefaultPaperSize.Checked)
                {
                    if (cmbxPaperSize.SelectedItem == null)
                    {
                        MessageBox.Show("Select paper size");
                        return false;
                    }

                    foreach (PaperSize size in newPrinterSettings.PaperSizes)
                    {
                        if (size.ToString().Equals(cmbxPaperSize.SelectedItem.ToString()))
                        {
                            printLibrary.PaperSize = size;
                            break;
                        }
                    }
                }

                if (!cbDefaultPaperSource.Checked)
                {
                    if (cmbxPaperSource.SelectedItem == null)
                    {
                        MessageBox.Show("Select paper source");
                        return false;
                    }

                    foreach (PaperSource paperSource in newPrinterSettings.PaperSources)
                    {
                        if (paperSource.ToString().Equals(cmbxPaperSource.SelectedItem.ToString()))
                        {
                            printLibrary.PaperSource = paperSource;
                            break;
                        }
                    }
                }

                if (!cbDefaultPrintInColor.Checked)
                    printLibrary.PrintInColor = cbPrintInColor.Checked;

                if (!cbDefaultPrinterResolution.Checked)
                {
                    if (cmbxPrinterResolutions.SelectedItem == null)
                    {
                        MessageBox.Show("Select printer resolution");
                        return false;
                    }

                    foreach (PrinterResolution printerResolution in newPrinterSettings.PrinterResolutions)
                    {
                        if (printerResolution.ToString().Equals(cmbxPrinterResolutions.SelectedItem.ToString()))
                        {
                            printLibrary.PrinterResolution = printerResolution;
                            break;
                        }
                    }
                }                

                printLibrary.PrinterName = cmbxPrinterNames.SelectedItem.ToString();
                PdfPrintTest.SetDefaultPrinter(defaultPrinter);
            }

            printLibrary.IsContentCentered = cbCentered.Checked;
            printLibrary.IsAutoRotate = cbAutoRotate.Checked;                        

            if (rbScaleActualSize.Checked)
                printLibrary.Scale = PdfPrint.ScaleTypes.None;
            if (rbScaleFit.Checked)
                printLibrary.Scale = PdfPrint.ScaleTypes.FitToMargins;
            if (rbScaleShrink.Checked)
                printLibrary.Scale = PdfPrint.ScaleTypes.Shrink;
            
            printLibrary.Pages = tbPrintPages.Text;

            if (rbPrintEvenOdd.Checked)
                printLibrary.RangeType = PdfPrint.RangeTypes.EvenAndOdd;
            if (rbPrintEven.Checked)
                printLibrary.RangeType = PdfPrint.RangeTypes.JustEven;
            if (rbPrintOdd.Checked)
                printLibrary.RangeType = PdfPrint.RangeTypes.JustOdd;            
            return true;
        }
        

        private bool SetSettingsFromGUIAdobe(PdfPrint printLibrary)
        {
            if (!cbUsePrinterSettingsAdobe.Checked)
            {
                if (cmbxPrinterNamesAdobe.SelectedItem == null)
                {
                    MessageBox.Show("Select printer.");
                    return false;
                }

                if (!cbDefaultPrintInColorAdobe.Checked)
                    printLibrary.PrintInColor = cbPrintInColorAdobe.Checked;

                if (!cbDefaultCollateAdobe.Checked)
                    printLibrary.Collate = cbCollateAdobe.Checked;

                if (!cbDefaultPrintOrientationAdobe.Checked)
                {
                    if (rbLandscapeAdobe.Checked)
                        printLibrary.IsLandscape = true;
                    if (rbPortraitAdobe.Checked)
                        printLibrary.IsLandscape = false;
                }

                if (!cbDefaultDuplexAdobe.Checked)
                {
                    if (rbDuplexHorizontalAdobe.Checked)
                        printLibrary.DuplexType = Duplex.Horizontal;
                    if (rbDuplexVerticalAdobe.Checked)
                        printLibrary.DuplexType = Duplex.Vertical;
                    if (rbDuplexSimplexAdobe.Checked)
                        printLibrary.DuplexType = Duplex.Simplex;
                }

                if (!cbDefaultNumCopiesAdobe.Checked)
                    printLibrary.Copies = (short)numCopiesAdobe.Value;

                var printerSettings = new PrinterSettings();
                var defaultPrinter = printerSettings.PrinterName;
                PdfPrintTest.SetDefaultPrinter(cmbxPrinterNamesAdobe.SelectedItem.ToString());
                var newPrinterSettings = new PrinterSettings();

                if (!cbDefaultPaperSizeAdobe.Checked)
                {
                    if (cmbxPaperSizeAdobe.SelectedItem == null)
                    {
                        MessageBox.Show("Select paper size");
                        return false;
                    }

                    foreach (PaperSize size in newPrinterSettings.PaperSizes)
                    {
                        if (size.ToString().Equals(cmbxPaperSizeAdobe.SelectedItem.ToString()))
                        {
                            printLibrary.PaperSize = size;
                            break;
                        }
                    }
                }

                if (!cbDefaultPaperSourceAdobe.Checked)
                {
                    if (cmbxPaperSourceAdobe.SelectedItem == null)
                    {
                        MessageBox.Show("Select paper source");
                        return false;
                    }

                    foreach (PaperSource paperSource in newPrinterSettings.PaperSources)
                    {
                        if (paperSource.ToString().Equals(cmbxPaperSourceAdobe.SelectedItem.ToString()))
                        {
                            printLibrary.PaperSource = paperSource;
                            break;
                        }
                    }
                }

                if (!cbDefaultPrinterResolutionAdobe.Checked)
                {
                    if (cmbxPrinterResolutionsAdobe.SelectedItem == null)
                    {
                        MessageBox.Show("Select printer resolution");
                        return false;
                    }

                    foreach (PrinterResolution printerResolution in newPrinterSettings.PrinterResolutions)
                    {
                        if (printerResolution.ToString().Equals(cmbxPrinterResolutionsAdobe.SelectedItem.ToString()))
                        {
                            printLibrary.PrinterResolution = printerResolution;
                            break;
                        }
                    }
                }
                
                printLibrary.PrinterName = cmbxPrinterNamesAdobe.SelectedItem.ToString();
                PdfPrintTest.SetDefaultPrinter(defaultPrinter);
            }

            printLibrary.IsAutoRotate = cbAutoRotateAdobe.Checked;            

            if (rbScaleActualSizeAdobe.Checked)
                printLibrary.Scale = PdfPrint.ScaleTypes.None;            
            if (rbScaleShrinkAdobe.Checked)
                printLibrary.Scale = PdfPrint.ScaleTypes.Shrink;            

            printLibrary.Pages = tbPrintPagesAdobe.Text;            
            return true;
        }                

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (!PdfPrintTest.IsFileNameCorrect(tbFileName.Text))
                return;

            var printLibrary = PdfPrintTest.GetPdfPrint(_configFile);        

            if (!SetSettingsFromGUI(printLibrary))
                return;

            PdfPrint.Status result = PdfPrint.Status.OK;

            if (cbUsePrintDialog.Checked)
                printLibrary.SettingDialog = true;

            if (!cbIsStream.Checked) {
                string jobName = string.IsNullOrEmpty(tbDocumentName.Text.Trim()) ? tbFileName.Text : tbDocumentName.Text.Trim();
                if (cbUsePrinterSettings.Checked)
                {                  
                    if (cbUseWatermark.Checked)
                        result = printLibrary.Print(tbFileName.Text, _printerSettings, tbPassword.Text, _watermark, jobName);
                    else
                        result = printLibrary.Print(tbFileName.Text, _printerSettings, tbPassword.Text, jobName);
                }
                else
                {
                    if (cbUseWatermark.Checked)
                        result = printLibrary.Print(tbFileName.Text, tbPassword.Text, _watermark, jobName);
                    else
                        result = printLibrary.Print(tbFileName.Text, tbPassword.Text, jobName);
                }
            }
            else {
                if (cbUsePrinterSettings.Checked)
                {
                    if (cbUseWatermark.Checked)
                        result = printLibrary.Print(PdfPrintTest.GetStream(tbFileName.Text), _printerSettings, tbPassword.Text, tbDocumentName.Text, _watermark);
                    else
                        result = printLibrary.Print(PdfPrintTest.GetStream(tbFileName.Text), _printerSettings, tbPassword.Text, tbDocumentName.Text);
                }
                else
                {
                    if (cbUseWatermark.Checked)
                        result = printLibrary.Print(PdfPrintTest.GetStream(tbFileName.Text), tbPassword.Text, tbDocumentName.Text, _watermark);
                    else
                        result = printLibrary.Print(PdfPrintTest.GetStream(tbFileName.Text), tbPassword.Text, tbDocumentName.Text);
                }
            }
                       
            if (result == PdfPrint.Status.OK)
                MessageBox.Show("Done successfully.");
            else
                MessageBox.Show("Error. " + PdfPrintTest.DecodeStatusCode(result));
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            var result = openPDFFileDialog.ShowDialog();
            if (result == DialogResult.OK)
                tbFileName.Text = openPDFFileDialog.FileName;
        }

        private void btnImageFileName_Click(object sender, EventArgs e)
        {
            var result = saveFileDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                tbImageFileName.Text = saveFileDialog.FileName;
            }
        }

        private PdfPrint.TiffCompression GetTiffCompression() {
            if (cmbxTiffCompression.SelectedItem.ToString().Contains("None"))
                return PdfPrint.TiffCompression.CompressionNone;
            if (cmbxTiffCompression.SelectedItem.ToString().Contains("LZW"))
                return PdfPrint.TiffCompression.CompressionLZW;
            if (cmbxTiffCompression.SelectedItem.ToString().Contains("CCITT3"))
                return PdfPrint.TiffCompression.CompressionCCITT3;
            if (cmbxTiffCompression.SelectedItem.ToString().Contains("CCITT4"))
                return PdfPrint.TiffCompression.CompressionCCITT4;
            return PdfPrint.TiffCompression.CompressionLZW;
        }

        private void btnSavePdfAsImage_Click(object sender, EventArgs e)
        {
            var printLibrary = PdfPrintTest.GetPdfPrint(_configFile);            
            var colorType = PdfPrint.ColorType.Original;
            if (rbAsItIsInPDF.Checked)
                colorType = PdfPrint.ColorType.Original;
            if (rbBlackAndWhite.Checked)
                colorType = PdfPrint.ColorType.BlackAndWhite;
            if (rbGray.Checked)
                colorType = PdfPrint.ColorType.GrayScale;

            try
            {                
                PdfPrint.Status result;
                if (cbxMultiTiff.Checked)
                {
                    var tiffCompression = GetTiffCompression();
                    if (cbIsStreamImage.Checked)
                        result = printLibrary.SavePdfPagesAsMultiPageTiff(PdfPrintTest.GetStream(tbFileName.Text), tbImageFileName.Text, (int)numFrom.Value,
                                                  (int)numToPage.Value, (int)numZoom.Value,
                                                  (float)numXResolution.Value, (float)numYResolution.Value, colorType, tbPassword.Text, tiffCompression);
                    else
                        result = printLibrary.SavePdfPagesAsMultiPageTiff(tbFileName.Text, tbImageFileName.Text, (int)numFrom.Value,
                                                  (int)numToPage.Value, (int)numZoom.Value,
                                                  (float)numXResolution.Value, (float)numYResolution.Value, colorType, tbPassword.Text, tiffCompression);
                }
                else
                {
                    if (cbIsStreamImage.Checked)
                        result = printLibrary.SavePdfPagesAsImages(PdfPrintTest.GetStream(tbFileName.Text), tbImageFileName.Text, (int)numFrom.Value,
                                                      (int)numToPage.Value, (int)numZoom.Value,
                                                      (float)numXResolution.Value, (float)numYResolution.Value, colorType,
                                                      (long)numQuality.Value, tbPassword.Text);
                    else
                        result = printLibrary.SavePdfPagesAsImages(tbFileName.Text, tbImageFileName.Text, (int)numFrom.Value,
                                                      (int)numToPage.Value, (int)numZoom.Value,
                                                      (float)numXResolution.Value, (float)numYResolution.Value, colorType,
                                                      (long)numQuality.Value, tbPassword.Text);
                }

                if (result == PdfPrint.Status.OK)
                    MessageBox.Show("Done successfully.");
                else
                    MessageBox.Show("Error. " + PdfPrintTest.DecodeStatusCode(result));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex.Message);
            }
        }               

        private void FillPrinterDefaults(PrinterInfo printerInfo, bool isAdobe)
        {
            if (isAdobe)
            {
                cbCollateAdobe.Checked = printerInfo.Collate;
                numCopiesAdobe.Value = printerInfo.Copies;
                rbDuplexSimplexAdobe.Checked = printerInfo.Duplex == Duplex.Simplex;
                rbDuplexHorizontalAdobe.Checked = printerInfo.Duplex == Duplex.Horizontal;
                rbDuplexVerticalAdobe.Checked = printerInfo.Duplex == Duplex.Vertical;
                rbLandscapeAdobe.Checked = printerInfo.Landscape;
                rbPortraitAdobe.Checked = !printerInfo.Landscape;
                cbPrintInColorAdobe.Checked = printerInfo.Color;
            }
            else
            {
                cbCollate.Checked = printerInfo.Collate;
                numCopies.Value = printerInfo.Copies;
                rbDuplexSimplex.Checked = printerInfo.Duplex == Duplex.Simplex;
                rbDuplexHorizontal.Checked = printerInfo.Duplex == Duplex.Horizontal;
                rbDuplexVertical.Checked = printerInfo.Duplex == Duplex.Vertical;
                rbLandscape.Checked = printerInfo.Landscape;
                rbPortrait.Checked = !printerInfo.Landscape;
                cbPrintInColor.Checked = printerInfo.Color;
            }
            
            PdfPrintTest.FillComboBox(isAdobe ? cmbxPrinterResolutionsAdobe : cmbxPrinterResolutions, printerInfo.PrinterResolutions, printerInfo.PrinterResolution);
            PdfPrintTest.FillComboBox(isAdobe ? cmbxPaperSizeAdobe : cmbxPaperSize, printerInfo.PaperSizes, printerInfo.PaperSize);
            PdfPrintTest.FillComboBox(isAdobe ? cmbxPaperSourceAdobe : cmbxPaperSource, printerInfo.PaperSources, printerInfo.PaperSource);
        }

        private void cmbxPrinterNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            _isNonAdobe = true;
            _isAdobe = false;
            LoadPrinterDefaults(cmbxPrinterNames.SelectedItem.ToString());
        }

        private void btnPrintWithAdobe_Click(object sender, EventArgs e)
        {            
            try
            {
                if (!PdfPrintTest.IsFileNameCorrect(tbFileName.Text))
                    return;                
                var printLibrary = PdfPrintTest.GetPdfPrint(_configFile);                           
                if (!SetSettingsFromGUIAdobe(printLibrary))
                    return;
                
                var resultMessage = "";
                PdfPrint.Status result = PdfPrint.Status.OK;
                if (cbUsePrinterSettingsAdobe.Checked)
                {
                    if (_printerSettingsAdobe == null)
                    {
                        MessageBox.Show("PrinterSettings not set. Press Set Printer Settings button");
                        return;
                    }
                    result = printLibrary.PrintWithAdobe(tbFileName.Text, _printerSettingsAdobe, ref resultMessage);
                }
                else
                    result = printLibrary.PrintWithAdobe(tbFileName.Text, ref resultMessage);

                MessageBox.Show("Result message=" + resultMessage);
                if (result == PdfPrint.Status.OK)
                    MessageBox.Show("Done successfully.");
                else
                    MessageBox.Show("Error. " + PdfPrintTest.DecodeStatusCode(result));
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exception " + ex.Message);
            }
        }

        private PrinterSettings _printerSettings = null;
        private PrinterSettings _printerSettingsAdobe = null;

        private void btnSetPrinterSettings_Click(object sender, EventArgs e)
        {            
            if (PdfPrintTest.Is64)
                MessageBox.Show("Not supported for 64 bit process");            
            else {
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)                
                    _printerSettings = printDialog.PrinterSettings;                
            }
        }

        private void btnSetPrinterSettingsAdobe_Click(object sender, EventArgs e)
        {
            if (PdfPrintTest.Is64)
                MessageBox.Show("Not supported for 64 bit process");
            else
            {
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)                
                    _printerSettingsAdobe = printDialog.PrinterSettings;                
            }
        }         

        private void btnSetWatermark_Click(object sender, EventArgs e)
        {
            if (_watermarkForm.ShowDialog() == DialogResult.OK)
                _watermark = _watermarkForm.Watermark;
        }

        private void cmbxPrinterNamesAdobe_SelectedIndexChanged(object sender, EventArgs e)
        {            
            _isNonAdobe = false;
            _isAdobe = true;            
            LoadPrinterDefaults(cmbxPrinterNamesAdobe.SelectedItem.ToString());                     
        }

        private void EnableOrDisableFieldsBasedOnDefaultCheck(bool isAdobe)
        {
            if (isAdobe)
            {
                numCopiesAdobe.Enabled = !cbDefaultNumCopiesAdobe.Checked;
                rbDuplexHorizontalAdobe.Enabled = !cbDefaultDuplexAdobe.Checked;
                rbDuplexSimplexAdobe.Enabled = !cbDefaultDuplexAdobe.Checked;
                rbDuplexVerticalAdobe.Enabled = !cbDefaultDuplexAdobe.Checked;
                cbPrintInColorAdobe.Enabled = !cbDefaultPrintInColorAdobe.Checked;
                cbCollateAdobe.Enabled = !cbDefaultCollateAdobe.Checked;
                cmbxPaperSourceAdobe.Enabled = !cbDefaultPaperSourceAdobe.Checked;
                rbPortraitAdobe.Enabled = !cbDefaultPrintOrientationAdobe.Checked;
                rbLandscapeAdobe.Enabled = !cbDefaultPrintOrientationAdobe.Checked;           
                cmbxPrinterResolutionsAdobe.Enabled = !cbDefaultPrinterResolutionAdobe.Checked;
                cmbxPaperSizeAdobe.Enabled = !cbDefaultPaperSizeAdobe.Checked;
            } else
            {
                numCopies.Enabled = !cbDefaultNumCopies.Checked;
                rbDuplexHorizontal.Enabled = !cbDefaultDuplex.Checked;
                rbDuplexSimplex.Enabled = !cbDefaultDuplex.Checked;
                rbDuplexVertical.Enabled = !cbDefaultDuplex.Checked;
                cbPrintInColor.Enabled = !cbDefaultPrintInColor.Checked;
                cbCollate.Enabled = !cbDefaultCollate.Checked;
                cmbxPaperSource.Enabled = !cbDefaultPaperSource.Checked;
                rbPortrait.Enabled = !cbDefaultPrintOrientation.Checked;
                rbLandscape.Enabled = !cbDefaultPrintOrientation.Checked;               
                cmbxPrinterResolutions.Enabled = !cbDefaultPrinterResolution.Checked;
                cmbxPaperSize.Enabled = !cbDefaultPaperSize.Checked;
            }
        }

        private void cbDefault_CheckedChanged(object sender, EventArgs e)
        {
            EnableOrDisableFieldsBasedOnDefaultCheck(false);
        }

        private void cbDefaultAdobe_CheckedChanged(object sender, EventArgs e)
        {
            EnableOrDisableFieldsBasedOnDefaultCheck(true);
        }

        private void cbUsePrinterSettings_CheckedChanged(object sender, EventArgs e)
        {
            panelPrinterSettings.Enabled = !cbUsePrinterSettings.Checked;
            btnSetPrinterSettings.Enabled = cbUsePrinterSettings.Checked;
        }

        private void cbUsePrinterSettingsAdobe_CheckedChanged(object sender, EventArgs e)
        {
            panelPrinterSettingsAdobe.Enabled = !cbUsePrinterSettingsAdobe.Checked;
            btnSetPrinterSettingsAdobe.Enabled = cbUsePrinterSettingsAdobe.Checked;
        }

        #region Mechanism for loading Printer Defaults - it can be very slow (in case of non-local printer) so I use Thread and Timer to not lose GUI responsivnes        

        private void SetPrinterInfo(object printerName) // We want to read just once to avoid double access of printerSettings which can be slow in case of non-local printer
        {            
            _printerInfo = PdfPrintTest.GetPrinterInfo(printerName);
            _printerInfoLoaded = true;
        }

        private System.Windows.Forms.Timer _timer = new System.Windows.Forms.Timer();
        private static bool _printerInfoLoaded = false;
        private static bool _isAdobe = true;
        private static bool _isNonAdobe = true;
        private static PrinterInfo _printerInfo = new PrinterInfo();
        private void LoadPrinterDefaults(string printerName)
        {
            Cursor = Cursors.WaitCursor;
            _printerInfoLoaded = false;            
            _timer.Start();
            Thread t = new Thread(new ParameterizedThreadStart(SetPrinterInfo));
            var printerSettings = new PrinterSettings();
            t.Start(printerName);
        }

        private void _timer_Tick(object sender, EventArgs e)
        {
            if (_printerInfoLoaded)
            {
                if (_isAdobe)
                    FillPrinterDefaults(_printerInfo, true);
                if (_isNonAdobe)
                    FillPrinterDefaults(_printerInfo, false);
                _isAdobe = false;
                _isNonAdobe = false;
                Cursor = Cursors.Arrow;
                _timer.Stop();
                _printerInfoLoaded = false;
            }
        }
        #endregion

        private void PdfPrintLibraryTestForm_Load(object sender, EventArgs e)
        {
            PdfPrintTest.SetConfigFromIni(_configFile);
            _timer.Interval = 100;
            _timer.Tick += _timer_Tick;
            _previewPaperHeight = _configFile.PreviewPageHeight;
            _previewPaperWidth = _configFile.PreviewPageWidth;
            _watermarkForm = new WatermarkForm(_watermark, _previewPaperWidth, _previewPaperHeight, _previewImagePath);
            Text += (PdfPrintTest.Is64 ? " 64 bit" : " 32 bit") + " ver. " + Application.ProductVersion;
            if (PdfPrintTest.Is64)
            {
                // on 64 bit PrinterSettingsDialog isn't available so we hide it...
                btnSetPrinterSettings.Visible = false;
                btnSetPrinterSettingsAdobe.Visible = false;
                cbUsePrinterSettings.Visible = false;
                cbUsePrinterSettingsAdobe.Visible = false;
            }
            cmbxTiffCompression.SelectedIndex = 0;
            EnableOrDisableFieldsBasedOnDefaultCheck(false);
            EnableOrDisableFieldsBasedOnDefaultCheck(true);
            FillPrinters();
            if (cmbxPrinterNames.Items.Count > 0)            
                LoadPrinterDefaults((new PrinterSettings()).PrinterName);           
        }

        private void cbUseWatermark_CheckedChanged(object sender, EventArgs e)
        {
            btnSetWatermark.Enabled = cbUseWatermark.Checked;
        }
    }
}
