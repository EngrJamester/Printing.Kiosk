using Printing.Kiosk.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO.Ports;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Printing.Kiosk.Forms
{
    public partial class ComputationSummary : Form
    {
        private bool withPaper { get; set; }

        public ComputationSummary()
        {
            InitializeComponent();
            var Pcal = new PrintCalculation();
            txtTotalAmount.Enabled = false;
            txtNoOfCopies.Enabled = false;
            txtColored.Enabled = false;
            txtCurrentBal.Enabled = false;
            btnPrint.Enabled = true;
            btnDispense.Enabled = false;
        }

        public string FileLocFromMain { get; set; }

        public bool PrintSuccess { get; set; }

        public void InitializeSerialPort()
        {
            if (serialPort1.IsOpen == false)
            {
                //serialPort1.BaudRate = 9600;
                //serialPort1.PortName = "COM5";
                //serialPort1.Parity = Parity.None;
                //serialPort1.StopBits = StopBits.One;
                //serialPort1.DataBits = 8;
                //serialPort1.Handshake = Handshake.None;
                //serialPort1.RtsEnable = true;
                //serialPort1.Open();
            }

        }

        frmMain Main = new frmMain();

        private void ComputationSummary_Load(object sender, EventArgs e)
        {
            withPaper = false;
            InitializeSerialPort();
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
                    var val = text.Split('\r');

                    for (int i = 1; i < val.Length; i++)
                    {
                        //Thread.Sleep(300);
                        if (val[0] == "1")
                        {

                            
                            var TAmount = Convert.ToInt32(txtTotalAmount.Text);
                            var TCurBal = Convert.ToInt32(txtCurrentBal.Text);

                            if (TAmount > TCurBal)
                            {
                                InsertedCoin = InsertedCoin + 1;
                                //InsertedCoin = TCurBal + Convert.ToInt32(textBox1.Text);
                                //txtCurrentBal.Text = Convert.ToString(InsertedCoin);
                                if (Convert.ToInt32(txtCurrentBal.Text) == TAmount)
                                {
                                    if (withPaper == false)
                                        btnDispense.Enabled = true;
                                    else
                                        btnPrint.Enabled = true;
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
                        else if(val[0] == "b")
                        {
                            btnPrint.Enabled = true;
                            btnDispense.Enabled = false;
                        }
                    }
                    this.txtCurrentBal.Text = Convert.ToString(InsertedCoin);
                    this.textBox1.Text = text;
                }
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
            //Input balance here if statement
            Main.FileLoc = FileLocFromMain ;
            var printStatus = Main.PrintDocument();
            if (printStatus == true)
            {
                var Stat = new frmStatus();
                var msgstatoutput = Stat.ShowDialog();
                if(msgstatoutput == DialogResult.Cancel)
                {
                    PrintSuccess = true;
                    serialPort1.Close();
                    this.Close();
                }

            }
         
        }

        private void DisplayBalance()
        {
            //InputCode here for the coin slot
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
            Thread.Sleep(500);
            serialPort1.WriteLine(Convert.ToString(Convert.ToInt32(txtNoOfPages.Text) * Convert.ToInt32(txtNoOfCopies.Text)));
        }

        private void btnWithPaper_Click(object sender, EventArgs e)
        {
            withPaper = true;
            
            if (txtColored.Text == "Yes")
            {
                //Return a value of cost per page and if colored
                var costPerImage = Convert.ToInt32(txtTotalAmount.Text)/(((Convert.ToInt32(txtNoOfCopies.Text) * 2) * Convert.ToInt32(txtNoOfPages.Text)));
                txtTotalAmount.Text = Convert.ToString(costPerImage + ((Convert.ToInt32(txtNoOfCopies.Text) * 1) * Convert.ToInt32(txtNoOfPages.Text)));
            }
            else
            {
                //Return a value of cost per page and if not colored
                var costPerImage = Convert.ToInt32(txtTotalAmount.Text) / ((Convert.ToInt32(txtNoOfCopies.Text) * Convert.ToInt32(txtNoOfPages.Text)));
                txtTotalAmount.Text = Convert.ToString(costPerImage + ((Convert.ToInt32(txtNoOfCopies.Text) ) * Convert.ToInt32(txtNoOfPages.Text)));
            }

        }
    }


}
