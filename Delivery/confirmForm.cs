using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.Delivery
{
    public partial class confirmForm : Form
    {
        public string InputText => textBoxInput.Text;

        public confirmForm(string prompt)
        {
            InitializeComponent();
            labelPrompt.Text = prompt;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxInput.Text))
                this.DialogResult = DialogResult.OK;
            else
                MessageBox.Show("Please enter a Delivery ID.", "Input Required");
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }
    }
}
