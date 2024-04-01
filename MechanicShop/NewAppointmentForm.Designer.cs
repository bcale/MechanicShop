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
            SuspendLayout();
            // 
            // calendar_selectDate
            // 
            calendar_selectDate.Location = new Point(462, 102);
            calendar_selectDate.Name = "calendar_selectDate";
            calendar_selectDate.Size = new Size(400, 39);
            calendar_selectDate.TabIndex = 0;
            // 
            // lbl_selectDateTime
            // 
            lbl_selectDateTime.AutoSize = true;
            lbl_selectDateTime.Location = new Point(117, 107);
            lbl_selectDateTime.Name = "lbl_selectDateTime";
            lbl_selectDateTime.Size = new Size(135, 32);
            lbl_selectDateTime.TabIndex = 1;
            lbl_selectDateTime.Text = "Select Date";
            // 
            // lbl_selectCustomer
            // 
            lbl_selectCustomer.AutoSize = true;
            lbl_selectCustomer.Location = new Point(114, 311);
            lbl_selectCustomer.Name = "lbl_selectCustomer";
            lbl_selectCustomer.Size = new Size(188, 32);
            lbl_selectCustomer.TabIndex = 2;
            lbl_selectCustomer.Text = "Select Customer";
            // 
            // cmbBox_selectCustomer
            // 
            cmbBox_selectCustomer.FormattingEnabled = true;
            cmbBox_selectCustomer.Location = new Point(462, 303);
            cmbBox_selectCustomer.Name = "cmbBox_selectCustomer";
            cmbBox_selectCustomer.Size = new Size(400, 40);
            cmbBox_selectCustomer.TabIndex = 3;
            // 
            // lbl_selectCustomerCar
            // 
            lbl_selectCustomerCar.AutoSize = true;
            lbl_selectCustomerCar.Location = new Point(114, 408);
            lbl_selectCustomerCar.Name = "lbl_selectCustomerCar";
            lbl_selectCustomerCar.Size = new Size(246, 32);
            lbl_selectCustomerCar.TabIndex = 4;
            lbl_selectCustomerCar.Text = "Select Customer's Car";
            // 
            // cmbBox_selectCustomerCar
            // 
            cmbBox_selectCustomerCar.FormattingEnabled = true;
            cmbBox_selectCustomerCar.Location = new Point(462, 400);
            cmbBox_selectCustomerCar.Name = "cmbBox_selectCustomerCar";
            cmbBox_selectCustomerCar.Size = new Size(400, 40);
            cmbBox_selectCustomerCar.TabIndex = 5;
            // 
            // lbl_selectServices
            // 
            lbl_selectServices.AutoSize = true;
            lbl_selectServices.Location = new Point(117, 507);
            lbl_selectServices.Name = "lbl_selectServices";
            lbl_selectServices.Size = new Size(185, 32);
            lbl_selectServices.TabIndex = 6;
            lbl_selectServices.Text = "Select Service(s)";
            // 
            // cmbBox_selectServices
            // 
            cmbBox_selectServices.FormattingEnabled = true;
            cmbBox_selectServices.Location = new Point(462, 499);
            cmbBox_selectServices.Name = "cmbBox_selectServices";
            cmbBox_selectServices.Size = new Size(400, 40);
            cmbBox_selectServices.TabIndex = 7;
            // 
            // lbl_selectTime
            // 
            lbl_selectTime.AutoSize = true;
            lbl_selectTime.Location = new Point(117, 217);
            lbl_selectTime.Name = "lbl_selectTime";
            lbl_selectTime.Size = new Size(138, 32);
            lbl_selectTime.TabIndex = 8;
            lbl_selectTime.Text = "Select Time";
            // 
            // calendar_selectTime
            // 
            calendar_selectTime.Format = DateTimePickerFormat.Time;
            calendar_selectTime.Location = new Point(462, 210);
            calendar_selectTime.Name = "calendar_selectTime";
            calendar_selectTime.ShowUpDown = true;
            calendar_selectTime.Size = new Size(400, 39);
            calendar_selectTime.TabIndex = 9;
            // 
            // btn_confirmAppointment
            // 
            btn_confirmAppointment.Location = new Point(114, 602);
            btn_confirmAppointment.Name = "btn_confirmAppointment";
            btn_confirmAppointment.Size = new Size(305, 46);
            btn_confirmAppointment.TabIndex = 10;
            btn_confirmAppointment.Text = "Confirm Appointment";
            btn_confirmAppointment.UseVisualStyleBackColor = true;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(712, 602);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(150, 46);
            btn_cancel.TabIndex = 11;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // NewAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1070, 711);
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
    }
}