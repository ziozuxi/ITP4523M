using System;
using System.Windows.Forms;
using WindowsFormsApp5.Models;

namespace WindowsFormsApp5.Product
{
    public partial class EditProductForm : Form
    {
        public ProductInfo CurrentProduct { get; private set; }

        public EditProductForm(ProductInfo productToEdit)
        {
            InitializeComponent();
            this.CurrentProduct = productToEdit;
            LoadProductData();
        }

        private void LoadProductData()
        {
            if (this.CurrentProduct != null)
            {
                txtProductID.Text = this.CurrentProduct.ProductID;
                txtProductName.Text = this.CurrentProduct.ProductName;
                numPrice.Value = this.CurrentProduct.Price;
                txtTarget.Text = this.CurrentProduct.Target;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (this.CurrentProduct != null)
            {
                this.CurrentProduct.ProductName = txtProductName.Text;
                this.CurrentProduct.Price = numPrice.Value;
                this.CurrentProduct.Target = txtTarget.Text;

                if (string.IsNullOrWhiteSpace(this.CurrentProduct.ProductName))
                {
                    MessageBox.Show("产品名称不能为空。", "验证错误", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtProductName.Focus();
                    return;
                }

                this.DialogResult = DialogResult.OK;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void EditProductForm_Load(object sender, EventArgs e)
        {

        }
    }
}