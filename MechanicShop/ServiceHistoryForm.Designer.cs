namespace MechanicShop
{
    partial class ServiceHistoryForm
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
            ComboBox_searchTerm = new ComboBox();
            label1 = new Label();
            txt_searchValue = new TextBox();
            btn_search = new Button();
            dataGridView1 = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // ComboBox_searchTerm
            // 
            ComboBox_searchTerm.FormattingEnabled = true;
            ComboBox_searchTerm.Location = new Point(98, 26);
            ComboBox_searchTerm.Name = "ComboBox_searchTerm";
            ComboBox_searchTerm.Size = new Size(147, 28);
            ComboBox_searchTerm.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 29);
            label1.Name = "label1";
            label1.Size = new Size(80, 20);
            label1.TabIndex = 1;
            label1.Text = "Search By: ";
            // 
            // txt_searchValue
            // 
            txt_searchValue.Location = new Point(98, 60);
            txt_searchValue.Name = "txt_searchValue";
            txt_searchValue.Size = new Size(147, 27);
            txt_searchValue.TabIndex = 2;
            // 
            // btn_search
            // 
            btn_search.Location = new Point(251, 60);
            btn_search.Name = "btn_search";
            btn_search.Size = new Size(94, 29);
            btn_search.TabIndex = 3;
            btn_search.Text = "Search";
            btn_search.UseVisualStyleBackColor = true;
            btn_search.Click += btn_search_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 95);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(776, 343);
            dataGridView1.TabIndex = 4;
            // 
            // ServiceHistoryForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(dataGridView1);
            Controls.Add(btn_search);
            Controls.Add(txt_searchValue);
            Controls.Add(label1);
            Controls.Add(ComboBox_searchTerm);
            Name = "ServiceHistoryForm";
            Text = "ServiceHistoryForm";
            Load += ServiceHistoryForm_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox ComboBox_searchTerm;
        private Label label1;
        private TextBox txt_searchValue;
        private Button btn_search;
        private DataGridView dataGridView1;
    }
}