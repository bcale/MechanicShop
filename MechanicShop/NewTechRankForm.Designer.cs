namespace MechanicShop
{
    partial class NewTechRankForm
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
            txt_rank_desc = new TextBox();
            lbl_rank_desc = new Label();
            lbl_rank_value = new Label();
            txt_rank_value = new TextBox();
            lbl_title = new Label();
            btn_save = new Button();
            btn_cancel = new Button();
            SuspendLayout();
            // 
            // txt_rank_desc
            // 
            txt_rank_desc.Location = new Point(256, 82);
            txt_rank_desc.Name = "txt_rank_desc";
            txt_rank_desc.Size = new Size(150, 31);
            txt_rank_desc.TabIndex = 0;
            // 
            // lbl_rank_desc
            // 
            lbl_rank_desc.AutoSize = true;
            lbl_rank_desc.Location = new Point(50, 82);
            lbl_rank_desc.Name = "lbl_rank_desc";
            lbl_rank_desc.Size = new Size(200, 25);
            lbl_rank_desc.TabIndex = 1;
            lbl_rank_desc.Text = "Rank Name/Description";
            // 
            // lbl_rank_value
            // 
            lbl_rank_value.AutoSize = true;
            lbl_rank_value.Location = new Point(152, 148);
            lbl_rank_value.Name = "lbl_rank_value";
            lbl_rank_value.Size = new Size(98, 25);
            lbl_rank_value.TabIndex = 2;
            lbl_rank_value.Text = "Rank Value";
            // 
            // txt_rank_value
            // 
            txt_rank_value.Location = new Point(256, 148);
            txt_rank_value.Name = "txt_rank_value";
            txt_rank_value.Size = new Size(150, 31);
            txt_rank_value.TabIndex = 3;
            // 
            // lbl_title
            // 
            lbl_title.AutoSize = true;
            lbl_title.Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lbl_title.Location = new Point(12, 9);
            lbl_title.Name = "lbl_title";
            lbl_title.Size = new Size(394, 45);
            lbl_title.TabIndex = 4;
            lbl_title.Text = "Add a new technician rank";
            // 
            // btn_save
            // 
            btn_save.Location = new Point(294, 205);
            btn_save.Name = "btn_save";
            btn_save.Size = new Size(112, 34);
            btn_save.TabIndex = 5;
            btn_save.Text = "Save";
            btn_save.UseVisualStyleBackColor = true;
            btn_save.Click += btn_save_Click;
            // 
            // btn_cancel
            // 
            btn_cancel.Location = new Point(294, 249);
            btn_cancel.Name = "btn_cancel";
            btn_cancel.Size = new Size(112, 34);
            btn_cancel.TabIndex = 6;
            btn_cancel.Text = "Cancel";
            btn_cancel.UseVisualStyleBackColor = true;
            btn_cancel.Click += btn_cancel_Click;
            // 
            // NewTechRankForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(435, 295);
            Controls.Add(btn_cancel);
            Controls.Add(btn_save);
            Controls.Add(lbl_title);
            Controls.Add(txt_rank_value);
            Controls.Add(lbl_rank_value);
            Controls.Add(lbl_rank_desc);
            Controls.Add(txt_rank_desc);
            Name = "NewTechRankForm";
            Text = "NewTechRankForm";
            Load += NewTechRankForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_rank_desc;
        private Label lbl_rank_desc;
        private Label lbl_rank_value;
        private TextBox txt_rank_value;
        private Label lbl_title;
        private Button btn_save;
        private Button btn_cancel;
    }
}