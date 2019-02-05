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
            this.pnlPaper = new System.Windows.Forms.Panel();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btn = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.lblUsbStatus = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnWirelessTransfer = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnFlashDrive = new Bunifu.Framework.UI.BunifuFlatButton();
            this.panel3 = new System.Windows.Forms.Panel();
            this.AdobeViewer = new AxAcroPDFLib.AxAcroPDF();
            this.pdfViewer1 = new PdfViewerNet.PdfViewer();
            this.panel1.SuspendLayout();
            this.pnlPaper.SuspendLayout();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AdobeViewer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel1.BackgroundImage")));
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
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
            // pnlPaper
            // 
            this.pnlPaper.BackColor = System.Drawing.Color.Gray;
            this.pnlPaper.Controls.Add(this.bunifuFlatButton2);
            this.pnlPaper.Controls.Add(this.btn);
            this.pnlPaper.Location = new System.Drawing.Point(86, 588);
            this.pnlPaper.Name = "pnlPaper";
            this.pnlPaper.Size = new System.Drawing.Size(756, 360);
            this.pnlPaper.TabIndex = 8;
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Print Document";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.ForeColor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = ((System.Drawing.Image)(resources.GetObject("bunifuFlatButton2.Iconimage")));
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 100D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(147, 199);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(6);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.DimGray;
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.Gold;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(463, 105);
            this.bunifuFlatButton2.TabIndex = 7;
            this.bunifuFlatButton2.Text = "Print Document";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            // 
            // btn
            // 
            this.btn.Activecolor = System.Drawing.Color.DimGray;
            this.btn.BackColor = System.Drawing.Color.DimGray;
            this.btn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn.BorderRadius = 0;
            this.btn.ButtonText = "Dispense Paper";
            this.btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn.DisabledColor = System.Drawing.Color.Gray;
            this.btn.ForeColor = System.Drawing.Color.DimGray;
            this.btn.Iconcolor = System.Drawing.Color.Transparent;
            this.btn.Iconimage = ((System.Drawing.Image)(resources.GetObject("btn.Iconimage")));
            this.btn.Iconimage_right = null;
            this.btn.Iconimage_right_Selected = null;
            this.btn.Iconimage_Selected = null;
            this.btn.IconMarginLeft = 0;
            this.btn.IconMarginRight = 0;
            this.btn.IconRightVisible = true;
            this.btn.IconRightZoom = 0D;
            this.btn.IconVisible = true;
            this.btn.IconZoom = 110D;
            this.btn.IsTab = false;
            this.btn.Location = new System.Drawing.Point(147, 49);
            this.btn.Margin = new System.Windows.Forms.Padding(6);
            this.btn.Name = "btn";
            this.btn.Normalcolor = System.Drawing.Color.DimGray;
            this.btn.OnHovercolor = System.Drawing.Color.DimGray;
            this.btn.OnHoverTextColor = System.Drawing.Color.Gold;
            this.btn.selected = false;
            this.btn.Size = new System.Drawing.Size(463, 105);
            this.btn.TabIndex = 6;
            this.btn.Text = "Dispense Paper";
            this.btn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btn.Textcolor = System.Drawing.Color.White;
            this.btn.TextFont = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.btnWirelessTransfer.ButtonText = "Wire Transfer";
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
            this.btnWirelessTransfer.Text = "Wire Transfer";
            this.btnWirelessTransfer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnWirelessTransfer.Textcolor = System.Drawing.Color.White;
            this.btnWirelessTransfer.TextFont = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
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
            this.panel3.Controls.Add(this.AdobeViewer);
            this.panel3.Location = new System.Drawing.Point(1054, 98);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(691, 866);
            this.panel3.TabIndex = 6;
            // 
            // AdobeViewer
            // 
            this.AdobeViewer.Enabled = true;
            this.AdobeViewer.Location = new System.Drawing.Point(18, 21);
            this.AdobeViewer.Name = "AdobeViewer";
            this.AdobeViewer.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("AdobeViewer.OcxState")));
            this.AdobeViewer.Size = new System.Drawing.Size(652, 823);
            this.AdobeViewer.TabIndex = 0;
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
            this.pdfViewer1.Location = new System.Drawing.Point(67, 70);
            this.pdfViewer1.Name = "pdfViewer1";
            this.pdfViewer1.OverridePrinterResolution = false;
            this.pdfViewer1.PrinterResolution = null;
            this.pdfViewer1.PrintScale = PdfPrintingNet.PdfPrint.ScaleTypes.FitToMargins;
            this.pdfViewer1.SelectionColor = System.Drawing.Color.FromArgb(((int)(((byte)(80)))), ((int)(((byte)(0)))), ((int)(((byte)(125)))), ((int)(((byte)(125)))));
            this.pdfViewer1.SelectionDisabled = false;
            this.pdfViewer1.ShowBookmarks = false;
            this.pdfViewer1.Size = new System.Drawing.Size(565, 594);
            this.pdfViewer1.TabIndex = 11;
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
            this.pdfViewer1.Watermark = null;
            this.pdfViewer1.ZoomValue = 100F;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1816, 1007);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.pnlPaper.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AdobeViewer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private Bunifu.Framework.UI.BunifuFlatButton btnFlashDrive;
        private System.Windows.Forms.Panel panel3;
        private AxAcroPDFLib.AxAcroPDF AdobeViewer;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lblUsbStatus;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnWirelessTransfer;
        private System.Windows.Forms.Panel pnlPaper;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btn;
        private PdfViewerNet.PdfViewer pdfViewer1;
    }
}