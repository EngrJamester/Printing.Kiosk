using Printing.Kiosk.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Printing.Kiosk.Forms
{
    public partial class ComputationSummary : Form
    {
        private bool withPaper { get; set; }

        private string PaperCountLeft { get; set; }

        public ComputationSummary()
        {
            InitializeComponent();
            var Pcal = new PrintCalculation();
            txtTotalAmount.Enabled = false;
            txtNoOfCopies.Enabled = false;
            txtColored.Enabled = false;
            txtCurrentBal.Enabled = false;
            btnPrint.Enabled = false;
            btnDispense.Enabled = false;
            btnWithPaper.Enabled = false;
            txtPaperProvided.Text = "No";
        }

        public string FileLocFromMain { get; set; }

        public bool PrintSuccess { get; set; }

        public void InitializeSerialPort()
        {
            try
            {
                if (serialPort1.IsOpen == false)
                {
                    serialPort1.BaudRate = 9600;
                    serialPort1.PortName = "COM16";
                    serialPort1.Parity = Parity.None;
                    serialPort1.StopBits = StopBits.One;
                    serialPort1.DataBits = 8;
                    serialPort1.Handshake = Handshake.None;
                    serialPort1.RtsEnable = true;
                    serialPort1.Open();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message,"Transaction",MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
          

        }

        frmMain Main = new frmMain();

        private void ComputationSummary_Load(object sender, EventArgs e)
        {
            withPaper = false;
            InitializeSerialPort();
            LoadDocument();
            if (CheckReaminingPaperInDispenser())
                MessageBox.Show("Paper is less than the assigned value","Transaction Information", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        #region "SerialPort Receive"

        private void ThreadProcSafe()
        {
            this.SetText(serialPort1.ReadExisting());
        }

        delegate void StringArgReturningVoidDelegate(string text);
        public int InsertedCoin = 0;

        private void SetText(string text)
        {
            try
            {
                // InvokeRequired required compares the thread ID of the
                // calling thread to the thread ID of the creating thread.
                // If these threads are different, it returns true.
                if (this.textBox1.InvokeRequired)
                {
                    StringArgReturningVoidDelegate d = new StringArgReturningVoidDelegate(SetText);
                    this.Invoke(d, new object[] { text });

                }
                else
                {
                    //var val = text.Split('\r');
                    var val = text;

                        //Thread.Sleep(300);
                        if (val == "1")
                        {

                            InsertedCoin = InsertedCoin + 1;
                            this.txtCurrentBal.Text = Convert.ToString(InsertedCoin);
                            this.textBox1.Text = text;

                            var TAmount = Convert.ToInt32(txtTotalAmount.Text);
                            var TCurBal = Convert.ToInt32(txtCurrentBal.Text);
                           
                            if (TAmount >= TCurBal)
                            {
                                
                                //InsertedCoin = TCurBal + Convert.ToInt32(textBox1.Text);
                                //txtCurrentBal.Text = Convert.ToString(InsertedCoin);
                                if (Convert.ToInt32(txtCurrentBal.Text) == TAmount)
                                {
                                 
                                    if(CheckReaminingPaperInDispenser())
                                    {
                                        btnDispense.Enabled = false;
                                        btnWithPaper.Enabled = true;
                                     }
                                    else
                                    {
                                        btnDispense.Enabled = true;
                                        btnWithPaper.Enabled = true;
                                        //btnPrint.Enabled = true;
                                    }


                            }
                                
                            }
                            else 
                            {
                                btnDispense.Enabled = true;
                                MessageBox.Show("Balance is now sufficient", "Transaction Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            //if (textBox1.Text != "")
                            //{

                            //    var TAmount = Convert.ToInt32(txtTotalAmount.Text);
                            //    var TCurBal = Convert.ToInt32(txtCurrentBal.Text);

                            //    if (TAmount > TCurBal )
                            //    {

                            //        //InsertedCoin = TCurBal + Convert.ToInt32(textBox1.Text);
                            //        //txtCurrentBal.Text = Convert.ToString(InsertedCoin);
                            //        InsertedCoin = InsertedCoin + 1;
                            //        if(Convert.ToInt32(txtCurrentBal.Text) == TAmount)
                            //        {
                            //            btnDispense.Enabled = true;
                            //        }

                            //    }else
                            //    {
                            //        btnDispense.Enabled = true;
                            //        MessageBox.Show("Balance is now sufficient","Transaction Notice",MessageBoxButtons.OK,MessageBoxIcon.Information);
                            //    }
                            //}
                            //else
                            //{
                            //    if(InsertedCoin == 1)
                            //        txtCurrentBal.Text = "1";
                            //}
                        }
                        else if(val == "b")
                        {
                            btnPrint.Enabled = true;
                            btnDispense.Enabled = false;
                            btnWithPaper.Enabled = false;
                        }
                    }
                //for (int i = 1; i < val.Length; i++)
                //{

                //}
            }
            catch (Exception ex)
            {
                var Alerts = new MessageAlerts();
                Alerts.ExceptionMessage(ex.ToString());
            }

        }

        private void serialPort1_DataReceived(object sender, SerialDataReceivedEventArgs e)
        {
            var dThread = new Thread(new ThreadStart(this.ThreadProcSafe));
            dThread.Start();
        }
        #endregion

        private void btnPrint_Click(object sender, EventArgs e)
        {
            if (CheckReaminingPaperInDispenser() && !withPaper)
            {
                var MsgStat = new MessageAlerts();
                MsgStat.ExceptionMessage("No More paper left in the Dispenser");
                serialPort1.WriteLine("b");
                return;
            }

            ExecutePrint();
        }

        private void ExecutePrint()
        {
            bool IsColor;
            short Copies = Convert.ToInt16(txtNoOfCopies.Text);
            if (txtColored.Text == "Yes")
                IsColor = true;
            else
                IsColor = false;
            //Input balance here if statement
            Main.FileLoc = FileLocFromMain;
            var printStatus = Main.PrintDocument(IsColor, Copies);
            if (printStatus == true)
            {
                var Stat = new frmStatus();
                var msgstatoutput = Stat.ShowDialog();
                if (msgstatoutput == DialogResult.Cancel)
                {
                    var path = Properties.Settings.Default.AdminPath + "Admin.xml";
                    var xDoc = XDocument.Load(path);
                    var node = xDoc.Descendants("Admin").FirstOrDefault(cd => cd.Element("paper").Value != "");
                    if (node.Name != null || node.Name != "")
                    {
                        int TotalRemaining = Convert.ToInt32(PaperCountLeft) - (Convert.ToInt32(txtNoOfCopies.Text) * Convert.ToInt32(txtNoOfPages.Text));
                        node.SetElementValue("paper", TotalRemaining);
                    }
                    xDoc.Save(path);
                    PrintSuccess = true;
                    serialPort1.Close();
                    this.Close();
                }

            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            serialPort1.Close();
            Main.Enabled = true;
            this.Close();
        }

        private void btnDispense_Click(object sender, EventArgs e)
        {
            //serialPort1.WriteLine("a");//sends off command when the previous state was on
            //Thread.Sleep(500);
            string PageValue = Convert.ToString(Convert.ToInt32(txtNoOfPages.Text) * Convert.ToInt32(txtNoOfCopies.Text));
            serialPort1.WriteLine(PageValue);

            var path = Properties.Settings.Default.AdminPath + "Admin.xml";
            var xDoc = XDocument.Load(path);
            var node = xDoc.Descendants("Admin").FirstOrDefault(cd => cd.Element("paper").Value != "");
            if (node.Name != null || node.Name != "")
            {
                int value = Convert.ToInt32(PaperCountLeft) - Convert.ToInt32(PageValue);
                if(value >= 0)
                    node.SetElementValue("paper", value);
                else
                    node.SetElementValue("paper", 0);
            }
            xDoc.Save(path);
            btnWithPaper.Enabled = false;
        }

        private void btnWithPaper_Click(object sender, EventArgs e)
        {
            withPaper = true;
            
            if (txtColored.Text == "Yes")
            {
                txtPaperProvided.Text = "Yes";
                btnWithPaper.Enabled = false;
                //Return a value of cost per page and if colored
                var costPerImage = Convert.ToInt32(txtTotalAmount.Text)/(((Convert.ToInt32(txtNoOfCopies.Text) * 2) * Convert.ToInt32(txtNoOfPages.Text)));
                txtTotalAmount.Text = Convert.ToString(costPerImage + ((Convert.ToInt32(txtNoOfCopies.Text) * 1) * Convert.ToInt32(txtNoOfPages.Text)));
                ExecutePrint();
            }
            else
            {
                txtPaperProvided.Text = "Yes";
                btnWithPaper.Enabled = false;
                //Return a value of cost per page and if not colored
                //var costPerImage = Convert.ToInt32(txtTotalAmount.Text) / ((Convert.ToInt32(txtNoOfCopies.Text) * Convert.ToInt32(txtNoOfPages.Text)));
                //txtTotalAmount.Text = Convert.ToString(costPerImage + ((Convert.ToInt32(txtNoOfCopies.Text) ) * Convert.ToInt32(txtNoOfPages.Text)));

                var costPerImage = Convert.ToInt32(txtTotalAmount.Text) / (((Convert.ToInt32(txtNoOfCopies.Text) * 2) * Convert.ToInt32(txtNoOfPages.Text)));
                txtTotalAmount.Text = Convert.ToString(costPerImage + ((Convert.ToInt32(txtNoOfCopies.Text) * 1) * Convert.ToInt32(txtNoOfPages.Text)));
                ExecutePrint();
            }

        }

        private void LoadDocument()
        {
            string path = Properties.Settings.Default.AdminPath + "Admin.xml"; // your code goes here

            bool exists = System.IO.Directory.Exists(Properties.Settings.Default.AdminPath);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(Properties.Settings.Default.AdminPath);
                if (!File.Exists(path))
                {
                    var xml = new XElement("Admin", new XElement("multiplier", 0.09), new XElement("paper", 25));
                    xml.Save(path);
                }
                else
                {
                    var xtr = new XmlTextReader(path);
                    while (xtr.Read())
                    {
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "paper")
                        {
                            PaperCountLeft = xtr.ReadElementContentAsString();
                            xtr.Close();
                        }
                    }

                }
            }
            else
            {
                var xtr = new XmlTextReader(path);
                while (xtr.Read())
                {
                   
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "paper")
                    {
                        PaperCountLeft = xtr.ReadElementContentAsString();
                        xtr.Close();
                    }

                }
            }


        }

        private bool CheckReaminingPaperInDispenser()
        {
            //var Count = (Convert.ToInt32(txtNoOfCopies.Text) * Convert.ToInt32(txtNoOfPages.Text));
            if (Convert.ToInt32(PaperCountLeft) < 5)
            {
                btnDispense.Enabled = false;
                return true;

            }
            else
            {
             
                return false;
            }
              
        }

        
    }


}
