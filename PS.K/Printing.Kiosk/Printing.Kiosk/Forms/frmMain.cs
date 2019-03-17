using MetroFramework.Forms;
using Microsoft.Office.Interop.Word;
using PdfPrintingNet;
using Printing.Kiosk.Classes;
using Printing.Kiosk.Forms;
using Spire.Pdf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

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
                }

                if (!completed)
                    MessageBox.Show("Timed out before task A completed.","Threading Star-up");
            }
            catch (AggregateException)
            {
                Console.WriteLine("Exception in taskA.");
            }


            //Will Less the Opacity of the Panels
            panel2.BackColor = Color.FromArgb(125, Color.Black);
            pnlPaper.BackColor = Color.FromArgb(125, Color.Black);

            btnPrintDocument.Enabled = false;
            var Datetime = DateTime.Now;
            lblDateTime.Text = Datetime.ToString("MM/dd/yyyy - hh:mm:ss");
        }

        public const int WM_DEVICECHANGE = 0X219;
        public const int WM_DEVICEARRIVAL = 0X3000;
        public const int WM_DEVICEREMOVECOMPLETE = 0X8004;
        public const int WM_DEVICETYP_VOLUME = 0X00000002;
        public const int WM_DEVICESAFETYREMOVED = 0x00000007;

        PDFPrinting pdfPrinting = new PDFPrinting();
        PrintDialog printDialog = new PrintDialog();

        public Boolean PrintColor { get; set; }
        public int NoOfCopies { get; set; }
        public bool IfSuccessPrintCleanPage { get; set; }

        public string FileLoc { get; set; }

        private void btnFlashDrive_Click(object sender, EventArgs e)
        {
            try
            {
                //backgroundWorker.RunWorkerAsync();
                var result = pdfViewer1.OpenDocument(pdfPrinting.CheckFileFormat());
                if(result.Result == PdfOpenFileStatus.PdfOpenFileResult.OK)
                {
                    
                    FileLoc = pdfPrinting.FileToBePrinted;
                    CheckPDFViewerIfNull();
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
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
                    CompSum.txtTotalAmount.Text = Convert.ToString(costPerImage + ((printDialog.PrinterSettings.Copies * 2) * pdfViewer1.NumberOfPages));
                    CompSum.txtColored.Text = "Yes";
                }
                else
                {
                    //Return a value of cost per page and if not colored
                    CompSum.txtTotalAmount.Text = Convert.ToString(costPerImage + ((printDialog.PrinterSettings.Copies * 1) * pdfViewer1.NumberOfPages));
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

        public Boolean PrintDocument()
        {
            var di = new DirectoryInfo(@"C:\FTP_Location");
            var pdfPrint = new PdfPrint("Project", "12345");
            PdfPrint.Status result = PdfPrint.Status.OK;
            bool PrintStatus = false;
            try
            {
                //result = pdfPrint.Print(FileLoc, printDialog.PrinterSettings);
               
                PrintStatus = true;
                if (result == PdfPrint.Status.OK)
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

        private void btnWirelessTransfer_Click(object sender, EventArgs e)
        {
            var WireLessInfo = new frmWireLessInfo();
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


            //var res = new rezult("result","OK");
            
            //if(e.Result == res.Res)
            //{
                
            //}


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
    }
}
