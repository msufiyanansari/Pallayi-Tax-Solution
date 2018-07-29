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
    public partial class FindForm : Form
    {
        private PdfViewer _callingToolbar;
        public FindForm(PdfViewer callingToolbar)
        {
            InitializeComponent();
            _callingToolbar = callingToolbar;
        }

        private void tbSearchTerm_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)Keys.Enter)
            {
                btnNext.PerformClick();
                e.Handled = true;
            }

            if (e.KeyChar == (char)Keys.Escape)
            {
                Close();
            }
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            _callingToolbar.SearchPrevious(tbSearchTerm.Text, cbCaseSensitive.Checked, cbWholeWordOnly.Checked);
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            _callingToolbar.SearchNext(tbSearchTerm.Text, cbCaseSensitive.Checked, cbWholeWordOnly.Checked);
        }
    }
}
