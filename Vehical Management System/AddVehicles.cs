using System;
using System.Data;
using MySql.Data.MySqlClient;
using System.Windows.Forms;

namespace Vehical_Management_System
{
    public partial class AddVehicles : Form
    {
        private MySqlConnection con;
        private string connectionString = "server=localhost;user id=root;password=;database=vehical_management";
        private string first_Name;
        //private string userRole;
        public AddVehicles(string userRole, string firstName)
        {
            InitializeComponent();
            con = new MySqlConnection(connectionString);
            first_Name = firstName;
         

            if (userRole != "Administrator")
            {
                btnDelete.Hide();
            }
        }
               

        private bool ValidateFields()
        {
            if (txtRegNo.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Vehicle Registration No");
                txtRegNo.Focus();
                return false;
            }

            string checkUserQuery = "SELECT COUNT(*) FROM vehicles WHERE registration_number = @RegNo";


            try
            {

                using (var cmd = new MySqlCommand(checkUserQuery, con))
                {
                con.Open(); // Open connection
                    cmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text.Trim());
                    int userCount = Convert.ToInt32(cmd.ExecuteScalar());

                    if (userCount > 0)
                    {
                        MessageBox.Show("This vehicle is already registered!");
                        txtRegNo.Focus();
                        return false;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error while checking registration number: " + ex.Message);
                return false;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close(); // connection closes
            }



            if (txtVehType.Text.Trim() == "")
            {
                MessageBox.Show("Please Select Vehicle Type");
                txtVehType.Focus();
                return false;
            }
            if (txtBand.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Brand");
                txtBand.Focus();
                return false;
            }
            if (txtModel.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Model");
                txtModel.Focus();
                return false;
            }
            if (txtYearManuf.Text.Trim() == "")
            {
                MessageBox.Show("Please Select Year of Manufacture");
                txtYearManuf.Focus();
                return false;
            }
            if (txtEngineNo.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Engine Number");
                txtEngineNo.Focus();
                return false;
            }
            if (txtChassisNo.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Chassis Number");
                txtChassisNo.Focus();
                return false;
            }
            if (txtFuelType.Text.Trim() == "")
            {
                MessageBox.Show("Please Select Fuel Type");
                txtFuelType.Focus();
                return false;
            }

            return true;
        }

        private void btn_add_vehicle_submit_Click(object sender, EventArgs e)
        {
            
            if (!ValidateFields())
                return; 

            try
            {
                con.Open();

                string query = "INSERT INTO vehicles " +
                               "(registration_number, VehType, brand,model, manufacture_year, engine_number, chassis_number, fuel_type, added_by) " +
                               "VALUES (@RegNo, @VehType, @Brand, @Model, @YearManuf, @EngineNo, @ChassisNo, @FuelType, @added_by)";

                using (MySqlCommand sql = new MySqlCommand(query, con))
                {
                    sql.Parameters.AddWithValue("@RegNo", txtRegNo.Text);
                    sql.Parameters.AddWithValue("@VehType", txtVehType.Text);
                    sql.Parameters.AddWithValue("@Brand", txtBand.Text);
                    sql.Parameters.AddWithValue("@Model", txtModel.Text);
                    sql.Parameters.AddWithValue("@YearManuf", txtYearManuf.Text);
                    sql.Parameters.AddWithValue("@EngineNo", txtEngineNo.Text);
                    sql.Parameters.AddWithValue("@ChassisNo", txtChassisNo.Text);
                    sql.Parameters.AddWithValue("@FuelType", txtFuelType.Text);
                    sql.Parameters.AddWithValue("@added_by", first_Name);

                    int rows = sql.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Vehicle added successfully!");

                        txtRegNo.Clear();
                        txtBand.Clear();
                        txtModel.Clear();
                        txtEngineNo.Clear();
                        txtChassisNo.Clear();                        
                        txtVehType.SelectedIndex = -1;
                        txtFuelType.SelectedIndex = -1;
                    }
                    else
                    {
                        MessageBox.Show("Insert failed!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close(); // connection closes
                Getdata();
            }
        }

        private void AddVehicles_Load(object sender, EventArgs e)
        {
            Getdata();
        }

        void Getdata()
        {
            try
            {
                if (con.State != ConnectionState.Open)
                    con.Open();

                using (MySqlCommand cmd = new MySqlCommand(
                    "SELECT registration_number, VehType, brand, owner_name, owner_contact, added_by, date_added FROM vehicles", con))
                {
                    using (MySqlDataAdapter sd = new MySqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string regNo = dataGridView1.SelectedRows[0].Cells["registration_number"].Value.ToString();

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this vehicle?",
                                                       "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();

                        using (MySqlCommand cmd = new MySqlCommand(
                            "DELETE FROM vehicles WHERE registration_number = @RegNo", con))
                        {
                            cmd.Parameters.AddWithValue("@RegNo", regNo);
                            cmd.ExecuteNonQuery();
                        }

                        MessageBox.Show("Vehicle deleted successfully.");
                        Getdata();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error deleting record: " + ex.Message);
                    }
                    finally
                    {
                        if (con.State == ConnectionState.Open)
                            con.Close();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Vehicle Reg No.");
            }
        }


    }

}
