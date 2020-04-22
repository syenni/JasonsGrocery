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
    public partial class EmployeeQueryUI : Form
    {
        private ManagerBaseForm baseForm;
        public bool open;

        public EmployeeQueryUI(ManagerBaseForm f)
        {
            InitializeComponent();
            baseForm = f;
            open = true;
        }

        private void EmployeeQueryUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            open = false;
            baseForm.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            baseForm.Show();
        }
    }
}
