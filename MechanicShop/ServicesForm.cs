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

        private void btn_addService_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Service class and populate it with the data from the text boxes
            Service service = new Service
            {
                ServiceName = txt_ServiceName.Text,
                ServiceDescription = txt_ServiceDescription.Text,
                ServiceCost = float.Parse(txt_ServiceCost.Text),
                ServiceTechReqRank = txt_reqTechRank.Text,
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
    }
}
