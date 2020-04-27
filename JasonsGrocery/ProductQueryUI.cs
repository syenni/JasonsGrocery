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
    public partial class uxProductQueryUI : Form
    {
        private ManagerBaseForm baseForm;
        public bool open;
        const string connectionString = @"Server=Seth-PC\SQLEXPRESS;Database=JasonsGrocery;User Id=Ryan;Password=1781;"; //Integrated Security=SSPI;
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
            uxdataGridView.DataSource = repo.RetrieveProducts(2); //Test to retrieve the productID 2
            
            /*if (DairyRadioButton.Checked)
            {
                uxdataGridView.DataSource = RetrieveProductsForDepartmentDataDelegate;
            }
            else if (DeliRadioButton.Checked)
            {
                uxdataGridView.DataSource = RetrieveProductsForDepartmentDataDelegate;
            }
            else if (ProduceRadioButton.Checked)
            {
                uxdataGridView.DataSource = RetrieveProductsForDepartmentDataDelegate;
            }
            else if (BakeryRadioButton.Checked)
            {
                uxdataGridView.DataSource = RetrieveProductsForDepartmentDataDelegate;
            }*/
        }
    }
}
