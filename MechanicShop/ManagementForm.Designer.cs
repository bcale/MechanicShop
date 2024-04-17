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
            radioButton1 = new RadioButton();
            btn_submit = new Button();
            btn_cancel = new Button();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            dateTimePicker2 = new DateTimePicker();
            label3 = new Label();
            dateTimePicker3 = new DateTimePicker();
            cbBox_services = new ComboBox();
            label4 = new Label();
            dateTimePicker4 = new DateTimePicker();
            label5 = new Label();
            dateTimePicker5 = new DateTimePicker();
            radioButton4 = new RadioButton();
            cbBox_technicians = new ComboBox();
            label6 = new Label();
            dateTimePicker6 = new DateTimePicker();
            label7 = new Label();
            dateTimePicker7 = new DateTimePicker();
            radioButton5 = new RadioButton();
            cbBox_customers = new ComboBox();
            radioButton6 = new RadioButton();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(110, 69);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(0, 20);
            label1.TabIndex = 0;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(7, 14);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(206, 20);
            label2.TabIndex = 1;
            label2.Text = "Select Management Options";
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Location = new Point(7, 69);
            radioButton1.Margin = new Padding(2);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(156, 24);
            radioButton1.TabIndex = 2;
            radioButton1.TabStop = true;
            radioButton1.Text = "Data for Given Day";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // btn_submit
            // 
            btn_submit.Location = new Point(129, 418);
            btn_submit.Margin = new Padding(2);
            btn_submit.Name = "btn_submit";
            btn_submit.Size = new Size(92, 29);
            btn_submit.TabIndex = 3;
            btn_submit.Text = "Submit";
            btn_submit.UseVisualStyleBackColor = true;
            btn_submit.Click += btn_submit_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(18, 418);
            btn_cancel.Margin = new Padding(2);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(92, 29);
            btn_cancel.TabIndex = 4;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(7, 119);
            radioButton2.Margin = new Padding(2);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(153, 24);
            radioButton2.TabIndex = 5;
            radioButton2.TabStop = true;
            radioButton2.Text = "Number of Service";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(7, 168);
            radioButton3.Margin = new Padding(2);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(208, 24);
            radioButton3.TabIndex = 6;
            radioButton3.TabStop = true;
            radioButton3.Text = "Total Service Cost Between";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(163, 69);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(248, 27);
            dateTimePicker1.TabIndex = 7;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(218, 166);
            dateTimePicker2.Margin = new Padding(2);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(248, 27);
            dateTimePicker2.TabIndex = 8;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(474, 169);
            label3.Margin = new Padding(2, 0, 2, 0);
            label3.Name = "label3";
            label3.Size = new Size(34, 20);
            label3.TabIndex = 9;
            label3.Text = "and";
            // 
            // dateTimePicker3
            // 
            dateTimePicker3.Location = new Point(511, 166);
            dateTimePicker3.Margin = new Padding(2);
            dateTimePicker3.Name = "dateTimePicker3";
            dateTimePicker3.Size = new Size(248, 27);
            dateTimePicker3.TabIndex = 10;
            // 
            // cbBox_services
            // 
            cbBox_services.FormattingEnabled = true;
            cbBox_services.Location = new Point(163, 119);
            cbBox_services.Margin = new Padding(2);
            cbBox_services.Name = "cbBox_services";
            cbBox_services.Size = new Size(150, 28);
            cbBox_services.TabIndex = 11;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(316, 121);
            label4.Margin = new Padding(2, 0, 2, 0);
            label4.Name = "label4";
            label4.Size = new Size(141, 20);
            label4.TabIndex = 12;
            label4.Text = "performed between";
            // 
            // dateTimePicker4
            // 
            dateTimePicker4.Location = new Point(458, 118);
            dateTimePicker4.Margin = new Padding(2);
            dateTimePicker4.Name = "dateTimePicker4";
            dateTimePicker4.Size = new Size(248, 27);
            dateTimePicker4.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(714, 119);
            label5.Margin = new Padding(2, 0, 2, 0);
            label5.Name = "label5";
            label5.Size = new Size(34, 20);
            label5.TabIndex = 14;
            label5.Text = "and";
            // 
            // dateTimePicker5
            // 
            dateTimePicker5.Location = new Point(751, 116);
            dateTimePicker5.Margin = new Padding(2);
            dateTimePicker5.Name = "dateTimePicker5";
            dateTimePicker5.Size = new Size(248, 27);
            dateTimePicker5.TabIndex = 15;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            radioButton4.Location = new Point(7, 219);
            radioButton4.Margin = new Padding(2);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(182, 24);
            radioButton4.TabIndex = 16;
            radioButton4.TabStop = true;
            radioButton4.Text = "Services performed by ";
            radioButton4.UseVisualStyleBackColor = true;
            // 
            // cbBox_technicians
            // 
            cbBox_technicians.FormattingEnabled = true;
            cbBox_technicians.Location = new Point(190, 217);
            cbBox_technicians.Margin = new Padding(2);
            cbBox_technicians.Name = "cbBox_technicians";
            cbBox_technicians.Size = new Size(150, 28);
            cbBox_technicians.TabIndex = 17;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(350, 219);
            label6.Margin = new Padding(2, 0, 2, 0);
            label6.Name = "label6";
            label6.Size = new Size(66, 20);
            label6.TabIndex = 18;
            label6.Text = "between";
            // 
            // dateTimePicker6
            // 
            dateTimePicker6.Location = new Point(419, 216);
            dateTimePicker6.Margin = new Padding(2);
            dateTimePicker6.Name = "dateTimePicker6";
            dateTimePicker6.Size = new Size(248, 27);
            dateTimePicker6.TabIndex = 19;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(671, 219);
            label7.Margin = new Padding(2, 0, 2, 0);
            label7.Name = "label7";
            label7.Size = new Size(34, 20);
            label7.TabIndex = 20;
            label7.Text = "and";
            // 
            // dateTimePicker7
            // 
            dateTimePicker7.Location = new Point(708, 216);
            dateTimePicker7.Margin = new Padding(2);
            dateTimePicker7.Name = "dateTimePicker7";
            dateTimePicker7.Size = new Size(248, 27);
            dateTimePicker7.TabIndex = 21;
            // 
            // radioButton5
            // 
            radioButton5.AutoSize = true;
            radioButton5.Location = new Point(7, 266);
            radioButton5.Margin = new Padding(2);
            radioButton5.Name = "radioButton5";
            radioButton5.Size = new Size(321, 24);
            radioButton5.TabIndex = 22;
            radioButton5.TabStop = true;
            radioButton5.Text = "Services Scheduled/Performed for Customer";
            radioButton5.UseVisualStyleBackColor = true;
            // 
            // cbBox_customers
            // 
            cbBox_customers.FormattingEnabled = true;
            cbBox_customers.Location = new Point(326, 263);
            cbBox_customers.Margin = new Padding(2);
            cbBox_customers.Name = "cbBox_customers";
            cbBox_customers.Size = new Size(150, 28);
            cbBox_customers.TabIndex = 23;
            // 
            // radioButton6
            // 
            radioButton6.AutoSize = true;
            radioButton6.Location = new Point(7, 317);
            radioButton6.Margin = new Padding(2);
            radioButton6.Name = "radioButton6";
            radioButton6.Size = new Size(347, 24);
            radioButton6.TabIndex = 24;
            radioButton6.TabStop = true;
            radioButton6.Text = "Display Technicians with No Services Conducted";
            radioButton6.UseVisualStyleBackColor = true;
            // 
            // ManagementForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1037, 454);
            Controls.Add(radioButton6);
            Controls.Add(cbBox_customers);
            Controls.Add(radioButton5);
            Controls.Add(dateTimePicker7);
            Controls.Add(label7);
            Controls.Add(dateTimePicker6);
            Controls.Add(label6);
            Controls.Add(cbBox_technicians);
            Controls.Add(radioButton4);
            Controls.Add(dateTimePicker5);
            Controls.Add(label5);
            Controls.Add(dateTimePicker4);
            Controls.Add(label4);
            Controls.Add(cbBox_services);
            Controls.Add(dateTimePicker3);
            Controls.Add(label3);
            Controls.Add(dateTimePicker2);
            Controls.Add(dateTimePicker1);
            Controls.Add(radioButton3);
            Controls.Add(radioButton2);
            Controls.Add(btn_cancel);
            Controls.Add(btn_submit);
            Controls.Add(radioButton1);
            Controls.Add(label2);
            Controls.Add(label1);
            Margin = new Padding(2);
            Name = "ManagementForm";
            Text = "Service Management";
            Load += ManagementForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private RadioButton radioButton1;
        private Button btn_submit;
        private Button btn_cancel;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private DateTimePicker dateTimePicker1;
        private DateTimePicker dateTimePicker2;
        private Label label3;
        private DateTimePicker dateTimePicker3;
        private ComboBox cbBox_services;
        private Label label4;
        private DateTimePicker dateTimePicker4;
        private Label label5;
        private DateTimePicker dateTimePicker5;
        private RadioButton radioButton4;
        private ComboBox cbBox_technicians;
        private Label label6;
        private DateTimePicker dateTimePicker6;
        private Label label7;
        private DateTimePicker dateTimePicker7;
        private RadioButton radioButton5;
        private ComboBox cbBox_customers;
        private RadioButton radioButton6;
    }
}