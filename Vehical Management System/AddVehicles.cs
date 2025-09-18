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


        public AddVehicles()
        {
            InitializeComponent();
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


    }

}
