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
            SuspendLayout();
            // 
            // lbl_technicianFname
            // 
            lbl_technicianFname.AutoSize = true;
            lbl_technicianFname.Location = new Point(122, 75);
            lbl_technicianFname.Name = "lbl_technicianFname";
            lbl_technicianFname.Size = new Size(76, 20);
            lbl_technicianFname.TabIndex = 0;
            lbl_technicianFname.Text = "FirstName";
            // 
            // txt_technicianFname
            // 
            txt_technicianFname.Location = new Point(288, 71);
            txt_technicianFname.Margin = new Padding(3, 4, 3, 4);
            txt_technicianFname.Name = "txt_technicianFname";
            txt_technicianFname.Size = new Size(114, 27);
            txt_technicianFname.TabIndex = 1;
            // 
            // txt_technicianLname
            // 
            txt_technicianLname.Location = new Point(288, 123);
            txt_technicianLname.Margin = new Padding(3, 4, 3, 4);
            txt_technicianLname.Name = "txt_technicianLname";
            txt_technicianLname.Size = new Size(114, 27);
            txt_technicianLname.TabIndex = 2;
            // 
            // lbl_technicianLname
            // 
            lbl_technicianLname.AutoSize = true;
            lbl_technicianLname.Location = new Point(122, 133);
            lbl_technicianLname.Name = "lbl_technicianLname";
            lbl_technicianLname.Size = new Size(75, 20);
            lbl_technicianLname.TabIndex = 3;
            lbl_technicianLname.Text = "LastName";
            // 
            // btn_technicianSave
            // 
            btn_technicianSave.Location = new Point(122, 249);
            btn_technicianSave.Margin = new Padding(3, 4, 3, 4);
            btn_technicianSave.Name = "btn_technicianSave";
            btn_technicianSave.Size = new Size(86, 31);
            btn_technicianSave.TabIndex = 4;
            btn_technicianSave.Text = "Save";
            btn_technicianSave.UseVisualStyleBackColor = true;
            btn_technicianSave.Click += btn_technicianSave_Click;
            // 
            // btn_technicianCancel
            // 
            btn_technicianCancel.Location = new Point(317, 249);
            btn_technicianCancel.Margin = new Padding(3, 4, 3, 4);
            btn_technicianCancel.Name = "btn_technicianCancel";
            btn_technicianCancel.Size = new Size(86, 31);
            btn_technicianCancel.TabIndex = 5;
            btn_technicianCancel.Text = "Cancel";
            btn_technicianCancel.UseVisualStyleBackColor = true;
            btn_technicianCancel.Click += btn_technicianCancel_Click;
            // 
            // cmbo_technicianRank
            // 
            cmbo_technicianRank.FormattingEnabled = true;
            cmbo_technicianRank.Location = new Point(264, 175);
            cmbo_technicianRank.Margin = new Padding(3, 4, 3, 4);
            cmbo_technicianRank.Name = "cmbo_technicianRank";
            cmbo_technicianRank.Size = new Size(138, 28);
            cmbo_technicianRank.TabIndex = 6;
            cmbo_technicianRank.SelectedIndexChanged += cmbo_technicianRank_SelectedIndexChanged;
            // 
            // lbl_technicianRank
            // 
            lbl_technicianRank.AutoSize = true;
            lbl_technicianRank.Location = new Point(122, 185);
            lbl_technicianRank.Name = "lbl_technicianRank";
            lbl_technicianRank.Size = new Size(110, 20);
            lbl_technicianRank.TabIndex = 7;
            lbl_technicianRank.Text = "TechnicianRank";
            // 
            // NewTechnicianForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(lbl_technicianRank);
            Controls.Add(cmbo_technicianRank);
            Controls.Add(btn_technicianCancel);
            Controls.Add(btn_technicianSave);
            Controls.Add(lbl_technicianLname);
            Controls.Add(txt_technicianLname);
            Controls.Add(txt_technicianFname);
            Controls.Add(lbl_technicianFname);
            Margin = new Padding(3, 4, 3, 4);
            Name = "NewTechnicianForm";
            Text = "NewTechnicianForm";
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
    }
}