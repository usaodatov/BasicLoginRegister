using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace basicLoginRegister
{
    public partial class ChangeProfileForm : Form
    {
        // Constructor for the ChangeProfileForm
        public ChangeProfileForm(string name, string surname, string email)
        {
            InitializeComponent();

            // Use the arguments to set the text boxes when the form is initialized
            EditNameText = name;
            EditSurnameText = surname;
            EditEmailText = email;
        }

        // Public properties to get and set the TextBox values
        public string EditNameText
        {
            get { return EditName.Text; }
            set { EditName.Text = value; }
        }

        public string EditSurnameText
        {
            get { return EditSurname.Text; }
            set { EditSurname.Text = value; }
        }

        public string EditEmailText
        {
            get { return EditEmail.Text; }
            set { EditEmail.Text = value; }
        }

        // Placeholder for the save_Click event handler
        private void save_Click(object sender, EventArgs e)
        {
            // Perform input validation
            if (String.IsNullOrWhiteSpace(EditNameText) ||
                String.IsNullOrWhiteSpace(EditSurnameText) ||
                String.IsNullOrWhiteSpace(EditEmailText))
            {
                MessageBox.Show("All fields must be filled in.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                // Assuming you have a method to get the path where user data is stored
                string filePath = CommonMethods.GetCredentialsFilePath();

                // Read the existing user data
                var lines = File.ReadAllLines(filePath).ToList();

                // Find the line with the user's data
                int index = lines.FindIndex(line => line.StartsWith(EditNameText));

                if (index != -1)
                {
                    // User found, update the user's data
                    lines[index] = $"{EditNameText},{EditSurnameText},{EditEmailText}";

                    // Write the updated data back to the file
                    File.WriteAllLines(filePath, lines);

                    MessageBox.Show("Profile updated successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Close the form if you wish to
                    // this.Close();
                }
                else
                {
                    MessageBox.Show("User not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while updating the profile: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Other event handlers for your form (if necessary)
    }
}
