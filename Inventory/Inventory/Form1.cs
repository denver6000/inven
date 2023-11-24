using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void addProductBtn_Click(object sender, EventArgs e)
        {
            string productCateg = categoryComboBox.SelectedItem.ToString();
            string productName = productNameTextBox.Text;
            string productDesc = productDescTextBox.Text;
            
            string productExpDate = expDatePicker.Value.ToString("yyyy-mm-dd");
            string productMfgDate = mfgDatePicker.Value.ToString("yyyy-mm-dd");

            string productPrice = sellPriceTextBox.Text;
            int productAmount = int.Parse(quantityUpDown.Value.ToString());
            try
            {
                gridBindingSource.Add(new Product(productName, productDesc, productMfgDate, productExpDate, productCateg, productAmount, productPrice));
            } catch (ProductFormatException)
            {
                MessageBox.Show("Please select a valid format for each input.");
            } 
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            expDatePicker.CustomFormat = "yyyy-mm-dd";
            mfgDatePicker.CustomFormat = "yyyy-mm-dd";
            categoryComboBox.Items.AddRange(new string[] {"Hygeine", "Food", "Drink", "Hardware"});
            productDataGrid.DataSource = gridBindingSource;
            productDataGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}
