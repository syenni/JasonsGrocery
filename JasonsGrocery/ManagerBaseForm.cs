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
    public partial class ManagerBaseForm : Form
    {
        SalesQueryUI sales;
        uxProductQueryUI product;
        EmployeeQueryUI employee;
        PasscodeUI passcode;
        public ManagerBaseForm(PasscodeUI p)
        {
            InitializeComponent();
            passcode = p;
        }

        private void SalesButton_Click(object sender, EventArgs e)
        {
            sales = new SalesQueryUI(this);
            sales.Show();
            this.Hide();
        }

        private void ProductButton_Click(object sender, EventArgs e)
        {
            product = new uxProductQueryUI(this);
            product.Show();
            this.Hide();
        }
        private void EmployeeButton_Click(object sender, EventArgs e)
        {
            employee = new EmployeeQueryUI(this);
            employee.Show();
            this.Hide();
        }

        private void ManagerBaseForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (product != null && product.open == true)
            {
                product.Close();
            }
            if (sales != null && sales.open == true)
            {
                sales.Close();
            }
            if (employee != null && employee.open == true)
            {
                employee.Close();
            }
            passcode.Close();
        }
    }
}
