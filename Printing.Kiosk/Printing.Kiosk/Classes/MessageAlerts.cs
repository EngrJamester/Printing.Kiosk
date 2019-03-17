using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Printing.Kiosk.Classes
{
    public class MessageAlerts
    {
        public void ExceptionMessage(string Message)
        {
            MessageBox.Show(Message,"Transaction Status");
        }

        public int ShowDialog(string text, string caption)
        {
            Form prompt = new Form();
            int num=0;
            prompt.Width = 500;
            prompt.Height = 200;
            prompt.Text = caption;
            prompt.StartPosition = FormStartPosition.CenterScreen;
            Label textLabel = new Label() { Left = 50, Top = 60, Text = text };
            //NumericUpDown inputBox = new NumericUpDown() { Left = 50, Top = 50, Width = 400 };
            Button confirmation = new Button() { Text = "Ok", Left = 350, Width = 100,Height=70, Top = 70 };
            confirmation.Click += (sender, e) => { prompt.Close(); num = 1; };
            prompt.Controls.Add(confirmation);
            prompt.Controls.Add(textLabel);
            //prompt.Controls.Add(inputBox);
            prompt.ShowDialog();
            return num;
        }
    }
}
