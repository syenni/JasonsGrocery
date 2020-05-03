using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace JasonsGrocery
{
    public partial class PasscodeUI : Form
    {
        private string passcode = "1234";

        public PasscodeUI()
        {
            InitializeComponent();
            MessageBox.Show("Passcode is: 1234");
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (passcode.Equals(PasscodeIDTextbox.Text)) {
                ManagerBaseForm m = new ManagerBaseForm(this);
                m.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Passcode.");
                PasscodeIDTextbox.Clear();
            }
        }

        private void PasscodeUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }
    }
}
