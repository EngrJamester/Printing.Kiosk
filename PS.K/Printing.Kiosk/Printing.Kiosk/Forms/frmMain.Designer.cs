namespace Printing.Kiosk
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.pbAdmin = new System.Windows.Forms.PictureBox();
            this.pnlPaper = new System.Windows.Forms.Panel();
            this.btnHelp = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnPrintDocument = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblDateTime = new System.Windows.Forms.Label();
            this.lblUsbStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnWirelessTransfer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFlashDrive = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pdfViewer1 = new PdfViewerNet.PdfViewer();
            this.backgroundWorker = new System.ComponentModel.BackgroundWorker();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).BeginInit();
            this.pnlPaper.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.pbAdmin);
            this.panel1.Controls.Add(this.pnlPaper);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1816, 1007);
            this.panel1.TabIndex = 0;
            // 
            // pbAdmin
            // 
            this.pbAdmin.BackColor = System.Drawing.Color.Transparent;
            this.pbAdmin.Image = ((System.Drawing.Image)(resources.GetObject("pbAdmin.Image")));
            this.pbAdmin.Location = new System.Drawing.Point(1702, 3);
            this.pbAdmin.Name = "pbAdmin";
            this.pbAdmin.Size = new System.Drawing.Size(102, 94);
            this.pbAdmin.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbAdmin.TabIndex = 11;
            this.pbAdmin.TabStop = false;
            this.pbAdmin.Click += new System.EventHandler(this.pbAdmin_Click);
            // 
            // pnlPaper
            // 
            this.pnlPaper.BackColor = System.Drawing.Color.Gray;
            this.pnlPaper.Controls.Add(this.btnHelp);
            this.pnlPaper.Controls.Add(this.btnPrintDocument);
            this.pnlPaper.Location = new System.Drawing.Point(86, 588);
            this.pnlPaper.Name = "pnlPaper";
            this.pnlPaper.Size = new System.Drawing.Size(756, 360);
            this.pnlPaper.TabIndex = 8;
            // 
            // btnHelp
            // 
            this.btnHelp.Activecolor = System.Drawing.Color.Transparent;
            this.btnHelp.BackColor = System.Drawing.Color.DimGray;
            this.btnHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnHelp.BorderRadius = 0;
            this.btnHelp.ButtonText = "Help Section";
            this.btnHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHelp.DisabledColor = System.Drawing.Color.Gray;
            this.btnHelp.ForeColor = System.Drawing.Color.DimGray;
            this.btnHelp.Iconcolor = System.Drawing.Color.Transparent;
            this.btnHelp.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnHelp.Iconimage")));
            this.btnHelp.Iconimage_right = null;
            this.btnHelp.Iconimage_right_Selected = null;
            this.btnHelp.Iconimage_Selected = null;
            this.btnHelp.IconMarginLeft = 0;
            this.btnHelp.IconMarginRight = 0;
            this.btnHelp.IconRightVisible = true;
            this.btnHelp.IconRightZoom = 0D;
            this.btnHelp.IconVisible = true;
            this.btnHelp.IconZoom = 80D;
            this.btnHelp.IsTab = false;
            this.btnHelp.Location = new System.Drawing.Point(147, 43);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(6);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Normalcolor = System.Drawing.Color.DimGray;
            this.btnHelp.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnHelp.OnHoverTextColor = System.Drawing.Color.Gold;
            this.btnHelp.selected = false;
            this.btnHelp.Size = new System.Drawing.Size(463, 105);
            this.btnHelp.TabIndex = 8;
            this.btnHelp.Text = "Help Section";
            this.btnHelp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnHelp.Textcolor = System.Drawing.Color.White;
            this.btnHelp.TextFont = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btnPrintDocument
            // 
            this.btnPrintDocument.Activecolor = System.Drawing.Color.Transparent;
            this.btnPrintDocument.BackColor = System.Drawing.Color.DimGray;
            this.btnPrintDocument.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnPrintDocument.BorderRadius = 0;
            this.btnPrintDocument.ButtonText = "Print Document";
            this.btnPrintDocument.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintDocument.DisabledColor = System.Drawing.Color.Gray;
            this.btnPrintDocument.ForeColor = System.Drawing.Color.DimGray;
            this.btnPrintDocument.Iconcolor = System.Drawing.Color.Transparent;
            this.btnPrintDocument.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnPrintDocument.Iconimage")));
            this.btnPrintDocument.Iconimage_right = null;
            this.btnPrintDocument.Iconimage_right_Selected = null;
            this.btnPrintDocument.Iconimage_Selected = null;
            this.btnPrintDocument.IconMarginLeft = 0;
            this.btnPrintDocument.IconMarginRight = 0;
            this.btnPrintDocument.IconRightVisible = true;
            this.btnPrintDocument.IconRightZoom = 0D;
            this.btnPrintDocument.IconVisible = true;
            this.btnPrintDocument.IconZoom = 100D;
            this.btnPrintDocument.IsTab = false;
            this.btnPrintDocument.Location = new System.Drawing.Point(147, 190);
            this.btnPrintDocument.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrintDocument.Name = "btnPrintDocument";
            this.btnPrintDocument.Normalcolor = System.Drawing.Color.DimGray;
            this.btnPrintDocument.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnPrintDocument.OnHoverTextColor = System.Drawing.Color.Gold;
            this.btnPrintDocument.selected = false;
            this.btnPrintDocument.Size = new System.Drawing.Size(463, 105);
            this.btnPrintDocument.TabIndex = 7;
            this.btnPrintDocument.Text = "Print Document";
            this.btnPrintDocument.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnPrintDocument.Textcolor = System.Drawing.Color.White;
            this.btnPrintDocument.TextFont = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintDocument.Click += new System.EventHandler(this.btnPrintDocument_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(84, 133);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(648, 62);
            this.label3.TabIndex = 10;
            this.label3.Text = "To start of the transaction kindly choose the location \r\nof your file to be print" +
    "ed";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(67, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(517, 112);
            this.label2.TabIndex = 9;
            this.label2.Text = "WELCOME";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Black;
            this.panel4.Controls.Add(this.lblDateTime);
            this.panel4.Controls.Add(this.lblUsbStatus);
            this.panel4.Controls.Add(this.pictureBox1);
            this.panel4.Controls.Add(this.label1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.ForeColor = System.Drawing.Color.DimGray;
            this.panel4.Location = new System.Drawing.Point(0, 970);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(1816, 37);
            this.panel4.TabIndex = 8;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.BackColor = System.Drawing.Color.Transparent;
            this.lblDateTime.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDateTime.ForeColor = System.Drawing.Color.White;
            this.lblDateTime.Location = new System.Drawing.Point(1654, 10);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(90, 19);
            this.lblDateTime.TabIndex = 11;
            this.lblDateTime.Text = "Date & Time";
            // 
            // lblUsbStatus
            // 
            this.lblUsbStatus.AutoSize = true;
            this.lblUsbStatus.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsbStatus.Location = new System.Drawing.Point(133, 10);
            this.lblUsbStatus.Name = "lblUsbStatus";
            this.lblUsbStatus.Size = new System.Drawing.Size(121, 18);
            this.lblUsbStatus.TabIndex = 10;
            this.lblUsbStatus.Text = "Not Connected";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(43, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(52, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "USB Status:";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Controls.Add(this.btnWirelessTransfer);
            this.panel2.Controls.Add(this.btnFlashDrive);
            this.panel2.Location = new System.Drawing.Point(86, 213);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(756, 360);
            this.panel2.TabIndex = 7;
            // 
            // btnWirelessTransfer
            // 
            this.btnWirelessTransfer.Activecolor = System.Drawing.Color.Transparent;
            this.btnWirelessTransfer.BackColor = System.Drawing.Color.DimGray;
            this.btnWirelessTransfer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnWirelessTransfer.BorderRadius = 0;
            this.btnWirelessTransfer.ButtonText = "Wireless Transfer";
            this.btnWirelessTransfer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnWirelessTransfer.DisabledColor = System.Drawing.Color.Gray;
            this.btnWirelessTransfer.ForeColor = System.Drawing.Color.DimGray;
            this.btnWirelessTransfer.Iconcolor = System.Drawing.Color.Transparent;
            this.btnWirelessTransfer.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnWirelessTransfer.Iconimage")));
            this.btnWirelessTransfer.Iconimage_right = null;
            this.btnWirelessTransfer.Iconimage_right_Selected = null;
            this.btnWirelessTransfer.Iconimage_Selected = null;
            this.btnWirelessTransfer.IconMarginLeft = 0;
            this.btnWirelessTransfer.IconMarginRight = 0;
            this.btnWirelessTransfer.IconRightVisible = true;
            this.btnWirelessTransfer.IconRightZoom = 0D;
            this.btnWirelessTransfer.IconVisible = true;
            this.btnWirelessTransfer.IconZoom = 120D;
            this.btnWirelessTransfer.IsTab = false;
            this.btnWirelessTransfer.Location = new System.Drawing.Point(147, 199);
            this.btnWirelessTransfer.Margin = new System.Windows.Forms.Padding(6);
            this.btnWirelessTransfer.Name = "btnWirelessTransfer";
            this.btnWirelessTransfer.Normalcolor = System.Drawing.Color.DimGray;
            this.btnWirelessTransfer.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnWirelessTransfer.OnHoverTextColor = System.Drawing.Color.Gold;
            this.btnWirelessTransfer.selected = false;
            this.btnWirelessTransfer.Size = new System.Drawing.Size(463, 105);
            this.btnWirelessTransfer.TabIndex = 7;
            this.btnWirelessTransfer.Text = "Wireless Transfer";
            this.btnWirelessTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWirelessTransfer.Textcolor = System.Drawing.Color.White;
            this.btnWirelessTransfer.TextFont = new System.Drawing.Font("Century Gothic", 30F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWirelessTransfer.Click += new System.EventHandler(this.btnWirelessTransfer_Click);
            // 
            // btnFlashDrive
            // 
            this.btnFlashDrive.Activecolor = System.Drawing.Color.DimGray;
            this.btnFlashDrive.BackColor = System.Drawing.Color.DimGray;
            this.btnFlashDrive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFlashDrive.BorderRadius = 0;
            this.btnFlashDrive.ButtonText = "Flash Drive";
            this.btnFlashDrive.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFlashDrive.DisabledColor = System.Drawing.Color.Gray;
            this.btnFlashDrive.ForeColor = System.Drawing.Color.DimGray;
            this.btnFlashDrive.Iconcolor = System.Drawing.Color.Transparent;
            this.btnFlashDrive.Iconimage = ((System.Drawing.Image)(resources.GetObject("btnFlashDrive.Iconimage")));
            this.btnFlashDrive.Iconimage_right = null;
            this.btnFlashDrive.Iconimage_right_Selected = null;
            this.btnFlashDrive.Iconimage_Selected = null;
            this.btnFlashDrive.IconMarginLeft = 0;
            this.btnFlashDrive.IconMarginRight = 0;
            this.btnFlashDrive.IconRightVisible = true;
            this.btnFlashDrive.IconRightZoom = 0D;
            this.btnFlashDrive.IconVisible = true;
            this.btnFlashDrive.IconZoom = 90D;
            this.btnFlashDrive.IsTab = false;
            this.btnFlashDrive.Location = new System.Drawing.Point(147, 49);
            this.btnFlashDrive.Margin = new System.Windows.Forms.Padding(6);
            this.btnFlashDrive.Name = "btnFlashDrive";
            this.btnFlashDrive.Normalcolor = System.Drawing.Color.DimGray;
            this.btnFlashDrive.OnHovercolor = System.Drawing.Color.DimGray;
            this.btnFlashDrive.OnHoverTextColor = System.Drawing.Color.Gold;
            this.btnFlashDrive.selected = false;
            this.btnFlashDrive.Size = new System.Drawing.Size(463, 105);
            this.btnFlashDrive.TabIndex = 6;
            this.btnFlashDrive.Text = "Flash Drive";
            this.btnFlashDrive.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnFlashDrive.Textcolor = System.Drawing.Color.White;
            this.btnFlashDrive.TextFont = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFlashDrive.Click += new System.EventHandler(this.btnFlashDrive_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DimGray;
            this.panel3.Controls.Add(this.pdfViewer1);
            this.panel3.Location = new System.Drawing.Point(1054, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 866);
            this.panel3.TabIndex = 6;
            // 
            // pdfViewer1
            // 
            this.pdfViewer1.AllowDrop = true;
            this.pdfViewer1.AutoPageSize = false;
            this.pdfViewer1.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.pdfViewer1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(203)))), ((int)(((byte)(203)))));
            this.pdfViewer1.ContextMenuDisabled = false;
            this.pdfViewer1.DisableParentShortcuts = true;
            this.pdfViewer1.DisablePdfViewerShortcuts = false;
            this.pdfViewer1.DisablePrinting = false;
            this.pdfViewer1.InitialOpenDirectory = null;
            this.pdfViewer1.InitialOpenFileName = null;
            this.pdfViewer1.IsCalledFromWPF = false;
            this.pdfViewer1.IsPrintAutoRotate = false;
            this.pdfViewer1.IsPrintContentCentered = true;
            this.pdfViewer1.IsToolbarVisible = true;
            this.pdfViewer1.Location = new System.Drawing.Point(22, 15);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.OverridePrinterResolution = false;
            this.pdfViewer1.PrinterResolution = null;
            this.pdfViewer1.PrintScale = PdfPrintingNet.PdfPrint.ScaleTypes.FitToMargins;
            this.pdfViewer1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.pdfViewer1.SelectionDisabled = false;
            this.pdfViewer1.ShowBookmarks = false;
            this.pdfViewer1.Size = new System.Drawing.Size(654, 835);
            this.pdfViewer1.TabIndex = 11;
            this.pdfViewer1.ToolbarBackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.pdfViewer1.ToolbarBookmarkVisible = true;
            this.pdfViewer1.ToolbarDocumentInfoVisible = true;
            this.pdfViewer1.ToolbarEmailVisible = false;
            this.pdfViewer1.ToolbarOpenVisible = false;
            this.pdfViewer1.ToolbarPageViewTypeVisible = true;
            this.pdfViewer1.ToolbarPageVisible = true;
            this.pdfViewer1.ToolbarPrintVisible = false;
            this.pdfViewer1.ToolbarRotateVisible = true;
            this.pdfViewer1.ToolbarSaveVisible = false;
            this.pdfViewer1.ToolbarSearchVisible = false;
            this.pdfViewer1.ToolbarTooltipVisible = false;
            this.pdfViewer1.ToolbarVisitedPagesVisible = true;
            this.pdfViewer1.ToolbarZoomVisible = true;
            this.pdfViewer1.ViewType = PdfViewerNet.PageViewType.Continuous;
            this.pdfViewer1.Watermark = null;
            this.pdfViewer1.ZoomValue = 100F;
            // 
            // backgroundWorker
            // 
            this.backgroundWorker.WorkerReportsProgress = true;
            this.backgroundWorker.WorkerSupportsCancellation = true;
            this.backgroundWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker_DoWork);
            this.backgroundWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.backgroundWorker_ProgressChanged);
            this.backgroundWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.backgroundWorker_RunWorkerCompleted);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1816, 1007);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbAdmin)).EndInit();
            this.pnlPaper.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnFlashDrive;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblUsbStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnWirelessTransfer;
        private System.Windows.Forms.Panel pnlPaper;
        public Bunifu.Framework.UI.BunifuFlatButton btnPrintDocument;
        public PdfViewerNet.PdfViewer pdfViewer1;
        public Bunifu.Framework.UI.BunifuFlatButton btnHelp;
        private System.Windows.Forms.Label lblDateTime;
        private System.ComponentModel.BackgroundWorker backgroundWorker;
        private System.Windows.Forms.PictureBox pbAdmin;
    }
}