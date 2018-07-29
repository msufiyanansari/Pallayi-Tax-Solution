namespace PdfViewerNetDemo
{
    partial class PdfViewerNetForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PdfViewerNetForm));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemOpenFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuItemCloseDocument = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemDocumentInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.bookmarksToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.menuItemPrint = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.selectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.deselectAllToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.copyToClipboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.findToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pageRotationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.clockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.counterClockwiseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.navigationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.firstPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lastPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.previousPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.gotoPageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.previousViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.nextViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.pageDisplayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.continuousViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.singlePageViewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.actualSizeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.zoomToPageLevelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pdfViewer1 = new PdfViewerNet.PdfViewer();
            this.sendAsEmailToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.toolStripMenuItem2});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(1671, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "File";
            this.menuStrip1.MenuActivate += new System.EventHandler(this.menuStrip1_MenuActivate);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuItemOpenFile,
            this.saveToolStripMenuItem,
            this.menuItemCloseDocument,
            this.toolStripSeparator3,
            this.menuItemDocumentInfo,
            this.bookmarksToolStripMenuItem,
            this.toolStripSeparator4,
            this.menuItemPrint,
            this.sendAsEmailToolStripMenuItem,
            this.toolStripSeparator5,
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(37, 20);
            this.toolStripMenuItem1.Text = "&File";
            // 
            // menuItemOpenFile
            // 
            this.menuItemOpenFile.Name = "menuItemOpenFile";
            this.menuItemOpenFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.menuItemOpenFile.Size = new System.Drawing.Size(196, 22);
            this.menuItemOpenFile.Text = "&Open";
            this.menuItemOpenFile.Click += new System.EventHandler(this.menuItemOpenFile_Click);
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.saveToolStripMenuItem.Text = "&Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // menuItemCloseDocument
            // 
            this.menuItemCloseDocument.Name = "menuItemCloseDocument";
            this.menuItemCloseDocument.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.menuItemCloseDocument.Size = new System.Drawing.Size(196, 22);
            this.menuItemCloseDocument.Text = "&Close";
            this.menuItemCloseDocument.Click += new System.EventHandler(this.menuItemCloseDocument_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(193, 6);
            // 
            // menuItemDocumentInfo
            // 
            this.menuItemDocumentInfo.Name = "menuItemDocumentInfo";
            this.menuItemDocumentInfo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.menuItemDocumentInfo.Size = new System.Drawing.Size(196, 22);
            this.menuItemDocumentInfo.Text = "&Document Info";
            this.menuItemDocumentInfo.Click += new System.EventHandler(this.menuItemDocumentInfo_Click);
            // 
            // bookmarksToolStripMenuItem
            // 
            this.bookmarksToolStripMenuItem.Name = "bookmarksToolStripMenuItem";
            this.bookmarksToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
            this.bookmarksToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.bookmarksToolStripMenuItem.Text = "&Bookmarks";
            this.bookmarksToolStripMenuItem.Click += new System.EventHandler(this.bookmarksToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(193, 6);
            // 
            // menuItemPrint
            // 
            this.menuItemPrint.Name = "menuItemPrint";
            this.menuItemPrint.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.menuItemPrint.Size = new System.Drawing.Size(196, 22);
            this.menuItemPrint.Text = "&Print";
            this.menuItemPrint.Click += new System.EventHandler(this.menuItemPrint_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(193, 6);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.exitToolStripMenuItem.Text = "E&xit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // editToolStripMenuItem
            // 
            this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.selectAllToolStripMenuItem,
            this.deselectAllToolStripMenuItem,
            this.copyToClipboardToolStripMenuItem,
            this.findToolStripMenuItem});
            this.editToolStripMenuItem.Name = "editToolStripMenuItem";
            this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
            this.editToolStripMenuItem.Text = "&Edit";
            // 
            // selectAllToolStripMenuItem
            // 
            this.selectAllToolStripMenuItem.Name = "selectAllToolStripMenuItem";
            this.selectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.selectAllToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.selectAllToolStripMenuItem.Text = "Se&lect All Text";
            this.selectAllToolStripMenuItem.Click += new System.EventHandler(this.selectAllToolStripMenuItem_Click);
            // 
            // deselectAllToolStripMenuItem
            // 
            this.deselectAllToolStripMenuItem.Name = "deselectAllToolStripMenuItem";
            this.deselectAllToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.A)));
            this.deselectAllToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.deselectAllToolStripMenuItem.Text = "D&eselect All Text";
            this.deselectAllToolStripMenuItem.Click += new System.EventHandler(this.deselectAllToolStripMenuItem_Click);
            // 
            // copyToClipboardToolStripMenuItem
            // 
            this.copyToClipboardToolStripMenuItem.Name = "copyToClipboardToolStripMenuItem";
            this.copyToClipboardToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.copyToClipboardToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.copyToClipboardToolStripMenuItem.Text = "&Copy";
            this.copyToClipboardToolStripMenuItem.Click += new System.EventHandler(this.copyToClipboardToolStripMenuItem_Click);
            // 
            // findToolStripMenuItem
            // 
            this.findToolStripMenuItem.Name = "findToolStripMenuItem";
            this.findToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
            this.findToolStripMenuItem.Size = new System.Drawing.Size(233, 22);
            this.findToolStripMenuItem.Text = "&Find";
            this.findToolStripMenuItem.Click += new System.EventHandler(this.findToolStripMenuItem_Click);
            // 
            // viewToolStripMenuItem
            // 
            this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.pageRotationToolStripMenuItem,
            this.navigationToolStripMenuItem,
            this.toolStripSeparator2,
            this.pageDisplayToolStripMenuItem,
            this.zoomToolStripMenuItem});
            this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
            this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.viewToolStripMenuItem.Text = "&View";
            // 
            // pageRotationToolStripMenuItem
            // 
            this.pageRotationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.clockwiseToolStripMenuItem,
            this.counterClockwiseToolStripMenuItem});
            this.pageRotationToolStripMenuItem.Name = "pageRotationToolStripMenuItem";
            this.pageRotationToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pageRotationToolStripMenuItem.Text = "Rotate &View";
            // 
            // clockwiseToolStripMenuItem
            // 
            this.clockwiseToolStripMenuItem.Name = "clockwiseToolStripMenuItem";
            this.clockwiseToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+Plus";
            this.clockwiseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Add)));
            this.clockwiseToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.clockwiseToolStripMenuItem.Text = "&Clockwise";
            this.clockwiseToolStripMenuItem.Click += new System.EventHandler(this.clockwiseToolStripMenuItem_Click);
            // 
            // counterClockwiseToolStripMenuItem
            // 
            this.counterClockwiseToolStripMenuItem.Name = "counterClockwiseToolStripMenuItem";
            this.counterClockwiseToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Shift+Minus";
            this.counterClockwiseToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Subtract)));
            this.counterClockwiseToolStripMenuItem.Size = new System.Drawing.Size(267, 22);
            this.counterClockwiseToolStripMenuItem.Text = "Counterclock&wise";
            this.counterClockwiseToolStripMenuItem.Click += new System.EventHandler(this.counterClockwiseToolStripMenuItem_Click);
            // 
            // navigationToolStripMenuItem
            // 
            this.navigationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.firstPageToolStripMenuItem,
            this.lastPageToolStripMenuItem,
            this.nextPageToolStripMenuItem,
            this.previousPageToolStripMenuItem,
            this.gotoPageToolStripMenuItem,
            this.toolStripSeparator1,
            this.previousViewToolStripMenuItem,
            this.nextViewToolStripMenuItem});
            this.navigationToolStripMenuItem.Name = "navigationToolStripMenuItem";
            this.navigationToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.navigationToolStripMenuItem.Text = "Page &Navigation";
            // 
            // firstPageToolStripMenuItem
            // 
            this.firstPageToolStripMenuItem.Name = "firstPageToolStripMenuItem";
            this.firstPageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Home)));
            this.firstPageToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.firstPageToolStripMenuItem.Text = "&First Page";
            this.firstPageToolStripMenuItem.Click += new System.EventHandler(this.firstPageToolStripMenuItem_Click);
            // 
            // lastPageToolStripMenuItem
            // 
            this.lastPageToolStripMenuItem.Name = "lastPageToolStripMenuItem";
            this.lastPageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.lastPageToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.lastPageToolStripMenuItem.Text = "&Last Page";
            this.lastPageToolStripMenuItem.Click += new System.EventHandler(this.lastPageToolStripMenuItem_Click);
            // 
            // nextPageToolStripMenuItem
            // 
            this.nextPageToolStripMenuItem.Name = "nextPageToolStripMenuItem";
            this.nextPageToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl+Right Arrow";
            this.nextPageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Right)));
            this.nextPageToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.nextPageToolStripMenuItem.Text = "&Next Page";
            this.nextPageToolStripMenuItem.Click += new System.EventHandler(this.nextPageToolStripMenuItem_Click);
            // 
            // previousPageToolStripMenuItem
            // 
            this.previousPageToolStripMenuItem.Name = "previousPageToolStripMenuItem";
            this.previousPageToolStripMenuItem.ShortcutKeyDisplayString = "Ctrl + Left Arrow";
            this.previousPageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Left)));
            this.previousPageToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.previousPageToolStripMenuItem.Text = "Pr&evious Page";
            this.previousPageToolStripMenuItem.Click += new System.EventHandler(this.previousPageToolStripMenuItem_Click);
            // 
            // gotoPageToolStripMenuItem
            // 
            this.gotoPageToolStripMenuItem.Name = "gotoPageToolStripMenuItem";
            this.gotoPageToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.gotoPageToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.gotoPageToolStripMenuItem.Text = "&Goto Page";
            this.gotoPageToolStripMenuItem.Click += new System.EventHandler(this.gotoPageToolStripMenuItem_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(240, 6);
            // 
            // previousViewToolStripMenuItem
            // 
            this.previousViewToolStripMenuItem.Name = "previousViewToolStripMenuItem";
            this.previousViewToolStripMenuItem.ShortcutKeyDisplayString = "Alt + Left Arrow";
            this.previousViewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Left)));
            this.previousViewToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.previousViewToolStripMenuItem.Text = "Previous &View";
            this.previousViewToolStripMenuItem.Click += new System.EventHandler(this.previousViewToolStripMenuItem_Click);
            // 
            // nextViewToolStripMenuItem
            // 
            this.nextViewToolStripMenuItem.Name = "nextViewToolStripMenuItem";
            this.nextViewToolStripMenuItem.ShortcutKeyDisplayString = "Alt + Right Arrow";
            this.nextViewToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.Right)));
            this.nextViewToolStripMenuItem.Size = new System.Drawing.Size(243, 22);
            this.nextViewToolStripMenuItem.Text = "Next Vie&w";
            this.nextViewToolStripMenuItem.Click += new System.EventHandler(this.nextViewToolStripMenuItem_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(158, 6);
            // 
            // pageDisplayToolStripMenuItem
            // 
            this.pageDisplayToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.continuousViewToolStripMenuItem,
            this.singlePageViewToolStripMenuItem});
            this.pageDisplayToolStripMenuItem.Name = "pageDisplayToolStripMenuItem";
            this.pageDisplayToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.pageDisplayToolStripMenuItem.Text = "&Page Display";
            // 
            // continuousViewToolStripMenuItem
            // 
            this.continuousViewToolStripMenuItem.Name = "continuousViewToolStripMenuItem";
            this.continuousViewToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.continuousViewToolStripMenuItem.Text = "&Continuosly Pages View";
            this.continuousViewToolStripMenuItem.Click += new System.EventHandler(this.continuousViewToolStripMenuItem_Click);
            // 
            // singlePageViewToolStripMenuItem
            // 
            this.singlePageViewToolStripMenuItem.Name = "singlePageViewToolStripMenuItem";
            this.singlePageViewToolStripMenuItem.Size = new System.Drawing.Size(200, 22);
            this.singlePageViewToolStripMenuItem.Text = "&Single Page View";
            this.singlePageViewToolStripMenuItem.Click += new System.EventHandler(this.singlePageViewToolStripMenuItem_Click);
            // 
            // zoomToolStripMenuItem
            // 
            this.zoomToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.zoomToToolStripMenuItem,
            this.actualSizeToolStripMenuItem,
            this.zoomToPageLevelToolStripMenuItem});
            this.zoomToolStripMenuItem.Name = "zoomToolStripMenuItem";
            this.zoomToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.zoomToolStripMenuItem.Text = "&Zoom";
            // 
            // zoomToToolStripMenuItem
            // 
            this.zoomToToolStripMenuItem.Name = "zoomToToolStripMenuItem";
            this.zoomToToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.zoomToToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.zoomToToolStripMenuItem.Text = "&Zoom To...";
            this.zoomToToolStripMenuItem.Click += new System.EventHandler(this.zoomToToolStripMenuItem_Click);
            // 
            // actualSizeToolStripMenuItem
            // 
            this.actualSizeToolStripMenuItem.Name = "actualSizeToolStripMenuItem";
            this.actualSizeToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D1)));
            this.actualSizeToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.actualSizeToolStripMenuItem.Text = "Act&ual Size";
            this.actualSizeToolStripMenuItem.Click += new System.EventHandler(this.actualSizeToolStripMenuItem_Click);
            // 
            // zoomToPageLevelToolStripMenuItem
            // 
            this.zoomToPageLevelToolStripMenuItem.Name = "zoomToPageLevelToolStripMenuItem";
            this.zoomToPageLevelToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D0)));
            this.zoomToPageLevelToolStripMenuItem.Size = new System.Drawing.Size(223, 22);
            this.zoomToPageLevelToolStripMenuItem.Text = "Zoom To Fit To &Page";
            this.zoomToPageLevelToolStripMenuItem.Click += new System.EventHandler(this.zoomToPageLevelToolStripMenuItem_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem,
            this.optionsToolStripMenuItem});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(44, 20);
            this.toolStripMenuItem2.Text = "&Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.aboutToolStripMenuItem.Text = "&About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(116, 22);
            this.optionsToolStripMenuItem.Text = "&Options";
            this.optionsToolStripMenuItem.Click += new System.EventHandler(this.optionsToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.panel1.Location = new System.Drawing.Point(0, 30);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1671, 1);
            this.panel1.TabIndex = 3;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.AllowDrop = true;
            this.pdfViewer1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pdfViewer1.BackgroundColor = System.Drawing.SystemColors.Control;
            this.pdfViewer1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pdfViewer1.IsCalledFromWPF = false;
            this.pdfViewer1.IsToolbarVisible = true;
            this.pdfViewer1.Location = new System.Drawing.Point(2, 27);
            this.pdfViewer1.Margin = new System.Windows.Forms.Padding(5);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.pdfViewer1.SelectionDisabled = true;
            this.pdfViewer1.ShowBookmarks = false;
            this.pdfViewer1.Size = new System.Drawing.Size(1668, 759);
            this.pdfViewer1.TabIndex = 0;
            this.pdfViewer1.ToolbarBackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.pdfViewer1.ToolbarBookmarkVisible = true;
            this.pdfViewer1.ToolbarDocumentInfoVisible = true;
            this.pdfViewer1.ToolbarEmailVisible = true;
            this.pdfViewer1.ToolbarOpenVisible = true;
            this.pdfViewer1.ToolbarPageViewTypeVisible = true;
            this.pdfViewer1.ToolbarPageVisible = true;
            this.pdfViewer1.ToolbarPrintVisible = true;
            this.pdfViewer1.ToolbarRotateVisible = true;
            this.pdfViewer1.ToolbarSaveVisible = true;
            this.pdfViewer1.ToolbarSearchVisible = true;
            this.pdfViewer1.ToolbarTooltipVisible = false;
            this.pdfViewer1.ToolbarVisitedPagesVisible = true;
            this.pdfViewer1.ToolbarZoomVisible = true;
            this.pdfViewer1.ViewType = PdfViewerNet.PageViewType.Continuous;
            this.pdfViewer1.ZoomValue = 100F;
            // 
            // sendAsEmailToolStripMenuItem
            // 
            this.sendAsEmailToolStripMenuItem.Name = "sendAsEmailToolStripMenuItem";
            this.sendAsEmailToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
            this.sendAsEmailToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.sendAsEmailToolStripMenuItem.Text = "Send as Emai&l";
            this.sendAsEmailToolStripMenuItem.Click += new System.EventHandler(this.sendAsEmailToolStripMenuItem_Click);
            // 
            // PdfViewerNetForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1671, 788);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.pdfViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "PdfViewerNetForm";
            this.Text = "Terminal Works PDF Viewer";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.PdfViewerNetForm_FormClosing);
            this.Load += new System.EventHandler(this.PdfViewerNetForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PdfViewerNet.PdfViewer pdfViewer1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem menuItemOpenFile;
        private System.Windows.Forms.ToolStripMenuItem menuItemCloseDocument;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem menuItemDocumentInfo;
        private System.Windows.Forms.ToolStripMenuItem bookmarksToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem menuItemPrint;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem editToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem selectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem deselectAllToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem copyToClipboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem findToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem pageRotationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem clockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem counterClockwiseToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem navigationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem firstPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem lastPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem previousPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem gotoPageToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem previousViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem nextViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem pageDisplayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem continuousViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem singlePageViewToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem actualSizeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem zoomToPageLevelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sendAsEmailToolStripMenuItem;
    }
}

