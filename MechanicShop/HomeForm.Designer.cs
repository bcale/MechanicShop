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
            SuspendLayout();
            // 
            // btn_Management
            // 
            btn_Management.Location = new Point(607, 12);
            btn_Management.Name = "btn_Management";
            btn_Management.Size = new Size(181, 53);
            btn_Management.TabIndex = 0;
            btn_Management.Text = "Management";
            btn_Management.UseVisualStyleBackColor = true;
            // 
            // btn_AddCustomer
            // 
            btn_AddCustomer.Location = new Point(420, 12);
            btn_AddCustomer.Name = "btn_AddCustomer";
            btn_AddCustomer.Size = new Size(181, 53);
            btn_AddCustomer.TabIndex = 1;
            btn_AddCustomer.Text = "New Customer";
            btn_AddCustomer.UseVisualStyleBackColor = true;
            btn_AddCustomer.Click += btn_AddCustomer_Click;
            // 
            // HomeForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btn_AddCustomer);
            Controls.Add(btn_Management);
            Name = "HomeForm";
            Text = "Form1";
            Load += HomeForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private Button btn_Management;
        private Button btn_AddCustomer;
    }
}
