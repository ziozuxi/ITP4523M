using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp5.Models; 

namespace WindowsFormsApp5.Product 
{
    public partial class ProductInfoview : Form
    {
        private ProductInfo currentProduct; 

        
        public ProductInfoview()
        {
            InitializeComponent();
        }

        
        public ProductInfoview(ProductInfo product) : this() 
        {
            currentProduct = product;
            DisplayProductDetails(); 
        }

     
        public void LoadProductData(ProductInfo product)
        {
            currentProduct = product;
            DisplayProductDetails();
        }

        private void DisplayProductDetails()
        {
            if (currentProduct != null)
            {
                textBox1.Text = currentProduct.ProductName;
                textBox2.Text = currentProduct.ProductID;
                textBox3.Text = currentProduct.Price.ToString("F2");

              
            }
            else
            {
               
                textBox1.Text = "N/A";
                textBox2.Text = "N/A";
                textBox3.Text = "0.00";
            }
        }

        private void btnBuy_Click(object sender, EventArgs e)
        {
           
            if (currentProduct != null)
            {
                MessageBox.Show($"You clicked Buy '{currentProduct.ProductName}'！\nID: {currentProduct.ProductID}\nprice: {currentProduct.Price:C}");
                
            }
            else
            {
                MessageBox.Show("There is no product information available for purchase.");
            }
        }

     
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void ProductInfoview_Load(object sender, EventArgs e)
        {

        }
    }
}