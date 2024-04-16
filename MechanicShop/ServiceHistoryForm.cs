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

namespace MechanicShop
{
    public partial class ServiceHistoryForm : Form
    {
        private readonly SqlConnection connection;

        public ServiceHistoryForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
        }

        private void ServiceHistoryForm_Load(object sender, EventArgs e)
        {
            PopulateSearchComboBox();
        }

        // Populate a ComboBox with the available search terms
        private void PopulateSearchComboBox()
        {
            // Define the search terms in an array of strings
            string[] searchTerms = {
                "Customer ID",
                "Vehicle ID",
                "Service ID",
                "Technician ID",
                "Service record date",
                "Service record time",
                "Service record status"
            };

            // Add each search term to the combo box
            foreach (string term in searchTerms)
            {
                ComboBox_searchTerm.Items.Add(term);
            }
        } 

        private void btn_search_Click(object sender, EventArgs e)
        {
            // Extrapolate combobox selection to DB column values
            string search_by = ComboBox_searchTerm.SelectedIndex.ToString() switch
            {
                "Customer ID" => "customer_id",
                "Vehicle ID" => "vehicle_id",
                "Service ID" => "service_id",
                "Technician ID" => "technician_id",
                "Service Record Date" => "service_record_date",
                "Service Record Time" => "service_record_time",
                "Service Record Status" => "service_record_status",
                _ => ComboBox_searchTerm.SelectedIndex.ToString(),// This should result in an error
            };

            string search_value = txt_searchValue.Text;

            string query = "SELECT * FROM service_history WHERE " + search_by + "=" + search_value;

            // TO DO: Use query to add data to the data grid view
        }
    }
}
