using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.Windows.Forms;

namespace Printing.Kiosk.Classes
{
    public class ExecuteFTP
    {
        public void FTP()
        {
            const string ex1 = "C:\\";
            const string ex2 = "C:\\Dir";

            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.CreateNoWindow = false;
            startInfo.UseShellExecute = false;
            startInfo.FileName = @"C:\FTP-Lite\FTPServer.exe";
            startInfo.WindowStyle = ProcessWindowStyle.Hidden;
            startInfo.Arguments = "-f j -o \"" + ex1 + "\" -z 1.0 -s y " + ex2;

            try
            {
                //Process[] pname = Process.GetProcesses();

                Process[] pname = Process.GetProcessesByName("FTPServer");
                if (pname.Length > 0)
                {
                    //MessageBox.Show("FTP Server is currently Running");
                }
                else
                {
                    //MessageBox.Show("Process Not running");
                    // Start the process with the info we specified.
                    // Call WaitForExit and then the using statement will close.
                    using (Process exeProcess = Process.Start(startInfo))
                    {

                        //exeProcess.WaitForExit();
                        //exeProcess.
                    }
                }
              
            }
            catch(Exception ex)
            {
                var MsgAlerts = new MessageAlerts();
                MsgAlerts.ExceptionMessage(ex.ToString());
            }
        }
    }
}
