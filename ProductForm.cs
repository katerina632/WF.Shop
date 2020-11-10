using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6__MultiWindow
{
    
    public partial class ProductForm : Form
    {
        public Product Product { get; set; }
        public bool IsCreate { get; set; }
        public ProductForm(Product product, bool isCreate)
        {
            Product = product;
            IsCreate = isCreate;
            InitializeComponent();

            if (!IsCreate)
            {
                okButton.Text = "Edit";

                nameTextBox.Text = product.Name;
                pricenumericUpDown1.Value = product.Price;
                countNumericUpDown2.Value = product.Quantity;
               discountNumericUpDown3.Value = product.Discount;
                countryComboBox1.SelectedItem = product.Country;
            }
        }

        public void Enabled()
        {
            nameTextBox.Enabled=false;
            pricenumericUpDown1.Enabled = false;
            countNumericUpDown2.Enabled = false;
            discountNumericUpDown3.Enabled = false;
            countryComboBox1.Enabled = false;
        }
        private void okButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(nameTextBox.Text))
            {
                MessageBox.Show("Enter name of the product!");
                return;
            }

            if (countryComboBox1.SelectedIndex==-1)
            {
                MessageBox.Show("Select country!");
                return;
            }
            Product.Name = nameTextBox.Text;
            Product.Price = Convert.ToDecimal(pricenumericUpDown1.Value);
            Product.Discount = Convert.ToDecimal(discountNumericUpDown3.Value);
            Product.Quantity = Convert.ToInt32(countNumericUpDown2.Value);
            Product.Country = countryComboBox1.SelectedItem.ToString();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void canselButton_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
