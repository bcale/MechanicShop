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
using static MechanicShop.NewAppointmentForm;
using static MechanicShop.ServicesForm;

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

                string functionName = @"dbo.[list_service_amount]";

                    using (SqlCommand command = new SqlCommand($"SELECT * FROM {functionName}(@p_ServName, @p_date1, @p_date2)", connection))
                    {

                        // Set SQL Parameters
                        command.Parameters.Clear();
                    SqlParameter p_ServName = new SqlParameter("@p_ServName", Service);
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

            if (rdBtn_technician_date.Checked)
            {                
                string functionName = @"dbo.[jobs_tech_assigned]";

                string techFullName = cbBox_technicians.Text;
                string[] techNames = techFullName.Split(' ');
                string technician_Fname = techNames[0];
                string technician_Lname = techNames[1];

                using (SqlCommand command = new SqlCommand($"SELECT * FROM {functionName}(@p_techFname,@p_techLname,@p_date1, @p_date2) order by vehicle_license_plate", connection))
                {

                    // Set SQL Parameters
                    command.Parameters.Clear();
                    SqlParameter p_TechFName = new SqlParameter("@p_techFname", technician_Fname);
                    SqlParameter p_TechLName = new SqlParameter("@p_techLname", technician_Lname);

                    SqlParameter p_Date1 = new SqlParameter("@p_date1", dateTimePicker6.Text);
                    SqlParameter p_Date2 = new SqlParameter("@p_date2", dateTimePicker7.Text);
                    // Add the parameters to the SqlCommand Object
                    command.Parameters.Add(p_TechFName);
                    command.Parameters.Add(p_TechLName);
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

            if (rdBtn_cost_date.Checked)
            {
                string functionName = @"dbo.[total_cost]";

                using (SqlCommand command = new SqlCommand($"SELECT * FROM {functionName}(@p_date1, @p_date2)", connection))
                {

                    // Set SQL Parameters
                    command.Parameters.Clear();
                    SqlParameter p_Date1 = new SqlParameter("@p_date1", dateTimePicker2.Text);
                    SqlParameter p_Date2 = new SqlParameter("@p_date2", dateTimePicker3.Text);
                    // Add the parameters to the SqlCommand Object
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
