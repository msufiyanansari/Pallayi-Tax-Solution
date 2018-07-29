using System;
using System.IO;
using System.Windows.Forms;
using PdfPrintingNet;

namespace SimplePDFPrintLibraryTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ReadCompanyAndPasswordFromIni();
        }

        private bool _is64 = (IntPtr.Size == 8);

        private string _company = "Test";
        private string _password = "";

        private void ReadCompanyAndPasswordFromIni()
        {

            if (!File.Exists("testform.ini"))
                return;

            var lines = File.ReadAllLines("testform.ini");
            foreach (var line in lines)
            {
                if (line.StartsWith("COMPANY="))
                    _company = line.Replace("COMPANY=", "");
                if (line.StartsWith("PASSWORD="))
                    _password = line.Replace("PASSWORD=", "");                
            }
        }

        private string DecodeStatusCode(PdfPrint.Status status)
        {
            switch (status)
            {
                case PdfPrint.Status.OK:
                    return "OK";
                case PdfPrint.Status.FILE_DOESNT_EXIST:
                    return "Filename doesn't exist";
                case PdfPrint.Status.CANNOT_PRINT_FILE:
                    return "Cannot print file";
                case PdfPrint.Status.PRINTER_DOESNT_EXIST:
                    return "Printer doesn't exist";
                case PdfPrint.Status.INVALID_DEVMOD:
                    return "Invalid printer properties structure.";
                case PdfPrint.Status.NOT_AVAILABLE_PRINTER_PROPERTIES:
                    return "Not available printer properties";
                case PdfPrint.Status.CANT_INITIALIZE_PRINTER:
                    return "Can't initialize printer";
                case PdfPrint.Status.PASSWORD_INVALID:
                    return "Invalid password";
                case PdfPrint.Status.INVALID_PDF:
                    return "Invalid pdf";
                case PdfPrint.Status.FILENAME_NOT_SET:
                    return "File name not set";
                case PdfPrint.Status.PASSWORD_NOT_PROVIDED:
                    return "PDF is password protected and password isn't provided.";
                case PdfPrint.Status.UNKNOWN_ERROR:
                    return "Unknown error";
                case PdfPrint.Status.INVALID_PRINT_RANGE:
                    return "Invalid print range";
                case PdfPrint.Status.INVALID_ADOBE_PRINT_RANGE:
                    return "Invalid print range for adobe. It could be from-to, single page or empty.";
                case PdfPrint.Status.PAGE_NUMBER_DOESNT_EXIST:
                    return "Page number doesn't exist";
                case PdfPrint.Status.PRINTING_CANCELLED:
                    return "Printing cancelled";
                case PdfPrint.Status.NOT_32_BIT:
                    return "Printing with Adobe is supported only in 32 bit application.";
            }
            return "Unknown error.";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbFileName.Text))
            {
                MessageBox.Show("Filename not set.");
                return;
            }

            if (!File.Exists(tbFileName.Text))
            {
                MessageBox.Show("Filename doesn't exist.");
                return;
            }

            var pdfPrint = new PdfPrint(_company, _password);
            pdfPrint.IsContentCentered = cbIsContentCentered.Checked;

            if (cmbxScale.Text == "None")
                pdfPrint.Scale = PdfPrint.ScaleTypes.None;

            if (cmbxScale.Text == "Shrink")
                pdfPrint.Scale = PdfPrint.ScaleTypes.Shrink;

            if (cmbxScale.Text == "FitToMargins")
                pdfPrint.Scale = PdfPrint.ScaleTypes.FitToMargins;

            PdfPrint.Status result = PdfPrint.Status.OK;
            if (!_is64) // in 32 bit PrintDialog could be used
            {
                PrintDialog printDialog = new PrintDialog();
                if (printDialog.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        result = pdfPrint.Print(tbFileName.Text, printDialog.PrinterSettings, tbPassword.Text);
                    }
                    catch (Exception ex)
                    {
                        result = PdfPrint.Status.UNKNOWN_ERROR;
                        MessageBox.Show("Error." + ex.Message);
                    }
                }
                else
                    result = PdfPrint.Status.PRINTING_CANCELLED;
            }
            else
            {
                pdfPrint.SettingDialog = true;
                try
                {
                    result = pdfPrint.Print(tbFileName.Text, tbPassword.Text);
                }
                catch (Exception ex)
                {
                    result = PdfPrint.Status.UNKNOWN_ERROR;
                    MessageBox.Show("Error." + ex.Message);
                }
            }

            if (result == PdfPrint.Status.OK)
                MessageBox.Show("Done successfully.");
            else if (result == PdfPrint.Status.PRINTING_CANCELLED)
                MessageBox.Show(DecodeStatusCode(result));
            else 
                MessageBox.Show("Error. " + DecodeStatusCode(result));
        }

        private void btnOpenFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();            
            openFileDialog.Filter = "PDF Files (.PDF)|*.PDF";           
            if (openFileDialog.ShowDialog() == DialogResult.OK)
                tbFileName.Text = openFileDialog.FileName;
        }        

        private void Form1_Load(object sender, EventArgs e)
        {            
            cmbxScale.SelectedIndex = 1;            
            Text += (_is64 ? " 64 bit" : " 32 bit") + " ver. " + Application.ProductVersion;
        }        
    }
}
