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
using WorkPositionData;
using StoreData.Models;

namespace JasonsGrocery
{
    public partial class EmployeeQueryUI : Form
    {
        private ManagerBaseForm baseForm;
        public bool open;
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=JasonsGrocery;Integrated Security=SSPI;";
        private IEmployeeRepository repo;
        private IWorkPositionRepository repo2;
        private ITimeEntryRepository repo3;

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

        private void UxAverageWorkPositionSalary_Click(object sender, EventArgs e)
        {
            //string positionName = uxWorkPositionList.SelectedItem.ToString();
            repo2 = new SqlWorkPositionRepository(connectionString);
            uxdataGridView.Columns.Clear();
            uxdataGridView.Columns.Add("PositionName", "Position Name");
            uxdataGridView.Columns.Add("Salary", "Average Salary");

            var employees = repo2.RetrieveWorkPositionsAvgSalary();

            foreach(var workposition in employees)
            {
                uxdataGridView.Rows.Add(workposition.PositionName,
                    workposition.HourlyPay);
            }
        }

        private void uxAddNewEmployeeButton_Click(object sender, EventArgs e)
        {
            AddEmployeeUI addEmployeeUI = new AddEmployeeUI(this);
            addEmployeeUI.Show();
        }

        public void addEmployeeInfo(string employeeName, string workPosition, string departmentName, double hourlyPay)
        {
            /*int workPositionID = 0;
            switch(workPosition)
            {
                case "Manager":
                    workPositionID = (int) WorkPositionType.Manager;
                    break;
                case "Cashier":
                    workPositionID = (int)WorkPositionType.Cashier;
                    break;
                case "Clerk":
                    workPositionID = (int)WorkPositionType.Clerk;
                    break;
                case "Janitor":
                    workPositionID = (int)WorkPositionType.Janitor;
                    break;
                case "Director":
                    workPositionID = (int)WorkPositionType.Director;
                    break;
                case "AssistantManager":
                    workPositionID = (int)WorkPositionType.AssistantManager;
                    break;
            }

            int departmentID = 0;
            switch (workPosition)
            {
                case "Bakery":
                    departmentID = (int)DepartmentType.Bakery;
                    break;
                case "Deli":
                    departmentID = (int)DepartmentType.Deli;
                    break;
                case "Produce":
                    departmentID = (int)DepartmentType.Produce;
                    break;
                case "Dairy":
                    departmentID = (int)DepartmentType.Dairy;
                    break;
            }*/
            //execute query
            repo = new SqlEmployeeRepository(connectionString);
            uxdataGridView.Columns.Clear();
            var employee = repo.CreateEmployee(employeeName, workPosition, departmentName, hourlyPay);
            if (employee != null)
            {
                if (departmentName.Equals("Produce"))
                {
                    MessageBox.Show("Employee Added Successfully to Produce Department");
                }
                else if (departmentName.Equals("Deli"))
                {
                    MessageBox.Show("Employee Added Successfully to Deli Department");
                }
                else if (departmentName.Equals("Dairy"))
                {
                    MessageBox.Show("Employee Added Successfully to Dairy Department");
                }
                else if (departmentName.Equals("Bakery"))
                {
                    MessageBox.Show("Employee Added Successfully to Bakery Department");
                }
            }
            else MessageBox.Show("Error in adding Employee");

        }

        private void DeliRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            uxListOfEmployees.Enabled = true;
        }

        private void ProduceRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            uxListOfEmployees.Enabled = true;
        }

        private void DairyRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            uxListOfEmployees.Enabled = true;
        }

        private void BakeryRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            uxListOfEmployees.Enabled = true;
        }

        private void UxCalculateHoursWorked_Click(object sender, EventArgs e)
        {
            int month = 1;
            switch (uxSelectMonthComboBox.SelectedItem.ToString()) {
                case "March":
                    month = 3;
                    break;
                case "April":
                    month = 4;
                    break;

            }
            DateTime date = new DateTime(Int32.Parse(uxSelectYearComboBox.SelectedItem.ToString()), month, 1);
            repo3 = new SqlTimeEntryRepository(connectionString);
            uxdataGridView.Columns.Clear();
            uxdataGridView.Columns.Add("EmployeeName", "Employee Name");
            uxdataGridView.Columns.Add("HoursWorked", "Hours Worked");
            
            var employees = repo3.RetrieveHoursWorked(date);

            foreach (var employee in employees)
            {
                uxdataGridView.Rows.Add(employee.EmployeeName,
                    employee.HoursWorked);
            }
        }

        private void uxSelectYearComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxSelectMonthComboBox.Enabled = true;
        }

        private void uxSelectMonthComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            uxCalculateHoursWorked.Enabled = true;
        }
    }
}
