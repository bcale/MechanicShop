namespace MechanicShop
{
    partial class VehicleForm
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
            lbl_AddCustomerTitle = new Label();
            lbl_vehicleMake = new Label();
            lbl_vehicleVIN = new Label();
            lbl_vehicleColor = new Label();
            lbl_vehicleLicensePlate = new Label();
            lbl_vehicleYear = new Label();
            lbl_vehicleTrim = new Label();
            lbl_vehicleModel = new Label();
            lbl_customer = new Label();
            txt_vehicleVIN = new TextBox();
            txt_vehicleColor = new TextBox();
            txt_vehicleLicensePlate = new TextBox();
            txt_vehicleYear = new TextBox();
            txt_vehicleTrim = new TextBox();
            txt_vehicleModel = new TextBox();
            txt_vehicleMake = new TextBox();
            btn_vehicleAdd = new Button();
            btn_vehicleCancel = new Button();
            txt_customer_firstName = new TextBox();
            txt_customer_lastName = new TextBox();
            btn_customer_search = new Button();
            dataGrid_customer_search_results = new DataGridView();
            lbl_customerID = new Label();
            txt_customerID = new TextBox();
            ((System.ComponentModel.ISupportInitialize)dataGrid_customer_search_results).BeginInit();
            SuspendLayout();
            // 
            // lbl_AddCustomerTitle
            // 
            lbl_AddCustomerTitle.AutoSize = true;
            lbl_AddCustomerTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_AddCustomerTitle.Location = new Point(9, 8);
            lbl_AddCustomerTitle.Name = "lbl_AddCustomerTitle";
            lbl_AddCustomerTitle.Size = new Size(181, 41);
            lbl_AddCustomerTitle.TabIndex = 40;
            lbl_AddCustomerTitle.Text = "Vehicle Data";
            // 
            // lbl_vehicleMake
            // 
            lbl_vehicleMake.AutoSize = true;
            lbl_vehicleMake.Location = new Point(12, 184);
            lbl_vehicleMake.Name = "lbl_vehicleMake";
            lbl_vehicleMake.Size = new Size(45, 20);
            lbl_vehicleMake.TabIndex = 38;
            lbl_vehicleMake.Text = "Make";
            // 
            // lbl_vehicleVIN
            // 
            lbl_vehicleVIN.AutoSize = true;
            lbl_vehicleVIN.Location = new Point(12, 382);
            lbl_vehicleVIN.Name = "lbl_vehicleVIN";
            lbl_vehicleVIN.Size = new Size(33, 20);
            lbl_vehicleVIN.TabIndex = 37;
            lbl_vehicleVIN.Text = "VIN";
            // 
            // lbl_vehicleColor
            // 
            lbl_vehicleColor.AutoSize = true;
            lbl_vehicleColor.Location = new Point(12, 349);
            lbl_vehicleColor.Name = "lbl_vehicleColor";
            lbl_vehicleColor.Size = new Size(45, 20);
            lbl_vehicleColor.TabIndex = 36;
            lbl_vehicleColor.Text = "Color";
            // 
            // lbl_vehicleLicensePlate
            // 
            lbl_vehicleLicensePlate.AutoSize = true;
            lbl_vehicleLicensePlate.Location = new Point(12, 316);
            lbl_vehicleLicensePlate.Name = "lbl_vehicleLicensePlate";
            lbl_vehicleLicensePlate.Size = new Size(94, 20);
            lbl_vehicleLicensePlate.TabIndex = 35;
            lbl_vehicleLicensePlate.Text = "License Plate";
            // 
            // lbl_vehicleYear
            // 
            lbl_vehicleYear.AutoSize = true;
            lbl_vehicleYear.Location = new Point(12, 283);
            lbl_vehicleYear.Name = "lbl_vehicleYear";
            lbl_vehicleYear.Size = new Size(37, 20);
            lbl_vehicleYear.TabIndex = 34;
            lbl_vehicleYear.Text = "Year";
            // 
            // lbl_vehicleTrim
            // 
            lbl_vehicleTrim.AutoSize = true;
            lbl_vehicleTrim.Location = new Point(12, 250);
            lbl_vehicleTrim.Name = "lbl_vehicleTrim";
            lbl_vehicleTrim.Size = new Size(38, 20);
            lbl_vehicleTrim.TabIndex = 33;
            lbl_vehicleTrim.Text = "Trim";
            // 
            // lbl_vehicleModel
            // 
            lbl_vehicleModel.AutoSize = true;
            lbl_vehicleModel.Location = new Point(12, 218);
            lbl_vehicleModel.Name = "lbl_vehicleModel";
            lbl_vehicleModel.Size = new Size(52, 20);
            lbl_vehicleModel.TabIndex = 32;
            lbl_vehicleModel.Text = "Model";
            // 
            // lbl_customer
            // 
            lbl_customer.AutoSize = true;
            lbl_customer.Location = new Point(9, 71);
            lbl_customer.Name = "lbl_customer";
            lbl_customer.Size = new Size(116, 20);
            lbl_customer.TabIndex = 31;
            lbl_customer.Text = "Select Customer";
            // 
            // txt_vehicleVIN
            // 
            txt_vehicleVIN.Location = new Point(119, 379);
            txt_vehicleVIN.Name = "txt_vehicleVIN";
            txt_vehicleVIN.Size = new Size(199, 27);
            txt_vehicleVIN.TabIndex = 29;
            // 
            // txt_vehicleColor
            // 
            txt_vehicleColor.Location = new Point(119, 346);
            txt_vehicleColor.Name = "txt_vehicleColor";
            txt_vehicleColor.Size = new Size(199, 27);
            txt_vehicleColor.TabIndex = 28;
            // 
            // txt_vehicleLicensePlate
            // 
            txt_vehicleLicensePlate.Location = new Point(119, 314);
            txt_vehicleLicensePlate.Name = "txt_vehicleLicensePlate";
            txt_vehicleLicensePlate.Size = new Size(199, 27);
            txt_vehicleLicensePlate.TabIndex = 27;
            // 
            // txt_vehicleYear
            // 
            txt_vehicleYear.Location = new Point(119, 280);
            txt_vehicleYear.Name = "txt_vehicleYear";
            txt_vehicleYear.Size = new Size(199, 27);
            txt_vehicleYear.TabIndex = 26;
            // 
            // txt_vehicleTrim
            // 
            txt_vehicleTrim.Location = new Point(119, 247);
            txt_vehicleTrim.Name = "txt_vehicleTrim";
            txt_vehicleTrim.Size = new Size(199, 27);
            txt_vehicleTrim.TabIndex = 25;
            // 
            // txt_vehicleModel
            // 
            txt_vehicleModel.Location = new Point(119, 214);
            txt_vehicleModel.Name = "txt_vehicleModel";
            txt_vehicleModel.Size = new Size(199, 27);
            txt_vehicleModel.TabIndex = 24;
            // 
            // txt_vehicleMake
            // 
            txt_vehicleMake.Location = new Point(119, 181);
            txt_vehicleMake.Name = "txt_vehicleMake";
            txt_vehicleMake.Size = new Size(199, 27);
            txt_vehicleMake.TabIndex = 23;
            // 
            // btn_vehicleAdd
            // 
            btn_vehicleAdd.Location = new Point(12, 432);
            btn_vehicleAdd.Name = "btn_vehicleAdd";
            btn_vehicleAdd.Size = new Size(94, 29);
            btn_vehicleAdd.TabIndex = 42;
            btn_vehicleAdd.Text = "Add Vehicle";
            btn_vehicleAdd.UseVisualStyleBackColor = true;
            btn_vehicleAdd.Click += btn_vehicleAdd_Click;
            // 
            // btn_vehicleCancel
            // 
            btn_vehicleCancel.Location = new Point(121, 432);
            btn_vehicleCancel.Name = "btn_vehicleCancel";
            btn_vehicleCancel.Size = new Size(94, 29);
            btn_vehicleCancel.TabIndex = 43;
            btn_vehicleCancel.Text = "Cancel";
            btn_vehicleCancel.UseVisualStyleBackColor = true;
            btn_vehicleCancel.Click += btn_vehicleCancel_Click;
            // 
            // txt_customer_firstName
            // 
            txt_customer_firstName.Location = new Point(12, 94);
            txt_customer_firstName.Margin = new Padding(2, 2, 2, 2);
            txt_customer_firstName.Name = "txt_customer_firstName";
            txt_customer_firstName.Size = new Size(143, 27);
            txt_customer_firstName.TabIndex = 44;
            txt_customer_firstName.Text = "First Name";
            // 
            // txt_customer_lastName
            // 
            txt_customer_lastName.Location = new Point(159, 94);
            txt_customer_lastName.Margin = new Padding(2, 2, 2, 2);
            txt_customer_lastName.Name = "txt_customer_lastName";
            txt_customer_lastName.Size = new Size(159, 27);
            txt_customer_lastName.TabIndex = 45;
            txt_customer_lastName.Text = "Last Name";
            // 
            // btn_customer_search
            // 
            btn_customer_search.Location = new Point(322, 92);
            btn_customer_search.Margin = new Padding(2, 2, 2, 2);
            btn_customer_search.Name = "btn_customer_search";
            btn_customer_search.Size = new Size(90, 27);
            btn_customer_search.TabIndex = 46;
            btn_customer_search.Text = "Search";
            btn_customer_search.UseVisualStyleBackColor = true;
            btn_customer_search.Click += btn_customer_search_Click;
            // 
            // dataGrid_customer_search_results
            // 
            dataGrid_customer_search_results.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGrid_customer_search_results.Location = new Point(426, 92);
            dataGrid_customer_search_results.Margin = new Padding(2, 2, 2, 2);
            dataGrid_customer_search_results.Name = "dataGrid_customer_search_results";
            dataGrid_customer_search_results.RowHeadersWidth = 62;
            dataGrid_customer_search_results.Size = new Size(591, 310);
            dataGrid_customer_search_results.TabIndex = 47;
            // 
            // lbl_customerID
            // 
            lbl_customerID.AutoSize = true;
            lbl_customerID.Location = new Point(12, 149);
            lbl_customerID.Margin = new Padding(2, 0, 2, 0);
            lbl_customerID.Name = "lbl_customerID";
            lbl_customerID.Size = new Size(91, 20);
            lbl_customerID.TabIndex = 48;
            lbl_customerID.Text = "Customer ID";
            // 
            // txt_customerID
            // 
            txt_customerID.Location = new Point(119, 149);
            txt_customerID.Margin = new Padding(2, 2, 2, 2);
            txt_customerID.Name = "txt_customerID";
            txt_customerID.Size = new Size(121, 27);
            txt_customerID.TabIndex = 49;
            // 
            // VehicleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1035, 470);
            Controls.Add(txt_customerID);
            Controls.Add(lbl_customerID);
            Controls.Add(dataGrid_customer_search_results);
            Controls.Add(btn_customer_search);
            Controls.Add(txt_customer_lastName);
            Controls.Add(txt_customer_firstName);
            Controls.Add(btn_vehicleCancel);
            Controls.Add(btn_vehicleAdd);
            Controls.Add(lbl_AddCustomerTitle);
            Controls.Add(lbl_vehicleMake);
            Controls.Add(lbl_vehicleVIN);
            Controls.Add(lbl_vehicleColor);
            Controls.Add(lbl_vehicleLicensePlate);
            Controls.Add(lbl_vehicleYear);
            Controls.Add(lbl_vehicleTrim);
            Controls.Add(lbl_vehicleModel);
            Controls.Add(lbl_customer);
            Controls.Add(txt_vehicleVIN);
            Controls.Add(txt_vehicleColor);
            Controls.Add(txt_vehicleLicensePlate);
            Controls.Add(txt_vehicleYear);
            Controls.Add(txt_vehicleTrim);
            Controls.Add(txt_vehicleModel);
            Controls.Add(txt_vehicleMake);
            Name = "VehicleForm";
            Text = "Vehicles";
            Load += VehicleForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGrid_customer_search_results).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_AddCustomerTitle;
        private Label lbl_vehicleMake;
        private Label lbl_vehicleVIN;
        private Label lbl_vehicleColor;
        private Label lbl_vehicleLicensePlate;
        private Label lbl_vehicleYear;
        private Label lbl_vehicleTrim;
        private Label lbl_vehicleModel;
        private Label lbl_customer;
        private TextBox txt_vehicleVIN;
        private TextBox txt_vehicleColor;
        private TextBox txt_vehicleLicensePlate;
        private TextBox txt_vehicleYear;
        private TextBox txt_vehicleTrim;
        private TextBox txt_vehicleModel;
        private TextBox txt_vehicleMake;
        private Button btn_vehicleAdd;
        private Button btn_vehicleCancel;
        private TextBox txt_customer_firstName;
        private TextBox txt_customer_lastName;
        private Button btn_customer_search;
        private DataGridView dataGrid_customer_search_results;
        private Label lbl_customerID;
        private TextBox txt_customerID;
    }
}