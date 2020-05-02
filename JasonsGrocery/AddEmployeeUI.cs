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
    public partial class AddEmployeeUI : Form
    {
        public EmployeeQueryUI employeeQueryUI;

        public AddEmployeeUI(EmployeeQueryUI form)
        {
            InitializeComponent();
            employeeQueryUI = form;
            employeeQueryUI.Enabled = false;
        }

        private void uxAddEmployeeButton_Click(object sender, EventArgs e)
        {
            employeeQueryUI.addEmployeeInfo(uxEmployeeNameTextBox.Text, uxWorkPositionComboBox.SelectedItem.ToString(),
                uxDeparmentNameComboBox.SelectedItem.ToString(), (double)uxHourlyPayNumericUpDown.Value);
            employeeQueryUI.Enabled = true;
            Close();
        }

        private void uxEmployeeNameTextBox_TextChanged(object sender, EventArgs e)
        {
            if(uxEmployeeNameTextBox.Text != "")
            {
                uxDeparmentNameComboBox.Enabled = true;
            }
            else
            {
                uxDeparmentNameComboBox.Enabled = false;
            }
        }

        private void uxDeparmentNameComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxWorkPositionComboBox.Enabled = true;
        }

        private void uxWorkPositionComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxHourlyPayNumericUpDown.Enabled = true;
            uxAddEmployeeButton.Enabled = true;
        }

        private void AddEmployeeUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            employeeQueryUI.Enabled = true;
        }
    }
}
