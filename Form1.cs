using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _6__MultiWindow
{
    public partial class Form1 : Form
    {
        List<Product> products;
        public Form1()
        {
            InitializeComponent();
            products = new List<Product>();
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            Product product = new Product();

            var prodForm = new ProductForm(product, true);


            if (prodForm.ShowDialog() == DialogResult.OK)
            {
                productListBox.Items.Add(product);
            }
        }

        private void delButton_Click(object sender, EventArgs e)
        {
            if (NoSelectedOrEmptyList())
            {
                productListBox.Items.RemoveAt(productListBox.SelectedIndex);
            }
        }

        private void infoButton_Click(object sender, EventArgs e)
        {
            if (NoSelectedOrEmptyList())
            {

                int index = productListBox.SelectedIndex;
                Product p = (Product)productListBox.Items[index];

                ProductForm prodForm = new ProductForm(p, false);
                prodForm.Enabled();
                prodForm.ShowDialog();
            }
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            if (NoSelectedOrEmptyList())
            {
                int index = productListBox.SelectedIndex;

                Product p = productListBox.SelectedItem as Product;

                ProductForm prodForm = new ProductForm(p, false);

                if (prodForm.ShowDialog() == DialogResult.OK)
                {
                    productListBox.Items.RemoveAt(index);
                    productListBox.Items.Insert(index, p);
                    productListBox.SelectedIndex = index;
                }
            }
        }

        private bool NoSelectedOrEmptyList()
        {
            if (productListBox.Items.Count == 0)
            {
                MessageBox.Show("List of producrs is empty!");
                return false;
            }
            if (productListBox.SelectedIndex == -1 && productListBox.Items.Count > 0)
            {
                MessageBox.Show("Select the product at first!");
                return false;
            }
            return true;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            foreach (var item in productListBox.Items)
            {
                products.Add((Product)item);
            }

            SaveFileDialog save = new SaveFileDialog();            
           
            save.OverwritePrompt = true;
            save.DefaultExt = ".bin";

            if (save.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter binFormat = new BinaryFormatter();

                try
                {
                    using (Stream fStream = File.Create(save.FileName))
                    {
                        binFormat.Serialize(fStream, products);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }
            }

            products.Clear();
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            
            OpenFileDialog open = new OpenFileDialog();

            open.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop); 
            
            open.Filter = "Binary Files(*.bin)|*.bin||";
           
            open.CheckFileExists = true;          

            if (open.ShowDialog() == DialogResult.OK)
            {
                BinaryFormatter binFormat = new BinaryFormatter();
               
                try
                {
                    using (Stream fStream = File.OpenRead(open.FileName))
                    {
                       products = (List<Product>)binFormat.Deserialize(fStream);
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                }


                productListBox.Items.Clear();
                
                foreach (var item in products)
                {
                    productListBox.Items.Add(item);
                }
                products.Clear();
            }
        }
    }
}
