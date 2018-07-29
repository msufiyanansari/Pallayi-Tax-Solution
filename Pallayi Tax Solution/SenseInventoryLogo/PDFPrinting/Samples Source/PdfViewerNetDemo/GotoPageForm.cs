using PdfViewerNet;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace PdfViewerNetDemo
{
    public partial class GotoPageForm : Form
    {
        private PdfViewer _callingPdfViewer;
        public GotoPageForm(PdfViewer callingPdfViewer)
        {
            InitializeComponent();
            _callingPdfViewer = callingPdfViewer;           
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ChangePageNumberAndCloseForm();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void GotoPageForm_Load(object sender, EventArgs e)
        {
            lTotalPages.Text = _callingPdfViewer.NumberOfPages.ToString();
            tbPageNumber.Text = _callingPdfViewer.CurrentPageNumber.ToString();
            tbPageNumber.SelectAll();
        }

        private void ChangePageNumberAndCloseForm()
        {
            int pageNumber = 0;
            try
            {
                pageNumber = int.Parse(tbPageNumber.Text.Trim());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Page number isn't valid.", "Invalid page number", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (pageNumber < 1 || pageNumber > _callingPdfViewer.NumberOfPages)
            {
                MessageBox.Show(string.Format("Page number must be within range {0} and {1}", 1, _callingPdfViewer.NumberOfPages), "Invalid page number interval", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _callingPdfViewer.GoToPage(pageNumber);
            Close();
        }

        private void GotoPageForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

            if (e.KeyCode == Keys.Enter)
                ChangePageNumberAndCloseForm();
        }
    }
}
