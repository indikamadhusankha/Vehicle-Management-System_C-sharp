using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Vehical_Management_System
{
    public partial class AddVehicles : Form
    {
        SqlConnection con;
        private string first_Name;
        //private string userRole;
        public AddVehicles(string userRole, string firstName)
        {
            InitializeComponent();
            first_Name = firstName;
            con = ConnectionManager.GetConnection();

            if (userRole != "Administrator")
            {
                btnDelete.Hide();
                btnEditVehicle.Hide();
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

            string checkUserQuery = "SELECT COUNT(*) FROM vehicles WHERE txtRegNo = @RegNo";


            try
            {

                con.Open(); // Open connection
                using (var cmd = new SqlCommand(checkUserQuery, con))
                {
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
            if (btn_add_vehicle_submit.Text == "Add Vehicle")
            {
                // 🟢 Insert logic
                string query = "INSERT INTO vehicles " +
                               "(txtRegNo, txtVehType, txtBand, txtModel, txtYearManuf, txtEngineNo, txtChassisNo, txtFuelType) " +
                               "VALUES (@RegNo, @VehType, @Brand, @Model, @YearManuf, @EngineNo, @ChassisNo, @FuelType)";
                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text);
                        cmd.Parameters.AddWithValue("@VehType", txtVehType.Text);
                        cmd.Parameters.AddWithValue("@Brand", txtBand.Text);
                        cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                        cmd.Parameters.AddWithValue("@YearManuf", txtYearManuf.Text);
                        cmd.Parameters.AddWithValue("@EngineNo", txtEngineNo.Text);
                        cmd.Parameters.AddWithValue("@ChassisNo", txtChassisNo.Text);
                        cmd.Parameters.AddWithValue("@FuelType", txtFuelType.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Vehicle added successfully!");
                    ClearFields();
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
            else if (btn_add_vehicle_submit.Text == "Update")
            {
                // 🟡 Update logic
                string query = "UPDATE vehicles SET " +
                               "txtVehType = @VehType, txtBand = @Brand, txtModel = @Model, txtYearManuf = @YearManuf, " +
                               "txtEngineNo = @EngineNo, txtChassisNo = @ChassisNo, txtFuelType = @FuelType " +
                               "WHERE txtRegNo = @RegNo";

                try
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand(query, con))
                    {
                        cmd.Parameters.AddWithValue("@RegNo", txtRegNo.Text);
                        cmd.Parameters.AddWithValue("@VehType", txtVehType.Text);
                        cmd.Parameters.AddWithValue("@Brand", txtBand.Text);
                        cmd.Parameters.AddWithValue("@Model", txtModel.Text);
                        cmd.Parameters.AddWithValue("@YearManuf", txtYearManuf.Text);
                        cmd.Parameters.AddWithValue("@EngineNo", txtEngineNo.Text);
                        cmd.Parameters.AddWithValue("@ChassisNo", txtChassisNo.Text);
                        cmd.Parameters.AddWithValue("@FuelType", txtFuelType.Text);
                        cmd.ExecuteNonQuery();
                    }
                    MessageBox.Show("Vehicle updated successfully!");

                    // Reset form
                    btn_add_vehicle_submit.Text = "Add Vehicle";
                    txtRegNo.ReadOnly = false;
                    ClearFields();

                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error updating vehicle: " + ex.Message);
                }
                finally
                {
                    con.Close();
                    Getdata();
                }
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
               // if (con.State != ConnectionState.Open)
                    con.Open();

                using (SqlCommand cmd = new SqlCommand(
                    "SELECT * FROM vehicles", con))
                {
                    using (SqlDataAdapter sd = new SqlDataAdapter(cmd))
                    {
                        DataTable dt = new DataTable();
                        sd.Fill(dt);
                        dataGridView1.DataSource = dt;
                    }
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Message: " + ex.Message);
            }
            finally
            {
               // if (con.State == ConnectionState.Open)
                    con.Close();
            }
        }


        // Clear all textbox feilds
        private void ClearFields()
        {
            txtRegNo.Clear();
            txtVehType.SelectedIndex = -1;            
            txtBand.Clear();
            txtModel.Clear();
            txtYearManuf.Clear();
            txtEngineNo.Clear();
            txtChassisNo.Clear();
            txtFuelType.SelectedIndex = -1;
            
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                string regNo = dataGridView1.SelectedRows[0].Cells["txtRegNo"].Value.ToString();

                DialogResult confirm = MessageBox.Show("Are you sure you want to delete this vehicle?",
                                                       "Confirm Delete", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    try
                    {
                        if (con.State != ConnectionState.Open)
                            con.Open();

                        using (SqlCommand cmd = new SqlCommand(
                            "DELETE FROM vehicles WHERE txtRegNo = @RegNo", con))
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
                        Getdata();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a Vehicle Reg No.");
            }
        }

        private void btnEditVehicle_Click(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                string regNo = dataGridView1.SelectedRows[0].Cells["txtRegNo"].Value.ToString();
                DialogResult editClick = MessageBox.Show("Are you sure you want to Edit this vehicle?",
                                                       "Confirm Edit", MessageBoxButtons.YesNo);

                if (editClick == DialogResult.Yes) {

                    
                    try {


                        btn_add_vehicle_submit.Text = "Update";
                        txtRegNo.Text = regNo;
                        txtRegNo.ReadOnly = true;
                        txtVehType.Text = dataGridView1.SelectedRows[0].Cells["txtVehType"].Value.ToString();
                        txtBand.Text = dataGridView1.SelectedRows[0].Cells["txtBand"].Value.ToString();
                        txtModel.Text = dataGridView1.SelectedRows[0].Cells["txtModel"].Value.ToString();
                        txtYearManuf.Text = dataGridView1.SelectedRows[0].Cells["txtYearManuf"].Value.ToString();         
                        txtEngineNo.Text = dataGridView1.SelectedRows[0].Cells["txtEngineNo"].Value.ToString();
                        txtChassisNo.Text = dataGridView1.SelectedRows[0].Cells["txtChassisNo"].Value.ToString();
                        txtFuelType.Text = dataGridView1.SelectedRows[0].Cells["txtFuelType"].Value.ToString();




                        

                    }
                    catch(Exception ex)
                    {
                        MessageBox.Show("messge :" + ex.Message);
                    } finally
                    {
                        
                    }                
                }
            }
            else
            {
                MessageBox.Show("Please Select Vehicle!");
            }
        }
    }

}
