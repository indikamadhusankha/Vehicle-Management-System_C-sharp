using System;
using System.Windows.Forms;

namespace Vehical_Management_System
{
    public partial class dashboard : Form
    {
        private string firstName;
       // private string lastName;
        private string userRole;

        public dashboard(string firstName, string lastName, string userRole)
        {
            InitializeComponent();
            lable_userInfo.Text = $"Welcome : {firstName} {lastName}";
            
            this.userRole = userRole;
            this.firstName = firstName;
            lable_user_role.Text = $"User Role : {userRole}";

        }

        private void addVehicleBtn_Click(object sender, EventArgs e)
        {
            new AddVehicles(userRole, firstName).Show();
            
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

        private void btn_logout_Click(object sender, EventArgs e)
        {
            // Confirm logout
            DialogResult result = MessageBox.Show(
                "Are you sure you want to log out?",
                "Confirm Logout",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                
                this.Hide();                
                login login = new login();
                login.Show();
                
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addDrivers addDrivers = new addDrivers();
            addDrivers.Show();
        }
    }
}
