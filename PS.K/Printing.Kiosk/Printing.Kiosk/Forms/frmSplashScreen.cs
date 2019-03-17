using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Printing.Kiosk.Forms
{
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
            
        }

        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            this.BackColor = Color.Gray;
            this.TransparencyKey = Color.DimGray;
        }
    }
}
