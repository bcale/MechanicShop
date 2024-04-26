namespace MechanicShop
{
    partial class ManagementForm
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
            label1 = new Label();
            label2 = new Label();
            rdBtn_Date = new RadioButton();
            btn_submit = new Button();
            btn_cancel = new Button();
            rdBtn_service_date = new RadioButton();
            rdBtn_cost_date = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker3 = new DateTimePicker();
            cbBox_services = new ComboBox();
            label4 = new Label();
            dateTimePicker4 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker5 = new DateTimePicker();
            rdBtn_technician_date = new RadioButton();
            cbBox_technicians = new ComboBox();
            label6 = new Label();
            dateTimePicker6 = new DateTimePicker();
            label7 = new Label();
            dateTimePicker7 = new DateTimePicker();
            rdBtn_customer = new RadioButton();
            cbBox_customers = new ComboBox();
            rdBtn_tech_noService = new RadioButton();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(96, 52);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 15);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(6, 10);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(165, 15);
            label2.TabIndex = 1;
            label2.Text = "Select Management Options";
            // 
            // rdBtn_Date
            // 
            rdBtn_Date.AutoSize = true;
            rdBtn_Date.Location = new Point(6, 52);
            rdBtn_Date.Margin = new Padding(2);
            rdBtn_Date.Name = "rdBtn_Date";
            rdBtn_Date.Size = new Size(123, 19);
            rdBtn_Date.TabIndex = 2;
            rdBtn_Date.TabStop = true;
            rdBtn_Date.Text = "Data for Given Day";
            rdBtn_Date.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(113, 314);
            btn_submit.Margin = new Padding(2);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(80, 22);
            btn_submit.TabIndex = 3;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(16, 314);
            btn_cancel.Margin = new Padding(2);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(80, 22);
            btn_cancel.TabIndex = 4;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // rdBtn_service_date
            // 
            rdBtn_service_date.AutoSize = true;
            rdBtn_service_date.Location = new Point(6, 89);
            rdBtn_service_date.Margin = new Padding(2);
            rdBtn_service_date.Name = "rdBtn_service_date";
            rdBtn_service_date.Size = new Size(123, 19);
            rdBtn_service_date.TabIndex = 5;
            rdBtn_service_date.TabStop = true;
            rdBtn_service_date.Text = "Number of Service";
            rdBtn_service_date.UseVisualStyleBackColor = true;
            // 
            // rdBtn_cost_date
            // 
            rdBtn_cost_date.AutoSize = true;
            rdBtn_cost_date.Location = new Point(6, 126);
            rdBtn_cost_date.Margin = new Padding(2);
            rdBtn_cost_date.Name = "rdBtn_cost_date";
            rdBtn_cost_date.Size = new Size(165, 19);
            rdBtn_cost_date.TabIndex = 6;
            rdBtn_cost_date.TabStop = true;
            rdBtn_cost_date.Text = "Total Service Cost Between";
            rdBtn_cost_date.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(143, 52);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(218, 23);
            dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Format = DateTimePickerFormat.Short;
            dateTimePicker2.Location = new Point(191, 124);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(218, 23);
            dateTimePicker2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(415, 127);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(27, 15);
            label3.TabIndex = 9;
            label3.Text = "and";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Format = DateTimePickerFormat.Short;
            dateTimePicker3.Location = new Point(447, 124);
            dateTimePicker3.Margin = new Padding(2);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(218, 23);
            dateTimePicker3.TabIndex = 10;
            // 
            // cbBox_services
            // 
            cbBox_services.FormattingEnabled = true;
            cbBox_services.Location = new Point(143, 89);
            cbBox_services.Margin = new Padding(2);
            cbBox_services.Name = "cbBox_services";
            cbBox_services.Size = new Size(132, 23);
            cbBox_services.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(276, 91);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(111, 15);
            label4.TabIndex = 12;
            label4.Text = "performed between";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Format = DateTimePickerFormat.Short;
            dateTimePicker4.Location = new Point(401, 88);
            dateTimePicker4.Margin = new Padding(2);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(218, 23);
            dateTimePicker4.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(625, 89);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 14;
            label5.Text = "and";
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Format = DateTimePickerFormat.Short;
            dateTimePicker5.Location = new Point(657, 87);
            dateTimePicker5.Margin = new Padding(2);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(218, 23);
            dateTimePicker5.TabIndex = 15;
            // 
            // rdBtn_technician_date
            // 
            rdBtn_technician_date.AutoSize = true;
            rdBtn_technician_date.Location = new Point(6, 164);
            rdBtn_technician_date.Margin = new Padding(2);
            rdBtn_technician_date.Name = "rdBtn_technician_date";
            rdBtn_technician_date.Size = new Size(145, 19);
            rdBtn_technician_date.TabIndex = 16;
            rdBtn_technician_date.TabStop = true;
            rdBtn_technician_date.Text = "Services performed by ";
            rdBtn_technician_date.UseVisualStyleBackColor = true;
            // 
            // cbBox_technicians
            // 
            cbBox_technicians.FormattingEnabled = true;
            cbBox_technicians.Location = new Point(166, 163);
            cbBox_technicians.Margin = new Padding(2);
            cbBox_technicians.Name = "cbBox_technicians";
            cbBox_technicians.Size = new Size(132, 23);
            cbBox_technicians.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(306, 164);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(52, 15);
            label6.TabIndex = 18;
            label6.Text = "between";
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Format = DateTimePickerFormat.Short;
            dateTimePicker6.Location = new Point(367, 162);
            dateTimePicker6.Margin = new Padding(2);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(218, 23);
            dateTimePicker6.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(587, 164);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(27, 15);
            label7.TabIndex = 20;
            label7.Text = "and";
            // 
            // dateTimePicker7
            // 
            dateTimePicker7.Format = DateTimePickerFormat.Short;
            dateTimePicker7.Location = new Point(620, 162);
            dateTimePicker7.Margin = new Padding(2);
            dateTimePicker7.Name = "dateTimePicker7";
            dateTimePicker7.Size = new Size(218, 23);
            dateTimePicker7.TabIndex = 21;
            // 
            // rdBtn_customer
            // 
            rdBtn_customer.AutoSize = true;
            rdBtn_customer.Location = new Point(6, 200);
            rdBtn_customer.Margin = new Padding(2);
            rdBtn_customer.Name = "rdBtn_customer";
            rdBtn_customer.Size = new Size(259, 19);
            rdBtn_customer.TabIndex = 22;
            rdBtn_customer.TabStop = true;
            rdBtn_customer.Text = "Services Scheduled/Performed for Customer";
            rdBtn_customer.UseVisualStyleBackColor = true;
            // 
            // cbBox_customers
            // 
            cbBox_customers.FormattingEnabled = true;
            cbBox_customers.Location = new Point(285, 197);
            cbBox_customers.Margin = new Padding(2);
            cbBox_customers.Name = "cbBox_customers";
            cbBox_customers.Size = new Size(132, 23);
            cbBox_customers.TabIndex = 23;
            // 
            // rdBtn_tech_noService
            // 
            rdBtn_tech_noService.AutoSize = true;
            rdBtn_tech_noService.Location = new Point(6, 238);
            rdBtn_tech_noService.Margin = new Padding(2);
            rdBtn_tech_noService.Name = "rdBtn_tech_noService";
            rdBtn_tech_noService.Size = new Size(279, 19);
            rdBtn_tech_noService.TabIndex = 24;
            rdBtn_tech_noService.TabStop = true;
            rdBtn_tech_noService.Text = "Display Technicians with No Services Conducted";
            rdBtn_tech_noService.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(306, 255);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(538, 222);
            dataGridView1.TabIndex = 25;
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(907, 501);
            Controls.Add(dataGridView1);
            Controls.Add(rdBtn_tech_noService);
            Controls.Add(cbBox_customers);
            Controls.Add(rdBtn_customer);
            Controls.Add(dateTimePicker7);
            Controls.Add(label7);
            Controls.Add(dateTimePicker6);
            Controls.Add(label6);
            Controls.Add(cbBox_technicians);
            Controls.Add(rdBtn_technician_date);
            Controls.Add(dateTimePicker5);
            Controls.Add(label5);
            Controls.Add(dateTimePicker4);
            Controls.Add(label4);
            Controls.Add(cbBox_services);
            Controls.Add(dateTimePicker3);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(rdBtn_cost_date);
            Controls.Add(rdBtn_service_date);
            Controls.Add(btn_cancel);
            Controls.Add(btn_submit);
            Controls.Add(rdBtn_Date);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "ManagementForm";
            Text = "Service Management";
            Load += ManagementForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton rdBtn_Date;
        private Button btn_submit;
        private Button btn_cancel;
        private RadioButton rdBtn_service_date;
        private RadioButton rdBtn_cost_date;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker3;
        private ComboBox cbBox_services;
        private Label label4;
        private DateTimePicker dateTimePicker4;
        private Label label5;
        private DateTimePicker dateTimePicker5;
        private RadioButton rdBtn_technician_date;
        private ComboBox cbBox_technicians;
        private Label label6;
        private DateTimePicker dateTimePicker6;
        private Label label7;
        private DateTimePicker dateTimePicker7;
        private RadioButton rdBtn_customer;
        private ComboBox cbBox_customers;
        private RadioButton rdBtn_tech_noService;
        private DataGridView dataGridView1;
    }
}