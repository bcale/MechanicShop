namespace MechanicShop
{
    partial class ServicesForm
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
            lbl_ServicesTitle = new Label();
            lbl_ServiceName = new Label();
            txt_ServiceName = new TextBox();
            lbl_ServiceDescription = new Label();
            txt_ServiceDescription = new TextBox();
            lbl_ServiceCost = new Label();
            txt_ServiceCost = new TextBox();
            SuspendLayout();
            // 
            // lbl_ServicesTitle
            // 
            lbl_ServicesTitle.AutoSize = true;
            lbl_ServicesTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ServicesTitle.Location = new Point(57, 52);
            lbl_ServicesTitle.Name = "lbl_ServicesTitle";
            lbl_ServicesTitle.Size = new Size(317, 65);
            lbl_ServicesTitle.TabIndex = 0;
            lbl_ServicesTitle.Text = "Select Service";
            lbl_ServicesTitle.Click += lbl_ServicesTitle_Click;
            // 
            // lbl_ServiceName
            // 
            lbl_ServiceName.AutoSize = true;
            lbl_ServiceName.Location = new Point(126, 186);
            lbl_ServiceName.Name = "lbl_ServiceName";
            lbl_ServiceName.Size = new Size(161, 32);
            lbl_ServiceName.TabIndex = 1;
            lbl_ServiceName.Text = "Service Name";
            lbl_ServiceName.Click += lbl_ServiceName_Click;
            // 
            // txt_ServiceName
            // 
            txt_ServiceName.Location = new Point(393, 183);
            txt_ServiceName.Name = "txt_ServiceName";
            txt_ServiceName.Size = new Size(482, 39);
            txt_ServiceName.TabIndex = 2;
            txt_ServiceName.TextChanged += txt_ServiceName_TextChanged;
            // 
            // lbl_ServiceDescription
            // 
            lbl_ServiceDescription.AutoSize = true;
            lbl_ServiceDescription.Location = new Point(126, 269);
            lbl_ServiceDescription.Name = "lbl_ServiceDescription";
            lbl_ServiceDescription.Size = new Size(218, 32);
            lbl_ServiceDescription.TabIndex = 3;
            lbl_ServiceDescription.Text = "Service Description";
            lbl_ServiceDescription.Click += lbl_ServiceDescription_Click;
            // 
            // txt_ServiceDescription
            // 
            txt_ServiceDescription.Location = new Point(393, 262);
            txt_ServiceDescription.Name = "txt_ServiceDescription";
            txt_ServiceDescription.Size = new Size(482, 39);
            txt_ServiceDescription.TabIndex = 4;
            txt_ServiceDescription.TextChanged += txt_ServiceDescription_TextChanged;
            // 
            // lbl_ServiceCost
            // 
            lbl_ServiceCost.AutoSize = true;
            lbl_ServiceCost.Location = new Point(126, 335);
            lbl_ServiceCost.Name = "lbl_ServiceCost";
            lbl_ServiceCost.Size = new Size(144, 32);
            lbl_ServiceCost.TabIndex = 5;
            lbl_ServiceCost.Text = "Service Cost";
            // 
            // txt_ServiceCost
            // 
            txt_ServiceCost.Location = new Point(393, 335);
            txt_ServiceCost.Name = "txt_ServiceCost";
            txt_ServiceCost.Size = new Size(482, 39);
            txt_ServiceCost.TabIndex = 6;
            txt_ServiceCost.TextChanged += txt_ServiceCost_TextChanged;
            // 
            // ServicesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1206, 612);
            Controls.Add(txt_ServiceCost);
            Controls.Add(lbl_ServiceCost);
            Controls.Add(txt_ServiceDescription);
            Controls.Add(lbl_ServiceDescription);
            Controls.Add(txt_ServiceName);
            Controls.Add(lbl_ServiceName);
            Controls.Add(lbl_ServicesTitle);
            Name = "ServicesForm";
            Text = "Services";
            Load += ServicesForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_ServicesTitle;
        private Label lbl_ServiceName;
        private TextBox txt_ServiceName;
        private Label lbl_ServiceDescription;
        private TextBox txt_ServiceDescription;
        private Label lbl_ServiceCost;
        private TextBox txt_ServiceCost;
    }
}