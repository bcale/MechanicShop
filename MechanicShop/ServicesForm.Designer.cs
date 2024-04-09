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
            btn_addService = new Button();
            btn_cancel = new Button();
            lbl_RequiredTechRank = new Label();
            cbBox_reqTechRank = new ComboBox();
            SuspendLayout();
            // 
            // lbl_ServicesTitle
            // 
            lbl_ServicesTitle.AutoSize = true;
            lbl_ServicesTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ServicesTitle.Location = new Point(44, 31);
            lbl_ServicesTitle.Margin = new Padding(2, 0, 2, 0);
            lbl_ServicesTitle.Name = "lbl_ServicesTitle";
            lbl_ServicesTitle.Size = new Size(208, 48);
            lbl_ServicesTitle.TabIndex = 0;
            lbl_ServicesTitle.Text = "Add Service";
            // 
            // lbl_ServiceName
            // 
            lbl_ServiceName.AutoSize = true;
            lbl_ServiceName.Location = new Point(97, 145);
            lbl_ServiceName.Margin = new Padding(2, 0, 2, 0);
            lbl_ServiceName.Name = "lbl_ServiceName";
            lbl_ServiceName.Size = new Size(119, 25);
            lbl_ServiceName.TabIndex = 1;
            lbl_ServiceName.Text = "Service Name";
            // 
            // txt_ServiceName
            // 
            txt_ServiceName.Location = new Point(352, 140);
            txt_ServiceName.Margin = new Padding(2, 2, 2, 2);
            txt_ServiceName.Name = "txt_ServiceName";
            txt_ServiceName.Size = new Size(372, 31);
            txt_ServiceName.TabIndex = 2;
            // 
            // lbl_ServiceDescription
            // 
            lbl_ServiceDescription.AutoSize = true;
            lbl_ServiceDescription.Location = new Point(97, 210);
            lbl_ServiceDescription.Margin = new Padding(2, 0, 2, 0);
            lbl_ServiceDescription.Name = "lbl_ServiceDescription";
            lbl_ServiceDescription.Size = new Size(162, 25);
            lbl_ServiceDescription.TabIndex = 3;
            lbl_ServiceDescription.Text = "Service Description";
            // 
            // txt_ServiceDescription
            // 
            txt_ServiceDescription.Location = new Point(352, 205);
            txt_ServiceDescription.Margin = new Padding(2, 2, 2, 2);
            txt_ServiceDescription.Name = "txt_ServiceDescription";
            txt_ServiceDescription.Size = new Size(372, 31);
            txt_ServiceDescription.TabIndex = 4;
            // 
            // lbl_ServiceCost
            // 
            lbl_ServiceCost.AutoSize = true;
            lbl_ServiceCost.Location = new Point(97, 262);
            lbl_ServiceCost.Margin = new Padding(2, 0, 2, 0);
            lbl_ServiceCost.Name = "lbl_ServiceCost";
            lbl_ServiceCost.Size = new Size(108, 25);
            lbl_ServiceCost.TabIndex = 5;
            lbl_ServiceCost.Text = "Service Cost";
            // 
            // txt_ServiceCost
            // 
            txt_ServiceCost.Location = new Point(352, 256);
            txt_ServiceCost.Margin = new Padding(2, 2, 2, 2);
            txt_ServiceCost.Name = "txt_ServiceCost";
            txt_ServiceCost.Size = new Size(372, 31);
            txt_ServiceCost.TabIndex = 6;
            // 
            // btn_addService
            // 
            btn_addService.Location = new Point(44, 413);
            btn_addService.Margin = new Padding(2, 2, 2, 2);
            btn_addService.Name = "btn_addService";
            btn_addService.Size = new Size(115, 36);
            btn_addService.TabIndex = 7;
            btn_addService.Text = "Add Service";
            btn_addService.UseVisualStyleBackColor = true;
            btn_addService.Click += btn_addService_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(212, 413);
            btn_cancel.Margin = new Padding(2, 2, 2, 2);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(115, 36);
            btn_cancel.TabIndex = 8;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // lbl_RequiredTechRank
            // 
            lbl_RequiredTechRank.AutoSize = true;
            lbl_RequiredTechRank.Location = new Point(97, 311);
            lbl_RequiredTechRank.Margin = new Padding(2, 0, 2, 0);
            lbl_RequiredTechRank.Name = "lbl_RequiredTechRank";
            lbl_RequiredTechRank.Size = new Size(210, 25);
            lbl_RequiredTechRank.TabIndex = 9;
            lbl_RequiredTechRank.Text = "Required Technician Rank";
            // 
            // cbBox_reqTechRank
            // 
            cbBox_reqTechRank.AllowDrop = true;
            cbBox_reqTechRank.FormattingEnabled = true;
            cbBox_reqTechRank.Location = new Point(352, 309);
            cbBox_reqTechRank.Margin = new Padding(2, 2, 2, 2);
            cbBox_reqTechRank.Name = "cbBox_reqTechRank";
            cbBox_reqTechRank.Size = new Size(372, 33);
            cbBox_reqTechRank.TabIndex = 10;
            // 
            // ServicesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(951, 488);
            Controls.Add(cbBox_reqTechRank);
            Controls.Add(lbl_RequiredTechRank);
            Controls.Add(btn_cancel);
            Controls.Add(btn_addService);
            Controls.Add(txt_ServiceCost);
            Controls.Add(lbl_ServiceCost);
            Controls.Add(txt_ServiceDescription);
            Controls.Add(lbl_ServiceDescription);
            Controls.Add(txt_ServiceName);
            Controls.Add(lbl_ServiceName);
            Controls.Add(lbl_ServicesTitle);
            Margin = new Padding(2, 2, 2, 2);
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
        private Button btn_addService;
        private Button btn_cancel;
        private Label lbl_RequiredTechRank;
        private ComboBox cbBox_reqTechRank;
    }
}