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
    public partial class uxProductQueryUI : Form
    {
        private MainForm mainForm;
        public bool open;
        public uxProductQueryUI(MainForm f)
        {
            InitializeComponent();
            mainForm = f;
            open = true;
        }

        private void BackButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            mainForm.Show();
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
            mainForm.Close();
        }
    }
}
