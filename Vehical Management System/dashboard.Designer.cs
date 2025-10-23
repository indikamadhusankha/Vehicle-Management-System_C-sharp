namespace Vehical_Management_System
{
    partial class dashboard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard));
            this.operatorPanel_1 = new System.Windows.Forms.Panel();
            this.addVehicleBtn = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dashbosrd_title = new System.Windows.Forms.Label();
            this.ManageUserPanel = new System.Windows.Forms.Panel();
            this.btnManageUser = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.addDriversPannel = new System.Windows.Forms.Panel();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.button1 = new System.Windows.Forms.Button();
            this.MaintainPannel = new System.Windows.Forms.Panel();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.reportsPannel = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.button3 = new System.Windows.Forms.Button();
            this.vehicle_managementDataSet = new Vehical_Management_System.vehicle_managementDataSet();
            this.usersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.usersTableAdapter = new Vehical_Management_System.vehicle_managementDataSetTableAdapters.usersTableAdapter();
            this.tableAdapterManager = new Vehical_Management_System.vehicle_managementDataSetTableAdapters.TableAdapterManager();
            this.panel2 = new System.Windows.Forms.Panel();
            this.lable_userInfo = new System.Windows.Forms.Label();
            this.lable_user_role = new System.Windows.Forms.Label();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.operatorPanel_1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.ManageUserPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.addDriversPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.MaintainPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.reportsPannel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_managementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // operatorPanel_1
            // 
            this.operatorPanel_1.BackColor = System.Drawing.Color.PowderBlue;
            this.operatorPanel_1.Controls.Add(this.addVehicleBtn);
            this.operatorPanel_1.Controls.Add(this.pictureBox1);
            this.operatorPanel_1.Cursor = System.Windows.Forms.Cursors.Default;
            this.operatorPanel_1.Location = new System.Drawing.Point(12, 9);
            this.operatorPanel_1.Name = "operatorPanel_1";
            this.operatorPanel_1.Size = new System.Drawing.Size(132, 85);
            this.operatorPanel_1.TabIndex = 0;
            // 
            // addVehicleBtn
            // 
            this.addVehicleBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addVehicleBtn.Location = new System.Drawing.Point(0, 57);
            this.addVehicleBtn.Name = "addVehicleBtn";
            this.addVehicleBtn.Size = new System.Drawing.Size(132, 28);
            this.addVehicleBtn.TabIndex = 1;
            this.addVehicleBtn.Text = "Vehicles";
            this.addVehicleBtn.UseVisualStyleBackColor = true;
            this.addVehicleBtn.Click += new System.EventHandler(this.addVehicleBtn_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(15, 7);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(104, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // dashbosrd_title
            // 
            this.dashbosrd_title.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.dashbosrd_title.AutoSize = true;
            this.dashbosrd_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dashbosrd_title.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dashbosrd_title.Location = new System.Drawing.Point(324, 26);
            this.dashbosrd_title.Name = "dashbosrd_title";
            this.dashbosrd_title.Size = new System.Drawing.Size(456, 37);
            this.dashbosrd_title.TabIndex = 1;
            this.dashbosrd_title.Text = "Vehical Management System";
            // 
            // ManageUserPanel
            // 
            this.ManageUserPanel.BackColor = System.Drawing.Color.PowderBlue;
            this.ManageUserPanel.Controls.Add(this.btnManageUser);
            this.ManageUserPanel.Controls.Add(this.pictureBox2);
            this.ManageUserPanel.Location = new System.Drawing.Point(12, 373);
            this.ManageUserPanel.Name = "ManageUserPanel";
            this.ManageUserPanel.Size = new System.Drawing.Size(132, 85);
            this.ManageUserPanel.TabIndex = 2;
            // 
            // btnManageUser
            // 
            this.btnManageUser.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnManageUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnManageUser.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnManageUser.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnManageUser.Location = new System.Drawing.Point(0, 54);
            this.btnManageUser.Name = "btnManageUser";
            this.btnManageUser.Size = new System.Drawing.Size(132, 31);
            this.btnManageUser.TabIndex = 1;
            this.btnManageUser.Text = "Users";
            this.btnManageUser.UseVisualStyleBackColor = true;
            this.btnManageUser.Click += new System.EventHandler(this.btnManageUser_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(14, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 50);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // addDriversPannel
            // 
            this.addDriversPannel.BackColor = System.Drawing.Color.PowderBlue;
            this.addDriversPannel.Controls.Add(this.pictureBox4);
            this.addDriversPannel.Controls.Add(this.button1);
            this.addDriversPannel.Location = new System.Drawing.Point(12, 100);
            this.addDriversPannel.Name = "addDriversPannel";
            this.addDriversPannel.Size = new System.Drawing.Size(132, 85);
            this.addDriversPannel.TabIndex = 8;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(19, 3);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(100, 50);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 13;
            this.pictureBox4.TabStop = false;
            // 
            // button1
            // 
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(0, 55);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(132, 30);
            this.button1.TabIndex = 9;
            this.button1.Text = "Drivers";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MaintainPannel
            // 
            this.MaintainPannel.BackColor = System.Drawing.Color.PowderBlue;
            this.MaintainPannel.Controls.Add(this.pictureBox5);
            this.MaintainPannel.Controls.Add(this.button2);
            this.MaintainPannel.Location = new System.Drawing.Point(12, 191);
            this.MaintainPannel.Name = "MaintainPannel";
            this.MaintainPannel.Size = new System.Drawing.Size(132, 85);
            this.MaintainPannel.TabIndex = 10;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(15, 6);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(100, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 13;
            this.pictureBox5.TabStop = false;
            // 
            // button2
            // 
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(0, 55);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(132, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Maintenance";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // reportsPannel
            // 
            this.reportsPannel.BackColor = System.Drawing.Color.PowderBlue;
            this.reportsPannel.Controls.Add(this.button4);
            this.reportsPannel.Controls.Add(this.pictureBox6);
            this.reportsPannel.Controls.Add(this.button3);
            this.reportsPannel.Location = new System.Drawing.Point(12, 282);
            this.reportsPannel.Name = "reportsPannel";
            this.reportsPannel.Size = new System.Drawing.Size(132, 85);
            this.reportsPannel.TabIndex = 11;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(0, 54);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(132, 30);
            this.button4.TabIndex = 14;
            this.button4.Text = "Reports";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(14, 4);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(100, 50);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 13;
            this.pictureBox6.TabStop = false;
            // 
            // button3
            // 
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(743, 3);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(146, 30);
            this.button3.TabIndex = 9;
            this.button3.Text = "Reports";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // vehicle_managementDataSet
            // 
            this.vehicle_managementDataSet.DataSetName = "vehicle_managementDataSet";
            this.vehicle_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // usersBindingSource
            // 
            this.usersBindingSource.DataMember = "users";
            this.usersBindingSource.DataSource = this.vehicle_managementDataSet;
            // 
            // usersTableAdapter
            // 
            this.usersTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.booksTableAdapter = null;
            this.tableAdapterManager.driversTableAdapter = null;
            this.tableAdapterManager.maintainsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Vehical_Management_System.vehicle_managementDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.usersTableAdapter = this.usersTableAdapter;
            this.tableAdapterManager.vehiclesTableAdapter = null;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel2.Controls.Add(this.dashbosrd_title);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1130, 94);
            this.panel2.TabIndex = 15;
            // 
            // lable_userInfo
            // 
            this.lable_userInfo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lable_userInfo.AutoSize = true;
            this.lable_userInfo.BackColor = System.Drawing.Color.Transparent;
            this.lable_userInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_userInfo.ForeColor = System.Drawing.Color.Black;
            this.lable_userInfo.Location = new System.Drawing.Point(174, 109);
            this.lable_userInfo.Name = "lable_userInfo";
            this.lable_userInfo.Size = new System.Drawing.Size(71, 25);
            this.lable_userInfo.TabIndex = 5;
            this.lable_userInfo.Text = "fname";
            // 
            // lable_user_role
            // 
            this.lable_user_role.AutoSize = true;
            this.lable_user_role.BackColor = System.Drawing.Color.Transparent;
            this.lable_user_role.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_user_role.ForeColor = System.Drawing.Color.Black;
            this.lable_user_role.Location = new System.Drawing.Point(175, 135);
            this.lable_user_role.Name = "lable_user_role";
            this.lable_user_role.Size = new System.Drawing.Size(80, 20);
            this.lable_user_role.TabIndex = 6;
            this.lable_user_role.Text = "User Role";
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.Crimson;
            this.btn_logout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_logout.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.btn_logout.FlatAppearance.BorderSize = 0;
            this.btn_logout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_logout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_logout.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.btn_logout.Location = new System.Drawing.Point(12, 464);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(132, 32);
            this.btn_logout.TabIndex = 13;
            this.btn_logout.Text = "Log Out";
            this.btn_logout.UseVisualStyleBackColor = false;
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Turquoise;
            this.panel1.Controls.Add(this.reportsPannel);
            this.panel1.Controls.Add(this.MaintainPannel);
            this.panel1.Controls.Add(this.btn_logout);
            this.panel1.Controls.Add(this.addDriversPannel);
            this.panel1.Controls.Add(this.ManageUserPanel);
            this.panel1.Controls.Add(this.operatorPanel_1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 94);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(159, 581);
            this.panel1.TabIndex = 16;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Teal;
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(159, 631);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(971, 44);
            this.panel3.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(17, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(242, 16);
            this.label1.TabIndex = 18;
            this.label1.Text = "Developed by : Madhusankha B H A A I";
            // 
            // dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleTurquoise;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1130, 675);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.lable_user_role);
            this.Controls.Add(this.lable_userInfo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.dashboard_Load);
            this.operatorPanel_1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ManageUserPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.addDriversPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.MaintainPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.reportsPannel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_managementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.usersBindingSource)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel operatorPanel_1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.Label dashbosrd_title;
        private System.Windows.Forms.Panel ManageUserPanel;
        private System.Windows.Forms.Button btnManageUser;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button addVehicleBtn;
        private System.Windows.Forms.Panel addDriversPannel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel MaintainPannel;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel reportsPannel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private vehicle_managementDataSet vehicle_managementDataSet;
        private System.Windows.Forms.BindingSource usersBindingSource;
        private vehicle_managementDataSetTableAdapters.usersTableAdapter usersTableAdapter;
        private vehicle_managementDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label lable_user_role;
        private System.Windows.Forms.Label lable_userInfo;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
    }
}