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
        private uxProductQueryUI manager;
        public MainForm()
        {
            InitializeComponent();
            manager = new uxProductQueryUI(this);
            employee = new EmployeeUI(this);
        }

        private void MangerButton_Click(object sender, EventArgs e)
        {
            manager.Show();
            this.Hide();
        }

        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            employee.Show();
            this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if(manager.open == true)
            {
                manager.Close();
            }
            if (employee.open == true)
            {
                employee.Close();
            }
        }
    }
}
