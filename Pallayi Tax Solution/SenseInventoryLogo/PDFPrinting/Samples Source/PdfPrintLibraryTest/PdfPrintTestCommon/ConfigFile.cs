using System;
using System.Collections.Generic;
using System.Text;

namespace PdfPrintLibraryTest
{
    public class ConfigFile
    {
        public string Company { get; set; }
        public string Password { get; set; }
        public string PreviewPageWidth { get; set; }
        public string PreviewPageHeight { get; set; }
        
        public ConfigFile()
        {
            Company = "TestCompany";
            Password = "";
            PreviewPageHeight = "8.27";
            PreviewPageWidth = "11.69";
        }
    }
}
