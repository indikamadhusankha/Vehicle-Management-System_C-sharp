using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Vehical_Management_System
{
    public partial class dashboard : Form
    {
        private string firstName;
        private string lastName;
        private string userRole;

        public dashboard(string firstName, string lastName, string userRole)
        {
            InitializeComponent();
            lable_userInfo.Text = $"Welcome : {firstName} {lastName}";
            
            this.userRole = userRole;
            lable_user_role.Text = $"User Role : {userRole}";

        }

        private void addVehicleBtn_Click(object sender, EventArgs e)
        {
            new AddVehicles(userRole).Show();
            
        }

        private void dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            
            if (userRole == "Administrator")
            {
                new ManageUser().Show();
            }
            else
            {
                MessageBox.Show("You don't have permission to this option.",
                                "Access Denied",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
            }


        }



        
    }
}
