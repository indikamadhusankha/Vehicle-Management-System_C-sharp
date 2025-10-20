using System;
using System.Data;
//using MySql.Data.MySqlClient;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Vehical_Management_System
{
    public partial class ManageUser : Form
    {
        SqlConnection con;
        public ManageUser()
        {
            InitializeComponent();
            con = ConnectionManager.GetConnection();
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


            string checkUserQuery = "SELECT COUNT(*) FROM users WHERE user_name = @user_name";
            using (con = ConnectionManager.GetConnection())
            {
                con.Open();
                using (SqlCommand cmd = new SqlCommand(checkUserQuery, con))
                {

                    cmd.Parameters.AddWithValue("@user_name", txtUserName.Text.Trim());

                    object result = cmd.ExecuteScalar();
                    int userCount = (result != null) ? Convert.ToInt32(result) : 0;

                    if (userCount > 0)
                    {
                        MessageBox.Show("Username already exists! Please choose another one.");
                        txtUserName.Focus();
                        return false;
                    }
                    con.Close();
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
            using (con = ConnectionManager.GetConnection())
            {

                try
                {
                    string hashedPassword = ComputeSha256Hash(txtPassword.Text.Trim());

                    string query = "INSERT INTO Users " +
                                   "(firstName, lastName, contact, user_name, hashed_password, user_role) " +
                                   "VALUES (@firstName, @lastName, @contact, @user_name, @hashed_password, @user_role)";

                    con.Open();
                    using (SqlCommand sql = new SqlCommand(query, con))
                    {

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
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    Getdata();
                }
            }
            
        }


        private void ManageUser_Load(object sender, EventArgs e)
        {
            Getdata();
        }



        private void Getdata()
        {
            using (con = ConnectionManager.GetConnection())
            {
                try
                {
                    con.Open();
                    using (SqlCommand getDataSql = new SqlCommand("SELECT * FROM users", con))
                    {
                        using (SqlDataAdapter sd = new SqlDataAdapter(getDataSql))
                        {
                            DataTable dataTable = new DataTable();
                            sd.Fill(dataTable);
                            dataGridView2.DataSource = dataTable;
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                finally
                {
                    con.Close();
                }
            }
        }
    }
}
