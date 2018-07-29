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
    public partial class ZoomForm : Form
    {
        PdfViewer _callingPdfViewer;
        const string ZOOM_TO_PAGE_LEVEL = "Zoom To Page Level";
        const string ACTUAL_SIZE = "Actual Size";

        private string _currentValue = "";
        public ZoomForm(PdfViewer callingPdfViewer)
        {
            InitializeComponent();
            _callingPdfViewer = callingPdfViewer;            
        }

        private void ZoomForm_Load(object sender, EventArgs e)
        {
            List<string> zoomValues = new List<string>();
            var availableZoomLevels = _callingPdfViewer.GetAvailableZoomLevels();
            foreach (float availableZoomLevel in availableZoomLevels)
                zoomValues.Add(availableZoomLevel + "%");
            zoomValues.Add(ZOOM_TO_PAGE_LEVEL);
            if (availableZoomLevels.Contains(100))
                zoomValues.Add(ACTUAL_SIZE);
            cmbxZoomValues.DataSource = zoomValues;

            if ((float)Math.Round(_callingPdfViewer.FitToPageZoomValue * 100, 2) == _callingPdfViewer.ZoomValue)                
                _currentValue = ZOOM_TO_PAGE_LEVEL;
            else if (_callingPdfViewer.ZoomValue == 100)
                _currentValue = ACTUAL_SIZE;

            if (string.IsNullOrEmpty(_currentValue))
                _currentValue = _callingPdfViewer.ZoomValue + "%";

            int currentValueIndex = zoomValues.IndexOf(_currentValue);
            if (currentValueIndex > -1)
                cmbxZoomValues.SelectedIndex = currentValueIndex;
            else
            {
                cmbxZoomValues.SelectedIndex = -1;
                cmbxZoomValues.SelectedText = _currentValue;
            }

            cmbxZoomValues.SelectAll();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            ChangeZoomAndCloseForm();
        }

        private void ChangeZoomAndCloseForm()
        {
            string selectedZoomValue = cmbxZoomValues.Text;
            if (selectedZoomValue.Equals(_currentValue))
            { // nothing changes, do nothing
                Close();
                return;
            }

            if (selectedZoomValue.Equals(ZOOM_TO_PAGE_LEVEL))
            {
                _callingPdfViewer.ZoomValue = (float)Math.Round(_callingPdfViewer.FitToPageZoomValue * 100, 2);               
                Close();
                return;
            }

            if (selectedZoomValue.Equals(ACTUAL_SIZE))
            {
                _callingPdfViewer.ZoomValue = 100;                
                Close();
                return;
            }

            float zoomLevel = 0;
            try
            {
                if (selectedZoomValue.EndsWith("%"))
                    selectedZoomValue = selectedZoomValue.Remove(selectedZoomValue.Length - 1);
                zoomLevel = float.Parse(selectedZoomValue);                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Zoom value isn't valid.", "Invalid zoom value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (zoomLevel < _callingPdfViewer.GetMinZoomLevel() || zoomLevel > _callingPdfViewer.GetMaxZoomLevel())
            {
                MessageBox.Show(string.Format("Zoom value must be within range {0} and {1}", _callingPdfViewer.GetMinZoomLevel(), _callingPdfViewer.GetMaxZoomLevel()), "Invalid zoom value", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _callingPdfViewer.ZoomValue = zoomLevel;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void ZoomForm_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
                Close();

            if (e.KeyCode == Keys.Enter)
                ChangeZoomAndCloseForm();
        }

        private void ZoomForm_Shown(object sender, EventArgs e)
        {
            cmbxZoomValues.Focus();
        }
    }
}
