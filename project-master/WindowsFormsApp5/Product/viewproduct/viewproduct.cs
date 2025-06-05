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

namespace WindowsFormsApp5.Product.viewproduct
{
    public partial class viewproduct : Form
    {
        public viewproduct()
        {
            InitializeComponent();
            dataGridView1.AutoGenerateColumns = false;
        }

        private void viewproduct_Load_1(object sender, EventArgs e)
        {
            LoadDataToGrid();
        }

        private string GetConnectionString()
        {
            string server = "127.0.0.1";
            string userId = "root";
            string password = "";
            string databaseName = "sstoy_db";

            return $"server={server};uid={userId};pwd={password};database={databaseName};";
        }

        private void LoadDataToGrid()
        {
            List<ProductInfo> productList = new List<ProductInfo>();
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
                            productList.Add(product);
                        }
                    }
                }
                catch (MySqlException ex)
                {
                    MessageBox.Show("MySQL Connection Error: " + ex.Message, "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error loading product data: " + ex.Message, "Application Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = productList;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
                return;

            if (dataGridView1.Columns[e.ColumnIndex].Name == "colEdit")
            {
                if (dataGridView1.Rows[e.RowIndex].DataBoundItem is ProductInfo productToEdit)
                {
                    EditProductForm editForm = new EditProductForm(productToEdit);
                    DialogResult result = editForm.ShowDialog();

                    if (result == DialogResult.OK)
                    {
                        dataGridView1.Refresh();
                        MessageBox.Show("Product view updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else if (dataGridView1.Columns[e.ColumnIndex].Name == "colDelete")
            {
                if (dataGridView1.Rows[e.RowIndex].DataBoundItem is ProductInfo productToDelete)
                {
                    DialogResult confirmResult = MessageBox.Show($"Are you sure you want to delete product: {productToDelete.ProductName} (ID: {productToDelete.ProductID})?",
                                                                 "Confirm Delete",
                                                                 MessageBoxButtons.YesNo,
                                                                 MessageBoxIcon.Warning);
                    if (confirmResult == DialogResult.Yes)
                    {
                        MessageBox.Show($"Product '{productToDelete.ProductName}' delete functionality not fully implemented yet.", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
        }
        private void label1_Click(object sender, EventArgs e) { }
        private void dataGridView1_Click(object sender, EventArgs e) { }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Search button clicked. Search functionality not yet implemented.");
        }
        private void cmbCategoryFilter_SelectedIndexChanged(object sender, EventArgs e) { }
    }
}