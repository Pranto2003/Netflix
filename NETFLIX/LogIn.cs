using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace NETFLIX
{
    public partial class LogIn : Form
    {
        string connectionString = "Data Source=DESKTOP-USGHJRD\\SQLEXPRESS;Initial Catalog=USER_REGISTRATION;Integrated Security=True;";
        SqlConnection con;
        int number;
        public LogIn()
        {
            
            InitializeComponent();
            con = new SqlConnection(connectionString);
        }

        private void adminLoginButton_Click(object sender, EventArgs e)
        {
            if (emailTextBox.Text == "netflix@gmail.com" && passwordTextBox.Text == "12345")
            {
                Admin_Panel admin_Panel = new Admin_Panel();
                admin_Panel.Show();
                this.Hide();
                emailTextBox.Text = "";
                passwordTextBox.Text = "";

            }
            else if (emailTextBox.Text == "" && passwordTextBox.Text == "")
            {
                MessageBox.Show("Enter Email and Password");
            }
            else if (emailTextBox.Text == "netflix@gmail.com" && passwordTextBox.Text == "")
            {
                MessageBox.Show("Enter Password");
            }
            else if (emailTextBox.Text == "" && passwordTextBox.Text != "12345")
            {
                MessageBox.Show("Enter Your Email");
            }
            else if (emailTextBox.Text != "netflix@gmail.com" && passwordTextBox.Text == "12345")
            {
                MessageBox.Show("Invalid Email");
            }
            else if (emailTextBox.Text == "netflix@gmail.com" && passwordTextBox.Text != "12345")
            {
                MessageBox.Show("Incorrect Password");
            }

            else
            {
                MessageBox.Show("Invalid Password");
            }
        }

        private void userSignInButton_Click(object sender, EventArgs e)
        {
            string email = emailTextBox.Text;
            string password = passwordTextBox.Text;
            string password2 = number.ToString();
            bool isAuthenticated = false;


            string regularQuery = "SELECT Password FROM UserData WHERE Email = @Email";
            SqlCommand regularCmd = new SqlCommand(regularQuery, con);
            regularCmd.Parameters.AddWithValue("@Email", email);

            con.Open();
            SqlDataReader regularReader = regularCmd.ExecuteReader();
            if (regularReader.Read())
            {
                string storedPassword = regularReader["Password"].ToString();
                if (storedPassword == password || password==password2)
                {
                    isAuthenticated = true;
                    MessageBox.Show("User authenticated successfully.");
                    Home home = new Home();
                    home.Show();
                    this.Hide();
                }
            }
            con.Close();

            if (!isAuthenticated)
            {
                string premiumQuery = "SELECT Password FROM PremiumUserData WHERE Email = @Email";
                SqlCommand premiumCmd = new SqlCommand(premiumQuery, con);
                premiumCmd.Parameters.AddWithValue("@Email", email);

                con.Open();
                SqlDataReader premiumReader = premiumCmd.ExecuteReader();
                if (premiumReader.Read())
                {
                    string storedPassword = premiumReader["Password"].ToString();
                    if (storedPassword == password || password == password2)
                    {
                        isAuthenticated = true;
                        MessageBox.Show("Premium user authenticated successfully.");
                        PremiumUsersHome home = new PremiumUsersHome();
                        home.Show();
                        this.Hide();
                    }
                }
                con.Close();
            }


            if (!isAuthenticated)
            {
                MessageBox.Show("Incorrect email or password. Please try again.");
            }

        }


        private void signUpButton_Click(object sender, EventArgs e)
        {
            RegistrationForm registrationForm = new RegistrationForm();
            registrationForm.Show();

        }
        private void premiumSignUpButton_Click(object sender, EventArgs e)
        {
            PremiumSignUp premiumSignUp = new PremiumSignUp();
            premiumSignUp.Show();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void showCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (showCheckBox.Checked)
            {
                passwordTextBox.PasswordChar = '\0';
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
            }
        }

        private void forgetPasswordButton_Click(object sender, EventArgs e)
        {
            Random random = new Random();


            number = random.Next(1000, 2500 + 1);
            MessageBox.Show("Here is your code :"+number, "Confirmation", MessageBoxButtons.OK);


        }
    }
}
