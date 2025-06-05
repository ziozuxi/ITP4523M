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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
            // Optional: Set form title
            this.Text = "Smile & Sunshine Toy Company - Login";
        }


        private void txtUsername_Enter(object sender, EventArgs e)
        {
            if (this.txtUsername.Text == "Please enter your username")
            {
                this.txtUsername.Text = "";
                this.txtUsername.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void txtUsername_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtUsername.Text))
            {
                this.txtUsername.Text = "Please enter your username";
                this.txtUsername.ForeColor = System.Drawing.Color.Silver;
            }
        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (this.txtPassword.Text == "Please enter your password")
            {
                this.txtPassword.Text = "";
                this.txtPassword.ForeColor = System.Drawing.Color.Black;
                this.txtPassword.UseSystemPasswordChar = true;
            }
        }

        private void txtPassword_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(this.txtPassword.Text))
            {
                this.txtPassword.Text = "Please enter your password";
                this.txtPassword.ForeColor = System.Drawing.Color.Silver;
                this.txtPassword.UseSystemPasswordChar = false;
            }
        }

        private void lblWelcome_Click(object sender, EventArgs e)
        {

        }

        private void lblWelcomeMsg_Click(object sender, EventArgs e)
        {

        }

        private void linkForgot_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            reset_password resetPwd = new reset_password();
            resetPwd.ShowDialog();
        }

        private void btnSignIn_Click(object sender, EventArgs e)
        {
            this.btnSignIn.Enabled = false;
            string username = txtUsername.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (username == "Please enter your username" || password == "Please enter your password")
            {
                MessageBox.Show("Please enter your username and password.");
                this.btnSignIn.Enabled = true;
                return;
            }

            if (AuthenticateUser(username, password))
            {
                LoadMain();
            }
            else
            {
                MessageBox.Show("Invalid username or password.", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.btnSignIn.Enabled = true;
            }
        }

        private bool AuthenticateUser(string username, string password)
        {
            try
            {
                var usersTable = new sstoy_dbDataSet.usersDataTable();
                var usersAdapter = new sstoy_dbDataSetTableAdapters.usersTableAdapter();
                usersAdapter.Fill(usersTable);

                return usersTable.Any(row => row.userID == username && row.password == password);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database error: " + ex.Message);
                return false;
            }
        }
    

        private void LoadMain()
        {
            this.btnSignIn.Enabled = true;
            MessageBox.Show("Main application loaded successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Optionally, open the main form here
            Main mainForm = new Main();
            mainForm.Show();
            this.Hide(); // Hide the login form
            //this.Close(); // Close the login form after loading main application
        }

    }
}
