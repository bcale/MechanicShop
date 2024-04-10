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
using static MechanicShop.ServicesForm;

namespace MechanicShop
{
    // https://youtu.be/o6wtDPVkKqI?si=Wvpvny1jpysj2zJb !!!
    // https://youtu.be/w2xi6Qjv8mw?si=qyHsqD25t-rT20Zt !
    public partial class ServicesForm : Form
    {
        private readonly SqlConnection connection;

        public class Service
        {
            public string ServiceName { get; set; } = string.Empty;
            public string ServiceDescription { get; set; } = string.Empty;
            public double ServiceCost { get; set; } = double.NaN;
            public int ServiceTechReqRankID { get; set; } = 0;
        }

        // Establish connection
        public ServicesForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
            PopulateTechnicianRankComboBox();
        }

        // Populate a ComboBox with the Techinician Ranks from the mechanicshop database
        // Use a dictionary to hold the ID values
        private Dictionary<int, string> rankDictionary = new Dictionary<int, string>();
        private void PopulateTechnicianRankComboBox()
        {
            string query = "SELECT * FROM technician_rank";
            SqlCommand command = new SqlCommand(query, connection);

            // Clear existing items in the combo box and the dictionary
            cbBox_reqTechRank.Items.Clear();
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

                    cbBox_reqTechRank.Items.Add(techRankInformation);
                }
                reader.Close();
            }
        }

        private void btn_addService_Click(object sender, EventArgs e)
        {
            // Get the selected rank from the combo box
            string selectedRank = cbBox_reqTechRank.SelectedItem.ToString();

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

            // Create a new instance of the Service class and populate it with the data from the text boxes
            Service service = new Service
            {
                ServiceName = txt_ServiceName.Text,
                ServiceDescription = txt_ServiceDescription.Text,
                ServiceCost = float.Parse(txt_ServiceCost.Text),
                ServiceTechReqRankID = rankId,
            };

            // Have user confirm before saving
            DialogResult result = MessageBox.Show("Insert Service into Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string p_insert_service = @"dbo.[insert_service]";

                SqlCommand command = new SqlCommand(p_insert_service, connection);
                command.CommandType = CommandType.StoredProcedure;

                // Set SQL Parameters
                command.Parameters.Clear();
                SqlParameter p_ServiceName = new("@p_serviceName", service.ServiceName);
                SqlParameter p_ServiceDescription = new("@p_serviceDescription", service.ServiceDescription);
                SqlParameter p_ServiceCost = new("@p_serviceCost", service.ServiceCost);
                SqlParameter p_ServiceRankRequirement = new("@p_serviceRankRequirement", service.ServiceTechReqRankID);


                // Add the parameters to the SqlCommand Object
                command.Parameters.Add(p_ServiceName);
                command.Parameters.Add(p_ServiceDescription);
                command.Parameters.Add(p_ServiceCost);
                command.Parameters.Add(p_ServiceRankRequirement);


                // EXEC the procedure
                command.ExecuteNonQuery();
                this.Close();
            }
        }

        // Canceling Add Service 
        private void btn_cancel_Click(object sender, EventArgs e)
        {
            // Have user confirm before quitting
            DialogResult result = MessageBox.Show("Are you sure you want to cancel?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {

        }
    }
}
