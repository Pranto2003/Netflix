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
    public partial class AdminPanelPremium : Form
    {
        private string connectionString = "Data Source=DESKTOP-USGHJRD\\SQLEXPRESS;Initial Catalog=USER_REGISTRATION;Integrated Security=True;";
        private SqlConnection con;
        private SqlDataAdapter adpt;
        private DataTable dt;

        public AdminPanelPremium()
        {
            InitializeComponent();
            dataGridView.CellDoubleClick += new DataGridViewCellEventHandler(premiumDataGridTable_CellDoubleClick);
            con = new SqlConnection(connectionString);
            displayPremiumUsers();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void premiumInsertButton_Click(object sender, EventArgs e)
        {
            if ((premiumFirstNameTextbox.Text == "") && (premiumLastNameTextbox.Text == "") && (premiumEmailTextbox.Text == "") && (premiumPasswordTextbox.Text == ""))
            {
                MessageBox.Show("Please fill up the informations.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else
            {
                con.Open();
                string firstName = premiumFirstNameTextbox.Text;
                string lastName = premiumLastNameTextbox.Text;
                string email = premiumEmailTextbox.Text;
                string password = premiumPasswordTextbox.Text;
                DateTime dateOfBirth = premiumDateOfBirthPicker.Value;
                string gender = premiumMaleRadioButton.Checked ? "Male" : "Female";
                string creditCardNo = premiumCreditCardTextbox.Text;
                string pin = premiumPinTextbox.Text;
                double price;
                int planMonth;
                if (premiumTwentyDollarPerMonthCheckBox.Checked)
                {
                    price = 20.00;
                    planMonth = 1;
                }
                else
                {
                    price = 200.00;
                    planMonth = 12;
                }

                string query = "INSERT INTO PremiumUserData (FirstName, LastName, Email, Password, DateOfBirth, Gender, CreditCardNo, PIN, Price, PlanMonth) " +
                    "VALUES (@FirstName, @LastName, @Email, @Password, @DateOfBirth, @Gender, @CreditCardNo, @PIN, @Price, @PlanMonth)";
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

                MessageBox.Show("Premium user inserted successfully.");
                premiumClearButton_Click(sender, e);
                displayPremiumUsers();
            }
        }

        private void premiumExitButton_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void premiumReturnButton_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void PremiumHome_Load(object sender, EventArgs e)
        {

        }

        private void premiumUpdateButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to update.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            con.Open();
            string emailToUpdate = premiumEmailTextbox.Text;
            string query = "UPDATE PremiumUserData SET FirstName = @FirstName, LastName = @LastName, Password = @Password, " +
                "DateOfBirth = @DateOfBirth, Gender = @Gender, CreditCardNo = @CreditCardNo, PIN = @PIN, Price = @Price, PlanMonth = @PlanMonth " +
                "WHERE Email = @Email";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@FirstName", premiumFirstNameTextbox.Text);
            cmd.Parameters.AddWithValue("@LastName", premiumLastNameTextbox.Text);
            cmd.Parameters.AddWithValue("@Password", premiumPasswordTextbox.Text);
            cmd.Parameters.AddWithValue("@DateOfBirth", premiumDateOfBirthPicker.Value);
            cmd.Parameters.AddWithValue("@Gender", premiumMaleRadioButton.Checked ? "Male" : "Female");
            cmd.Parameters.AddWithValue("@CreditCardNo", premiumCreditCardTextbox.Text);
            cmd.Parameters.AddWithValue("@PIN", premiumPinTextbox.Text);
            double price = premiumTwentyDollarPerMonthCheckBox.Checked ? 20.00 : 200.00;
            int planMonth = premiumTwentyDollarPerMonthCheckBox.Checked ? 1 : 12;
            cmd.Parameters.AddWithValue("@Price", price);
            cmd.Parameters.AddWithValue("@PlanMonth", planMonth);
            cmd.Parameters.AddWithValue("@Email", emailToUpdate);

            int rowsAffected = cmd.ExecuteNonQuery();
            con.Close();

            if (rowsAffected > 0)
            {
                MessageBox.Show("Premium user updated successfully.");
                premiumClearButton_Click(sender, e);
                displayPremiumUsers();
            }
            else
            {
                MessageBox.Show("No records updated. Email not found.");
            }
        }

        private void premiumDeleteButton_Click(object sender, EventArgs e)
        {
            if (dataGridView.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select a row to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            DialogResult result = MessageBox.Show("Are you sure you want to delete this record?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                con.Open();
                string emailToDelete = premiumEmailTextbox.Text;
                string query = "DELETE FROM PremiumUserData WHERE Email = @Email";
                SqlCommand cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Email", emailToDelete);
                cmd.ExecuteNonQuery();
                con.Close();

                MessageBox.Show("Premium user deleted successfully.");
                premiumClearButton_Click(sender, e);
                displayPremiumUsers();
            }
            else
            {
                MessageBox.Show("Your record isn't Deleted");
            }
        }

        private void displayPremiumUsers()
        {
            dt = new DataTable();
            con.Open();
            adpt = new SqlDataAdapter("SELECT * FROM PremiumUserData", con);
            adpt.Fill(dt);
            dataGridView.DataSource = dt;
            con.Close();
        }
        private void premiumDataGridTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int id = int.Parse(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            premiumFirstNameTextbox.Text = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            premiumLastNameTextbox.Text = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
            premiumEmailTextbox.Text = dataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();
            premiumPasswordTextbox.Text = dataGridView.Rows[e.RowIndex].Cells[4].Value.ToString();
            if (DateTime.TryParse(dataGridView.Rows[e.RowIndex].Cells[6].Value.ToString(), out DateTime dateOfBirth))
            {
                premiumDateOfBirthPicker.Value = dateOfBirth;
            }
            
            string gender = dataGridView.Rows[e.RowIndex].Cells[5].Value.ToString();
            if (gender == "Male")
            {
                premiumMaleRadioButton.Checked = true;
                premiumFemaleRadioButton.Checked = false;
            }
            else
            {
                premiumMaleRadioButton.Checked = false;
                premiumFemaleRadioButton.Checked = true;
            }
            premiumCreditCardTextbox.Text = dataGridView.Rows[e.RowIndex].Cells[7].Value.ToString();
            premiumPinTextbox.Text = dataGridView.Rows[e.RowIndex].Cells[8].Value.ToString();
            double price = double.Parse(dataGridView.Rows[e.RowIndex].Cells[9].Value.ToString());
            int planMonth = int.Parse(dataGridView.Rows[e.RowIndex].Cells[10].Value.ToString());
            premiumTwentyDollarPerMonthCheckBox.Checked = (price == 20.00 && planMonth == 1);
            premiumTwoHundredDollarPerYearCheckBox.Checked = (price == 200.00 && planMonth == 12);
            MessageBox.Show("Row Selected Successfully.");
        }



        private void premiumClearButton_Click(object sender, EventArgs e)
        {
            premiumFirstNameTextbox.Text = "";
            premiumLastNameTextbox.Text = "";
            premiumEmailTextbox.Text = "";
            premiumPasswordTextbox.Text = "";
            premiumDateOfBirthPicker.Value = DateTime.Today;
            premiumMaleRadioButton.Checked = false;
            premiumFemaleRadioButton.Checked = false;
            premiumCreditCardTextbox.Text = "";
            premiumPinTextbox.Text = "";
            premiumTwentyDollarPerMonthCheckBox.Checked = false;
            premiumTwoHundredDollarPerYearCheckBox.Checked = false;
            searchByEmailTextBox.Text = "";
        }


        private void searchButton_Click(object sender, EventArgs e)
        {
            string searchTerm = searchByEmailTextBox.Text.Trim();

            if (searchTerm == "")
            {
                MessageBox.Show("Please enter an email to search.", "Alert", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string query = "SELECT * FROM PremiumUserData WHERE Email = @Email";

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlCommand command = new SqlCommand(query, connection);
                command.Parameters.AddWithValue("@Email", searchTerm);

                connection.Open();
                SqlDataReader reader = command.ExecuteReader();

                if (reader.Read())
                {
                    MessageBox.Show("ID found successfully.", "Confirmation", MessageBoxButtons.OK);

                    premiumFirstNameTextbox.Text = reader["FirstName"].ToString();
                    premiumLastNameTextbox.Text = reader["LastName"].ToString();
                    premiumEmailTextbox.Text = reader["Email"].ToString();
                    premiumPasswordTextbox.Text = reader["Password"].ToString();

                    if (DateTime.TryParse(reader["DateOfBirth"].ToString(), out DateTime dateOfBirth))
                    {
                        premiumDateOfBirthPicker.Value = dateOfBirth;
                    }
                    else
                    {
                        MessageBox.Show("Invalid date format for Date of Birth.");
                    }

                    string gender = reader["Gender"].ToString();
                    premiumMaleRadioButton.Checked = (gender == "Male");
                    premiumFemaleRadioButton.Checked = (gender == "Female");

                    premiumCreditCardTextbox.Text = reader["CreditCardNo"].ToString();
                    premiumPinTextbox.Text = reader["PIN"].ToString();

                    double price = Convert.ToDouble(reader["Price"]);
                    int planMonth = Convert.ToInt32(reader["PlanMonth"]);
                    premiumTwentyDollarPerMonthCheckBox.Checked = (price == 20.00 && planMonth == 1);
                    premiumTwoHundredDollarPerYearCheckBox.Checked = (price == 200.00 && planMonth == 12);
                }
                else
                {
                    MessageBox.Show("No user found with the provided email.", "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                connection.Close();
            }
        }

    }
}
