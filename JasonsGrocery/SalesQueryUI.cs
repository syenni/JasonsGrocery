using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepartmentData;
using ProductData;

namespace JasonsGrocery
{
    public partial class SalesQueryUI : Form
    {
        private ManagerBaseForm baseForm;
        public bool open;
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=JasonsGrocery;Integrated Security=SSPI;";
        private ISalesRepository repo;

        public SalesQueryUI(ManagerBaseForm f)
        {
            InitializeComponent();
            baseForm = f;
            open = true;
        }

        private void SalesQueryUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            open = false;
            baseForm.Close();
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            baseForm.Show();
        }

        private void UxDailySales_Click(object sender, EventArgs e)
        {
            DateTime date = uxdateTimePicker.Value.Date;
            //string year = date.Year.ToString();
            //string month = date.Month.ToString();
            //string day = date.Day.ToString();
            repo = new SqlSalesRepository(connectionString);
            uxdataGridView.Columns.Clear();
            uxdataGridView.Columns.Add("ProductName", "Product Name");
            uxdataGridView.Columns.Add("AmountOfProductsSold", "Amount Sold");
            uxdataGridView.Columns.Add("UnitPrice", "Unit Price");
            uxdataGridView.Columns.Add("TotalSales", "Total Sales");

            var sales = repo.RetrieveDailySales(date); 

            foreach(var sale in sales)
            {
                uxdataGridView.Rows.Add(sale.ProductName,
                    sale.AmountOfProductsSold,
                    "$"+ sale.UnitPrice,
                    "$"+sale.TotalSales);
            }
        }
    }
}
