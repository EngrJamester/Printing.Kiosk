using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Printing.Kiosk.Classes
{
    public class PrintPDFwithAcrobat
    {
        public bool Print(string FilePathSelected)
        {
            string Filepath = FilePathSelected;
            bool Printstatus = false;
           

                ProcessStartInfo printProcessInfo = new ProcessStartInfo()
                {
                    Verb = "print",
                    CreateNoWindow = true,
                    FileName = Filepath,
                    WindowStyle = ProcessWindowStyle.Hidden
                };

                Process printProcess = new Process();
                printProcess.StartInfo = printProcessInfo;
                printProcess.Start();

                printProcess.WaitForInputIdle();

                Thread.Sleep(3000);

                if (false == printProcess.CloseMainWindow())
                {
                    printProcess.Kill();
                }
            Printstatus = true;
            return Printstatus;
        }
    }
}
