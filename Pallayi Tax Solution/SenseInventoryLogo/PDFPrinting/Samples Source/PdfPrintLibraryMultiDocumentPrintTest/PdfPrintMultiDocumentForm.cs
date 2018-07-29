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
using System.Text;
using System.Windows.Forms;

namespace PdfPrintLibraryMultiDocumentPrintTest
{
    public partial class PdfPrintMultiDocumentForm : Form
    {
        public PdfPrintMultiDocumentForm()
        {
            InitializeComponent();
        }

        public PDFPrintPropertiesForm[] pdfPrintPropertiesForms = new PDFPrintPropertiesForm[5];

        private ConfigFile _configFile = new ConfigFile();

        private void btnOpen_Click(object sender, EventArgs e)
        {
            Button buttonPressed = (sender as Button);
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF files (.pdf)|*.pdf";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                if (buttonPressed.Equals(btnOpen1))
                    tbPdf1.Text = ofd.FileName;
                if (buttonPressed.Equals(btnOpen2))
                    tbPdf2.Text = ofd.FileName;
                if (buttonPressed.Equals(btnOpen3))
                    tbPdf3.Text = ofd.FileName;
                if (buttonPressed.Equals(btnOpen4))
                    tbPdf4.Text = ofd.FileName;
                if (buttonPressed.Equals(btnOpen5))
                    tbPdf5.Text = ofd.FileName;
            }
        }    

        private void FillPrinters()
        {
            var installedPrinters = PrinterSettings.InstalledPrinters;
            var printerSettings = new PrinterSettings();
            string defaultPrinter = printerSettings.PrinterName;
            cmbxPrinterNames.SelectedIndexChanged -= cmbxPrinterNames_SelectedIndexChanged;
            PdfPrintTest.FillComboBox(cmbxPrinterNames, installedPrinters, defaultPrinter);           
            cmbxPrinterNames.SelectedIndexChanged += cmbxPrinterNames_SelectedIndexChanged;
        }        

        PrinterInfo _printerInfo = null;
        private void cmbxPrinterNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            _printerInfo = PdfPrintTest.GetPrinterInfo(cmbxPrinterNames.SelectedItem.ToString());

            foreach(PDFPrintPropertiesForm form in pdfPrintPropertiesForms)
                if (form != null)                
                    form.ApplyPrinterInfo(_printerInfo);
        }

        private void btnProperties_Click(object sender, EventArgs e)
        {
            string buttonPressed = (sender as Button).Name;
            string buttonIndex = buttonPressed[buttonPressed.Length - 1].ToString();
            int pdfDocumentIndex = -1;
            if (int.TryParse(buttonIndex, out pdfDocumentIndex))
            {
                pdfDocumentIndex--;
                if (pdfDocumentIndex > -1 && pdfDocumentIndex < 5)
                {
                    if (pdfPrintPropertiesForms[pdfDocumentIndex] == null)
                    {
                        pdfPrintPropertiesForms[pdfDocumentIndex] = new PDFPrintPropertiesForm(cmbxPrinterNames.SelectedItem.ToString(), pdfDocumentIndex);
                        if (_printerInfo == null)                        
                            _printerInfo = PdfPrintTest.GetPrinterInfo(cmbxPrinterNames.SelectedItem.ToString());                        
                        pdfPrintPropertiesForms[pdfDocumentIndex].ApplyPrinterInfo(_printerInfo);
                        pdfPrintPropertiesForms[pdfDocumentIndex].ShowDialog();
                    }
                    else
                        pdfPrintPropertiesForms[pdfDocumentIndex].ShowDialog();
                }
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Text += (PdfPrintTest.Is64 ? " 64 bit" : " 32 bit") + " ver. " + Application.ProductVersion;
            PdfPrintTest.SetConfigFromIni(_configFile);
            FillPrinters();
        }
            
        private void AddPdfDocumentIfNeeded(Control textBoxWithPdfFileName, int index, List<SinglePdfDocumentPrintSettings> documents)
        {
            string fileName = textBoxWithPdfFileName.Text.Trim();
            if (!string.IsNullOrEmpty(fileName))
            {
                if (!File.Exists(fileName))
                {
                    MessageBox.Show(string.Format("File {0} doesn't exist.", fileName));
                    textBoxWithPdfFileName.Focus();
                }
                else
                {
                    if (pdfPrintPropertiesForms[index] == null)
                        pdfPrintPropertiesForms[index] = new PDFPrintPropertiesForm(cmbxPrinterNames.SelectedItem.ToString(), index);
                    var pdfDocument = pdfPrintPropertiesForms[index].GetSinglePdfDocumentPrintSettings(fileName);
                    if (pdfDocument != null)
                        documents.Add(pdfDocument);
                }
            }
        }            
        private void btnPrint_Click(object sender, EventArgs e)
        {
            List<SinglePdfDocumentPrintSettings> documents = new List<SinglePdfDocumentPrintSettings>();
            AddPdfDocumentIfNeeded(tbPdf1, 0, documents);
            AddPdfDocumentIfNeeded(tbPdf2, 1, documents);
            AddPdfDocumentIfNeeded(tbPdf3, 2, documents);
            AddPdfDocumentIfNeeded(tbPdf4, 3, documents);
            AddPdfDocumentIfNeeded(tbPdf5, 4, documents);
            if (documents.Count > 0)
            {
                Cursor = Cursors.WaitCursor;
                var pdfPrint = PdfPrintTest.GetPdfPrint(_configFile);
                MultiPdfDocumentPrintSettings multiDocuments = new MultiPdfDocumentPrintSettings(tbJobName.Text);
                multiDocuments.DocumentList = documents;
                var status = pdfPrint.Print(multiDocuments);
                Cursor = Cursors.Arrow;
                MessageBox.Show("Status = " + status.ToString());                
                multiDocuments.Dispose();
            } else
                MessageBox.Show("None of the document selected for print.");
        }

        private void tbPdf_TextChanged(object sender, EventArgs e)
        {
            var textBox = (sender as TextBox);
            if (textBox.Equals(tbPdf1))
                btnProperties1.Enabled = !string.IsNullOrEmpty(tbPdf1.Text.Trim());
            if (textBox.Equals(tbPdf2))
                btnProperties2.Enabled = !string.IsNullOrEmpty(tbPdf2.Text.Trim());
            if (textBox.Equals(tbPdf3))
                btnProperties3.Enabled = !string.IsNullOrEmpty(tbPdf3.Text.Trim());
            if (textBox.Equals(tbPdf4))
                btnProperties4.Enabled = !string.IsNullOrEmpty(tbPdf4.Text.Trim());
            if (textBox.Equals(tbPdf5))
                btnProperties5.Enabled = !string.IsNullOrEmpty(tbPdf5.Text.Trim());
        }
    }    
}
