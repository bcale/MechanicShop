using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MechanicShop.NewTechnicianForm;

namespace MechanicShop
{
    public partial class NewTechnicianForm : Form
    {
        private readonly SqlConnection connection;
        public class Technician
        {
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; } = string.Empty;


        }
        public NewTechnicianForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
        }

        private void AddTechnician_Load(object sender, EventArgs e)
        {

        }

        private void btn_technicianSave_Click(object sender, EventArgs e)
        {
            Technician technician = new Technician
            {
                FirstName = txt_technicianFname.Text,
                LastName = txt_technicianLname.Text,

            };

            // Have user confirm before saving
            DialogResult result = MessageBox.Show("Insert technician into Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string p_insert_technician = @"dbo.[insert_technician]";

                SqlCommand command = new SqlCommand(p_insert_technician, connection);
                command.CommandType = CommandType.StoredProcedure;

                // Set SQL Parameters
                command.Parameters.Clear();
                SqlParameter p_FirstName = new("@p_fname", technician.FirstName);
                SqlParameter p_LastName = new("@p_lname", technician.LastName);



                // Add the parameters to the SqlCommand Object
                command.Parameters.Add(p_FirstName);
                command.Parameters.Add(p_LastName);



                // EXEC the procedure
                command.ExecuteNonQuery();
                this.Close();
            }
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
    }
}
