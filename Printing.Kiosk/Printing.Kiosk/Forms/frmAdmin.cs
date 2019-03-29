using Printing.Kiosk.Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Xml.Linq;

namespace Printing.Kiosk.Forms
{
    public partial class frmAdmin : Form
    {
        public frmAdmin()
        {
            InitializeComponent();
        }

        private int PaperCount { get; set; }

        //
        private bool TabControlValue { get; set; }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShutdown_Click(object sender, EventArgs e)
        {
            var MsgStat = MessageBox.Show("Are you sure you want to shutdonw?", "Notificaiton", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if(MsgStat == DialogResult.Yes)
            {
                var psi = new ProcessStartInfo("shutdown", "/s /t 0");
                psi.CreateNoWindow = true;
                psi.UseShellExecute = false;
                Process.Start(psi);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                    var path = Properties.Settings.Default.AdminPath + "Admin.xml";
                    var xDoc = XDocument.Load(path);
                    var node = xDoc.Descendants("Admin").FirstOrDefault(cd => cd.Element("multiplier").Value != "");
                    if (node.Name != null || node.Name != "")
                    {
                        node.SetElementValue("multiplier", txtMultiplier.Text);
                    }
                    xDoc.Save(path);
                    lblStatus.Text = "File Has been updated";
                    lblStatus.ForeColor = Color.PaleGreen;
            }
            catch (Exception ex)
            {
                var MsgAlert = new MessageAlerts();
                MsgAlert.ExceptionMessage(ex.Message);
            }
          

        }

        private void frmAdmin_Load(object sender, EventArgs e)
        {
            try
            {
                lblAdminStatus.Text = "Not Admin";
                lblAdminStatus.ForeColor = Color.Salmon;
                lblStatus.ForeColor = Color.Salmon;
                groupBoxButtons.Enabled = false;
                TabControlValue = true;
                LoadDocument();
                LoadPaperCount();
            }
            catch (Exception ex)
            {
                var MsgAlert = new MessageAlerts();
                MsgAlert.ExceptionMessage(ex.Message);
            }
            
        }

        private void LoadDocument()
        {
            string path = Properties.Settings.Default.AdminPath + "Admin.xml"; // your code goes here

            bool exists = System.IO.Directory.Exists(Properties.Settings.Default.AdminPath);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(Properties.Settings.Default.AdminPath);
                if(!File.Exists(path))
                {
                    var xml = new XElement("Admin", new XElement("multiplier", 0.0), new XElement("paper", 25));
                    xml.Save(path);
                }
                else
                {
                    var xtr = new XmlTextReader(path);
                    while (xtr.Read())
                    {
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "multiplier")
                        {
                            txtMultiplier.Text = xtr.ReadElementContentAsString();
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
                    if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "multiplier")
                    {
                        txtMultiplier.Text = xtr.ReadElementContentAsString();
                        xtr.Close();
                    }
                    
                }
            }
                
        }

        private void btnOne_Click(object sender, EventArgs e)
        {
            if(lblAdminStatus.Text == "Admin")
            {
                if (TabControlValue)
                {
                    ValidateAdmin();
                    lblStatus.Text = "No Update";
                    lblStatus.ForeColor = Color.Salmon;
                    if (txtMultiplier.Text == "0" && txtMultiplier.Text != null)
                        txtMultiplier.Text = "1";
                    else
                        txtMultiplier.Text = txtMultiplier.Text + 1;
                }
                else if (!TabControlValue)
                {
                    lblStatPaper.Text = "Paper Count - No Update";
                    lblStatPaper.ForeColor = Color.Salmon;
                    if (txtPaperCount.Text == "0" && txtPaperCount.Text != null)
                        txtPaperCount.Text = "1";
                    else
                        txtPaperCount.Text = txtPaperCount.Text + 1;
                }
            }else
            {
                if (txtCode.Text == "0" && txtCode.Text != null)
                    txtCode.Text = "1";
                else
                    txtCode.Text = txtCode.Text + 1;
            }
           
        }

        private void btnTwo_Click(object sender, EventArgs e)
        {
            if (lblAdminStatus.Text == "Admin")
            {
                if (TabControlValue)
                {
                    ValidateAdmin();
                    lblStatus.Text = "No Update";
                    lblStatus.ForeColor = Color.Salmon;
                    if (txtMultiplier.Text == "0" && txtMultiplier.Text != null)
                        txtMultiplier.Text = "2";
                    else
                        txtMultiplier.Text = txtMultiplier.Text + 2;
                }
                else if (!TabControlValue)
                {
                    lblStatPaper.Text = "Paper Count - No Update";
                    lblStatPaper.ForeColor = Color.Salmon;
                    if (txtPaperCount.Text == "0" && txtPaperCount.Text != null)
                        txtPaperCount.Text = "2";
                    else
                        txtPaperCount.Text = txtPaperCount.Text + 2;
                }
            }else
            {
                if (txtCode.Text == "0" && txtCode.Text != null)
                    txtCode.Text = "2";
                else
                    txtCode.Text = txtCode.Text + 2;
            }
        }

