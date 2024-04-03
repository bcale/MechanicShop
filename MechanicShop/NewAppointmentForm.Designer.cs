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
            lbl_selectTechnician = new Label();
            cmbBox_selectTechnician = new ComboBox();
            cmbBox_selectTech = new ComboBox();
            lbl_selectTech = new Label();
            SuspendLayout();
            // 
            // calendar_selectDate
            // 
            calendar_selectDate.Location = new Point(284, 64);
            calendar_selectDate.Margin = new Padding(2);
            calendar_selectDate.Name = "calendar_selectDate";
            calendar_selectDate.Size = new Size(248, 27);
            calendar_selectDate.TabIndex = 0;
            // 
            // lbl_selectDateTime
            // 
            lbl_selectDateTime.AutoSize = true;
            lbl_selectDateTime.Location = new Point(72, 67);
            lbl_selectDateTime.Margin = new Padding(2, 0, 2, 0);
            lbl_selectDateTime.Name = "lbl_selectDateTime";
            lbl_selectDateTime.Size = new Size(85, 20);
            lbl_selectDateTime.TabIndex = 1;
            lbl_selectDateTime.Text = "Select Date";
            // 
            // lbl_selectCustomer
            // 
            lbl_selectCustomer.AutoSize = true;
            lbl_selectCustomer.Location = new Point(70, 194);
            lbl_selectCustomer.Margin = new Padding(2, 0, 2, 0);
            lbl_selectCustomer.Name = "lbl_selectCustomer";
            lbl_selectCustomer.Size = new Size(116, 20);
            lbl_selectCustomer.TabIndex = 2;
            lbl_selectCustomer.Text = "Select Customer";
            // 
            // cmbBox_selectCustomer
            // 
            cmbBox_selectCustomer.FormattingEnabled = true;
            cmbBox_selectCustomer.Location = new Point(284, 189);
            cmbBox_selectCustomer.Margin = new Padding(2);
            cmbBox_selectCustomer.Name = "cmbBox_selectCustomer";
            cmbBox_selectCustomer.Size = new Size(248, 28);
            cmbBox_selectCustomer.TabIndex = 3;
            cmbBox_selectCustomer.SelectedIndexChanged += cmbBox_selectCustomer_SelectedIndexChanged;
            // 
            // lbl_selectCustomerCar
            // 
            lbl_selectCustomerCar.AutoSize = true;
            lbl_selectCustomerCar.Location = new Point(70, 255);
            lbl_selectCustomerCar.Margin = new Padding(2, 0, 2, 0);
            lbl_selectCustomerCar.Name = "lbl_selectCustomerCar";
            lbl_selectCustomerCar.Size = new Size(151, 20);
            lbl_selectCustomerCar.TabIndex = 4;
            lbl_selectCustomerCar.Text = "Select Customer's Car";
            // 
            // cmbBox_selectCustomerCar
            // 
            cmbBox_selectCustomerCar.FormattingEnabled = true;
            cmbBox_selectCustomerCar.Location = new Point(284, 250);
            cmbBox_selectCustomerCar.Margin = new Padding(2);
            cmbBox_selectCustomerCar.Name = "cmbBox_selectCustomerCar";
            cmbBox_selectCustomerCar.Size = new Size(248, 28);
            cmbBox_selectCustomerCar.TabIndex = 5;
            // 
            // lbl_selectServices
            // 
            lbl_selectServices.AutoSize = true;
            lbl_selectServices.Location = new Point(72, 317);
            lbl_selectServices.Margin = new Padding(2, 0, 2, 0);
            lbl_selectServices.Name = "lbl_selectServices";
            lbl_selectServices.Size = new Size(116, 20);
            lbl_selectServices.TabIndex = 6;
            lbl_selectServices.Text = "Select Service(s)";
            // 
            // cmbBox_selectServices
            // 
            cmbBox_selectServices.FormattingEnabled = true;
            cmbBox_selectServices.Location = new Point(284, 312);
            cmbBox_selectServices.Margin = new Padding(2);
            cmbBox_selectServices.Name = "cmbBox_selectServices";
            cmbBox_selectServices.Size = new Size(248, 28);
            cmbBox_selectServices.TabIndex = 7;
            cmbBox_selectServices.SelectedIndexChanged += cmbBox_selectServices_SelectedIndexChanged;
            // 
            // lbl_selectTime
            // 
            lbl_selectTime.AutoSize = true;
            lbl_selectTime.Location = new Point(72, 136);
            lbl_selectTime.Margin = new Padding(2, 0, 2, 0);
            lbl_selectTime.Name = "lbl_selectTime";
            lbl_selectTime.Size = new Size(86, 20);
            lbl_selectTime.TabIndex = 8;
            lbl_selectTime.Text = "Select Time";
            // 
            // calendar_selectTime
            // 
            calendar_selectTime.Format = DateTimePickerFormat.Time;
            calendar_selectTime.Location = new Point(284, 131);
            calendar_selectTime.Margin = new Padding(2);
            calendar_selectTime.Name = "calendar_selectTime";
            calendar_selectTime.ShowUpDown = true;
            calendar_selectTime.Size = new Size(248, 27);
            calendar_selectTime.TabIndex = 9;
            // 
            // btn_confirmAppointment
            // 
            btn_confirmAppointment.Location = new Point(72, 469);
            btn_confirmAppointment.Margin = new Padding(2);
            btn_confirmAppointment.Name = "btn_confirmAppointment";
            btn_confirmAppointment.Size = new Size(188, 29);
            btn_confirmAppointment.TabIndex = 10;
            btn_confirmAppointment.Text = "Confirm Appointment";
            btn_confirmAppointment.UseVisualStyleBackColor = true;
            btn_confirmAppointment.Click += btn_confirmAppointment_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(440, 469);
            btn_cancel.Margin = new Padding(2);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(92, 29);
            btn_cancel.TabIndex = 11;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // cmbBox_selectTech
            // 
            cmbBox_selectTech.FormattingEnabled = true;
            cmbBox_selectTech.Location = new Point(284, 373);
            cmbBox_selectTech.Margin = new Padding(2);
            cmbBox_selectTech.Name = "cmbBox_selectTech";
            cmbBox_selectTech.Size = new Size(248, 28);
            cmbBox_selectTech.TabIndex = 13;
            // 
            // lbl_selectTech
            // 
            lbl_selectTech.AutoSize = true;
            lbl_selectTech.Location = new Point(72, 378);
            lbl_selectTech.Margin = new Padding(2, 0, 2, 0);
            lbl_selectTech.Name = "lbl_selectTech";
            lbl_selectTech.Size = new Size(122, 20);
            lbl_selectTech.TabIndex = 12;
            lbl_selectTech.Text = "Select Technician";
            // 
            // NewAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 509);
            Controls.Add(cmbBox_selectTech);
            Controls.Add(lbl_selectTech);
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
            Margin = new Padding(2);
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
        private Label lbl_selectTechnician;
        private ComboBox cmbBox_selectTechnician;
        private ComboBox cmbBox_selectTech;
        private Label lbl_selectTech;
    }
}