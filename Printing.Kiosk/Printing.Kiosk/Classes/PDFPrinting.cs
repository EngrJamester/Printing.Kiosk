using GemBox.Presentation;
using GemBox.Spreadsheet;
using Microsoft.Office.Interop.Word;
using PdfPrintingNet;
using SautinSoft;
using System;
using System.Collections.Generic;
using System.IO;    
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using Printing.Kiosk.Forms;
using Spire.Pdf;

namespace Printing.Kiosk.Classes
{
    public class PDFPrinting
    {
        

        //Handles the file which has a .doc/docx format
        public string FileInDocFormat { get; set; }

        //Handles the file name to be printed
        public string FileToBePrinted { get; set; }

        //Verify that the document is in excel format
        public bool ExcelFormat { get; set; }

        // We need to convert first all the document to PDF FIle
        // The PDF Viewer from PDFPrinting.NET does not convert .doc documents
        // It can only read PDF files
        public string ConvertDocToPdf(string fileName)
        {

            //Gets the file in doc format to compute images
            FileInDocFormat = fileName;

            string outfile = Properties.Settings.Default.FolderPath + "file.pdf";// C:\\Users\\MSI\\Documents\\file.pdf"; // path for output file
            string extension = Path.GetExtension(fileName);
            if (extension == ".doc" || extension == ".docx")
            {
                Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                Microsoft.Office.Interop.Word.Document doc = null;
                doc = app.Documents.Open(fileName, Type.Missing, false);

                //convert file doc to pdf
                doc.ExportAsFixedFormat(outfile, WdExportFormat.wdExportFormatPDF);
                //close doc file and quit app word
                doc.Close(false, Type.Missing, Type.Missing);
                app.Quit(false, false, false);
                System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
            }
            
            return outfile;
    
        }

        public string DecodeStatusCode(PdfPrint.Status status)
        {
            switch (status)
            {
                case PdfPrint.Status.OK:
                    return "OK";
                case PdfPrint.Status.FILE_DOESNT_EXIST:
                    return "Filename doesn't exist";
                case PdfPrint.Status.CANNOT_PRINT_FILE:
                    return "Cannot print file";
                case PdfPrint.Status.PRINTER_DOESNT_EXIST:
                    return "Printer doesn't exist";
                case PdfPrint.Status.INVALID_DEVMOD:
                    return "Invalid printer properties structure.";
                case PdfPrint.Status.NOT_AVAILABLE_PRINTER_PROPERTIES:
                    return "Not available printer properties";
                case PdfPrint.Status.CANT_INITIALIZE_PRINTER:
                    return "Can't initialize printer";
                case PdfPrint.Status.PASSWORD_INVALID:
                    return "Invalid password";
                case PdfPrint.Status.INVALID_PDF:
                    return "Invalid pdf";
                case PdfPrint.Status.FILENAME_NOT_SET:
                    return "File name not set";
                case PdfPrint.Status.PASSWORD_NOT_PROVIDED:
                    return "PDF is password protected and password isn't provided.";
                case PdfPrint.Status.UNKNOWN_ERROR:
                    return "Unknown error";
                case PdfPrint.Status.INVALID_PRINT_RANGE:
                    return "Invalid print range";
                case PdfPrint.Status.INVALID_ADOBE_PRINT_RANGE:
                    return "Invalid print range for adobe. It could be from-to, single page or empty.";
                case PdfPrint.Status.PAGE_NUMBER_DOESNT_EXIST:
                    return "Page number doesn't exist";
                case PdfPrint.Status.PRINTING_CANCELLED:
                    return "Printing cancelled";
                case PdfPrint.Status.NOT_32_BIT:
                    return "Printing with Adobe is supported only in 32 bit application.";
            }
            return "Unknown error.";
        }

        public string ConvertPPTtoPDF(string FilePath)
        {
            //Converts the PPT To doc to get the computation

            string DefaultLoc = Properties.Settings.Default.FolderPath + "Convert.pdf";
            ComponentInfo.SetLicense("FREE-LIMITED-KEY");

            var presentation = PresentationDocument.Load(FilePath);

            // In order to achieve the conversion of a loaded PowerPoint file to PDF,
            // we just need to save a PresentationDocument object to desired 
            // output file format. "C:\\Users\\MSI\\Documents\\Convert.pdf"
            presentation.Save(DefaultLoc);
            string loc = Properties.Settings.Default.FolderPath + "Convert.pdf"; // "C:\\Users\\MSI\\Documents\\Convert.pdf";

            FileInDocFormat = ConvertPDFtoWord(DefaultLoc);
            return loc;
        }

        public string ConvertExcelToPDF(string FilePath)
        {
            string DefaultLoc = Properties.Settings.Default.FolderPath + "ConvertExcel.pdf";
            // If using Professional version, put your serial key below. ("C:\\Users\\MSI\\Documents\\ConvertExcel.pdf"
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
                try
                {
                    var ef = ExcelFile.Load(FilePath);
                    ef.Save(DefaultLoc);
                }
                catch (Exception)
                {
                    
                    MessageBox.Show("We can only print up to 150 lines","Transaction Details", MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                // In order to achieve the conversion of a loaded Excel file to PDF,
                // or to some other Excel format,
                // we just need to save an ExcelFile object to desired output file format.
              
                string loc = DefaultLoc;
                return loc;

        }

        public string ConvertPDFtoWord(string FilePath)
        {
            string SaveToFileLocation = Properties.Settings.Default.FolderPath + "PdfToWrod.docx";
            PdfFocus pdfFocus = new PdfFocus();

            PdfDocument pdfDoc = new PdfDocument();
            pdfDoc.LoadFromFile(FilePath);
            pdfDoc.SaveToFile(SaveToFileLocation,FileFormat.DOC);
            //System.Diagnostics.Process.Start(SaveToFileLocation);

            return SaveToFileLocation;
        }

        public string CheckFileFormat(bool DirectoryLocation)
        {
            frmMain Main = new frmMain();
            var splash = new frmSplashScreen();
            OpenFileDialog openFile = new OpenFileDialog();
            string outfile = Properties.Settings.Default.FolderPath+"file.pdf";

            //Limits the user to open file
            if (DirectoryLocation)
                openFile.InitialDirectory = @"C:\FTP_Location";
            else
                openFile.InitialDirectory = "This PC";

            openFile.Filter = "DOC files (*.doc)|*.docx ";
            openFile.Filter = "Office Files|*.docx;*.doc;*.pdf;*.pptx;*.ppt;*.xls;*.xlsx";
            

            if (openFile.ShowDialog() == DialogResult.OK)
            {
              
                splash.Show();
                    string file = openFile.FileName;
                    string extension = Path.GetExtension(file);
                    if (extension == ".doc" || extension == ".docx")
                    {
                        ExcelFormat = false;
                        outfile = ConvertDocToPdf(openFile.FileName);
                    }
                    else if (extension == ".pptx" || extension == ".ptx")
                    {
                        outfile = ConvertPPTtoPDF(openFile.FileName);
                        ExcelFormat = false;
                    }
                    else if (extension == ".xls" || extension == ".xlsx" || extension == ".xlsm")
                    {
                        outfile = ConvertExcelToPDF(openFile.FileName);
                        ExcelFormat = true;
                    }
                    else if (extension == ".pdf")
                    {
                        FileInDocFormat=ConvertPDFtoWord(openFile.FileName);
                        outfile = file;
                        ExcelFormat = false;
                    }
                //return null;
            }
            else
            {
                outfile = "";
            }
            splash.Close();
            FileToBePrinted = outfile;
            return outfile;
        }

     
    }
}
