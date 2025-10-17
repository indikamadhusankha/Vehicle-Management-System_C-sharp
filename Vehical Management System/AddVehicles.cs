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

        private string userRole;
        public AddVehicles(string userRole)
        {
            InitializeComponent();
            con = new MySqlConnection(connectionString);

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

            con.Open();
                using (var cmd = new MySqlCommand(checkUserQuery, con))
                {                    

                    cmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text.Trim());

                    int userCount = Convert.ToInt32(cmd.ExecuteScalar()); // returns number of rows with that username

                    if (userCount > 0)
                    {
                        MessageBox.Show("This vehicle is already registered!");
                        txtRegNo.Focus();
                        return false;
                    }
                con.Close();
            } // SqlCommand disposed
            


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
                               "(registration_number, VehType, brand,model, manufacture_year, engine_number, chassis_number, fuel_type) " +
                               "VALUES (@RegNo, @VehType, @Brand, @Model, @YearManuf, @EngineNo, @ChassisNo, @FuelType)";

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

                    int rows = sql.ExecuteNonQuery();

                    if (rows > 0)
                    {
                        MessageBox.Show("Vehicle added successfully!");
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
                con.Close();
                Getdata();
            }
        }

        private void AddVehicles_Load(object sender, EventArgs e)
        {
            Getdata();
        }

        void Getdata()
        {
            con.Open();
            MySqlCommand cmd = new MySqlCommand("select * from vehicles", con);
            MySqlDataAdapter sd = new MySqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            sd.Fill(dt);
            dataGridView1.DataSource = dt;
        }

       private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                
                // get driver_id of selected row
                string regNo = dataGridView1.SelectedRows[1].Cells["txtRegNo"].Value.ToString();
                MySqlCommand cmd = new MySqlCommand(
                      "DELETE FROM vehicles WHERE registration_number = @RegNo", con);
                  
                    con.Open();
                    cmd.Parameters.AddWithValue("@RegNo", regNo);
                    cmd.ExecuteNonQuery();
                

                MessageBox.Show("Vehicle deleted successfully.");

                // reload grid
                Getdata();
            }
            else
            {
                MessageBox.Show("Please select a Vehicle Reg No.");
            }
        }

        
    }

}
