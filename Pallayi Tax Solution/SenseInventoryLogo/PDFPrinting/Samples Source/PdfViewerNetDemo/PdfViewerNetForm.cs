using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace PdfViewerNetDemo
{
    public partial class PdfViewerNetForm : Form
    {
        private string _fileName = "";
        private ConfigFile _configFile;
        public PdfViewerNetForm(string fileName)
        {
            InitializeComponent();
            _fileName = fileName;            
            pdfViewer1.DocumentLoaded += PdfViewer1_DocumentLoaded;
            pdfViewer1.DocumentSaved += PdfViewer1_DocumentSaved;
            pdfViewer1.CurrentPageChanged += PdfViewer1_CurrentPageChanged;
        }

        private void PdfViewer1_DocumentSaved(object sender, PdfViewerNet.DocumentSavedEventArgs e)
        {
            Text = e.NewFileName;
        }

        private void PdfViewer1_CurrentPageChanged(object sender, PdfViewerNet.CurrentPageEventArgs e)
        {
            RefreshMenu();
        }

        private void PdfViewer1_DocumentLoaded(object sender, PdfViewerNet.DocumentLoadedEventArgs e)
        {
            Text = e.FileName;
            RefreshMenu();
        }

        private void PdfViewerNetForm_Load(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_fileName))            
                pdfViewer1.OpenDocument(_fileName);
            _configFile = new ConfigFile(pdfViewer1);
            pdfViewer1.IsToolbarVisible = _configFile.IsToolbarVisible;
            pdfViewer1.ToolbarBookmarkVisible = _configFile.ToolbarBookmarkVisible;
            pdfViewer1.ToolbarDocumentInfoVisible = _configFile.ToolbarDocumentInfoVisible;
            pdfViewer1.ToolbarOpenVisible = _configFile.ToolbarOpenVisible;
            pdfViewer1.ToolbarPageViewTypeVisible = _configFile.ToolbarPageViewTypeVisible;
            pdfViewer1.ToolbarPageVisible = _configFile.ToolbarPageVisible;
            pdfViewer1.ToolbarPrintVisible = _configFile.ToolbarPrintVisible;
            pdfViewer1.ToolbarRotateVisible = _configFile.ToolbarRotateVisible;
            pdfViewer1.ToolbarSearchVisible = _configFile.ToolbarSearchVisible;
            pdfViewer1.ToolbarVisitedPagesVisible = _configFile.ToolbarVisitedPagesVisible;
            pdfViewer1.ToolbarZoomVisible = _configFile.ToolbarZoomVisible;
            pdfViewer1.ToolbarTooltipVisible = _configFile.ToolbarTooltipVisible;
            pdfViewer1.ShowBookmarks = _configFile.ShowBookmark;
            pdfViewer1.ViewType = _configFile.ViewType;
            pdfViewer1.SetLicenseInfo(_configFile.Company, _configFile.Password);
            pdfViewer1.SelectionDisabled = _configFile.SelectionDisabled;
            pdfViewer1.DisablePrinting = _configFile.DisablePrinting;
            RefreshMenu();
        }

        private void menuItemOpenFile_Click(object sender, EventArgs e)
        {           
            OpenDocument();
        }

        private void OpenDocument()
        {
            pdfViewer1.OpenDocument();
        }
        private void menuItemCloseDocument_Click(object sender, EventArgs e)
        {
            pdfViewer1.CloseDocument();
        }

        private void menuItemDocumentInfo_Click(object sender, EventArgs e)
        {
            pdfViewer1.ShowDocumentInfo();
        }

        private void bookmarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.ShowBookmarks = !pdfViewer1.ShowBookmarks;
        }

        private void menuItemPrint_Click(object sender, EventArgs e)
        {
            pdfViewer1.Print();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
            // TODO Dispose svega? Da li treba?            
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.SelectAllText();
        }

        private void deselectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.DeselectAllText();
        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.CopySelectedContentToClipboard();
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //pdfViewer1.SelectToolbarSearchField();
            FindForm findForm = new FindForm(pdfViewer1);
            findForm.ShowDialog();
        }

        private void clockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.Rotate(true);
        }

        private void counterClockwiseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.Rotate(false);
        }

        private void firstPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.GoToPage(1);
        }

        private void lastPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.GoToPage(pdfViewer1.NumberOfPages);
        }

        private void nextPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.GoToPage(pdfViewer1.CurrentPageNumber + 1);
        }

        private void previousPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.GoToPage(pdfViewer1.CurrentPageNumber - 1);
        }

        private void gotoPageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var gotoPageForm = new GotoPageForm(pdfViewer1);
            gotoPageForm.ShowDialog();            
        }

        private void previousViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.GoToPreviousVisitedPage();
        }

        private void nextViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.GoToNextVisitedPage();
        }

        private void continuousViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.ViewType = PdfViewerNet.PageViewType.Continuous;
        }

        private void singlePageViewToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.ViewType = PdfViewerNet.PageViewType.Single;
        }

        private void zoomToToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var zoomForm = new ZoomForm(pdfViewer1);
            zoomForm.ShowDialog();
            //pdfViewer1.SelectToolbarZoomField();
        }

        private void actualSizeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.ZoomValue = 100;
        }

        private void zoomToPageLevelToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.ZoomValue = (float)Math.Round(pdfViewer1.FitToPageZoomValue * 100, 2);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm aboutForm = new AboutForm();
            aboutForm.ShowDialog();
        }

        private OptionsForm _optionsForm = null;
        private void optionsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_optionsForm == null)
            {
                ConfigFile configFile = new ConfigFile(pdfViewer1);
                _optionsForm = new OptionsForm(pdfViewer1, configFile);
            }
            _optionsForm.ShowDialog();
        }
        
        private void RefreshMenu()
        {
            menuItemCloseDocument.Enabled = pdfViewer1.IsDocumentLoaded;
            menuItemPrint.Enabled = pdfViewer1.IsDocumentLoaded && pdfViewer1.DocumentPermissions.Print && !pdfViewer1.DisablePrinting;

            actualSizeToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;
            zoomToPageLevelToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;
            zoomToToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;

            bookmarksToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded && pdfViewer1.TableOfContent != null && pdfViewer1.TableOfContent.Count > 0;
            menuItemDocumentInfo.Enabled = pdfViewer1.IsDocumentLoaded;

            clockwiseToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;
            counterClockwiseToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;

            continuousViewToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;
            singlePageViewToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;

            var hasSelection = pdfViewer1.GetSelectedImage() != null || !string.IsNullOrEmpty(pdfViewer1.GetSelectedText());
            copyToClipboardToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded && hasSelection;
            selectAllToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded && !pdfViewer1.SelectionDisabled;
            deselectAllToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded && hasSelection;
            findToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;

            firstPageToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded && pdfViewer1.CurrentPageNumber != 1;
            lastPageToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded && pdfViewer1.CurrentPageNumber != pdfViewer1.NumberOfPages;
            previousPageToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded && pdfViewer1.CurrentPageNumber > 1;
            nextPageToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded && pdfViewer1.CurrentPageNumber < pdfViewer1.NumberOfPages;
            gotoPageToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;
            previousViewToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded && pdfViewer1.CurrentVisitedPageIndex > 0;
            nextViewToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded && pdfViewer1.CurrentVisitedPageIndex < (pdfViewer1.VisitedPages.Count - 1);

            navigationToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;
            pageDisplayToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;
            pageRotationToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;
            zoomToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;

            saveToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;
            sendAsEmailToolStripMenuItem.Enabled = pdfViewer1.IsDocumentLoaded;

            if (pdfViewer1.GetMaxZoomLevel() < 100)
                actualSizeToolStripMenuItem.Enabled = false;
        }

        private void menuStrip1_MenuActivate(object sender, EventArgs e)
        {
            RefreshMenu();
        }

        private void PdfViewerNetForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (pdfViewer1.IsDocumentLoaded)
                pdfViewer1.CloseDocument();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var saveStatus = pdfViewer1.SaveDocument();
            if (saveStatus.Result == PdfPrintingNet.PdfSaveFileStatus.PdfSaveFileResult.Error)            
                MessageBox.Show("There was an error in saving the document. " + saveStatus.Status, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            if (saveStatus.Result == PdfPrintingNet.PdfSaveFileStatus.PdfSaveFileResult.OK)
                MessageBox.Show("PDF document was saved successfully.");
        }

        private void sendAsEmailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pdfViewer1.SendDocumentInEmail();
        }
    }
}
