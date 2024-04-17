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
using System.Xml.Linq;

namespace MechanicShop
{
    public partial class ManagementForm : Form
    {
        private readonly SqlConnection connection;

        public ManagementForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();

            PopulateServicesComboBox();
            PopulateCustomerComboBox();
            PopulateTechniciansComboBox();
        }

        private void ManagementForm_Load(object sender, EventArgs e)
        {

        }


        /// Combo Boxes -------------------------------------------------------------------------
        private void PopulateServicesComboBox()
        {
            // Make sure box is cleared
            cbBox_services.Items.Clear();

            string query = "SELECT service_name FROM services";
            SqlCommand command = new SqlCommand(query, connection);

            // Read the results and add each customer first and last name to the ComboBox
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string serviceName = reader.GetString(0);
                cbBox_services.Items.Add(serviceName);
            }
        }

        /// <summary> Populate the Select Customer comboBox using customers table; retrieve First and Last names  </summary>
        private void PopulateCustomerComboBox()
        {
            cbBox_customers.Items.Clear();

            string query = "SELECT customer_Fname, customer_Lname FROM customers";
            SqlCommand command = new SqlCommand(query, connection);

            // Read the results and add each customer first and last name to the ComboBox
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string customerName = reader.GetString(0) + " " + reader.GetString(1);
                cbBox_customers.Items.Add(customerName);
            }
        }

        private void PopulateTechniciansComboBox()
        {
            cbBox_technicians.Items.Clear();

            string query = "SELECT technician_Fname, technician_Lname FROM technicians";
            SqlCommand command = new SqlCommand(query, connection);

            // Read the results and add each customer first and last name to the ComboBox
            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string technicianName = reader.GetString(0) + " " + reader.GetString(1);
                cbBox_technicians.Items.Add(technicianName);
            }
        }

        private void btn_submit_Click(object sender, EventArgs e)
        {
            var checkedButton = Controls.OfType<RadioButton>().FirstOrDefault(radioButton => radioButton.Checked);

            SearchResults SearchResults = new SearchResults(checkedButton);
            SearchResults.Show();
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
