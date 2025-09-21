using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehical_Management_System
{
    public partial class ManageUser : Form
    {
        public ManageUser()
        {
            InitializeComponent();
        }

              

        private bool ValidateFields()
        {
            if (txtFirstName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter First Name");
                txtFirstName.Focus();
                return false;
            }
            if (txtLastName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Last Name");
                txtLastName.Focus();
                return false;
            }
            string contact = txtContactNo.Text.Trim();

            // check length
            if (contact.Length != 10)
            {
                MessageBox.Show("Invalid Contact Number (must be exactly 10 digits)");
                txtContactNo.Focus();
                return false;
            }

            // check if starts with 0
            if (!contact.StartsWith("0"))
            {
                MessageBox.Show("Invalid Contact Number");
                txtContactNo.Focus();
                return false;
            }

            // check if only digits
            if (!System.Text.RegularExpressions.Regex.IsMatch(contact, @"^\d{10}$"))
            {
                MessageBox.Show("Invalid Contact Number");
                txtContactNo.Focus();
                return false;
            }

            if (txtUserName.Text.Trim() == "")
            {
                MessageBox.Show("Please enter User Name");
                txtUserName.Focus();
                return false;
            }


            string checkUserQuery = "SELECT COUNT(*) FROM Users WHERE user_name = @user_name";

            using (SqlConnection conn = new SqlConnection(
                "Data Source=(localdb)\\ProjectModels;Initial Catalog=vehicle_management;Integrated Security=True;TrustServerCertificate=True"))
            {
                using (SqlCommand cmd = new SqlCommand(checkUserQuery, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@user_name", txtUserName.Text.Trim());

                    int userCount = (int)cmd.ExecuteScalar(); // returns number of rows with that username

                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists! Please choose another one.");
                        txtUserName.Focus();
                        return false;
                    }
                } // SqlCommand disposed
            }


            //check password empty

            if (txtPassword.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Password");
                txtPassword.Focus();
                return false;
            }

            // Check password length (must be between 6 and 10)
            if (txtPassword.Text.Trim().Length < 6 || txtPassword.Text.Trim().Length > 10)
            {
                MessageBox.Show("Password length must be between 6 and 10 characters");
                txtPassword.Focus();
                return false;
            }

            // Check confirm password empty
            if (txtPasswordConfirm.Text.Trim() == "")
            {
                MessageBox.Show("Please Enter confirm Password");
                txtPasswordConfirm.Focus();
                return false;
            }

            // Check if confirm password matches password
            if (txtPasswordConfirm.Text.Trim() != txtPassword.Text.Trim())
            {
                MessageBox.Show("Passwords do not match!");
                txtPasswordConfirm.Focus();
                return false;
            }

            if (txtUserRole.SelectedIndex == -1) // no item selected
            {
                MessageBox.Show("Please select a User Role");
                txtUserRole.Focus();
                return false;
            }

            return true;
        }

        public static string ComputeSha256Hash(string rawData)
        {
            // Create a SHA256
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash returns byte array
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(rawData));

                // Convert byte array to a string
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2")); // hex format
                }
                return builder.ToString();
            }
        }


        private void btn_userManage_submit_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;

            try
            {
                string hashedPassword = ComputeSha256Hash(txtPassword.Text.Trim());

                string query = "INSERT INTO users " +
                               "(firstName, lastName, contact, user_name, hashed_password, user_role) " +
                               "VALUES (@firstName, @lastName, @contact, @user_name, @hashed_password, @user_role)";

                using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=vehicle_management;Integrated Security=True;TrustServerCertificate=True"))
                {
                    using (SqlCommand sql = new SqlCommand(query, conn))
                    {
                        conn.Open();
                        sql.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                        sql.Parameters.AddWithValue("@lastName", txtLastName.Text);
                        sql.Parameters.AddWithValue("@contact", txtContactNo.Text);
                        sql.Parameters.AddWithValue("@user_name", txtUserName.Text);
                        sql.Parameters.AddWithValue("@hashed_password", hashedPassword);
                        sql.Parameters.AddWithValue("@user_role", txtUserRole.Text);

                        int rows = sql.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "User added successfully!" : "Insert failed!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            
        }

        private void ManageUser_Load(object sender, EventArgs e)
        {


            {
                Getdata();
            }

            void Getdata()
            {

                using (SqlConnection conn = new SqlConnection("Data Source=(localdb)\\ProjectModels;Initial Catalog=vehicle_management;Integrated Security=True;TrustServerCertificate=True"))
                {
                    SqlCommand getDataSql = new SqlCommand("select * from users", conn);
                    conn.Open();
                    SqlDataAdapter sd = new SqlDataAdapter(getDataSql);
                    DataTable dataTable = new DataTable();
                    sd.Fill(dataTable);
                    dataGridView2.DataSource = dataTable;
                }

                    
            }
        }
    }
}
