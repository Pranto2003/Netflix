using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace NETFLIX
{
    public partial class Admin_Panel : Form

    {
        string connectionString = "Data Source=DESKTOP-USGHJRD\\SQLEXPRESS;Initial Catalog=USER_REGISTRATION;Integrated Security=True;";
        SqlConnection con;
        SqlDataAdapter adpt;
        DataTable dt;
        public Admin_Panel()
        {
            InitializeComponent();
            dataGridView.CellDoubleClick += new DataGridViewCellEventHandler(dataGridView_CellDoubleClick);
            con = new SqlConnection(connectionString);
            display();
        }

        private void insertButton_Click(object sender, EventArgs e)
        {
            if ((firstNameTextbox.Text == "") && (secondNameTextbox.Text == "") && (emailTextbox.Text == "") && (passwordTextbox.Text == ""))
            {
                MessageBox.Show("Please fill up the informations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                con.Open();
                string firstName = firstNameTextbox.Text;
                string lastName = secondNameTextbox.Text;
                string email = emailTextbox.Text;
                string password = passwordTextbox.Text;
                DateTime dateOfBirth = dateOfBirthTextbox.Value;
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

                MessageBox.Show("Insertion Successful");
                clear();
                display();
            }
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con = new SqlConnection(connectionString);
            con.Open();
            string firstName = firstNameTextbox.Text;
            string lastName = secondNameTextbox.Text;
            string email = emailTextbox.Text;
            string password = passwordTextbox.Text;
            DateTime dateOfBirth = dateOfBirthTextbox.Value;
            string gender = maleRadioButton.Checked ? "Male" : "Female";

            string query = "UPDATE UserData SET FirstName = @FirstName, LastName = @LastName, Password = @Password, DateOfBirth = @DateOfBirth, Gender = @Gender WHERE Email = @Email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@FirstName", firstName);
            cmd.Parameters.AddWithValue("@LastName", lastName);
            cmd.Parameters.AddWithValue("@Password", password);
            cmd.Parameters.AddWithValue("@DateOfBirth", dateOfBirth);
            cmd.Parameters.AddWithValue("@Gender", gender);
            cmd.Parameters.AddWithValue("@Email", email);

            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Update Successful");
                clear();
                display();
            }
            else
            {
                MessageBox.Show("No records updated. Email not found.");
            }
        }


        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                MessageBox.Show("You record has been deleted");
                con.Open();
                string emailToDelete = emailTextbox.Text;
                string query = "DELETE FROM UserData WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", emailToDelete);
                cmd.ExecuteNonQuery();
                con.Close();
                clear();
                display();
            }
            else
            {
                MessageBox.Show("Record is not deleted");
            }

        }

        private void returnButton_Click(object sender, EventArgs e)
        {
            LogIn login = new LogIn();
            login.Show();
            this.Close();
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            clear();
        }
        private void clear()
        {
            firstNameTextbox.Text = "";
            secondNameTextbox.Text = "";
            emailTextbox.Text = "";
            passwordTextbox.Text = "";
            dateOfBirthTextbox.Value = DateTime.Today;
            maleRadioButton.Checked = false;
            FemaleRadioButton.Checked = false;
            searchByEmailTextBox.Text = "";
        }
        public void display()
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("SELECT * FROM UserData", con);
            adpt.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }

        private void dataGridView_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            firstNameTextbox.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            secondNameTextbox.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            emailTextbox.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            passwordTextbox.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (DateTime.TryParse(dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString(), out DateTime dateOfBirth))
            {
                dateOfBirthTextbox.Value = dateOfBirth;
            }
            
            string gender = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (gender == "Male")
            {
                maleRadioButton.Checked = true;
                FemaleRadioButton.Checked = false;
            }
            else
            {
                maleRadioButton.Checked = false;
                FemaleRadioButton.Checked = true;
            }
            MessageBox.Show("Row Selected Successfully.");
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MaleRadioButton_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void premiumUsers_Click(object sender, EventArgs e)
        {
            AdminPanelPremium form = new AdminPanelPremium();
            form.Show();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (searchByEmailTextBox.Text == "")
            {
                MessageBox.Show("Please enter email first", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Question);

            }
            else
            {
                string searchEmail = searchByEmailTextBox.Text;

                con.Open();
                string query = "SELECT * FROM UserData WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", searchEmail);

                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    MessageBox.Show("ID found successfully.", "Confirmation", MessageBoxButtons.OK);

                    firstNameTextbox.Text = reader["FirstName"].ToString();
                    secondNameTextbox.Text = reader["LastName"].ToString();
                    emailTextbox.Text = reader["Email"].ToString();
                    passwordTextbox.Text = reader["Password"].ToString();

                    if (DateTime.TryParse(reader["DateOfBirth"].ToString(), out DateTime dateOfBirth))
                    {
                        dateOfBirthTextbox.Value = dateOfBirth;
                    }
                    else
                    {
                        MessageBox.Show("Invalid date format for Date of Birth.");
                    }

                    string gender = reader["Gender"].ToString();
                    if (gender == "Male")
                    {
                        maleRadioButton.Checked = true;
                        FemaleRadioButton.Checked = false;
                    }
                    else
                    {
                        maleRadioButton.Checked = false;
                        FemaleRadioButton.Checked = true;
                    }
                }
                else
                {
                    MessageBox.Show("No user found with the specified email.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                con.Close();
            }
        }
        
    }
}
