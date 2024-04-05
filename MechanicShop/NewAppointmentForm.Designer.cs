namespace MechanicShop
{
    partial class NewAppointmentForm
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
            calendar_selectDate = new DateTimePicker();
            lbl_selectDateTime = new Label();
            lbl_selectCustomer = new Label();
            cmbBox_selectCustomer = new ComboBox();
            lbl_selectCustomerCar = new Label();
            cmbBox_selectCustomerCar = new ComboBox();
            lbl_selectServices = new Label();
            cmbBox_selectServices = new ComboBox();
            lbl_selectTime = new Label();
            calendar_selectTime = new DateTimePicker();
            btn_confirmAppointment = new Button();
            btn_cancel = new Button();
            cmbBox_selectTechnician = new ComboBox();
            lbl_selectTechnician = new Label();
            checkBox_Status = new CheckBox();
            SuspendLayout();
            // 
            // calendar_selectDate
            // 
            calendar_selectDate.Format = DateTimePickerFormat.Short;
            calendar_selectDate.Location = new Point(462, 50);
            calendar_selectDate.Name = "calendar_selectDate";
            calendar_selectDate.Size = new Size(400, 39);
            calendar_selectDate.TabIndex = 0;
            // 
            // lbl_selectDateTime
            // 
            lbl_selectDateTime.AutoSize = true;
            lbl_selectDateTime.Location = new Point(117, 54);
            lbl_selectDateTime.Name = "lbl_selectDateTime";
            lbl_selectDateTime.Size = new Size(135, 32);
            lbl_selectDateTime.TabIndex = 1;
            lbl_selectDateTime.Text = "Select Date";
            // 
            // lbl_selectCustomer
            // 
            lbl_selectCustomer.AutoSize = true;
            lbl_selectCustomer.Location = new Point(114, 258);
            lbl_selectCustomer.Name = "lbl_selectCustomer";
            lbl_selectCustomer.Size = new Size(188, 32);
            lbl_selectCustomer.TabIndex = 2;
            lbl_selectCustomer.Text = "Select Customer";
            // 
            // cmbBox_selectCustomer
            // 
            cmbBox_selectCustomer.FormattingEnabled = true;
            cmbBox_selectCustomer.Location = new Point(462, 250);
            cmbBox_selectCustomer.Name = "cmbBox_selectCustomer";
            cmbBox_selectCustomer.Size = new Size(400, 40);
            cmbBox_selectCustomer.TabIndex = 3;
            cmbBox_selectCustomer.SelectedIndexChanged += cmbBox_selectCustomer_SelectedIndexChanged;
            // 
            // lbl_selectCustomerCar
            // 
            lbl_selectCustomerCar.AutoSize = true;
            lbl_selectCustomerCar.Location = new Point(114, 355);
            lbl_selectCustomerCar.Name = "lbl_selectCustomerCar";
            lbl_selectCustomerCar.Size = new Size(246, 32);
            lbl_selectCustomerCar.TabIndex = 4;
            lbl_selectCustomerCar.Text = "Select Customer's Car";
            // 
            // cmbBox_selectCustomerCar
            // 
            cmbBox_selectCustomerCar.FormattingEnabled = true;
            cmbBox_selectCustomerCar.Location = new Point(462, 347);
            cmbBox_selectCustomerCar.Name = "cmbBox_selectCustomerCar";
            cmbBox_selectCustomerCar.Size = new Size(400, 40);
            cmbBox_selectCustomerCar.TabIndex = 5;
            // 
            // lbl_selectServices
            // 
            lbl_selectServices.AutoSize = true;
            lbl_selectServices.Location = new Point(117, 454);
            lbl_selectServices.Name = "lbl_selectServices";
            lbl_selectServices.Size = new Size(185, 32);
            lbl_selectServices.TabIndex = 6;
            lbl_selectServices.Text = "Select Service(s)";
            // 
            // cmbBox_selectServices
            // 
            cmbBox_selectServices.FormattingEnabled = true;
            cmbBox_selectServices.Location = new Point(462, 446);
            cmbBox_selectServices.Name = "cmbBox_selectServices";
            cmbBox_selectServices.Size = new Size(400, 40);
            cmbBox_selectServices.TabIndex = 7;
            cmbBox_selectServices.SelectedIndexChanged += cmbBox_selectServices_SelectedIndexChanged;
            // 
            // lbl_selectTime
            // 
            lbl_selectTime.AutoSize = true;
            lbl_selectTime.Location = new Point(117, 165);
            lbl_selectTime.Name = "lbl_selectTime";
            lbl_selectTime.Size = new Size(138, 32);
            lbl_selectTime.TabIndex = 8;
            lbl_selectTime.Text = "Select Time";
            // 
            // calendar_selectTime
            // 
            calendar_selectTime.Format = DateTimePickerFormat.Time;
            calendar_selectTime.Location = new Point(462, 157);
            calendar_selectTime.Name = "calendar_selectTime";
            calendar_selectTime.ShowUpDown = true;
            calendar_selectTime.Size = new Size(400, 39);
            calendar_selectTime.TabIndex = 9;
            // 
            // btn_confirmAppointment
            // 
            btn_confirmAppointment.Location = new Point(117, 750);
            btn_confirmAppointment.Name = "btn_confirmAppointment";
            btn_confirmAppointment.Size = new Size(306, 46);
            btn_confirmAppointment.TabIndex = 10;
            btn_confirmAppointment.Text = "Confirm Appointment";
            btn_confirmAppointment.UseVisualStyleBackColor = true;
            btn_confirmAppointment.Click += btn_confirmAppointment_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(715, 750);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(150, 46);
            btn_cancel.TabIndex = 11;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // cmbBox_selectTechnician
            // 
            cmbBox_selectTechnician.FormattingEnabled = true;
            cmbBox_selectTechnician.Location = new Point(462, 544);
            cmbBox_selectTechnician.Name = "cmbBox_selectTechnician";
            cmbBox_selectTechnician.Size = new Size(400, 40);
            cmbBox_selectTechnician.TabIndex = 13;
            // 
            // lbl_selectTechnician
            // 
            lbl_selectTechnician.AutoSize = true;
            lbl_selectTechnician.Location = new Point(117, 552);
            lbl_selectTechnician.Name = "lbl_selectTechnician";
            lbl_selectTechnician.Size = new Size(197, 32);
            lbl_selectTechnician.TabIndex = 12;
            lbl_selectTechnician.Text = "Select Technician";
            // 
            // checkBox_Status
            // 
            checkBox_Status.AutoSize = true;
            checkBox_Status.Location = new Point(117, 704);
            checkBox_Status.Margin = new Padding(5, 5, 5, 5);
            checkBox_Status.Name = "checkBox_Status";
            checkBox_Status.Size = new Size(164, 36);
            checkBox_Status.TabIndex = 15;
            checkBox_Status.Text = "Completed";
            checkBox_Status.UseVisualStyleBackColor = true;
            // 
            // NewAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1069, 814);
            Controls.Add(checkBox_Status);
            Controls.Add(cmbBox_selectTechnician);
            Controls.Add(lbl_selectTechnician);
            Controls.Add(btn_cancel);
            Controls.Add(btn_confirmAppointment);
            Controls.Add(calendar_selectTime);
            Controls.Add(lbl_selectTime);
            Controls.Add(cmbBox_selectServices);
            Controls.Add(lbl_selectServices);
            Controls.Add(cmbBox_selectCustomerCar);
            Controls.Add(lbl_selectCustomerCar);
            Controls.Add(cmbBox_selectCustomer);
            Controls.Add(lbl_selectCustomer);
            Controls.Add(lbl_selectDateTime);
            Controls.Add(calendar_selectDate);
            Name = "NewAppointmentForm";
            Text = "Schedule New Appointment";
            Load += NewAppointmentForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker calendar_selectDate;
        private Label lbl_selectDateTime;
        private Label lbl_selectCustomer;
        private ComboBox cmbBox_selectCustomer;
        private Label lbl_selectCustomerCar;
        private ComboBox cmbBox_selectCustomerCar;
        private Label lbl_selectServices;
        private ComboBox cmbBox_selectServices;
        private Label lbl_selectTime;
        private DateTimePicker calendar_selectTime;
        private Button btn_confirmAppointment;
        private Button btn_cancel;
        private ComboBox cmbBox_selectTechnician;
        private Label lbl_selectTechnician;
        private CheckBox checkBox_Status;
    }
}