        private void btnThree_Click(object sender, EventArgs e)
        {
            if (lblAdminStatus.Text == "Admin")
            {
                if (TabControlValue)
                {
                    ValidateAdmin();
                    lblStatus.Text = "No Update";
                    lblStatus.ForeColor = Color.Salmon;
                    if (txtMultiplier.Text == "0" && txtMultiplier.Text != null)
                        txtMultiplier.Text = "3";
                    else
                        txtMultiplier.Text = txtMultiplier.Text + 3;
                }
                else if (!TabControlValue)
                {
                    lblStatPaper.Text = "Paper Count - No Update";
                    lblStatPaper.ForeColor = Color.Salmon;
                    if (txtPaperCount.Text == "0" && txtPaperCount.Text != null)
                        txtPaperCount.Text = "3";
                    else
                        txtPaperCount.Text = txtPaperCount.Text + 3;
                }
            }else
            {
                if (txtCode.Text == "0" && txtCode.Text != null)
                    txtCode.Text = "3";
                else
                    txtCode.Text = txtCode.Text + 3;
            }
        }

        private void btnFour_Click(object sender, EventArgs e)
        {
            if (lblAdminStatus.Text == "Admin")
            {
                if (TabControlValue)
                {
                    ValidateAdmin();
                    lblStatus.Text = "No Update";
                    lblStatus.ForeColor = Color.Salmon;
                    if (txtMultiplier.Text == "0" && txtMultiplier.Text != null)
                        txtMultiplier.Text = "4";
                    else
                        txtMultiplier.Text = txtMultiplier.Text + 4;
                }
                else if (!TabControlValue)
                {
                    lblStatPaper.Text = "Paper Count - No Update";
                    lblStatPaper.ForeColor = Color.Salmon;
                    if (txtPaperCount.Text == "0" && txtPaperCount.Text != null)
                        txtPaperCount.Text = "4";
                    else
                        txtPaperCount.Text = txtPaperCount.Text + 4;
                }
            }
            else
            {
                if (txtCode.Text == "0" && txtCode.Text != null)
                    txtCode.Text = "4";
                else
                    txtCode.Text = txtCode.Text + 4;
            }
        }

        private void btnFive_Click(object sender, EventArgs e)
        {
            if (lblAdminStatus.Text == "Admin")
            {
                if (TabControlValue)
                {
                    ValidateAdmin();
                    lblStatus.Text = "No Update";
                    lblStatus.ForeColor = Color.Salmon;
                    if (txtMultiplier.Text == "0" && txtMultiplier.Text != null)
                        txtMultiplier.Text = "5";
                    else
                        txtMultiplier.Text = txtMultiplier.Text + 5;
                }
                else if (!TabControlValue)
                {
                    lblStatPaper.Text = "Paper Count - No Update";
                    lblStatPaper.ForeColor = Color.Salmon;
                    if (txtPaperCount.Text == "0" && txtPaperCount.Text != null)
                        txtPaperCount.Text = "5";
                    else
                        txtPaperCount.Text = txtPaperCount.Text + 5;
                }
            }
            else
            {
                if (txtCode.Text == "0" && txtCode.Text != null)
                    txtCode.Text = "5";
                else
                    txtCode.Text = txtCode.Text + 5;
            }
        }

        private void btnSix_Click(object sender, EventArgs e)
        {
            if (lblAdminStatus.Text == "Admin")
            {
                if (TabControlValue)
                {
                    ValidateAdmin();
                    lblStatus.Text = "No Update";
                    lblStatus.ForeColor = Color.Salmon;
                    if (txtMultiplier.Text == "0" && txtMultiplier.Text != null)
                        txtMultiplier.Text = "6";
                    else
                        txtMultiplier.Text = txtMultiplier.Text + 6;
                }
                else if (!TabControlValue)
                {
                    lblStatPaper.Text = "Paper Count - No Update";
                    lblStatPaper.ForeColor = Color.Salmon;
                    if (txtPaperCount.Text == "0" && txtPaperCount.Text != null)
                        txtPaperCount.Text = "6";
                    else
                        txtPaperCount.Text = txtPaperCount.Text + 6;
                }
            }
            else
            {
                if (txtCode.Text == "0" && txtCode.Text != null)
                    txtCode.Text = "6";
                else
                    txtCode.Text = txtCode.Text + 6;
            }
        }

