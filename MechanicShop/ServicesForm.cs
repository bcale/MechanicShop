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
            public float ServiceCost { get; set; } = 0;
            public string ServiceTechReqRank { get; set; } = string.Empty;

        }

        // Establish connection
        public ServicesForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
            PopulateTechnicianRankComboBox();
        }

        // Populate a ComboBox with the Techinician Ranks from the mechanicshop database
        private void PopulateTechnicianRankComboBox()
        {
            string query = "SELECT technician_rank_id FROM technician_rank";
            SqlCommand command = new SqlCommand(query, connection);

            // Read the results and add each customer name to the ComboBox
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Get the string (assmued data type is string. Must be in the string format. Use a different Get method for different data types)
                    // The number passed to the method is the index of the column retrieved in the SQL query
                    int technicianRanks = reader.GetInt32(0);

                    // Add each customer name to the ComboBox
                    cbBox_reqTechRank.Items.Add(technicianRanks);
                    // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldatareader.getsqlstring?view=dotnet-plat-ext-8.0
                }
                reader.Close(); // Only one SqlDataReader per associated SqlConnection may be open at a time. Be sure to call Close()
            }
        } // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldatareader.read?view=dotnet-plat-ext-8.0


        private void btn_addService_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Service class and populate it with the data from the text boxes
            Service service = new Service
            {
                ServiceName = txt_ServiceName.Text,
                ServiceDescription = txt_ServiceDescription.Text,
                ServiceCost = float.Parse(txt_ServiceCost.Text),
                ServiceTechReqRank = cbBox_reqTechRank.Text,
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
                SqlParameter p_ServiceRankRequirement = new("@p_serviceRankRequirement", service.ServiceTechReqRank);


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
    }
}
