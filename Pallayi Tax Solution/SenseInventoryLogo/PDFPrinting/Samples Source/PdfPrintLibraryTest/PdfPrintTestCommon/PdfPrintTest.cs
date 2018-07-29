using PdfPrintingNet;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.IO;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace PdfPrintLibraryTest
{
    public class PdfPrintTest
    {
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);

        public static void FillComboBox(ComboBox comboBox, ICollection values, string defaultValue)
        {
            try
            {
                comboBox.Items.Clear();
                foreach (object value in values)
                {
                    if (value is PrinterResolution)
                    {
                        comboBox.Items.Add(((PrinterResolution)value).ToString());
                        continue;
                    }

                    if (value is PaperSource)
                    {
                        comboBox.Items.Add(((PaperSource)value).ToString());
                        continue;
                    }

                    if (value is PaperSize)
                    {
                        comboBox.Items.Add(((PaperSize)value).ToString());
                        continue;
                    }

                    if (value is string)
                        comboBox.Items.Add(value);
                }
                comboBox.SelectedIndex = comboBox.Items.IndexOf(defaultValue);
            }
            catch (Exception ex)
            {
                MessageBox.Show("FillComboBox error. ex=" + ex.Message);
            }
        }

        public static byte[] GetStream(string fileName)
        {
            return File.ReadAllBytes(fileName);
        }

        public static PdfPrint GetPdfPrint(ConfigFile configFile)
        {
            return new PdfPrint(configFile.Company, configFile.Password);
        }

        public static string DecodeStatusCode(PdfPrint.Status status)
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
                case PdfPrint.Status.INVALID_IMAGE_TYPE:
                    return "Invalid image type.";
                case PdfPrint.Status.NOT_32_BIT:
                    return "Printing with Adobe is supported only in 32 bit application.";
            }
            return "Unknown error.";
        }

        public static bool Is64 { get { return IntPtr.Size == 8; } }

        public static PrinterInfo GetPrinterInfo(object printerName) // We want to read just once to avoid double access of printerSettings which can be slow in case of non-local printer
        {
            //SetDefaultPrinter(printerName);
            var printerSettings = new PrinterSettings();
            printerSettings.PrinterName = printerName.ToString();
            PrinterInfo printerInfo = new PrinterInfo();
            printerInfo.PrinterName = printerName.ToString();
            printerInfo.Collate = printerSettings.Collate;
            printerInfo.Color = printerSettings.DefaultPageSettings.Color;
            printerInfo.Copies = printerSettings.Copies;
            printerInfo.Duplex = printerSettings.Duplex;
            printerInfo.Landscape = printerSettings.DefaultPageSettings.Landscape;
            printerInfo.PaperSize = printerSettings.DefaultPageSettings.PaperSize.ToString();
            foreach (PaperSize paperSize in printerSettings.PaperSizes)
                printerInfo.PaperSizes.Add(paperSize.ToString());
            printerInfo.PaperSource = printerSettings.DefaultPageSettings.PaperSource.ToString();
            foreach (PaperSource paperSource in printerSettings.PaperSources)
                printerInfo.PaperSources.Add(paperSource.ToString());
            printerInfo.PrinterResolution = printerSettings.DefaultPageSettings.PrinterResolution.ToString();
            foreach (PrinterResolution printerResolution in printerSettings.PrinterResolutions)
                printerInfo.PrinterResolutions.Add(printerResolution.ToString());
            return printerInfo;
        }

        public static bool IsFileNameCorrect(string fileName)
        {
            if (string.IsNullOrEmpty(fileName))
            {
                MessageBox.Show("Filename not set", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (!File.Exists(fileName))
            {
                MessageBox.Show("Filename doesn't exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }

        public static void SetConfigFromIni(ConfigFile configFile)
        {

            if (!File.Exists("testform.ini"))
                return;

            var lines = File.ReadAllLines("testform.ini");
            foreach (var line in lines)
            {
                if (line.StartsWith("COMPANY="))
                    configFile.Company = line.Replace("COMPANY=", "");
                if (line.StartsWith("PASSWORD="))
                    configFile.Password = line.Replace("PASSWORD=", "");

                if (line.StartsWith("PREVIEW_PAPER_WIDTH="))
                {
                    string previewPaperWidth = line.Replace("PREVIEW_PAPER_WIDTH=", "").Trim();
                    if (!string.IsNullOrEmpty(previewPaperWidth))
                        configFile.PreviewPageWidth = previewPaperWidth;
                }

                if (line.StartsWith("PREVIEW_PAPER_HEIGHT="))
                {
                    string previewPaperHeight = line.Replace("PREVIEW_PAPER_HEIGHT=", "").Trim();
                    if (!string.IsNullOrEmpty(previewPaperHeight))
                        configFile.PreviewPageHeight = previewPaperHeight;
                }
            }
        }
    }

    public class PrinterInfo
    {
        public string PrinterName { get; set; }
        public bool Collate { get; set; }
        public int Copies { get; set; }
        public Duplex Duplex { get; set; }
        public bool Landscape { get; set; }
        public bool Color { get; set; }
        public List<string> PrinterResolutions { get; set; }
        public List<string> PaperSources { get; set; }
        public List<string> PaperSizes { get; set; }
        public string PaperSource { get; set; }
        public string PaperSize { get; set; }
        public string PrinterResolution { get; set; }

        public PrinterInfo()
        {
            PrinterName = "";
            Collate = false;
            Copies = 1;
            Duplex = Duplex.Default;
            Landscape = false;
            Color = false;
            PrinterResolutions = new List<string>();
            PaperSources = new List<string>();
            PaperSizes = new List<string>();
            PrinterResolution = "";
            PaperSize = "";
            PaperSource = "";
        }
    }
}
