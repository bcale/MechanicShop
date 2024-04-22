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

            if(rdBtn_service_date.Checked)
            {
                

                string Service = cbBox_services.Text;
                //DateTime ServiceDate1 = dateTimePicker4.D;
                //DateTime ServiceDate2 = dateTimePicker5.MaxDate;
                String ServiceDate1 = dateTimePicker4.Text;
                string ServiceDate2 = dateTimePicker5.Text;
                //DateTime dt;
                //DateTime dt2;

                

                string functionName = @"dbo.[list_service_amount]";

                    using (SqlCommand command = new SqlCommand($"SELECT * FROM {functionName}(@p_ServName, @p_date1, @p_date2)", connection))
                    {

                        // Set SQL Parameters
                        command.Parameters.Clear();
                    SqlParameter p_ServName = new SqlParameter("@p_ServName", Service);
                    // SqlParameter p_Date1 = new SqlParameter("@p_date1", DateTime.TryParse(ServiceDate1, out dt));
                    //SqlParameter p_Date2 = new SqlParameter("@p_date2", DateTime.TryParse(ServiceDate2, out dt2));
                    // SqlParameter p_Date2 = new SqlParameter("@p_date2", ServiceDate2);
                    // SqlParameter p_Date1 = new SqlParameter("@p_date1", dateTimePicker4.Date);
                    SqlParameter p_Date1 = new SqlParameter("@p_date1", dateTimePicker4.Text);
                    SqlParameter p_Date2 = new SqlParameter("@p_date2", dateTimePicker5.Text);


                    // Add the parameters to the SqlCommand Object
                    command.Parameters.Add(p_ServName);
                    command.Parameters.Add(p_Date1);
                        command.Parameters.Add(p_Date2);

                        // Create new objects to execute the command
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        DataTable dataTable = new DataTable();

                        try
                        {
                            // Fill the data grid
                            adapter.Fill(dataTable);
                            dataGridView1.DataSource = dataTable;
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error: " + ex.Message);
                        }
                    }
                

            }
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
