using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicShop
{
    public partial class AddTechnician : Form
    {
        public class Technician
        {

            //Where are we putting the ID's?
        }

        public AddTechnician()
        {
            InitializeComponent();
        }

        private void AddTechnician_Load(object sender, EventArgs e)
        {

        }



        private void InitializeComponent()
        {
            btn_technicianSave = new Button();
            btn_technicianCancel = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            SuspendLayout();
            // 
            // button1
            // 
            btn_technicianSave.Location = new Point(12, 226);
            btn_technicianSave.Name = "button1";
            btn_technicianSave.Size = new Size(75, 23);
            btn_technicianSave.TabIndex = 0;
            btn_technicianSave.Text = "Save";
            btn_technicianSave.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            btn_technicianCancel.Location = new Point(93, 226);
            btn_technicianCancel.Name = "button2";
            btn_technicianCancel.Size = new Size(75, 23);
            btn_technicianCancel.TabIndex = 1;
            btn_technicianCancel.Text = "Cancel";
            btn_technicianCancel.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(20, 15);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 2;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(20, 44);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 3;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(145, 23);
            label1.Name = "label1";
            label1.Size = new Size(61, 15);
            label1.TabIndex = 4;
            label1.Text = "FirstName";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(145, 52);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 5;
            label2.Text = "LastName";
            // 
            // AddTechnician
            // 
            ClientSize = new Size(284, 261);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btn_technicianCancel);
            Controls.Add(btn_technicianSave);
            Name = "AddTechnician";
            ResumeLayout(false);
            PerformLayout();
        }

        private void btn_technicianSave_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Customer class and populate it with the data from the text boxes
            Technician technician = new Technician
            {


            };

            // TODO: Insert into DB
        }
        private void btn_technicianCancel_Click(object sender, EventArgs e)
        {
            // Have user confirm before quitting
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }



        private Button btn_technicianSave;
        private Button btn_technicianCancel;
        private TextBox textBox2;
        private Label label1;
        private Label label2;
        private TextBox textBox1;


    }
}
