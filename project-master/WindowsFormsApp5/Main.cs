using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
            this.Load += Main_Load;
        }

        private void sidebar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Main_Load(object sender, EventArgs e)
        {
            ShowHomePage();
        }

        private void ShowHomePage()
        {
            panel3.Controls.Clear();
            Home homeForm = new Home();
            homeForm.TopLevel = false;
            homeForm.FormBorderStyle = FormBorderStyle.None;
            homeForm.Dock = DockStyle.Fill;
            panel3.Dock = DockStyle.Fill;
            panel3.Controls.Add(homeForm);
            homeForm.Show();
        }


        private void ProcessBtn_Click(object sender, EventArgs e)
        {
            ShowDeliveryPage();
        }

        private void ShowDeliveryPage()
        {
            panel3.Controls.Clear();
            Delivery.Delivery deliveryForm = new Delivery.Delivery();
            deliveryForm.TopLevel = false;
            deliveryForm.FormBorderStyle = FormBorderStyle.None;
            deliveryForm.Dock = DockStyle.Fill;
            panel3.Dock = DockStyle.Fill;
            panel3.Controls.Add(deliveryForm);
            deliveryForm.Show();
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            ShowHomePage();
        }

        private void prodBtn_Click(object sender, EventArgs e)
        {
            ShowProductPage();
        }

        private void ShowProductPage()
        {
            panel3.Controls.Clear();
            Product.productControl productForm = new Product.productControl();
            productForm.TopLevel = false;
            productForm.FormBorderStyle = FormBorderStyle.None;
            productForm.Dock = DockStyle.Fill;
            panel3.Dock = DockStyle.Fill;
            panel3.Controls.Add(productForm);
            productForm.Show();
        }

        private void Inventory_Click(object sender, EventArgs e)
        {
            ShowInventoryPage();
        }

        private void ShowInventoryPage()
        {
            panel3.Controls.Clear();
            Inventory.Inventory inventoryForm = new Inventory.Inventory();
            inventoryForm.TopLevel = false;
            inventoryForm.FormBorderStyle = FormBorderStyle.None;
            inventoryForm.Dock = DockStyle.Fill;
            panel3.Dock = DockStyle.Fill;
            panel3.Controls.Add(inventoryForm);
            inventoryForm.Show();
        }
    }
}
