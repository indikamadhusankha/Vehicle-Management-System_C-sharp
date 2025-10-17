using MySql.Data.MySqlClient;
using System;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace Vehical_Management_System
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
        
        private void loginBtn_Click(object sender, EventArgs e)
        {
            string userName = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            string hashedPassword = ComputeSha256Hash(password);

            string checkUserQuery = "SELECT firstName, lastName, user_role FROM Users WHERE user_name = @user_name AND hashed_password = @password";
            string connectionString = "server=localhost;user id=root;password=;database=vehical_management";
            try
            {
                using (MySqlConnection con = new MySqlConnection(connectionString))
                {
                    con.Open();
                    using (MySqlCommand cmd = new MySqlCommand(checkUserQuery, con))
                    {

                        cmd.Parameters.AddWithValue("@user_name", userName);
                        cmd.Parameters.AddWithValue("@password", hashedPassword);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                string firstName = reader["firstName"].ToString();
                                string lastName = reader["lastName"].ToString();
                                string UserRole = reader["user_role"].ToString();

                                // Pass role to Dashboard
                                dashboard dashboardForm = new dashboard(firstName, lastName, UserRole);
                                dashboardForm.Show();
                                this.Hide();
                            }
                            else
                            {
                                MessageBox.Show("Username or Password is invalid.");
                            }
                        }
                    }
                }
            }catch (Exception ex)
            {
                MessageBox.Show("Error connecting to database: " + ex.Message);
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
