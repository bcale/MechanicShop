namespace MechanicShop
{
    partial class HomeForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btn_MakeAppointment = new Button();
            btn_NewCustomer = new Button();
            label1 = new Label();
            btn_NewVehicle = new Button();
            btn_NewTechnician = new Button();
            btn_NewService = new Button();
            SuspendLayout();
            // 
            // btn_MakeAppointment
            // 
            btn_MakeAppointment.Location = new Point(319, 19);
            btn_MakeAppointment.Margin = new Padding(6, 4, 6, 4);
            btn_MakeAppointment.Name = "btn_MakeAppointment";
            btn_MakeAppointment.Size = new Size(293, 85);
            btn_MakeAppointment.TabIndex = 0;
            btn_MakeAppointment.Text = "Make Appointment";
            btn_MakeAppointment.UseVisualStyleBackColor = true;
            btn_MakeAppointment.Click += btn_Management_Click;
            // 
            // btn_NewCustomer
            // 
            btn_NewCustomer.Location = new Point(15, 19);
            btn_NewCustomer.Margin = new Padding(6, 4, 6, 4);
            btn_NewCustomer.Name = "btn_NewCustomer";
            btn_NewCustomer.Size = new Size(293, 85);
            btn_NewCustomer.TabIndex = 1;
            btn_NewCustomer.Text = "New Customer";
            btn_NewCustomer.UseVisualStyleBackColor = true;
            btn_NewCustomer.Click += btn_NewCustomer_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(223, 474);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(395, 32);
            label1.TabIndex = 2;
            label1.Text = "Careful Technicians Collaborating ™";
            // 
            // btn_NewVehicle
            // 
            btn_NewVehicle.Location = new Point(15, 113);
            btn_NewVehicle.Margin = new Padding(6, 4, 6, 4);
            btn_NewVehicle.Name = "btn_NewVehicle";
            btn_NewVehicle.Size = new Size(293, 85);
            btn_NewVehicle.TabIndex = 3;
            btn_NewVehicle.Text = "New Vehicle";
            btn_NewVehicle.UseVisualStyleBackColor = true;
            btn_NewVehicle.Click += btn_NewVehicle_Click;
            // 
            // btn_NewTechnician
            // 
            btn_NewTechnician.Location = new Point(319, 113);
            btn_NewTechnician.Margin = new Padding(6, 4, 6, 4);
            btn_NewTechnician.Name = "btn_NewTechnician";
            btn_NewTechnician.Size = new Size(293, 85);
            btn_NewTechnician.TabIndex = 4;
            btn_NewTechnician.Text = "New Technician";
            btn_NewTechnician.UseVisualStyleBackColor = true;
            btn_NewTechnician.Click += btn_NewTechnician_Click;
            // 
            // btn_NewService
            // 
            btn_NewService.Location = new Point(19, 335);
            btn_NewService.Margin = new Padding(6, 4, 6, 4);
            btn_NewService.Name = "btn_NewService";
            btn_NewService.Size = new Size(293, 85);
            btn_NewService.TabIndex = 5;
            btn_NewService.Text = "New Service";
            btn_NewService.UseVisualStyleBackColor = true;
            btn_NewService.Click += btn_NewService_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(630, 510);
            Controls.Add(btn_NewService);
            Controls.Add(btn_NewTechnician);
            Controls.Add(btn_NewVehicle);
            Controls.Add(label1);
            Controls.Add(btn_NewCustomer);
            Controls.Add(btn_MakeAppointment);
            Margin = new Padding(6, 4, 6, 4);
            Name = "HomeForm";
            Text = "Database Interface";
            Load += HomeForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_MakeAppointment;
        private Button btn_NewCustomer;
        private Label label1;
        private Button btn_NewVehicle;
        private Button btn_NewTechnician;
        private Button btn_NewService;
    }
}
