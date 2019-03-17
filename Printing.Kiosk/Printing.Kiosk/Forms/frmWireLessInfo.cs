using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Printing.Kiosk.Forms
{
    public partial class frmWireLessInfo : Form
    {
        public frmWireLessInfo()
        {
            InitializeComponent();
            lblIPAddress.Text = LocalIP();
        }

        //public static string GetLocalIPAddress()
        //{
        //    var host = Dns.GetHostEntry(Dns.GetHostName());
        //    foreach (var ip in host.AddressList)
        //    {
        //        if (ip.AddressFamily == AddressFamily.InterNetwork)
        //        {
        //            return ip.ToString();
        //        }
        //    }
        //    throw new Exception("No network adapters with an IPv4 address in the system!");
        //}

        public static string LocalIP()
        {
            try
            {
                string myIP = "";
                string hostName = Dns.GetHostName(); // Retrive the Name of HOST  
                                                     //Console.WriteLine(hostName);
                                                     // Get the IP  
                                                     //string myIP = Dns.GetHostByName(hostName).AddressList[0].ToString();
                var ct = Dns.GetHostByName(hostName).AddressList.Length;
                for (int i=0;i< ct; i++)
                {
                    if(Dns.GetHostByName(hostName).AddressList[i].ToString() != "" && ct != 2)
                    {
                        myIP = Dns.GetHostByName(hostName).AddressList[i].ToString();
                    }else if(ct == 2)
                    {
                        myIP = Dns.GetHostByName(hostName).AddressList[1].ToString();
                    }
                }
                return myIP;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Transaction");
                return null;
            }
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
                this.Close();
        }
    }

}
