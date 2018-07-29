using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using PdfViewerNet;

namespace PdfViewerNetDemo
{
    public partial class OptionsForm : Form
    {
        private PdfViewer _pdfViewer = null;
        private ConfigFile _configFile = null;

        private List<string> viewTypeOptions = new List<string>();
        public OptionsForm(PdfViewer pdfViewer, ConfigFile configFile)
        {
            InitializeComponent();
            _pdfViewer = pdfViewer;
            _configFile = configFile;
            viewTypeOptions.Add("Single");
            viewTypeOptions.Add("Continuous");
            cmbxPageViewType.DataSource = viewTypeOptions;
        }
       
        private void btnOK_Click(object sender, EventArgs e)
        {
            _pdfViewer.IsToolbarVisible = cbDisplayToolbar.Checked;
            _pdfViewer.ToolbarTooltipVisible = cbShowToolbarTooltips.Checked;
            _pdfViewer.ToolbarBookmarkVisible = cbShowToolbarBookmarks.Checked;
            _pdfViewer.ToolbarDocumentInfoVisible = cbShowDocumentInfo.Checked;
            _pdfViewer.ToolbarOpenVisible = cbShowOpen.Checked;
            _pdfViewer.ToolbarPageViewTypeVisible = cbShowPageViewType.Checked;
            _pdfViewer.ToolbarPageVisible = cbShowPages.Checked;
            _pdfViewer.ToolbarPrintVisible = cbShowPrint.Checked;
            _pdfViewer.ToolbarRotateVisible = cbShowRotation.Checked;
            _pdfViewer.ToolbarSearchVisible = cbShowSearch.Checked;
            _pdfViewer.ToolbarVisitedPagesVisible = cbShowVisited.Checked;
            _pdfViewer.ToolbarZoomVisible = cbShowZoom.Checked;
            _pdfViewer.ShowBookmarks = cbShowBookmarks.Checked;
            _pdfViewer.SelectionDisabled = cbDisableSelection.Checked;
            _pdfViewer.ToolbarEmailVisible = cbShowEmailButton.Checked;
            _pdfViewer.ToolbarSaveVisible = cbShowSaveButton.Checked;
            _pdfViewer.DisableParentShortcuts = cbDisableParentShortcuts.Checked;
            _pdfViewer.DisablePdfViewerShortcuts = cbDisablePdfViewerShortctus.Checked;
            _pdfViewer.DisablePrinting = cbDisablePrinting.Checked;

            string viewType = cmbxPageViewType.SelectedItem.ToString().ToUpper();
            if (viewType.Equals("SINGLE"))
                _pdfViewer.ViewType = PageViewType.Single;
            if (viewType.Equals("CONTINUOUS"))
                _pdfViewer.ViewType = PageViewType.Continuous;
            _configFile.SaveConfig();            
            Close();          
        }

        private void OptionsForm_Load(object sender, EventArgs e)
        {
            cbDisplayToolbar.Checked = _pdfViewer.IsToolbarVisible;
            cbShowToolbarTooltips.Checked = _pdfViewer.ToolbarTooltipVisible;
            cbShowDocumentInfo.Checked = _pdfViewer.ToolbarDocumentInfoVisible;
            cbShowOpen.Checked = _pdfViewer.ToolbarOpenVisible;
            cbShowPages.Checked = _pdfViewer.ToolbarPageVisible;
            cbShowPageViewType.Checked = _pdfViewer.ToolbarPageViewTypeVisible;
            cbShowPrint.Checked = _pdfViewer.ToolbarPrintVisible;
            cbShowRotation.Checked = _pdfViewer.ToolbarRotateVisible;
            cbShowSearch.Checked = _pdfViewer.ToolbarSearchVisible;
            cbShowToolbarBookmarks.Checked = _pdfViewer.ToolbarBookmarkVisible;
            cbShowVisited.Checked = _pdfViewer.ToolbarVisitedPagesVisible;
            cbShowZoom.Checked = _pdfViewer.ToolbarZoomVisible;
            cbShowBookmarks.Checked = _pdfViewer.ShowBookmarks;
            cbDisableSelection.Checked = _pdfViewer.SelectionDisabled;
            cbDisableParentShortcuts.Checked = _pdfViewer.DisableParentShortcuts;
            cbDisablePdfViewerShortctus.Checked = _pdfViewer.DisablePdfViewerShortcuts;
            cbDisablePrinting.Checked = _pdfViewer.DisablePrinting;

            string viewTypeVal = "None";
            if (_pdfViewer.ViewType == PageViewType.Continuous)
                viewTypeVal = "Continuous";
            if (_pdfViewer.ViewType == PageViewType.Single)
                viewTypeVal = "Single";
            int index = viewTypeOptions.IndexOf(viewTypeVal);
            if (index != -1)
                cmbxPageViewType.SelectedIndex = index;
            cbShowSaveButton.Checked = _pdfViewer.ToolbarSaveVisible;
            cbShowEmailButton.Checked = _pdfViewer.ToolbarEmailVisible;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