        private void btnSeven_Click(object sender, EventArgs e)
        {
            if (lblAdminStatus.Text == "Admin")
            {
                if (TabControlValue)
                {
                    ValidateAdmin();
                    lblStatus.Text = "No Update";
                    lblStatus.ForeColor = Color.Salmon;
                    if (txtMultiplier.Text == "0" && txtMultiplier.Text != null)
                        txtMultiplier.Text = "7";
                    else
                        txtMultiplier.Text = txtMultiplier.Text + 7;
                }
                else if (!TabControlValue)
                {
                    lblStatPaper.Text = "Paper Count - No Update";
                    lblStatPaper.ForeColor = Color.Salmon;
                    if (txtPaperCount.Text == "0" && txtPaperCount.Text != null)
                        txtPaperCount.Text = "7";
                    else
                        txtPaperCount.Text = txtPaperCount.Text + 7;
                }
            }
            else
            {
                if (txtCode.Text == "0" && txtCode.Text != null)
                    txtCode.Text = "7";
                else
                    txtCode.Text = txtCode.Text + 7;
            }
        }

        private void btnEight_Click(object sender, EventArgs e)
        {
            if (lblAdminStatus.Text == "Admin")
            {
                if (TabControlValue)
                {
                    ValidateAdmin();
                    lblStatus.Text = "No Update";
                    lblStatus.ForeColor = Color.Salmon;
                    if (txtMultiplier.Text == "0" && txtMultiplier.Text != null)
                        txtMultiplier.Text = "8";
                    else
                        txtMultiplier.Text = txtMultiplier.Text + 8;
                }
                else if (!TabControlValue)
                {
                    lblStatPaper.Text = "Paper Count - No Update";
                    lblStatPaper.ForeColor = Color.Salmon;
                    if (txtPaperCount.Text == "0" && txtPaperCount.Text != null)
                        txtPaperCount.Text = "8";
                    else
                        txtPaperCount.Text = txtPaperCount.Text + 8;
                }
            }
            else
            {
                if (txtCode.Text == "0" && txtCode.Text != null)
                    txtCode.Text = "8";
                else
                    txtCode.Text = txtCode.Text + 8;
            }
        }

        private void btnNine_Click(object sender, EventArgs e)
        {
            if (lblAdminStatus.Text == "Admin")
            {
                if (TabControlValue)
                {
                    ValidateAdmin();
                    lblStatus.Text = "No Update";
                    lblStatus.ForeColor = Color.Salmon;
                    if (txtMultiplier.Text == "0" && txtMultiplier.Text != null)
                        txtMultiplier.Text = "9";
                    else
                        txtMultiplier.Text = txtMultiplier.Text + 9;
                }
                else if (!TabControlValue)
                {
                    lblStatPaper.Text = "Paper Count - No Update";
                    lblStatPaper.ForeColor = Color.Salmon;
                    if (txtPaperCount.Text == "0" && txtPaperCount.Text != null)
                        txtPaperCount.Text = "9";
                    else
                        txtPaperCount.Text = txtPaperCount.Text + 9;
                }
            }
            else
            {
                if (txtCode.Text == "0" && txtCode.Text != null)
                    txtCode.Text = "9";
                else
                    txtCode.Text = txtCode.Text + 9;
            }
        }

        private void btnTen_Click(object sender, EventArgs e)
        {
            if (lblAdminStatus.Text == "Admin")
            {
                if (TabControlValue)
                {
                    ValidateAdmin();
                    lblStatus.Text = "No Update";
                    lblStatus.ForeColor = Color.Salmon;
                    if (txtMultiplier.Text == "0" && txtMultiplier.Text != null)
                        txtMultiplier.Text = "0";
                    else
                        txtMultiplier.Text = txtMultiplier.Text + 0;
                }
                else if (!TabControlValue)
                {
                    lblStatPaper.Text = "Paper Count - No Update";
                    lblStatPaper.ForeColor = Color.Salmon;
                    if (txtPaperCount.Text == "0" && txtPaperCount.Text != null)
                        txtPaperCount.Text = "0";
                    else
                        txtPaperCount.Text = txtPaperCount.Text + 0;
                }
            }
            else
            {
                if (txtCode.Text == "0" && txtCode.Text != null)
                    txtCode.Text = "0";
                else
                    txtCode.Text = txtCode.Text + 0;
            }
        }

        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (lblAdminStatus.Text == "Admin")
            {
                if (TabControlValue)
                {
                    ValidateAdmin();
                    lblStatus.Text = "No Update";
                    lblStatus.ForeColor = Color.Salmon;
                    if (txtMultiplier.Text == "0" && txtMultiplier.Text != null)
                        txtMultiplier.Text = txtMultiplier.Text + ".";
                }
                else if (!TabControlValue)
                {
                    lblAdminStatusPaper.Text = "Paper Count - No Update";
                    lblAdminStatusPaper.ForeColor = Color.Salmon;
                    if (txtPaperCount.Text == "0" && txtPaperCount.Text != null)
                        txtPaperCount.Text = "";
                    else
                        txtPaperCount.Text = txtPaperCount.Text + ".";
                }
            }
            else
            {
                if (txtCode.Text == "0" && txtCode.Text != null)
                    txtCode.Text = txtCode.Text + ".";
            }


        }

