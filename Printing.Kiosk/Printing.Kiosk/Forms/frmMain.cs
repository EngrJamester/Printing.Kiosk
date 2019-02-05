using MetroFramework.Forms;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Printing.Kiosk
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
            panel2.BackColor = Color.FromArgb(125,Color.Black);
            pnlPaper.BackColor = Color.FromArgb(125, Color.Black);
        }

        private void btnFlashDrive_Click(object sender, EventArgs e)
        {

                OpenFileDialog openFile = new OpenFileDialog();
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    string file = openFile.FileName;

                    //Gets the file name for printing purposes


                    string outfile = "C:\\Users\\MSI\\Documents\\file.pdf"; // path for output file
                    string extension = Path.GetExtension(file);
                    if (extension == ".doc" || extension == ".docx")
                    {
                        Microsoft.Office.Interop.Word.Application app = new Microsoft.Office.Interop.Word.Application();
                        Microsoft.Office.Interop.Word.Document doc = null;
                        doc = app.Documents.Open(file, Type.Missing, false);

                        //convert file doc to pdf
                        doc.ExportAsFixedFormat(outfile, WdExportFormat.wdExportFormatPDF);
                        //close doc file and quit app word
                        doc.Close(false, Type.Missing, Type.Missing);
                        app.Quit(false, false, false);
                        System.Runtime.InteropServices.Marshal.ReleaseComObject(app);
                    }
                    AdobeViewer.src = outfile;
                    pdfViewer1.OpenDocument();

                //FilePath = outfile;

            }
      
        }
    }
}
