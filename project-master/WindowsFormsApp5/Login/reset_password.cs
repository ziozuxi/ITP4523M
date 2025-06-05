using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp5.LoginForm
{
    public partial class reset_password : Form
    {
        public reset_password()
        {
            InitializeComponent();
            this.Text = "Reset Password";
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            string username = txtUsername.Text.Trim();
            string email = txtEmail.Text.Trim();

            // Example: Replace with your actual user validation logic
            if (IsValidUser(username, email))
            {
                // Reset password logic here
                MessageBox.Show("Password reset successful.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Invalid username or email.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnGoBack_Click(object sender, EventArgs e)
        {
            this.Close();
            // Optionally, show the login form again:
            // var loginForm = new Login();
            // loginForm.Show();
        }

        // Dummy validation method for demonstration
        private bool IsValidUser(string username, string email)
        {
            // Replace with actual user lookup logic
            return username == "admin" && email == "admin@example.com";
        }

        private void reset_password_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Dispose();
            Login lg = new Login();
            lg.Show();
        }
    }
}
