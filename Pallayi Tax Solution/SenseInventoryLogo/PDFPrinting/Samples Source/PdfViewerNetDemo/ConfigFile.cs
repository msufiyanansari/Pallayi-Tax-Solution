using PdfViewerNet;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace PdfViewerNetDemo
{
    public class ConfigFile
    {
        public class Constants
        {
            public const string COMPANY = "COMPANY";
            public const string PASSWORD = "PASSWORD";
            public const string IS_TOOLBAR_VISIBLE = "IS_TOOLBAR_VISIBLE";
            public const string TOOLBAR_OPEN_VISIBLE = "TOOLBAR_OPEN_VISIBLE";
            public const string TOOLBAR_PRINT_VISIBLE = "TOOLBAR_PRINT_VISIBLE";
            public const string TOOLBAR_TOOLTIP_VISIBLE = "TOOLBAR_TOOLTIP_VISIBLE";
            public const string TOOLBAR_PAGE_VIEW_TYPE_VISIBLE = "TOOLBAR_PAGE_VIEW_TYPE_VISIBLE";
            public const string TOOLBAR_ROTATE_VISIBLE = "TOOLBAR_ROTATE_VISIBLE";
            public const string TOOLBAR_VISITED_PAGES_VISIBLE = "TOOLBAR_VISITED_PAGES_VISIBLE";
            public const string TOOLBAR_BOOKMARK_VISIBLE = "TOOLBAR_BOOKMARK_VISIBLE";
            public const string TOOLBAR_ZOOM_VISIBLE = "TOOLBAR_ZOOM_VISIBLE";
            public const string TOOLBAR_PAGE_VISIBLE = "TOOLBAR_PAGE_VISIBLE";
            public const string TOOLBAR_DOCUMENT_INFO_VISIBLE = "TOOLBAR_DOCUMENT_INFO_VISIBLE";
            public const string TOOLBAR_SEARCH_VISIBLE = "TOOLBAR_SEARCH_VISIBLE";
            public const string SHOW_BOOKMARK = "SHOW_BOOKMARK";
            public const string TOOLBAR_EMAIL_VISIBLE = "TOOLBAR_EMAIL_VISIBLE";
            public const string TOOLBAR_SAVE_VISIBLE = "TOOLBAR_SAVE_VISIBLE";
            public const string SELECTION_DISABLED = "SELECTION_DISABLED";
            public const string PAGE_VIEW_TYPE = "PAGE_VIEW_TYPE";
            public const string DISABLE_PARENT_SHORTCUTS = "DISABLE_PARENT_SHORTCUTS";
            public const string DISABLE_PDFVIEWER_SHORTCUTS = "DISABLE_PDFVIEWER_SHORTCUTS";
            public const string DISABLE_PRINTING = "DISABLE_PRINTING";
            public const string ON = "1";
            public const string OFF = "0";
        }
        
        private string GetConfigFileLocation()
        {
            return Path.GetDirectoryName(System.Reflection.Assembly.GetEntryAssembly().Location) + "\\pdfviewernetdemo.ini";
        }

        private void ReadConfigFromIni()
        {
            string configFileLocation = GetConfigFileLocation();
            if (!File.Exists(configFileLocation))
                return;

            var lines = File.ReadAllLines(configFileLocation);
            foreach (var line in lines)
            {
                string configLine = line.ToUpper();
                if (configLine.StartsWith(Constants.COMPANY + "="))
                    Company = line.Replace(Constants.COMPANY + "=", "");
                if (configLine.StartsWith(Constants.PASSWORD + "="))
                    Password = line.Replace(Constants.PASSWORD + "=", "");
                string value = "";
                if (configLine.StartsWith(Constants.IS_TOOLBAR_VISIBLE + "="))
                {
                    value = configLine.Replace(Constants.IS_TOOLBAR_VISIBLE + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        IsToolbarVisible = true;
                    if (value.Equals(Constants.OFF))
                        IsToolbarVisible = false;
                }

                if (configLine.StartsWith(Constants.TOOLBAR_TOOLTIP_VISIBLE + "="))
                {
                    value = configLine.Replace(Constants.TOOLBAR_TOOLTIP_VISIBLE + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        ToolbarTooltipVisible = true;
                    if (value.Equals(Constants.OFF))
                        ToolbarTooltipVisible = false;
                }                
                if (configLine.StartsWith(Constants.TOOLBAR_OPEN_VISIBLE + "="))
                {
                    value = configLine.Replace(Constants.TOOLBAR_OPEN_VISIBLE + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        ToolbarOpenVisible = true;
                    if (value.Equals(Constants.OFF))
                        ToolbarOpenVisible = false;
                }

                if (configLine.StartsWith(Constants.SELECTION_DISABLED + "="))
                {
                    value = configLine.Replace(Constants.SELECTION_DISABLED + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        SelectionDisabled = true;
                    if (value.Equals(Constants.OFF))
                        SelectionDisabled = false;
                }

                if (configLine.StartsWith(Constants.TOOLBAR_PRINT_VISIBLE + "="))
                {
                    value = configLine.Replace(Constants.TOOLBAR_PRINT_VISIBLE + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        ToolbarPrintVisible = true;
                    if (value.Equals(Constants.OFF))
                        ToolbarPrintVisible = false;
                }

                if (configLine.StartsWith(Constants.TOOLBAR_SAVE_VISIBLE + "="))
                {
                    value = configLine.Replace(Constants.TOOLBAR_SAVE_VISIBLE + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        ToolbarSaveVisible = true;
                    if (value.Equals(Constants.OFF))
                        ToolbarSaveVisible = false;
                }

                if (configLine.StartsWith(Constants.TOOLBAR_EMAIL_VISIBLE + "="))
                {
                    value = configLine.Replace(Constants.TOOLBAR_EMAIL_VISIBLE + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        ToolbarEmailVisible = true;
                    if (value.Equals(Constants.OFF))
                        ToolbarEmailVisible = false;
                }

                if (configLine.StartsWith(Constants.TOOLBAR_PAGE_VIEW_TYPE_VISIBLE + "="))
                {
                    value = configLine.Replace(Constants.TOOLBAR_PAGE_VIEW_TYPE_VISIBLE + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        ToolbarPageViewTypeVisible = true;
                    if (value.Equals(Constants.OFF))
                        ToolbarPageViewTypeVisible = false;
                }

                if (configLine.StartsWith(Constants.TOOLBAR_ROTATE_VISIBLE + "="))
                {
                    value = configLine.Replace(Constants.TOOLBAR_ROTATE_VISIBLE + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        ToolbarRotateVisible = true;
                    if (value.Equals(Constants.OFF))
                        ToolbarRotateVisible = false;
                }

                if (configLine.StartsWith(Constants.TOOLBAR_VISITED_PAGES_VISIBLE + "="))
                {
                    value = configLine.Replace(Constants.TOOLBAR_VISITED_PAGES_VISIBLE + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        ToolbarVisitedPagesVisible = true;
                    if (value.Equals(Constants.OFF))
                        ToolbarVisitedPagesVisible = false;
                }

                if (configLine.StartsWith(Constants.TOOLBAR_BOOKMARK_VISIBLE + "="))
                {
                    value = configLine.Replace(Constants.TOOLBAR_BOOKMARK_VISIBLE + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        ToolbarBookmarkVisible = true;
                    if (value.Equals(Constants.OFF))
                        ToolbarBookmarkVisible = false;
                 }

                if (configLine.StartsWith(Constants.TOOLBAR_ZOOM_VISIBLE + "="))
                {
                    value = configLine.Replace(Constants.TOOLBAR_ZOOM_VISIBLE + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        ToolbarZoomVisible = true;
                    if (value.Equals(Constants.OFF))
                        ToolbarZoomVisible = false;
                }

                if (configLine.StartsWith(Constants.TOOLBAR_PAGE_VISIBLE + "="))
                {
                    value = configLine.Replace(Constants.TOOLBAR_PAGE_VISIBLE + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        ToolbarPageVisible = true;
                    if (value.Equals(Constants.OFF))
                        ToolbarPageVisible = false;
                }

                if (configLine.StartsWith(Constants.TOOLBAR_DOCUMENT_INFO_VISIBLE + "="))
                {
                    value = configLine.Replace(Constants.TOOLBAR_DOCUMENT_INFO_VISIBLE + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        ToolbarDocumentInfoVisible = true;
                    if (value.Equals(Constants.OFF))
                        ToolbarDocumentInfoVisible = false;
                }

                if (configLine.StartsWith(Constants.TOOLBAR_SEARCH_VISIBLE + "="))
                {
                    value = configLine.Replace(Constants.TOOLBAR_SEARCH_VISIBLE + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        ToolbarSearchVisible = true;
                    if (value.Equals(Constants.OFF))
                        ToolbarSearchVisible = false;
                }

                if (configLine.StartsWith(Constants.SHOW_BOOKMARK + "="))
                {
                    value = configLine.Replace(Constants.SHOW_BOOKMARK + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        ShowBookmark = true;
                    if (value.Equals(Constants.OFF))
                        ShowBookmark = false;
                }

                if (configLine.StartsWith(Constants.PAGE_VIEW_TYPE + "="))
                {
                    value = configLine.Replace(Constants.PAGE_VIEW_TYPE + "=", "").Trim().ToUpper();
                    if (value.Equals("SINGLE"))
                        ViewType = PageViewType.Single;
                    if (value.Equals("CONTINUOUS"))
                        ViewType = PageViewType.Continuous;                    
                }

                if (configLine.StartsWith(Constants.DISABLE_PARENT_SHORTCUTS + "="))
                {
                    value = configLine.Replace(Constants.DISABLE_PARENT_SHORTCUTS + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        DisableParentShortcuts = true;
                    if (value.Equals(Constants.OFF))
                        DisableParentShortcuts = false;
                }

                if (configLine.StartsWith(Constants.DISABLE_PDFVIEWER_SHORTCUTS + "="))
                {
                    value = configLine.Replace(Constants.DISABLE_PDFVIEWER_SHORTCUTS + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        DisablePdfViewerShortcuts = true;
                    if (value.Equals(Constants.OFF))
                        DisablePdfViewerShortcuts = false;
                }

                if (configLine.StartsWith(Constants.DISABLE_PRINTING + "="))
                {
                    value = configLine.Replace(Constants.DISABLE_PRINTING + "=", "").Trim();
                    if (value.Equals(Constants.ON))
                        DisablePrinting = true;
                    if (value.Equals(Constants.OFF))
                        DisablePrinting = false;
                }
            }
        }
    
        private string GetConfigLine(string property, bool value)
        {
            return property + "=" + (value ? Constants.ON : Constants.OFF) + Environment.NewLine;
        }

        public void SaveConfig()
        {
            string configFileLocation = GetConfigFileLocation();
            SetDefaultValues(_pdfViewer);
            File.WriteAllText (configFileLocation, Constants.COMPANY + "=" + Company + Environment.NewLine);
            File.AppendAllText(configFileLocation, Constants.PASSWORD + "=" + Password + Environment.NewLine);
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.IS_TOOLBAR_VISIBLE, IsToolbarVisible));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.TOOLBAR_OPEN_VISIBLE, ToolbarOpenVisible));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.TOOLBAR_PRINT_VISIBLE, ToolbarPrintVisible));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.TOOLBAR_ZOOM_VISIBLE, ToolbarZoomVisible));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.TOOLBAR_PAGE_VIEW_TYPE_VISIBLE, ToolbarPageViewTypeVisible));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.TOOLBAR_PAGE_VISIBLE, ToolbarPageVisible));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.TOOLBAR_TOOLTIP_VISIBLE, ToolbarTooltipVisible));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.TOOLBAR_ROTATE_VISIBLE, ToolbarRotateVisible));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.TOOLBAR_VISITED_PAGES_VISIBLE, ToolbarVisitedPagesVisible));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.TOOLBAR_BOOKMARK_VISIBLE, ToolbarBookmarkVisible));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.TOOLBAR_DOCUMENT_INFO_VISIBLE, ToolbarDocumentInfoVisible));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.TOOLBAR_EMAIL_VISIBLE, ToolbarEmailVisible));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.TOOLBAR_SAVE_VISIBLE, ToolbarSaveVisible));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.TOOLBAR_SEARCH_VISIBLE, ToolbarSearchVisible));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.SHOW_BOOKMARK, ShowBookmark));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.SELECTION_DISABLED, SelectionDisabled));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.DISABLE_PARENT_SHORTCUTS, DisableParentShortcuts));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.DISABLE_PDFVIEWER_SHORTCUTS, DisablePdfViewerShortcuts));
            File.AppendAllText(configFileLocation, GetConfigLine(Constants.DISABLE_PRINTING, DisablePrinting));

            if (ViewType == PageViewType.Single) // TODO If None?
                File.AppendAllText(configFileLocation, Constants.PAGE_VIEW_TYPE + "=" + "Single" + Environment.NewLine);
            if (ViewType == PageViewType.Continuous)
                File.AppendAllText(configFileLocation, Constants.PAGE_VIEW_TYPE + "=" + "Continuous" + Environment.NewLine);
        }

        public string Company { get; set; }
        public string Password { get; set; }

        public bool IsToolbarVisible { get; set; }
        public bool ToolbarOpenVisible { get; set; }
        public bool SelectionDisabled { get; set; }
        public bool ToolbarZoomVisible { get; set; }
        public bool ToolbarPrintVisible { get; set; }
        public bool ToolbarSaveVisible { get; set; }
        public bool ToolbarEmailVisible { get; set; }
        public bool ToolbarPageViewTypeVisible { get; set; }
        public bool ToolbarPageVisible { get; set; }
        public bool ToolbarTooltipVisible { get; set; }
        public bool ToolbarRotateVisible { get; set; }
        public bool ToolbarVisitedPagesVisible { get; set; }
        public bool ToolbarBookmarkVisible { get; set; }
        public bool ToolbarDocumentInfoVisible { get; set; }
        public bool ToolbarSearchVisible { get; set; }

        public bool DisableParentShortcuts { get; set; }
        public bool DisablePdfViewerShortcuts { get; set; }
        public bool DisablePrinting { get; set; }

        public bool ShowBookmark { get; set; } 
        public PageViewType ViewType { get; set; }

        private PdfViewer _pdfViewer;

        private void SetDefaultValues(PdfViewer pdfViewer)
        {
            IsToolbarVisible = pdfViewer.IsToolbarVisible;
            ToolbarBookmarkVisible = pdfViewer.ToolbarBookmarkVisible;
            ToolbarOpenVisible = pdfViewer.ToolbarOpenVisible;
            ToolbarZoomVisible = pdfViewer.ToolbarZoomVisible;
            ToolbarPrintVisible = pdfViewer.ToolbarPrintVisible;
            ToolbarPageViewTypeVisible = pdfViewer.ToolbarPageViewTypeVisible;
            ToolbarPageVisible = pdfViewer.ToolbarPageVisible;
            ToolbarPrintVisible = pdfViewer.ToolbarPrintVisible;
            ToolbarRotateVisible = pdfViewer.ToolbarRotateVisible;
            ToolbarSearchVisible = pdfViewer.ToolbarSearchVisible;
            ToolbarSaveVisible = pdfViewer.ToolbarSaveVisible;
            ToolbarEmailVisible = pdfViewer.ToolbarEmailVisible;
            ToolbarVisitedPagesVisible = pdfViewer.ToolbarVisitedPagesVisible;
            ToolbarZoomVisible = pdfViewer.ToolbarZoomVisible;
            ToolbarDocumentInfoVisible = pdfViewer.ToolbarDocumentInfoVisible;
            ShowBookmark = pdfViewer.ShowBookmarks;
            ViewType = pdfViewer.ViewType;
            SelectionDisabled = pdfViewer.SelectionDisabled;
            ToolbarTooltipVisible = pdfViewer.ToolbarTooltipVisible;
            DisableParentShortcuts = pdfViewer.DisableParentShortcuts;
            DisablePdfViewerShortcuts = pdfViewer.DisablePdfViewerShortcuts;
            DisablePrinting = pdfViewer.DisablePrinting;
        }

        public ConfigFile(PdfViewer pdfViewer)
        {
            Company = "";
            Password = "";
            _pdfViewer = pdfViewer;
            SetDefaultValues(pdfViewer);
            ReadConfigFromIni();
        }
    }    
}