        private bool ValidateAdmin()
        {
            bool UserStat = false;
            if (lblAdminStatus.Text == "Not Admin")
            {
                if (txtCode.Text == "12345")
                {
                    groupBoxButtons.Enabled = true;
                    lblAdminStatus.Text = "Admin";
                    lblAdminStatusPaper.Text = "Admin";
                    lblAdminStatusPaper.ForeColor = Color.PaleGreen;
                    lblAdminStatus.ForeColor = Color.PaleGreen;
                    panel1.Hide();
                    UserStat = true;
                }
                else
                {
                    var MsgStat = new MessageAlerts();
                    MsgStat.ExceptionMessage("Incorrect Code");
                }
                
            }

            return UserStat;
        }

        private void LoadPaperCount()
        {
            string path = Properties.Settings.Default.AdminPath + "Admin.xml"; // your code goes here

            bool exists = System.IO.Directory.Exists(Properties.Settings.Default.AdminPath);

            if (!exists)
            {
                System.IO.Directory.CreateDirectory(Properties.Settings.Default.AdminPath);
                if (!File.Exists(path))
                {
                    var xml = new XElement("Admin", new XElement("multiplier", 0.0), new XElement("paper", 25));
                    xml.Save(path);
                }
                else
                {
                    var xtr = new XmlTextReader(path);
                    while (xtr.Read())
                    {
                        if (xtr.NodeType == XmlNodeType.Element && xtr.Name == "paper")
                        {
                            txtPaperCount.Text = xtr.ReadElementContentAsString();
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
                        txtPaperCount.Text = xtr.ReadElementContentAsString();
                        xtr.Close();
                    }

                }
            }

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (lblAdminStatus.Text == "Admin")
            {
                if (TabControlValue)
                {
                    if (txtMultiplier.Text != "")
                        txtMultiplier.Text = txtMultiplier.Text.Remove(txtMultiplier.Text.Length - 1, 1);
                }
                else
                {
                    if (txtPaperCount.Text != "")
                        txtPaperCount.Text = txtPaperCount.Text.Remove(txtPaperCount.Text.Length - 1, 1);
                }
            }
            else
            {
                if (txtCode.Text != "")
                    txtCode.Text = txtCode.Text.Remove(txtCode.Text.Length - 1, 1);
            }
           
        }

        private void btnRefillPaper_Click(object sender, EventArgs e)
        {
            try
            {
                    if (Convert.ToInt32(txtPaperCount.Text) > 25)
                    {
                        var MsgStat = new MessageAlerts();
                        MsgStat.ExceptionMessage("Maximum No of Paper : 25");
                    }else
                    {
                        var path = Properties.Settings.Default.AdminPath + "Admin.xml";
                        var xDoc = XDocument.Load(path);
                        var node = xDoc.Descendants("Admin").FirstOrDefault(cd => cd.Element("paper").Value != "");
                        if (node.Name != null || node.Name != "")
                        {
                            node.SetElementValue("paper", txtPaperCount.Text);
                        }
                        xDoc.Save(path);
                        lblStatPaper.Text = "Paper Count - Update";
                        lblStatPaper.ForeColor = Color.PaleGreen;
                        LoadPaperCount();   
                    }
                
            }
            catch (Exception ex)
            {
                var MsgAlert = new MessageAlerts();
                MsgAlert.ExceptionMessage(ex.Message);
            }

        }

        //Detect Changes in the tabControl
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {

            if (tabControl.SelectedTab == tabControl.TabPages[0])//your specific tabname
            {
                //MessageBox.Show("Tab1");
                TabControlValue = true;
            }

            if (tabControl.SelectedTab == tabControl.TabPages[1])
            {

                //MessageBox.Show("Tab2");
                TabControlValue = false;
            }
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            ValidateAdmin();
        }
    }
}
