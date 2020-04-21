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
    public partial class EmployeeUI : Form
    {
        private MainForm mainForm;
        public bool open;
        public EmployeeUI(MainForm f)
        {
            InitializeComponent();
            mainForm = f;
            open = true;
        }

        private void Button1_Click(object sender, EventArgs e)
        {

        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
        }

        private void EmployeeUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            open = false;
            mainForm.Close();
        }
    }
}
