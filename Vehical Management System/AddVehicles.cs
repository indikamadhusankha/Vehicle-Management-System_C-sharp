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

namespace Vehical_Management_System
{
    public partial class AddVehicles : Form
    {

        private string userRole;
        public AddVehicles(string userRole)
        {
            InitializeComponent();
            
            if (userRole != "Administrator")
            {
                btnDelete.Hide();
            }
        }

        SqlConnection conn = new SqlConnection(
            "Data Source=(localdb)\\ProjectModels;Initial Catalog=vehicle_management;Integrated Security=True;TrustServerCertificate=True"
        );

        private bool ValidateFields()
        {
            if (txtRegNo.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Vehicle Registration No");
                txtRegNo.Focus();
                return false;
            }

            string checkUserQuery = "SELECT COUNT(*) FROM vehicles WHERE txtRegNo = @RegNo";

            using (SqlConnection conn = new SqlConnection(
                "Data Source=(localdb)\\ProjectModels;Initial Catalog=vehicle_management;Integrated Security=True;TrustServerCertificate=True"))
            {
                using (SqlCommand cmd = new SqlCommand(checkUserQuery, conn))
                {
                    conn.Open();

                    cmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text.Trim());

                    int userCount = (int)cmd.ExecuteScalar(); // returns number of rows with that username

                    if (userCount > 0)
                    {
                        MessageBox.Show("This vehicle is already registered!");
                        txtRegNo.Focus();
                        return false;
                    }
                } // SqlCommand disposed
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
                conn.Open();

                string query = "INSERT INTO vehicles " +
                               "(txtRegNo, txtVehType, txtBand,txtModel, txtYearManuf, txtEngineNo, txtChassisNo, txtFuelType) " +
                               "VALUES (@RegNo, @VehType, @Brand, @Model, @YearManuf, @EngineNo, @ChassisNo, @FuelType)";

                using (SqlCommand sql = new SqlCommand(query, conn))
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
                conn.Close();
                Getdata();
            }
        }

        private void AddVehicles_Load(object sender, EventArgs e)
        {
            Getdata();
        }

        void Getdata()
        {
            SqlCommand cmd = new SqlCommand("select * from vehicles", conn);
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
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
                SqlCommand cmd = new SqlCommand(
                      "DELETE FROM vehicles WHERE txtRegNo = @RegNo", conn);
                  
                    conn.Open();
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
