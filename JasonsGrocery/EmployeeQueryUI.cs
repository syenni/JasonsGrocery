using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EmployeeData;

namespace JasonsGrocery
{
    public partial class EmployeeQueryUI : Form
    {
        private ManagerBaseForm baseForm;
        public bool open;
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=JasonsGrocery;Integrated Security=SSPI;";
        private IEmployeeRepository repo;

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

        public void UncheckRadioButtons(RadioButton r)
        {
            if (r != DeliRadioButton)
            {
                DeliRadioButton.Checked = false;
            }
            if (r != BakeryRadioButton)
            {
                BakeryRadioButton.Checked = false;
            }
            if (r != DairyRadioButton)
            {
                DairyRadioButton.Checked = false;
            }
            if (r != ProduceRadioButton)
            {
                ProduceRadioButton.Checked = false;
            }
        }

        private void ProduceRadioButton_Click(object sender, EventArgs e)
        {
            UncheckRadioButtons(ProduceRadioButton);
        }

        private void BakeryRadioButton_Click(object sender, EventArgs e)
        {
            UncheckRadioButtons(BakeryRadioButton);
        }

        private void DairyRadioButton_Click(object sender, EventArgs e)
        {
            UncheckRadioButtons(DairyRadioButton);
        }

        private void DeliRadioButton_Click(object sender, EventArgs e)
        {
            UncheckRadioButtons(DeliRadioButton);
        }

        private void UxListOfEmployees_Click(object sender, EventArgs e)
        {
            repo = new SqlEmployeeRepository(connectionString);
            uxdataGridView.Columns.Clear();
            uxdataGridView.Columns.Add("EmployeeID", "Employee ID");
            uxdataGridView.Columns.Add("EmployeeName", "Employee Name");
            uxdataGridView.Columns.Add("PositionName", "Work Position");

            if (DairyRadioButton.Checked)
            {
                var employees = repo.RetrieveEmployeesInDepartment(3); //Dairy's ID = 3

                foreach (var y in employees)
                {
                    uxdataGridView.Rows.Add(y.EmployeeID, y.EmployeeName, y.PositionName);
                }
            }
            else if (DeliRadioButton.Checked)
            {
                var employees = repo.RetrieveEmployeesInDepartment(2); //Deli's ID = 2

                foreach (var y in employees)
                {
                    uxdataGridView.Rows.Add(y.EmployeeID, y.EmployeeName, y.PositionName);
                }
            }
            else if (ProduceRadioButton.Checked)
            {
                var employees = repo.RetrieveEmployeesInDepartment(1); //Produce's ID = 1

                foreach (var y in employees)
                {
                    uxdataGridView.Rows.Add(y.EmployeeID, y.EmployeeName, y.PositionName);
                }
            }
            else if (BakeryRadioButton.Checked)
            {
                var employees = repo.RetrieveEmployeesInDepartment(4); //Bakery's ID = 4

                foreach (var y in employees)
                {
                    uxdataGridView.Rows.Add(y.EmployeeID, y.EmployeeName, y.PositionName);
                }
            }
        }

        private void UxAverageEmployeeSalary_Click(object sender, EventArgs e)
        {
            string positionName = uxWorkPositionList.SelectedItem.ToString();
            repo = new SqlEmployeeRepository(connectionString);
            uxdataGridView.Columns.Clear();
            uxdataGridView.Columns.Add("PositionName", "Position Name");
            uxdataGridView.Columns.Add("Salary", "Average Salary");
            

        }
    }
}
