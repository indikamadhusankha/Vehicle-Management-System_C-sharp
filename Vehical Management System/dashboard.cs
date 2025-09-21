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

        public dashboard(string firstName, string lastName, string UserRole)
        {
            InitializeComponent();

            string fName = firstName;
            string lName = lastName;
        }

        private void addVehicleBtn_Click(object sender, EventArgs e)
        {
            new AddVehicles().Show();
            
        }

        private void dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnManageUser_Click(object sender, EventArgs e)
        {
            new ManageUser().Show();
        }



        private void LoadFormInPanel(Form frm)
        {
            // Clear previous controls
           // panelContainer.Controls.Clear();

            // Make the form a child of panel
            frm.TopLevel = false;  // Form එක top-level නොවන විදිහට
            frm.FormBorderStyle = FormBorderStyle.None; // Form border නැතුව
            frm.Dock = DockStyle.Fill; // panel එක පුරා expand කරන්න

            // Add form to panel
          //  panelContainer.Controls.Add(frm);
            frm.Show();
        }

        private void usermn_Click(object sender, EventArgs e)
        {
            Form myForm = new ManageUser();
            LoadFormInPanel(myForm);
        }

        
    }
}
