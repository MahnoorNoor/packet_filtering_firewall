using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Group10_proj
{
    public partial class AdminLogin : Form
    {
        private Form parentForm;
        public AdminLogin(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm; // Save the parent form
            this.AcceptButton = LoginBtn; // Set the LoginBtn as the accept button

        }
        #region Empty
        private void Admin_login_Load(object sender, EventArgs e)
        {
        }

        private void Username_TextChanged(object sender, EventArgs e)
        {
        }
        private void Password_TextChanged(object sender, EventArgs e)
        {
        }
        private void Label_password_Click(object sender, EventArgs e)
        {
        }
        private void Password_TextChanged_1(object sender, EventArgs e)
        {

        }
        #endregion
        private void back_Btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            Firewall firewall = new Firewall();
            firewall.ShowDialog();
            this.Close();
        }

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            // This function is called when the login button is clicked.
            // It checks if the username and password are valid.
            // If they are, it navigates to the "Add_Custom_Rules" form.
            
            // If the username is invalid, it shows a different error message.
            if (string.IsNullOrEmpty(Username.Text) || string.IsNullOrEmpty(Password.Text))
            {
                MessageBox.Show("Username and password must not be empty.");
                return;
            }  
            // If the password is less than 8 characters, it shows an error message.
            if (Password.Text.Length < 8)
            {
                MessageBox.Show("Password must be more than 8 characters.");
                return;
            }

            try
            {
                // Authentication
                bool isAuthenticated = AuthenticateUser(Username.Text, Password.Text);
                if (isAuthenticated)
                {
                    AddCustomRules customRulesForm = new AddCustomRules();
                    this.Hide(); // Hide the current form
                    customRulesForm.ShowDialog(); // Show the AddCustomRules form and wait for it to close
                    this.Show(); // Show the current form when AddCustomRules form is closed
                }
                else
                {
                    MessageBox.Show("Invalid username or password. Please try again.");
                }
            }
            catch (Exception ex)
            {
                // Error handling
                MessageBox.Show("An error occurred while attempting to log in. Please try again later.");
                // Log the exception for debugging purposes
                Console.WriteLine(ex.ToString());
            }
        }
        private bool AuthenticateUser(string username, string password)
        {
            // This is a placeholder method. In a real-world application, you'd check the username and password against a database.
            return username == "admin" && password == "12345678";
        }
        private void ResetBtn_Click(object sender, EventArgs e)
        {
            Username.Clear();
            Password.Clear();
        }
    }
}