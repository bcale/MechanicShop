namespace MechanicShop
{
    partial class NewTechnicianForm
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
            lbl_technicianFname = new Label();
            txt_technicianFname = new TextBox();
            txt_technicianLname = new TextBox();
            lbl_technicianLname = new Label();
            btn_technicianSave = new Button();
            btn_technicianCancel = new Button();
            cmbo_technicianRank = new ComboBox();
            lbl_technicianRank = new Label();
            lbl_title = new Label();
            SuspendLayout();
            // 
            // lbl_technicianFname
            // 
            lbl_technicianFname.AutoSize = true;
            lbl_technicianFname.Location = new Point(13, 90);
            lbl_technicianFname.Margin = new Padding(4, 0, 4, 0);
            lbl_technicianFname.Name = "lbl_technicianFname";
            lbl_technicianFname.Size = new Size(92, 25);
            lbl_technicianFname.TabIndex = 0;
            lbl_technicianFname.Text = "FirstName";
            // 
            // txt_technicianFname
            // 
            txt_technicianFname.Location = new Point(221, 85);
            txt_technicianFname.Margin = new Padding(4, 5, 4, 5);
            txt_technicianFname.Name = "txt_technicianFname";
            txt_technicianFname.Size = new Size(142, 31);
            txt_technicianFname.TabIndex = 1;
            // 
            // txt_technicianLname
            // 
            txt_technicianLname.Location = new Point(221, 150);
            txt_technicianLname.Margin = new Padding(4, 5, 4, 5);
            txt_technicianLname.Name = "txt_technicianLname";
            txt_technicianLname.Size = new Size(142, 31);
            txt_technicianLname.TabIndex = 2;
            // 
            // lbl_technicianLname
            // 
            lbl_technicianLname.AutoSize = true;
            lbl_technicianLname.Location = new Point(13, 162);
            lbl_technicianLname.Margin = new Padding(4, 0, 4, 0);
            lbl_technicianLname.Name = "lbl_technicianLname";
            lbl_technicianLname.Size = new Size(90, 25);
            lbl_technicianLname.TabIndex = 3;
            lbl_technicianLname.Text = "LastName";
            // 
            // btn_technicianSave
            // 
            btn_technicianSave.Location = new Point(13, 307);
            btn_technicianSave.Margin = new Padding(4, 5, 4, 5);
            btn_technicianSave.Name = "btn_technicianSave";
            btn_technicianSave.Size = new Size(108, 39);
            btn_technicianSave.TabIndex = 4;
            btn_technicianSave.Text = "Save";
            btn_technicianSave.UseVisualStyleBackColor = true;
            btn_technicianSave.Click += btn_technicianSave_Click;
            // 
            // btn_technicianCancel
            // 
            btn_technicianCancel.Location = new Point(257, 307);
            btn_technicianCancel.Margin = new Padding(4, 5, 4, 5);
            btn_technicianCancel.Name = "btn_technicianCancel";
            btn_technicianCancel.Size = new Size(108, 39);
            btn_technicianCancel.TabIndex = 5;
            btn_technicianCancel.Text = "Cancel";
            btn_technicianCancel.UseVisualStyleBackColor = true;
            btn_technicianCancel.Click += btn_technicianCancel_Click;
            // 
            // cmbo_technicianRank
            // 
            cmbo_technicianRank.FormattingEnabled = true;
            cmbo_technicianRank.Location = new Point(191, 215);
            cmbo_technicianRank.Margin = new Padding(4, 5, 4, 5);
            cmbo_technicianRank.Name = "cmbo_technicianRank";
            cmbo_technicianRank.Size = new Size(172, 33);
            cmbo_technicianRank.TabIndex = 6;
            cmbo_technicianRank.SelectedIndexChanged += cmbo_technicianRank_SelectedIndexChanged;
            // 
            // lbl_technicianRank
            // 
            lbl_technicianRank.AutoSize = true;
            lbl_technicianRank.Location = new Point(13, 227);
            lbl_technicianRank.Margin = new Padding(4, 0, 4, 0);
            lbl_technicianRank.Name = "lbl_technicianRank";
            lbl_technicianRank.Size = new Size(130, 25);
            lbl_technicianRank.TabIndex = 7;
            lbl_technicianRank.Text = "TechnicianRank";
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(12, 9);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(359, 48);
            lbl_title.TabIndex = 8;
            lbl_title.Text = "Add a new technician";
            // 
            // NewTechnicianForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(408, 386);
            Controls.Add(lbl_title);
            Controls.Add(lbl_technicianRank);
            Controls.Add(cmbo_technicianRank);
            Controls.Add(btn_technicianCancel);
            Controls.Add(btn_technicianSave);
            Controls.Add(lbl_technicianLname);
            Controls.Add(txt_technicianLname);
            Controls.Add(txt_technicianFname);
            Controls.Add(lbl_technicianFname);
            Margin = new Padding(4, 5, 4, 5);
            Name = "NewTechnicianForm";
            Text = "NewTechnicianForm";
            Load += NewTechnicianForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lbl_technicianFname;
        private TextBox txt_technicianFname;
        private TextBox txt_technicianLname;
        private Label lbl_technicianLname;
        private Button btn_technicianSave;
        private Button btn_technicianCancel;
        private ComboBox cmbo_technicianRank;
        private Label lbl_technicianRank;
        private Label lbl_title;
    }
}