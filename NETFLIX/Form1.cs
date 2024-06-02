using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
namespace NETFLIX
{
    public partial class RegistrationForm : Form
    {
        public RegistrationForm()
        {
            InitializeComponent();
        }

     /*   private void FirstNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FemaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DateofBirthDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }*/

        private void confirmButton_Click(object sender, EventArgs e)
        {
            if (firstNameTextBox.Text == "" && lastNameTextBox.Text == "" && emailTextBox.Text == "" && passwordTextBox.Text == "")
            {
                MessageBox.Show("Please fill up the informations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-USGHJRD\\SQLEXPRESS;Initial Catalog=USER_REGISTRATION;Integrated Security=True;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string firstName = firstNameTextBox.Text;
                string lastName = lastNameTextBox.Text;
                string email = emailTextBox.Text;
                string password = passwordTextBox.Text;
                DateTime dateOfBirth = dateofBirthDateTimePicker.Value;
                if (maleRadioButton.Checked)
                {
                    string gender = "Male";
                    string query = "INSERT INTO UserData (FirstName, LastName, Email, Password, DateOfBirth, Gender) VALUES ('" + firstName + "', '" + lastName + "', '" + email + "','" + password + "', '" + dateOfBirth + "', '" + gender + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    string gender = "Female";
                    string query = "INSERT INTO UserData (FirstName, LastName, Email, Password, DateOfBirth, Gender) VALUES ('" + firstName + "', '" + lastName + "', '" + email + "','" + password + "', '" + dateOfBirth + "', '" + gender + "')";
                    SqlCommand cmd = new SqlCommand(query, con);
                    cmd.ExecuteNonQuery();
                }
                con.Close();

                MessageBox.Show("Your Registration is complete. Now you can enjoy our Service. Please LOGIN");
                this.Close();
            }
            
        }
    }
}
