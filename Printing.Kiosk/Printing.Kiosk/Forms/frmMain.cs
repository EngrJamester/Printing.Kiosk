using MetroFramework.Forms;
using Microsoft.Office.Interop.Word;
using PdfPrintingNet;
using Printing.Kiosk.Classes;
using Printing.Kiosk.Forms;
using Spire.Pdf;
using System;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Printing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Printing.Kiosk
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            //Execute the application
            var ftpExecute = new ExecuteFTP();

            try
            {
                // Wait on a single task with a timeout specified.
                System.Threading.Tasks.Task taskA = System.Threading.Tasks.Task.Run(() => ftpExecute.FTP());
                taskA.Wait(3000);       // Wait for 3 second.
                bool completed = taskA.IsCompleted;
                if (completed)
                {
                    //Console.WriteLine("Task A completed: {0}, Status: {1}",
                    //           completed, taskA.Status);
                    //Initialize component
                    InitializeComponent();
                    //Will Less the Opacity of the Panels
                    panel2.BackColor = Color.FromArgb(125, Color.Black);
                    pnlPaper.BackColor = Color.FromArgb(125, Color.Black);

                    btnPrintDocument.Enabled = false;
                    var Datetime = DateTime.Now;
                    lblDateTime.Text = Datetime.ToString("MM/dd/yyyy - hh:mm:ss");
                    checkFolderLocation();
                }

                if (!completed)
                    MessageBox.Show("Timed out before task A completed.", "Threading Star-up");
            }
            catch (AggregateException)
            {
                Console.WriteLine("Exception in taskA.");
            }



        }

        public const int WM_DEVICECHANGE = 0X219;
        public const int WM_DEVICEARRIVAL = 0X3000;
        public const int WM_DEVICEREMOVECOMPLETE = 0X8004;
        public const int WM_DEVICETYP_VOLUME = 0X00000002;
        public const int WM_DEVICESAFETYREMOVED = 0x00000007;

        PDFPrinting pdfPrinting = new PDFPrinting();
        PrintDialog printDialog = new PrintDialog();
        frmWireLessInfo WireLess = new frmWireLessInfo();

        public Boolean PrintColor { get; set; }
        public int NoOfCopies { get; set; }
        public bool IfSuccessPrintCleanPage { get; set; }

        public string FileLoc { get; set; }

        public int Location { get; set; }

        public enum Directory
        {
           USB,
           WirelessTransfer
        }

        private void btnFlashDrive_Click(object sender, EventArgs e)
        {
            OpenDiretory(Directory.USB);
        }

        private void WireLessInfo_FormClosed(object sender, FormClosedEventArgs e)
        {
            OpenDiretory(Directory.WirelessTransfer);
        }

        public void OpenDiretory(Directory Value)
        {
            try
            {
                bool DirectoryLocation;
                //If 0 FlashDrive
                if ((int)Value == 0)
                {
                    DirectoryLocation = false;
                }else // Wirless Transfer
                {
                    DirectoryLocation = true;
                }
                //backgroundWorker.RunWorkerAsync();
                var result = pdfViewer1.OpenDocument(pdfPrinting.CheckFileFormat(DirectoryLocation));
                if (result.Result == PdfOpenFileStatus.PdfOpenFileResult.OK)
                {

                    FileLoc = pdfPrinting.FileToBePrinted;
                    CheckPDFViewerIfNull();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Transaction");
            }
        }

        private void btnPrintDocument_Click(object sender, EventArgs e)
        {

            PdfPrint.Status result = PdfPrint.Status.OK;


            if (printDialog.ShowDialog() == DialogResult.OK)
            {
                //Open ComputeSummary form
                var CompSum = new ComputationSummary();

                //Returns a value of number of copies to be printed
                CompSum.txtNoOfCopies.Text = Convert.ToString(printDialog.PrinterSettings.Copies);
                CompSum.txtNoOfPages.Text = Convert.ToString(pdfViewer1.NumberOfPages);
                //Returns a boolean value if the item to be printed is colored or grayscale
                PrintColor = printDialog.PrinterSettings.DefaultPageSettings.Color;

                decimal costPerImage = 0;
                //Compute Cost
                var cal = new PrintCalculation();
                if (!pdfPrinting.ExcelFormat)
                {
                    costPerImage = cal.CalculateImageInFile(pdfPrinting.FileInDocFormat);
                }


                if (PrintColor == true)
                {
                    //Return a value of cost per page and if colored
                    CompSum.txtTotalAmount.Text =  Convert.ToString(costPerImage + ((printDialog.PrinterSettings.Copies * 2) * pdfViewer1.NumberOfPages));
                    CompSum.txtColored.Text = "Yes";
                }
                else
                {
                    //Return a value of cost per page and if not colored
                    CompSum.txtTotalAmount.Text =  Convert.ToString(costPerImage + ((printDialog.PrinterSettings.Copies * 1) * pdfViewer1.NumberOfPages));
                    CompSum.txtColored.Text = "No";
                }

                CompSum.FileLocFromMain = FileLoc;
                CompSum.ShowDialog();
                if (CompSum.PrintSuccess)
                {
                    pdfViewer1.CloseDocument();
                    btnPrintDocument.Enabled = false;
                }
            }
            else
            {
                pdfViewer1.CloseDocument();
                result = PdfPrint.Status.PRINTING_CANCELLED;

            }

            if (result == PdfPrint.Status.OK)
            { /*MessageBox.Show("Done Successfully", "Printing Transaction Status", MessageBoxButtons.OK, MessageBoxIcon.Information);*/}
            else if (result == PdfPrint.Status.PRINTING_CANCELLED)
            {
                var MsgAlerts = new MessageAlerts();
                MsgAlerts.ExceptionMessage(pdfPrinting.DecodeStatusCode(result));
            }
            else
            {
                var MsgAlerts = new MessageAlerts();
                MsgAlerts.ExceptionMessage("Error." + pdfPrinting.DecodeStatusCode(result));
            }
        }

        public Boolean PrintDocument(bool IsColor, short NoOfCopies)
        {
            var di = new DirectoryInfo(@"C:\FTP_Location");
            //Using PDFPrinting
            var pdfPrint = new PdfPrint("Project", "12345");
            //Using Spire
            var pdfPrintUsingAcrobat = new PrintPDFwithAcrobat();
            PdfPrint.Status result = PdfPrint.Status.OK;
            bool PrintStatus = false;
            try
            {
                //var res = pdfPrintUsingAcrobat.Print(FileLoc);
                //Pdf Printing Method result == PdfPrint.Status.OK
                //result = pdfPrint.Print(FileLoc, printDialog.PrinterSettings);

                PdfDocument pdfdocument = new PdfDocument();
                pdfdocument.LoadFromFile(FileLoc);
                pdfdocument.PrintDocument.PrinterSettings.Copies = NoOfCopies;
                //pdfdocument.PrintSettings.Color = printDialog.PrinterSettings.SupportsColor;

                if (!IsColor)
                    pdfdocument.PrintSettings.Color = false;

                pdfdocument.Print();
                pdfdocument.Dispose();
                PrintStatus = true;
                if (true)
                {
                    //Delete all files in the FTP File Location

                    foreach (FileInfo file in di.EnumerateFiles())
                    {
                        file.Delete();
                    }
                    PrintStatus = true;
                    return PrintStatus;
                }
                return PrintStatus;
            }
            catch (Exception ex)
            {
                result = PdfPrint.Status.UNKNOWN_ERROR;
                MessageBox.Show("Error." + ex.Message, "Printer Status", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return PrintStatus;
            }
        }

        private Boolean CheckPDFViewerIfNull()
        {
            if (pdfViewer1.IsDocumentLoaded)
            {
                /* MessageBox.Show("Document Loaded"); */
                btnPrintDocument.Enabled = true;
                return true;
            }
            else
            {/* MessageBox.Show("Document Not Loaded");*/
                btnPrintDocument.Enabled = false;
                return false;
            }
        }

        //private void btnDispensePaper_Click(object sender, EventArgs e)
        //{
        //    var SerialP = new SerialPort();
        //    SerialP.GetPorts();
        //}

        private void btnWirelessTransfer_Click(object sender, EventArgs e)
        {
            var WireLessInfo = new frmWireLessInfo();
            WireLessInfo.FormClosed += WireLessInfo_FormClosed;
            WireLessInfo.ShowDialog();
        }

        //Detect USB connected Device
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);

            switch (m.Msg)
            {
                case WM_DEVICECHANGE:
                    switch ((int)m.WParam)
                    {
                        case WM_DEVICEARRIVAL:
                            lblUsbStatus.Text = "New Device Connected";
                            break;

                        case WM_DEVICEREMOVECOMPLETE:
                            lblUsbStatus.Text = "Device Removed";
                            break;
                        case WM_DEVICESAFETYREMOVED:
                            lblUsbStatus.Text = "New Device Connected";
                            break;
                    }
                    break;
            }
        }

        private void backgroundWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            e.Result = (PdfOpenFileStatus)e.Argument;
        }

        private void backgroundWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            var val = e.ProgressPercentage;
        }

        private void backgroundWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {

        }

        private void pbAdmin_Click(object sender, EventArgs e)
        {
            var admin = new frmAdmin();
            admin.ShowDialog();
        }

        private void checkFolderLocation()
        {
            bool exists = System.IO.Directory.Exists(Properties.Settings.Default.FolderPath);
            bool Wexists = System.IO.Directory.Exists(Properties.Settings.Default.WirelessPath);
            bool AdmininFolderExists = System.IO.Directory.Exists(Properties.Settings.Default.AdminPath);
            string path = Properties.Settings.Default.AdminPath + "Admin.xml";

            if (!exists)
                System.IO.Directory.CreateDirectory(Properties.Settings.Default.FolderPath);
            if (!Wexists)
                System.IO.Directory.CreateDirectory(Properties.Settings.Default.WirelessPath);

            if (!AdmininFolderExists)
            {
                System.IO.Directory.CreateDirectory(Properties.Settings.Default.AdminPath);
                if (!File.Exists(path))
                {
                    var xml = new XElement("Admin", new XElement("multiplier", 0.0), new XElement("paper", 25));
                    xml.Save(path);
                }

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            Location = 0;
        }

        private void btnHelp_Click(object sender, EventArgs e)
        {
            string HelpLocation = System.IO.Directory.GetCurrentDirectory();
            var HL = HelpLocation + "\\HelpSection.docx";
            string HelpFileLocation = pdfPrinting.ConvertDocToPdf(HL);
            pdfViewer1.OpenDocument(HelpFileLocation);
        }
    }
}
