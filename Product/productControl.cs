using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using WindowsFormsApp5.Models;

namespace WindowsFormsApp5.Product
{
    public partial class productControl : Form
    {
        private List<ProductInfo> loadedProducts = new List<ProductInfo>();

        public productControl()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadProductsFromDB();
            DisplayProductsOnUI();
        }

        private string GetConnectionString()
        {
            string server = "127.0.0.1";
            string userId = "root";
            string password = "";
            string databaseName = "sstoy_db";

            return $"server={server};uid={userId};pwd={password};database={databaseName};";
        }

        private void LoadProductsFromDB()
        {
            loadedProducts.Clear();
            string connStr = GetConnectionString();

            using (MySqlConnection connection = new MySqlConnection(connStr))
            {
                try
                {
                    connection.Open();
                    string sql = "SELECT productID, productName, price, target FROM productlist";
                    MySqlCommand cmd = new MySqlCommand(sql, connection);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            ProductInfo product = new ProductInfo
                            {
                                ProductID = reader["productID"].ToString(),
                                ProductName = reader["productName"].ToString(),
                                Price = Convert.ToDecimal(reader["price"]),
                                Target = reader["target"].ToString()
                            };
                            loadedProducts.Add(product);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL Connection Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading products: " + ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void DisplayProductsOnUI()
        {
            if (loadedProducts.Count > 0) { productNameLabel.Text = loadedProducts[0].ProductName; }
            else { productNameLabel.Text = "Product 1 Name"; }

            if (loadedProducts.Count > 1) { label2.Text = loadedProducts[1].ProductName; }
            else { label2.Text = "Product 2 Name"; }

            if (loadedProducts.Count > 2) { label6.Text = loadedProducts[2].ProductName; }
            else { label6.Text = "Product 3 Name"; }

            if (loadedProducts.Count > 3) { label5.Text = loadedProducts[3].ProductName; }
            else { label5.Text = "Product 4 Name"; }

            if (loadedProducts.Count > 4) { label8.Text = loadedProducts[4].ProductName; }
            else { label8.Text = "Product 5 Name"; }
        }

        private void ShowProductInfoDetailForm(ProductInfo product)
        {
            if (product != null)
            {
                ProductInfoview productInfoForm = new ProductInfoview(product);
                productInfoForm.ShowDialog();
            }
        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {
            if (loadedProducts.Count > 0) ShowProductInfoDetailForm(loadedProducts[0]);
        }
        private void productNameLabel_Click_1(object sender, EventArgs e)
        {
            if (loadedProducts.Count > 0) ShowProductInfoDetailForm(loadedProducts[0]);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            if (loadedProducts.Count > 1) ShowProductInfoDetailForm(loadedProducts[1]);
        }
        private void label2_Click_2(object sender, EventArgs e)
        {
            if (loadedProducts.Count > 1) ShowProductInfoDetailForm(loadedProducts[1]);
        }
        private void pictureBox6_Click(object sender, EventArgs e)
        {
            if (loadedProducts.Count > 2) ShowProductInfoDetailForm(loadedProducts[2]);
        }
        private void label6_Click(object sender, EventArgs e)
        {
            if (loadedProducts.Count > 2) ShowProductInfoDetailForm(loadedProducts[2]);
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (loadedProducts.Count > 3) ShowProductInfoDetailForm(loadedProducts[3]);
        }
        private void label5_Click(object sender, EventArgs e)
        {
            if (loadedProducts.Count > 3) ShowProductInfoDetailForm(loadedProducts[3]);
        }
        private void pictureBox8_Click(object sender, EventArgs e)
        {
            if (loadedProducts.Count > 4) ShowProductInfoDetailForm(loadedProducts[4]);
        }
        private void label8_Click(object sender, EventArgs e)
        {
            if (loadedProducts.Count > 4) ShowProductInfoDetailForm(loadedProducts[4]);
        }

        private void clearOrderButton_Click(object sender, EventArgs e)
        {
            if (orderedItemsDataGridView != null)
            {
                orderedItemsDataGridView.Rows.Clear();
            }
        }

        private void viewproduct_Click(object sender, EventArgs e)
        {
            try
            {
                WindowsFormsApp5.Product.viewproduct.viewproduct productViewForm = new WindowsFormsApp5.Product.viewproduct.viewproduct();
                productViewForm.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not open product view form: " + ex.Message + "\nPlease ensure the 'WindowsFormsApp5.Product.viewproduct.viewproduct' form exists and is correct.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void checkoutButton_Click(object sender, EventArgs e)
        {
            checkoutform.Form1 outcheckFormInstance = new checkoutform.Form1();
            outcheckFormInstance.ShowDialog();
        }

        private void orderedItemsDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void panel9_Paint(object sender, PaintEventArgs e) { }
        private void searchTextBox_TextChanged(object sender, EventArgs e) { }
        private void button1_Click_1(object sender, EventArgs e) { }
        private void categoryComboBox_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}