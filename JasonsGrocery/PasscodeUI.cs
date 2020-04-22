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
        MainForm form;
        private string passcode = "42069";

        public PasscodeUI(MainForm f)
        {
            InitializeComponent();
            form = f;
        }

        private void LogInButton_Click(object sender, EventArgs e)
        {
            if (passcode.Equals(PasscodeIDTextbox.Text)) {
                ManagerBaseForm m = new ManagerBaseForm();
                m.Show();
                this.Hide();
            }
            else
            {
                form.Show();
                this.Hide();
            }
        }

        private void PasscodeUI_FormClosing(object sender, FormClosingEventArgs e)
        {
            form.Close();
        }
    }
}
