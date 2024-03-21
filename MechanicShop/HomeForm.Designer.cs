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
            btn_Management = new Button();
            btn_AddCustomer = new Button();
            btn_AddTechnician = new Button();
            SuspendLayout();
            // 
            // btn_Management
            // 
            btn_Management.Location = new Point(531, 9);
            btn_Management.Margin = new Padding(3, 2, 3, 2);
            btn_Management.Name = "btn_Management";
            btn_Management.Size = new Size(158, 40);
            btn_Management.TabIndex = 0;
            btn_Management.Text = "Management";
            btn_Management.UseVisualStyleBackColor = true;
            // 
            // btn_AddCustomer
            // 
            btn_AddCustomer.Location = new Point(368, 9);
            btn_AddCustomer.Margin = new Padding(3, 2, 3, 2);
            btn_AddCustomer.Name = "btn_AddCustomer";
            btn_AddCustomer.Size = new Size(158, 40);
            btn_AddCustomer.TabIndex = 1;
            btn_AddCustomer.Text = "New Customer";
            btn_AddCustomer.UseVisualStyleBackColor = true;
            btn_AddCustomer.Click += btn_AddCustomer_Click;
            // 
            // button1
            // 
            btn_AddTechnician.Location = new Point(368, 54);
            btn_AddTechnician.Name = "button1";
            btn_AddTechnician.Size = new Size(158, 43);
            btn_AddTechnician.TabIndex = 2;
            btn_AddTechnician.Text = "New Technician";
            btn_AddTechnician.UseVisualStyleBackColor = true;
            btn_AddTechnician.Click += btn_AddTechnician_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(700, 338);
            Controls.Add(btn_AddTechnician);
            Controls.Add(btn_AddCustomer);
            Controls.Add(btn_Management);
            Margin = new Padding(3, 2, 3, 2);
            Name = "HomeForm";
            Text = "Form1";
            Load += HomeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Management;
        private Button btn_AddCustomer;
        private Button btn_AddTechnician;
        
    }
}
