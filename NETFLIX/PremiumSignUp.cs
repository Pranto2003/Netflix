using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace NETFLIX
{
    public partial class PremiumSignUp : Form
    {
        public PremiumSignUp()
        {
            InitializeComponent();
        }


        private void PremiumConfirmButton_Click(object sender, EventArgs e)
        {
            if (FirstNameTextBox.Text == "" && LastNameTextBox.Text == "" && EmailTextBox.Text == "" && PasswordTextBox.Text == "")
            {
                MessageBox.Show("Please fill up the informations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string connectionString = "Data Source=DESKTOP-USGHJRD\\SQLEXPRESS;Initial Catalog=USER_REGISTRATION;Integrated Security=True;";
                SqlConnection con = new SqlConnection(connectionString);
                con.Open();
                string firstName = FirstNameTextBox.Text;
                string lastName = LastNameTextBox.Text;
                string email = EmailTextBox.Text;
                string password = PasswordTextBox.Text;
                DateTime dateOfBirth = PremiumDateTimePicker.Value;
                string gender = MaleRadioButton.Checked ? "Male" : "Female";
                string creditCardNo = CreditCardTextBox.Text;
                string pin = PinTextBox.Text;
                double price;
                int planMonth;
                if (TwentyDollarPerMonthCheckBox.Checked)
                {
                    price = 20.00;
                    planMonth = 1;
                }
                else
                {
                    price = 200.00;
                    planMonth = 12;
                }

                string query = "INSERT INTO PremiumUserData (FirstName, LastName, Email, Password, DateOfBirth, Gender, CreditCardNo, PIN, Price, PlanMonth) VALUES (@FirstName, @LastName, @Email, @Password, @DateOfBirth, @Gender, @CreditCardNo, @PIN, @Price, @PlanMonth)";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@FirstName", firstName);
                cmd.Parameters.AddWithValue("@LastName", lastName);
                cmd.Parameters.AddWithValue("@Email", email);
                cmd.Parameters.AddWithValue("@Password", password);
                cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
                cmd.Parameters.AddWithValue("@Gender", gender);
                cmd.Parameters.AddWithValue("@CreditCardNo", creditCardNo);
                cmd.Parameters.AddWithValue("@PIN", pin);
                cmd.Parameters.AddWithValue("@Price", price);
                cmd.Parameters.AddWithValue("@PlanMonth", planMonth);

                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Your Registration for Premium Service is complete. Now you can enjoy our Premium Content.");
                this.Close();
            }
        }
    }
}
