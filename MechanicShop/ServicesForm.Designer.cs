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
            label1 = new Label();
            txt_reqTechRank = new TextBox();
            SuspendLayout();
            // 
            // lbl_ServicesTitle
            // 
            lbl_ServicesTitle.AutoSize = true;
            lbl_ServicesTitle.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_ServicesTitle.Location = new Point(57, 40);
            lbl_ServicesTitle.Name = "lbl_ServicesTitle";
            lbl_ServicesTitle.Size = new Size(278, 65);
            lbl_ServicesTitle.TabIndex = 0;
            lbl_ServicesTitle.Text = "Add Service";
            // 
            // lbl_ServiceName
            // 
            lbl_ServiceName.AutoSize = true;
            lbl_ServiceName.Location = new Point(126, 186);
            lbl_ServiceName.Name = "lbl_ServiceName";
            lbl_ServiceName.Size = new Size(161, 32);
            lbl_ServiceName.TabIndex = 1;
            lbl_ServiceName.Text = "Service Name";
            // 
            // txt_ServiceName
            // 
            txt_ServiceName.Location = new Point(458, 179);
            txt_ServiceName.Name = "txt_ServiceName";
            txt_ServiceName.Size = new Size(482, 39);
            txt_ServiceName.TabIndex = 2;
            // 
            // lbl_ServiceDescription
            // 
            lbl_ServiceDescription.AutoSize = true;
            lbl_ServiceDescription.Location = new Point(126, 269);
            lbl_ServiceDescription.Name = "lbl_ServiceDescription";
            lbl_ServiceDescription.Size = new Size(218, 32);
            lbl_ServiceDescription.TabIndex = 3;
            lbl_ServiceDescription.Text = "Service Description";
            // 
            // txt_ServiceDescription
            // 
            txt_ServiceDescription.Location = new Point(458, 262);
            txt_ServiceDescription.Name = "txt_ServiceDescription";
            txt_ServiceDescription.Size = new Size(482, 39);
            txt_ServiceDescription.TabIndex = 4;
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
            txt_ServiceCost.Location = new Point(458, 328);
            txt_ServiceCost.Name = "txt_ServiceCost";
            txt_ServiceCost.Size = new Size(482, 39);
            txt_ServiceCost.TabIndex = 6;
            // 
            // btn_addService
            // 
            btn_addService.Location = new Point(57, 529);
            btn_addService.Name = "btn_addService";
            btn_addService.Size = new Size(150, 46);
            btn_addService.TabIndex = 7;
            btn_addService.Text = "Add Service";
            btn_addService.UseVisualStyleBackColor = true;
            btn_addService.Click += btn_addService_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(275, 529);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(150, 46);
            btn_cancel.TabIndex = 8;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(126, 398);
            label1.Name = "label1";
            label1.Size = new Size(287, 32);
            label1.TabIndex = 9;
            label1.Text = "Required Technician Rank";
            // 
            // txt_reqTechRank
            // 
            txt_reqTechRank.Location = new Point(458, 391);
            txt_reqTechRank.Name = "txt_reqTechRank";
            txt_reqTechRank.Size = new Size(482, 39);
            txt_reqTechRank.TabIndex = 10;
            // 
            // ServicesForm
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1236, 624);
            Controls.Add(txt_reqTechRank);
            Controls.Add(label1);
            Controls.Add(btn_cancel);
            Controls.Add(btn_addService);
            Controls.Add(txt_ServiceCost);
            Controls.Add(lbl_ServiceCost);
            Controls.Add(txt_ServiceDescription);
            Controls.Add(lbl_ServiceDescription);
            Controls.Add(txt_ServiceName);
            Controls.Add(lbl_ServiceName);
            Controls.Add(lbl_ServicesTitle);
            Name = "ServicesForm";
            Text = "Services";
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
        private Label label1;
        private TextBox txt_reqTechRank;
    }
}