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
    public partial class MainForm : Form
    {
        private EmployeeUI employee;
        private PasscodeUI passcode;
        public MainForm()
        {
            InitializeComponent();
        }

        private void MangerButton_Click(object sender, EventArgs e)
        {
            passcode = new PasscodeUI(this);
            passcode.Show();
            this.Hide();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            employee = new EmployeeUI(this);
            employee.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }
    }
}
