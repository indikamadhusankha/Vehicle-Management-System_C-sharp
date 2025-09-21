namespace Vehical_Management_System
{
    partial class AddVehicles
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
            this.label1 = new System.Windows.Forms.Label();
            this.lable_register_no = new System.Windows.Forms.Label();
            this.lableBand = new System.Windows.Forms.Label();
            this.txtRegNo = new System.Windows.Forms.TextBox();
            this.txtBand = new System.Windows.Forms.TextBox();
            this.lableVehiclaType = new System.Windows.Forms.Label();
            this.txtVehType = new System.Windows.Forms.ComboBox();
            this.lableModel = new System.Windows.Forms.Label();
            this.txtModel = new System.Windows.Forms.TextBox();
            this.lableYearManu = new System.Windows.Forms.Label();
            this.txtFuelType = new System.Windows.Forms.ComboBox();
            this.lableFuelType = new System.Windows.Forms.Label();
            this.txtEngineNo = new System.Windows.Forms.TextBox();
            this.txtChassisNo = new System.Windows.Forms.TextBox();
            this.lableEngineNumber = new System.Windows.Forms.Label();
            this.lableChassisNumber = new System.Windows.Forms.Label();
            this.btn_add_vehicle_submit = new System.Windows.Forms.Button();
            this.txtYearManuf = new System.Windows.Forms.DateTimePicker();
            this.vehicle_managementDataSet = new Vehical_Management_System.vehicle_managementDataSet();
            this.vehiclemanagementDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnDelete = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_managementDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclemanagementDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Add New Vehicle";
            // 
            // lable_register_no
            // 
            this.lable_register_no.AutoSize = true;
            this.lable_register_no.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lable_register_no.Location = new System.Drawing.Point(42, 124);
            this.lable_register_no.Name = "lable_register_no";
            this.lable_register_no.Size = new System.Drawing.Size(155, 20);
            this.lable_register_no.TabIndex = 1;
            this.lable_register_no.Text = "Registration Number";
            // 
            // lableBand
            // 
            this.lableBand.AutoSize = true;
            this.lableBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableBand.Location = new System.Drawing.Point(42, 241);
            this.lableBand.Name = "lableBand";
            this.lableBand.Size = new System.Drawing.Size(47, 20);
            this.lableBand.TabIndex = 2;
            this.lableBand.Text = "Band";
            // 
            // txtRegNo
            // 
            this.txtRegNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRegNo.Location = new System.Drawing.Point(213, 120);
            this.txtRegNo.Name = "txtRegNo";
            this.txtRegNo.Size = new System.Drawing.Size(223, 29);
            this.txtRegNo.TabIndex = 3;
            // 
            // txtBand
            // 
            this.txtBand.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBand.Location = new System.Drawing.Point(213, 239);
            this.txtBand.Name = "txtBand";
            this.txtBand.Size = new System.Drawing.Size(223, 29);
            this.txtBand.TabIndex = 4;
            // 
            // lableVehiclaType
            // 
            this.lableVehiclaType.AutoSize = true;
            this.lableVehiclaType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableVehiclaType.Location = new System.Drawing.Point(42, 163);
            this.lableVehiclaType.Name = "lableVehiclaType";
            this.lableVehiclaType.Size = new System.Drawing.Size(99, 20);
            this.lableVehiclaType.TabIndex = 5;
            this.lableVehiclaType.Text = "Vehicle Type";
            // 
            // txtVehType
            // 
            this.txtVehType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtVehType.FormattingEnabled = true;
            this.txtVehType.ItemHeight = 20;
            this.txtVehType.Items.AddRange(new object[] {
            "Car",
            "Van",
            "Jeep / SUV",
            "Pickup",
            "Minivan",
            "Bus",
            "Minibus",
            "Three-Wheeler",
            "Motorcycle",
            "Lorry / Truck",
            "Trailer",
            "Delivery Van",
            "Tractor",
            "Bulldozer",
            "Excavator",
            "Crane",
            "Forklift"});
            this.txtVehType.Location = new System.Drawing.Point(213, 160);
            this.txtVehType.Name = "txtVehType";
            this.txtVehType.Size = new System.Drawing.Size(223, 28);
            this.txtVehType.TabIndex = 6;
            // 
            // lableModel
            // 
            this.lableModel.AutoSize = true;
            this.lableModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableModel.Location = new System.Drawing.Point(42, 202);
            this.lableModel.Name = "lableModel";
            this.lableModel.Size = new System.Drawing.Size(52, 20);
            this.lableModel.TabIndex = 7;
            this.lableModel.Text = "Model";
            // 
            // txtModel
            // 
            this.txtModel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtModel.Location = new System.Drawing.Point(213, 199);
            this.txtModel.Name = "txtModel";
            this.txtModel.Size = new System.Drawing.Size(223, 29);
            this.txtModel.TabIndex = 8;
            // 
            // lableYearManu
            // 
            this.lableYearManu.AutoSize = true;
            this.lableYearManu.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableYearManu.Location = new System.Drawing.Point(42, 280);
            this.lableYearManu.Name = "lableYearManu";
            this.lableYearManu.Size = new System.Drawing.Size(155, 20);
            this.lableYearManu.TabIndex = 10;
            this.lableYearManu.Text = "Year of Manufacture";
            // 
            // txtFuelType
            // 
            this.txtFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFuelType.FormattingEnabled = true;
            this.txtFuelType.Items.AddRange(new object[] {
            "Petrol",
            "Diesel",
            "Hybrid",
            "Electric"});
            this.txtFuelType.Location = new System.Drawing.Point(213, 396);
            this.txtFuelType.Name = "txtFuelType";
            this.txtFuelType.Size = new System.Drawing.Size(223, 28);
            this.txtFuelType.TabIndex = 11;
            // 
            // lableFuelType
            // 
            this.lableFuelType.AutoSize = true;
            this.lableFuelType.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableFuelType.Location = new System.Drawing.Point(42, 397);
            this.lableFuelType.Name = "lableFuelType";
            this.lableFuelType.Size = new System.Drawing.Size(78, 20);
            this.lableFuelType.TabIndex = 12;
            this.lableFuelType.Text = "Fuel Type";
            // 
            // txtEngineNo
            // 
            this.txtEngineNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEngineNo.Location = new System.Drawing.Point(213, 316);
            this.txtEngineNo.Name = "txtEngineNo";
            this.txtEngineNo.Size = new System.Drawing.Size(223, 29);
            this.txtEngineNo.TabIndex = 13;
            // 
            // txtChassisNo
            // 
            this.txtChassisNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChassisNo.Location = new System.Drawing.Point(213, 356);
            this.txtChassisNo.Name = "txtChassisNo";
            this.txtChassisNo.Size = new System.Drawing.Size(223, 29);
            this.txtChassisNo.TabIndex = 14;
            // 
            // lableEngineNumber
            // 
            this.lableEngineNumber.AutoSize = true;
            this.lableEngineNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableEngineNumber.Location = new System.Drawing.Point(42, 319);
            this.lableEngineNumber.Name = "lableEngineNumber";
            this.lableEngineNumber.Size = new System.Drawing.Size(119, 20);
            this.lableEngineNumber.TabIndex = 15;
            this.lableEngineNumber.Text = "Engine Number";
            // 
            // lableChassisNumber
            // 
            this.lableChassisNumber.AutoSize = true;
            this.lableChassisNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lableChassisNumber.Location = new System.Drawing.Point(42, 358);
            this.lableChassisNumber.Name = "lableChassisNumber";
            this.lableChassisNumber.Size = new System.Drawing.Size(125, 20);
            this.lableChassisNumber.TabIndex = 16;
            this.lableChassisNumber.Text = "Chassis Number";
            // 
            // btn_add_vehicle_submit
            // 
            this.btn_add_vehicle_submit.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btn_add_vehicle_submit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add_vehicle_submit.FlatAppearance.BorderSize = 0;
            this.btn_add_vehicle_submit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add_vehicle_submit.Location = new System.Drawing.Point(213, 432);
            this.btn_add_vehicle_submit.Name = "btn_add_vehicle_submit";
            this.btn_add_vehicle_submit.Size = new System.Drawing.Size(142, 36);
            this.btn_add_vehicle_submit.TabIndex = 17;
            this.btn_add_vehicle_submit.Text = "Add Vehicle";
            this.btn_add_vehicle_submit.UseVisualStyleBackColor = false;
            this.btn_add_vehicle_submit.Click += new System.EventHandler(this.btn_add_vehicle_submit_Click);
            // 
            // txtYearManuf
            // 
            this.txtYearManuf.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearManuf.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.txtYearManuf.Location = new System.Drawing.Point(213, 279);
            this.txtYearManuf.Name = "txtYearManuf";
            this.txtYearManuf.Size = new System.Drawing.Size(223, 26);
            this.txtYearManuf.TabIndex = 18;
            // 
            // vehicle_managementDataSet
            // 
            this.vehicle_managementDataSet.DataSetName = "vehicle_managementDataSet";
            this.vehicle_managementDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vehiclemanagementDataSetBindingSource
            // 
            this.vehiclemanagementDataSetBindingSource.DataSource = this.vehicle_managementDataSet;
            this.vehiclemanagementDataSetBindingSource.Position = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(456, 120);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(638, 347);
            this.dataGridView1.TabIndex = 19;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnDelete.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDelete.FlatAppearance.BorderSize = 0;
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(952, 479);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(142, 36);
            this.btnDelete.TabIndex = 20;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // AddVehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1115, 578);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtYearManuf);
            this.Controls.Add(this.btn_add_vehicle_submit);
            this.Controls.Add(this.lableChassisNumber);
            this.Controls.Add(this.lableEngineNumber);
            this.Controls.Add(this.txtChassisNo);
            this.Controls.Add(this.txtEngineNo);
            this.Controls.Add(this.lableFuelType);
            this.Controls.Add(this.txtFuelType);
            this.Controls.Add(this.lableYearManu);
            this.Controls.Add(this.txtModel);
            this.Controls.Add(this.lableModel);
            this.Controls.Add(this.txtVehType);
            this.Controls.Add(this.lableVehiclaType);
            this.Controls.Add(this.txtBand);
            this.Controls.Add(this.txtRegNo);
            this.Controls.Add(this.lableBand);
            this.Controls.Add(this.lable_register_no);
            this.Controls.Add(this.label1);
            this.Name = "AddVehicles";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Vehicles";
            this.Load += new System.EventHandler(this.AddVehicles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.vehicle_managementDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclemanagementDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lable_register_no;
        private System.Windows.Forms.Label lableBand;
        private System.Windows.Forms.TextBox txtRegNo;
        private System.Windows.Forms.TextBox txtBand;
        private System.Windows.Forms.Label lableVehiclaType;
        private System.Windows.Forms.ComboBox txtVehType;
        private System.Windows.Forms.Label lableModel;
        private System.Windows.Forms.TextBox txtModel;
        private System.Windows.Forms.Label lableYearManu;
        private System.Windows.Forms.ComboBox txtFuelType;
        private System.Windows.Forms.Label lableFuelType;
        private System.Windows.Forms.TextBox txtEngineNo;
        private System.Windows.Forms.TextBox txtChassisNo;
        private System.Windows.Forms.Label lableEngineNumber;
        private System.Windows.Forms.Label lableChassisNumber;
        private System.Windows.Forms.Button btn_add_vehicle_submit;
        private System.Windows.Forms.DateTimePicker txtYearManuf;
        private System.Windows.Forms.BindingSource vehiclemanagementDataSetBindingSource;
        private vehicle_managementDataSet vehicle_managementDataSet;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnDelete;
    }
}