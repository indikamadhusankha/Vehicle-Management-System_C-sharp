using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;

namespace Vehical_Management_System
{
    public partial class addDrivers : Form
    {
        SqlConnection con;
        public addDrivers()
        {
            InitializeComponent();
        }        

        private void addDrivers_Load(object sender, EventArgs e)
        {
            

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
            if (txtNIC.Text.Trim() == "")
            {
                MessageBox.Show("Please enter NIC Number");
                txtNIC.Focus();
                return false;
            }
            else
            {
                string pattern = @"^([0-9]{9}[vVxX]|[0-9]{12})$";
                if (!System.Text.RegularExpressions.Regex.IsMatch(txtNIC.Text.Trim(), pattern))
                {
                    MessageBox.Show("Invalid NIC format! Please enter a valid NIC number.");
                    txtNIC.Focus();
                    return false;
                }
            }
            if (txtDrivingLicence.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Driving Licence Number");
                txtDrivingLicence.Focus();
                return false;
            }
            if (dateLiceExpire.Text.Trim() == "")
            {
                MessageBox.Show("Please Select Licence Expire Date");
                dateLiceExpire.Focus();
                return false;
            }
            if (txtContact.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Contact Number");
                txtContact.Focus();
                return false;
            }
            if (txtAddress.Text.Trim() == "")
            {
                MessageBox.Show("Please enter Address");
                txtAddress.Focus();
                return false;
            }


            return true;
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            if (!ValidateFields())
                return;
            try
            {
                string query = "INSERT INTO drivers (firstName, lastName, nic, license_no, license_expiry, contact_no, address) " +
                    "VALUES(@firstName, @lastName, @nic, @license_no, @license_expiry, @contact_no, @address)";
                
                using (con = ConnectionManager.GetConnection())
                {
                    con.Open();
                    using (SqlCommand sql = new SqlCommand(query, con))
                    {

                        sql.Parameters.AddWithValue("@firstName", txtFirstName.Text);
                        sql.Parameters.AddWithValue("@lastName", txtLastName.Text);
                        sql.Parameters.AddWithValue("@nic", txtNIC.Text);
                        sql.Parameters.AddWithValue("@license_no", txtDrivingLicence.Text);
                        sql.Parameters.AddWithValue("@license_expiry", dateLiceExpire.Text);
                        sql.Parameters.AddWithValue("@contact_no", txtContact.Text);
                        sql.Parameters.AddWithValue("@address", txtAddress.Text);
                        int rows = sql.ExecuteNonQuery();
                        MessageBox.Show(rows > 0 ? "Driver added successfully!" : "Insert failed!");
                    }
                }

            }
            catch (Exception ex) 
            {
                MessageBox.Show("Message:" + ex.Message);
            }
            finally
            {
                con.Close();
            }

        }
    }
}
