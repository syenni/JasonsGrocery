using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

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

        //HoursWorkedButton
        private void Button1_Click(object sender, EventArgs e)
        {
            string connectionString = @"Data Source = (localdb)\MSSQLLocalDb; Initial Catalog = bhartman; Integrated Security = True;";
            using (SqlConnection sqlConnection = new SqlConnection(connectionString))
            {
                string script = File.ReadAllText(@"JasonsGrocery\PersonData\Sql\Procedures\Person.FetchPerson");
                sqlConnection.Open();
                SqlDataAdapter sqlData = new SqlDataAdapter(script, sqlConnection);
                DataTable dataTable = new DataTable();
                sqlData.Fill(dataTable);
                uxDataGrid.DataSource = dataTable;
            }
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
