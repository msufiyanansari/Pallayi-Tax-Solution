using PdfPrintingNet;
using PdfPrintLibraryTest;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PdfPrintLibraryMultiDocumentPrintTest
{
    public partial class PDFPrintPropertiesForm : Form
    {
        public string PrinterName { get; set; }
        private int _pdfDocumentIndex = -1;
        private PrinterSettings _printerSettings = new PrinterSettings();

        private string _previewPaperWidth = "";
        private string _previewPaperHeight = "";
        private string _previewImagePath = "";
        private PdfWatermark _watermark = new PdfWatermark();
        private WatermarkForm _watermarkForm;

        private ConfigFile _configFile = new ConfigFile();


        public PDFPrintPropertiesForm(string printerName, int pdfDocumentIndex)
        {
            InitializeComponent();
           // PdfDocumentSettings = pdfDocumentSettings;
            PrinterName = printerName;
            _pdfDocumentIndex = pdfDocumentIndex;
            Text = "Properties for PDF Document " + (++pdfDocumentIndex);
        }

        private void PDFPrintProperties_Load(object sender, EventArgs e)
        {
            PdfPrintTest.SetConfigFromIni(_configFile);
            _previewPaperHeight = _configFile.PreviewPageHeight;
            _previewPaperWidth = _configFile.PreviewPageWidth;
            _watermarkForm = new WatermarkForm(_watermark, _previewPaperWidth, _previewPaperHeight, _previewImagePath);

            if (PdfPrintTest.Is64)
            {
                // on 64 bit PrinterSettingsDialog isn't available so we hide it...
                btnSetPrinterSettings.Visible = false;            
                cbUsePrinterSettings.Visible = false;                
            }
        }

        public SinglePdfDocumentPrintSettings GetSinglePdfDocumentPrintSettings(string fileName)
        {
            SinglePdfDocumentPrintSettings pdfDocumentPrintSettings = null;
            if (cbIsStream.Checked)            
                pdfDocumentPrintSettings = new SinglePdfDocumentPrintSettings(File.ReadAllBytes(fileName), tbPassword.Text);
            else
                pdfDocumentPrintSettings = new SinglePdfDocumentPrintSettings(fileName, tbPassword.Text);

            var printerSettings = new PrinterSettings();
            var defaultPrinter = printerSettings.PrinterName;
            PdfPrintTest.SetDefaultPrinter(PrinterName);
            var newPrinterSettings = new PrinterSettings();

            if (cbUsePrinterSettings.Checked)
                pdfDocumentPrintSettings.PrinterSettings = _printerSettings;
            else
            {                                                        
                if (!cbDefaultPrintOrientation.Checked)
                {
                    if (rbLandscape.Checked)
                    {
                        pdfDocumentPrintSettings.IsLandscape = true;
                        newPrinterSettings.DefaultPageSettings.Landscape = true;
                    }
                    if (rbPortrait.Checked)
                    {
                        pdfDocumentPrintSettings.IsLandscape = false;
                        newPrinterSettings.DefaultPageSettings.Landscape = false;
                    }
                }
                                   

                if (!cbDefaultPaperSize.Checked)
                {
                    if (cmbxPaperSize.SelectedItem == null)
                    {
                        MessageBox.Show(string.Format("Paper size for PDF Document {0} not set.", _pdfDocumentIndex));
                        PdfPrintTest.SetDefaultPrinter(defaultPrinter);
                        return null;
                    }

                    foreach (PaperSize size in newPrinterSettings.PaperSizes)
                    {
                        if (size.ToString().Equals(cmbxPaperSize.SelectedItem.ToString()))
                        {
                            pdfDocumentPrintSettings.PaperSize = size;
                            newPrinterSettings.DefaultPageSettings.PaperSize = size;
                            break;
                        }
                    }
                }

                if (!cbDefaultPaperSource.Checked)
                {
                    if (cmbxPaperSource.SelectedItem == null)
                    {
                        MessageBox.Show(string.Format("Paper source for PDF Document {0} not set.", _pdfDocumentIndex));
                        PdfPrintTest.SetDefaultPrinter(PrinterName);
                        return null;
                    }

                    foreach (PaperSource paperSource in newPrinterSettings.PaperSources)
                    {
                        if (paperSource.ToString().Equals(cmbxPaperSource.SelectedItem.ToString()))
                        {
                            pdfDocumentPrintSettings.PaperSource = paperSource;
                            newPrinterSettings.DefaultPageSettings.PaperSource = paperSource;
                            break;
                        }
                    }
                }

                if (!cbDefaultPrintInColor.Checked)
                {
                    pdfDocumentPrintSettings.PrintInColor = cbPrintInColor.Checked;
                    newPrinterSettings.DefaultPageSettings.Color = cbPrintInColor.Checked;
                }

                if (!cbDefaultPrinterResolution.Checked)
                {
                    if (cmbxPrinterResolutions.SelectedItem == null)
                    {
                        MessageBox.Show(string.Format("Printer resolution for PDF Document {0} not set.", _pdfDocumentIndex));
                        PdfPrintTest.SetDefaultPrinter(defaultPrinter);
                        return null;
                    }

                    foreach (PrinterResolution printerResolution in newPrinterSettings.PrinterResolutions)
                    {
                        if (printerResolution.ToString().Equals(cmbxPrinterResolutions.SelectedItem.ToString()))
                        {
                            pdfDocumentPrintSettings.PrinterResolution = printerResolution;
                            newPrinterSettings.DefaultPageSettings.PrinterResolution = printerResolution;
                            break;
                        }
                    }
                }
                
                PdfPrintTest.SetDefaultPrinter(defaultPrinter);
                newPrinterSettings.PrinterName = PrinterName;
                pdfDocumentPrintSettings.PrinterSettings = newPrinterSettings;
            }

            if (cbUseWatermark.Checked)
                pdfDocumentPrintSettings.Watermark = _watermark;
            pdfDocumentPrintSettings.IsContentCentered = cbCentered.Checked;
            pdfDocumentPrintSettings.IsAutoRotate = cbAutoRotate.Checked;

            if (rbScaleActualSize.Checked)
                pdfDocumentPrintSettings.Scale = PdfPrint.ScaleTypes.None;
            if (rbScaleFit.Checked)
                pdfDocumentPrintSettings.Scale = PdfPrint.ScaleTypes.FitToMargins;
            if (rbScaleShrink.Checked)
                pdfDocumentPrintSettings.Scale = PdfPrint.ScaleTypes.Shrink;

            pdfDocumentPrintSettings.Pages = tbPrintPages.Text;

            if (rbPrintEvenOdd.Checked)
                pdfDocumentPrintSettings.RangeType = PdfPrint.RangeTypes.EvenAndOdd;
            if (rbPrintEven.Checked)
                pdfDocumentPrintSettings.RangeType = PdfPrint.RangeTypes.JustEven;
            if (rbPrintOdd.Checked)
                pdfDocumentPrintSettings.RangeType = PdfPrint.RangeTypes.JustOdd;            
            
            return pdfDocumentPrintSettings;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {                       
            Hide(); 
        }
        
        private void EnableOrDisableFieldsBasedOnDefaultCheck()
        {          
            cbPrintInColor.Enabled = !cbDefaultPrintInColor.Checked;                
            cmbxPaperSource.Enabled = !cbDefaultPaperSource.Checked;
            rbPortrait.Enabled = !cbDefaultPrintOrientation.Checked;
            rbLandscape.Enabled = !cbDefaultPrintOrientation.Checked;
            cmbxPrinterResolutions.Enabled = !cbDefaultPrinterResolution.Checked;
            cmbxPaperSize.Enabled = !cbDefaultPaperSize.Checked;            
        }

        public void ApplyPrinterInfo(PrinterInfo printerInfo)
        {
            cbDefaultPaperSize.Checked = true;
            cbDefaultPaperSource.Checked = true;
            cbDefaultPrinterResolution.Checked = true;
            cbDefaultPrintInColor.Checked = true;
            cbDefaultPrintOrientation.Checked = true;
            
            cbPrintInColor.Checked = printerInfo.Color;
            rbLandscape.Checked = printerInfo.Landscape;
            rbPortrait.Checked = !printerInfo.Landscape;
            _printerSettings = null;
            
            rbLandscape.Checked = printerInfo.Landscape;
            rbPortrait.Checked = !printerInfo.Landscape;

            PdfPrintTest.FillComboBox(cmbxPrinterResolutions, printerInfo.PrinterResolutions, printerInfo.PrinterResolution);
            PdfPrintTest.FillComboBox(cmbxPaperSize, printerInfo.PaperSizes, printerInfo.PaperSize);
            PdfPrintTest.FillComboBox(cmbxPaperSource, printerInfo.PaperSources, printerInfo.PaperSource);

            PrinterName = printerInfo.PrinterName;
            cbUsePrinterSettings.Checked = false;
            EnableOrDisableFieldsBasedOnDefaultCheck();
        }

        private void btnSetPrinterSettings_Click(object sender, EventArgs e)
        {
            if (PdfPrintTest.Is64)
                MessageBox.Show("Not supported for 64 bit process");
            else
            {
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)
                    _printerSettings = printDialog.PrinterSettings;
            }        
        }

        private void cbDefault_Changed(object sender, EventArgs e)
        {
            EnableOrDisableFieldsBasedOnDefaultCheck();
        }

        private void cbUsePrinterSettings_CheckedChanged(object sender, EventArgs e)
        {
            panelPrinterSettings.Enabled = !cbUsePrinterSettings.Checked;
            btnSetPrinterSettings.Enabled = cbUsePrinterSettings.Checked;
        }

        private void btnSetWatermark_Click(object sender, EventArgs e)
        {
            if (_watermarkForm.ShowDialog() == DialogResult.OK)
                _watermark = _watermarkForm.Watermark;
        }

        private void cbUseWatermark_CheckedChanged(object sender, EventArgs e)
        {
            btnSetWatermark.Enabled = cbUseWatermark.Checked;
        }
    }
}
