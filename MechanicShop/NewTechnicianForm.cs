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
            public int TechRankID { get; set; } = 0;
        }

        public class Ranks
        {
            public int TechRankID { get; set; } = 0;
            public double TechRank { get; set; } = double.NaN;

        }

        public NewTechnicianForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
            PopulateTechRankComboBox();

        }

        private void NewTechnicianForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_technicianSave_Click(object sender, EventArgs e)
        {
            // Get the selected rank from the combo box
            string selectedRank = cmbo_technicianRank.SelectedItem.ToString();

            // Get the rank ID from the dictionary based on the selected display value
            int rankId = 0;
            if (rankDictionary.ContainsValue(selectedRank))
            {
                // Find the value pair in the dictionary, if it is there, set the rank id
                var rankKeyValuePair = rankDictionary.FirstOrDefault(pair => pair.Value == selectedRank);
                rankId = rankKeyValuePair.Key;
            }
            else
            {
                MessageBox.Show("Selected rank information not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            Technician technician = new Technician
            {
                FirstName = txt_technicianFname.Text,
                LastName = txt_technicianLname.Text,
                TechRankID = rankId,
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
                SqlParameter p_TechRankID = new("@p_rank", technician.TechRankID);


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

        // Populate a ComboBox with the rank value and description from the mechanicshop database
        // format:{rank desc} - {rank value}
        // Use a dictionary to hold the ID values
        private Dictionary<int, string> rankDictionary = new Dictionary<int, string>();
        private void PopulateTechRankComboBox()
        {
            string query = "SELECT * FROM technician_rank";
            SqlCommand command = new SqlCommand(query, connection);

            // Clear existing items in the combo box and the dictionary
            cmbo_technicianRank.Items.Clear();
            rankDictionary.Clear(); 

            // Read the results and add each customer name to the ComboBox
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    int techRankID = reader.GetInt32(0);
                    double techRankValue = reader.GetDouble(2);
                    string techRankInformation = $"{reader.GetString(1)} - {techRankValue}";

                    // Add the rank ID and its associated value to the dictionary
                    rankDictionary.Add(techRankID, techRankInformation);

                    cmbo_technicianRank.Items.Add(techRankInformation);
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