using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace basicLoginRegister
{

    public partial class Access : Form
    {
        public Access()
        {
            InitializeComponent();
        }

        private void NewRegister_Click(object sender, EventArgs e)
        {
            Registration registrationForm = new Registration();
            //open registration form when clicked
            registrationForm.ShowDialog();
        }

        private void LogIn_Click(object sender, EventArgs e)
        {
            string enteredUsername = txtUsername.Text; // username textbox is named txtUsername
            string enteredPassword = txtPassword.Text; // password textbox is named txtPassword

            // Read the credentials from the file
            string filePath = CommonMethods.GetCredentialsFilePath(); //  method from commonmethods.cs
            try
            {
                // Read all lines from the file
                string[] lines = File.ReadAllLines(filePath);

                // Split each line by comma and check if the username and password match
                var userParts = lines.Select(line => line.Split(','))
                                     .FirstOrDefault(parts => parts.Length > 3 &&
                                                              parts[2] == enteredUsername &&
                                                              parts[3] == enteredPassword);

                if (userParts != null && userParts.Length > 3)
                {
                    // If user is found, userParts will have the user's data
                    // name, surname, email
                    Profile profileForm = new Profile(userParts[0], userParts[1], userParts[2]); 
                    this.Hide();
                    profileForm.ShowDialog();
                    this.Show();
                }
                else
                {
                    MessageBox.Show("Login failed. Check your username and password.", "Authentication Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            ClearLoginForm();
            

        }
        // Clear the login form
        public void ClearLoginForm()
        {
            txtUsername.Clear();
            txtPassword.Clear();
        }

        // Event handlers
        private void userName_TextChanged(object sender, EventArgs e)
        {
            //logic for when the username is changed
        }

        private void passWord_TextChanged(object sender, EventArgs e)
        {
            //  
        }
        public void ClearTextBoxes()
        {
            txtUsername.Text = "";
            txtPassword.Text = "";
        }
        private void ProfileForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            ClearLoginForm();
            this.Show(); // Show the Access form again
        }
    }
}
