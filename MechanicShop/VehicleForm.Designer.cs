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
            cbBox_vehicleCustomer = new ComboBox();
            btn_vehicleAdd = new Button();
            btn_vehicleCancel = new Button();
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
            lbl_vehicleMake.Location = new Point(12, 109);
            lbl_vehicleMake.Name = "lbl_vehicleMake";
            lbl_vehicleMake.Size = new Size(45, 20);
            lbl_vehicleMake.TabIndex = 38;
            lbl_vehicleMake.Text = "Make";
            // 
            // lbl_vehicleVIN
            // 
            lbl_vehicleVIN.AutoSize = true;
            lbl_vehicleVIN.Location = new Point(12, 307);
            lbl_vehicleVIN.Name = "lbl_vehicleVIN";
            lbl_vehicleVIN.Size = new Size(33, 20);
            lbl_vehicleVIN.TabIndex = 37;
            lbl_vehicleVIN.Text = "VIN";
            // 
            // lbl_vehicleColor
            // 
            lbl_vehicleColor.AutoSize = true;
            lbl_vehicleColor.Location = new Point(12, 274);
            lbl_vehicleColor.Name = "lbl_vehicleColor";
            lbl_vehicleColor.Size = new Size(45, 20);
            lbl_vehicleColor.TabIndex = 36;
            lbl_vehicleColor.Text = "Color";
            // 
            // lbl_vehicleLicensePlate
            // 
            lbl_vehicleLicensePlate.AutoSize = true;
            lbl_vehicleLicensePlate.Location = new Point(12, 241);
            lbl_vehicleLicensePlate.Name = "lbl_vehicleLicensePlate";
            lbl_vehicleLicensePlate.Size = new Size(94, 20);
            lbl_vehicleLicensePlate.TabIndex = 35;
            lbl_vehicleLicensePlate.Text = "License Plate";
            // 
            // lbl_vehicleYear
            // 
            lbl_vehicleYear.AutoSize = true;
            lbl_vehicleYear.Location = new Point(12, 208);
            lbl_vehicleYear.Name = "lbl_vehicleYear";
            lbl_vehicleYear.Size = new Size(37, 20);
            lbl_vehicleYear.TabIndex = 34;
            lbl_vehicleYear.Text = "Year";
            // 
            // lbl_vehicleTrim
            // 
            lbl_vehicleTrim.AutoSize = true;
            lbl_vehicleTrim.Location = new Point(12, 175);
            lbl_vehicleTrim.Name = "lbl_vehicleTrim";
            lbl_vehicleTrim.Size = new Size(38, 20);
            lbl_vehicleTrim.TabIndex = 33;
            lbl_vehicleTrim.Text = "Trim";
            // 
            // lbl_vehicleModel
            // 
            lbl_vehicleModel.AutoSize = true;
            lbl_vehicleModel.Location = new Point(12, 142);
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
            lbl_customer.Size = new Size(72, 20);
            lbl_customer.TabIndex = 31;
            lbl_customer.Text = "Customer";
            // 
            // txt_vehicleVIN
            // 
            txt_vehicleVIN.Location = new Point(119, 304);
            txt_vehicleVIN.Name = "txt_vehicleVIN";
            txt_vehicleVIN.Size = new Size(199, 27);
            txt_vehicleVIN.TabIndex = 29;
            // 
            // txt_vehicleColor
            // 
            txt_vehicleColor.Location = new Point(119, 271);
            txt_vehicleColor.Name = "txt_vehicleColor";
            txt_vehicleColor.Size = new Size(199, 27);
            txt_vehicleColor.TabIndex = 28;
            // 
            // txt_vehicleLicensePlate
            // 
            txt_vehicleLicensePlate.Location = new Point(119, 238);
            txt_vehicleLicensePlate.Name = "txt_vehicleLicensePlate";
            txt_vehicleLicensePlate.Size = new Size(199, 27);
            txt_vehicleLicensePlate.TabIndex = 27;
            // 
            // txt_vehicleYear
            // 
            txt_vehicleYear.Location = new Point(119, 205);
            txt_vehicleYear.Name = "txt_vehicleYear";
            txt_vehicleYear.Size = new Size(199, 27);
            txt_vehicleYear.TabIndex = 26;
            // 
            // txt_vehicleTrim
            // 
            txt_vehicleTrim.Location = new Point(119, 172);
            txt_vehicleTrim.Name = "txt_vehicleTrim";
            txt_vehicleTrim.Size = new Size(199, 27);
            txt_vehicleTrim.TabIndex = 25;
            // 
            // txt_vehicleModel
            // 
            txt_vehicleModel.Location = new Point(119, 139);
            txt_vehicleModel.Name = "txt_vehicleModel";
            txt_vehicleModel.Size = new Size(199, 27);
            txt_vehicleModel.TabIndex = 24;
            // 
            // txt_vehicleMake
            // 
            txt_vehicleMake.Location = new Point(119, 106);
            txt_vehicleMake.Name = "txt_vehicleMake";
            txt_vehicleMake.Size = new Size(199, 27);
            txt_vehicleMake.TabIndex = 23;
            // 
            // cbBox_vehicleCustomer
            // 
            cbBox_vehicleCustomer.FormattingEnabled = true;
            cbBox_vehicleCustomer.Location = new Point(119, 68);
            cbBox_vehicleCustomer.Name = "cbBox_vehicleCustomer";
            cbBox_vehicleCustomer.Size = new Size(199, 28);
            cbBox_vehicleCustomer.TabIndex = 41;
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
            // VehicleForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(611, 473);
            Controls.Add(btn_vehicleCancel);
            Controls.Add(btn_vehicleAdd);
            Controls.Add(cbBox_vehicleCustomer);
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
        private ComboBox cbBox_vehicleCustomer;
        private Button btn_vehicleAdd;
        private Button btn_vehicleCancel;
    }
}