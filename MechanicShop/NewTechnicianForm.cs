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
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace MechanicShop
{
    public partial class NewTechnicianForm : Form
    {
        private readonly SqlConnection connection;
        public class Technician
        {
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; } = string.Empty;
            public string TechRank { get; set; } = string.Empty;


        }
        public NewTechnicianForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
            PopulateCustomerComboBox();

        }

        private void NewTechnicianForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_technicianSave_Click(object sender, EventArgs e)
        {
            Technician technician = new Technician
            {
                FirstName = txt_technicianFname.Text,
                LastName = txt_technicianLname.Text,
                TechRank = cmbo_technicianRank.Text,
            };

            // Have user confirm before saving
            DialogResult result = MessageBox.Show("Insert technician into Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            string query = $"SELECT technician_rank_id FROM technician_rank WHERE rank_value = {technician.TechRank}";
            SqlCommand getRankId = new(query, connection);

            // Read the results and add each customer first and last name to the ComboBox
            int rankId = 0;
            using (SqlDataReader reader = getRankId.ExecuteReader())
            {
                if (reader.Read())
                {
                    rankId = reader.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("RankID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            if (result == DialogResult.Yes)
            {
                string p_insert_technician = @"dbo.[insert_technician]";

                SqlCommand command = new SqlCommand(p_insert_technician, connection);
                command.CommandType = CommandType.StoredProcedure;

                // Set SQL Parameters
                command.Parameters.Clear();
                SqlParameter p_FirstName = new("@p_fname", technician.FirstName);
                SqlParameter p_LastName = new("@p_lname", technician.LastName);
                SqlParameter p_TechRankID = new("@p_rank", rankId);


                // Add the parameters to the SqlCommand Object
                command.Parameters.Add(p_FirstName);
                command.Parameters.Add(p_LastName);
                command.Parameters.Add(p_TechRankID);


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

        // Populate a ComboBox with the first and last names from the mechanicshop database
        // format:{lastName}, {firstName}
        private void PopulateCustomerComboBox()
        {
            string query = "SELECT rank_value FROM technician_rank";
            SqlCommand command = new SqlCommand(query, connection);

            // Read the results and add each customer name to the ComboBox
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Get the string (assmued data type is string. Must be in the string format. Use a different Get method for different data types)
                    // The number passed to the method is the index of the column retrieved in the SQL query
                    double technicianRank = reader.GetDouble(0);

                    // Add each customer name to the ComboBox
                    cmbo_technicianRank.Items.Add(technicianRank);
                    // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldatareader.getsqlstring?view=dotnet-plat-ext-8.0
                }
                reader.Close(); // Only one SqlDataReader per associated SqlConnection may be open at a time. Be sure to call Close()
            }
        } // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldatareader.read?view=dotnet-plat-ext-8.0}

        private void cmbo_technicianRank_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}