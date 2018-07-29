using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PdfViewerNetDemo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(string[] args)
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string fileName = args.Length > 0 ? args[0] : "";
            Application.Run(new PdfViewerNetForm(fileName));            
        }
    }
}
