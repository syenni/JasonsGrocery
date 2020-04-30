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
using StoreData;

namespace JasonsGrocery
{
    public partial class uxProductQueryUI : Form
    {
        private ManagerBaseForm baseForm;
        public bool open;
        const string connectionString = @"Server=(localdb)\MSSQLLocalDb;Database=JasonsGrocery;Integrated Security=SSPI;";
        private IProductRepository repo;

        public uxProductQueryUI(ManagerBaseForm f)
        {
            InitializeComponent();
            baseForm = f;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            baseForm.Show();
        }
        
        public void UncheckRadioButtons(RadioButton r)
        {
            if(r != DeliRadioButton)
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

        private void ManagerUI_FormClosed(object sender, FormClosedEventArgs e)
        {
            open = false;
            baseForm.Close();
        }

        private void UxCheckItemStock_Click(object sender, EventArgs e)
        {
            repo = new SqlProductRepository(connectionString);
            uxdataGridView.Columns.Clear();
            uxdataGridView.Columns.Add("ProductName", "Product Name");
            uxdataGridView.Columns.Add("UnitPrice", "Unit Price");

            if (DairyRadioButton.Checked)
            {
                var products = repo.RetrieveProducts(3); //Dairy's ID = 3

                foreach (var y in products)
                {
                    uxdataGridView.Rows.Add(y.ProductName, y.UnitPrice);
                }
            }
            else if (DeliRadioButton.Checked)
            {
                var products = repo.RetrieveProducts(2); //Deli's ID = 2

                foreach (var y in products)
                {
                    uxdataGridView.Rows.Add(y.ProductName, y.UnitPrice);
                }
            }
            else if (ProduceRadioButton.Checked)
            {
                var products = repo.RetrieveProducts(1); //Produce's ID = 1

                foreach (var y in products)
                {
                    uxdataGridView.Rows.Add(y.ProductName, y.UnitPrice);
                }
            }
            else if (BakeryRadioButton.Checked)
            {
                var products = repo.RetrieveProducts(4); //Bakery's ID = 4

                foreach (var y in products)
                {
                    uxdataGridView.Rows.Add(y.ProductName, y.UnitPrice);
                }
            }
        }

        private void uxItemUnderQuantity_Click(object sender, EventArgs e)
        {
            repo = new SqlProductRepository(connectionString);
            int quantity = (int)uxNumericUpDown.Value;
            uxdataGridView.Columns.Clear();
            uxdataGridView.Columns.Add("ProductName", "Product Name");
            uxdataGridView.Columns.Add("StockQuantity", "Stock Quantity");

            var products = repo.RetrieveProductsUnderCount(quantity); //Dairy's ID = 3

            foreach (var y in products)
            {
                uxdataGridView.Rows.Add(y.ProductName, y.StockQuantity);
            }
            
        }

    }
}
