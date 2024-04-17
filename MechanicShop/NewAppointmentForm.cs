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
using static MechanicShop.NewCustomerForm;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MechanicShop
{
    public partial class NewAppointmentForm : Form
    {
        private readonly SqlConnection connection;

        //create Appointment class
        public class Appointment
        {
            public string ServiceDate { get; set; } = string.Empty;
            public string ServiceTime { get; set; } = string.Empty;
            public string CustomerName { get; set; } = string.Empty;
            public string CustomerCar { get; set; } = string.Empty;
            public string SelectedService { get; set; } = string.Empty;
            public string SelectedTechnician { get; set; } = string.Empty;
            public bool Status { get; set; } = false;
        }

        public NewAppointmentForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
            PopulateSelectCustomerComboBox();
            //cmbBox_selectCustomer.SelectedIndexChanged += cmbBox_selectCustomer_SelectedIndexChanged; --> Manual change in NewAppointmentDesigner.cs to subscribe to index change of the customer selection combo box; Putting here so you know :]
            PopulateSelectServiceComboBox();
        }

        private void NewAppointmentForm_Load(object sender, EventArgs e)
        {

        }

        /// <summary> Call PopulateSelectCustomerVehicleComboBox() when the selected index of the customer_select combo box changes  </summary>
        private void cmbBox_selectCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Clear the items first 
            cmbBox_selectCustomerCar.Items.Clear();
            PopulateSelectCustomerVehicleComboBox();
        }

        /// <summary> Call PopulateSelectCustomerTechComboBox() when the selected index of the service_select combo box changes  </summary>
        private void cmbBox_selectServices_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbBox_selectTechnician.Items.Clear();
            PopulateSelectTechComboBox();
        }

        /// <summary> Populate the Select Customer comboBox using customers table; retrieve First and Last names  </summary>
        private void PopulateSelectCustomerComboBox()
        {
            string query = "SELECT customer_Fname, customer_Lname FROM customers";
            SqlCommand command = new SqlCommand(query, connection);

            // Read the results and add each customer first and last name to the ComboBox
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Get the customers' first and last names.
                    // The number passed to the method is the index of the column retrieved in the SQL query. 
                    // Note: column count begins with field selected in query above, not necessarily the 1st column in the table
                    string customerName = reader.GetString(0) + " " + reader.GetString(1);

                    //add each full name to comboBox
                    cmbBox_selectCustomer.Items.Add(customerName);
                }
                reader.Close(); // Only one SqlDataReader per associated SqlConnection may be open at a time. Be sure to call Close()
            }
        } // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldatareader.read?view=dotnet-plat-ext-8.0


        /// <summary> Populate the Select Customer Vehicle comboBox using the vehicle table and chosen cutomerID
        ///           The functionality of customer selection should be adjusted in such a way that the customerID is pulled from the DB
        ///           In this implementation, having several people with the same first and last name will result in unexpected behavior  </summary>
        private void PopulateSelectCustomerVehicleComboBox()
        {
            // Get the selected customer's name
            string selected_customer = cmbBox_selectCustomer.Text;

            // Get the customerID -- Again, this will not work if there are 2 or more customers with the same name.
            // Separate the name based on the space char
            string fullName = selected_customer;
            string[] names = fullName.Split(' ');
            string customer_Fname = names[0];
            string customer_Lname = names[1];

            // We should probably make a function for this? I dunno
            string query = $"SELECT customer_id FROM customers WHERE customer_Fname='{customer_Fname}' AND customer_Lname='{customer_Lname}';"; // Use $ before a string use interpolated strings. Looks cleaner!
            // https://open.spotify.com/album/7aeIwIg63Qyt1bzjsPufzl?si=F0p65GeGQcOFDknsLmhStw
            SqlCommand getCustID = new SqlCommand(query, connection);

            // Read the results and add each customer first and last name to the ComboBox
            int customerID = 0;
            using (SqlDataReader reader = getCustID.ExecuteReader())
            {
                if (reader.Read())
                {
                    customerID = reader.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("Customer ID not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Get the vehicle plate
            // I chose the plate because its unique to a vehicle yet not as obscure as a DB id or long as a VIN 
            // Better way to do this would be something similar to how I did it in the new vehicle form
            query = $"SELECT vehicle_license_plate FROM vehicles WHERE customer_id='{customerID}';";

            SqlCommand command = new(query, connection);

            // Read the results and add each customer first and last name to the ComboBox
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    string vehicleLicensePlate = reader.GetString(0);
                    cmbBox_selectCustomerCar.Items.Add(vehicleLicensePlate);
                }
            }
        }


        /// <summary>
        /// Fill the services combo box with the available services
        /// This can be made better as well. I would suggest a similar approach that was done in the new vehicle form to display full service details.
        ///      Or perhaps there is a better looking option </summary>
        private void PopulateSelectServiceComboBox()
        {
            string query = "SELECT service_name FROM services";
            SqlCommand command = new(query, connection);

            using SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())
            {
                string service = reader.GetString(0);
                cmbBox_selectServices.Items.Add(service);
            }
        }


        /// <summary> Populate the Select Technician comboBox using the tech table and service rank  </summary>
        private void PopulateSelectTechComboBox()
        {
            // Get the selected service
            string selected_service = cmbBox_selectServices.Text;

            // Create a function for this 
            string query = $"SELECT required_technician_rank_id FROM services WHERE service_name='{selected_service}';";

            SqlCommand getRequiredRank = new(query, connection);

            // Read the results and add each customer first and last name to the ComboBox
            int requiredRankID = 0;
            using (SqlDataReader reader = getRequiredRank.ExecuteReader())
            {
                if (reader.Read())
                {
                    requiredRankID = reader.GetInt32(0);
                }
                else
                {
                    MessageBox.Show("Rank not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Create a function for this 
            query = $"SELECT rank_value FROM technician_rank WHERE technician_rank_id='{requiredRankID}';";
            SqlCommand getRequiredRankValue = new(query, connection);

            // Read the results and return the rank value for the ID
            double requiredRankValue = 0;
            using (SqlDataReader reader = getRequiredRankValue.ExecuteReader())
            {
                if (reader.Read())
                {
                    requiredRankValue = reader.GetDouble(0);
                }
                else
                {
                    MessageBox.Show("Rank not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

            // Get the technicians that can work this job
            query = $"SELECT * FROM select_technicians_withRankValue()";
            SqlCommand command = new(query, connection);

            // Read the results and add each tech name to the ComboBox
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    double techrankValue = reader.GetDouble(4);

                    if (techrankValue >= requiredRankValue)
                    {
                        string firstName = reader.GetString(1);
                        string lastName = reader.GetString(2);

                        string fullName = $"{firstName} {lastName}";

                        cmbBox_selectTechnician.Items.Add(fullName);
                    }
                }
            }
        }

        private void btn_confirmAppointment_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Appointment class and populate it with 
            // the data from the NewAppointmentForm
            Appointment appointment = new()
            {
                ServiceDate = calendar_selectDate.Text,
                ServiceTime = calendar_selectTime.Text,
                CustomerName = cmbBox_selectCustomer.Text,
                CustomerCar = cmbBox_selectCustomerCar.Text,
                SelectedService = cmbBox_selectServices.Text,
                SelectedTechnician = cmbBox_selectTechnician.Text,
                Status = checkBox_Status.Checked,
            };

            // Get customer Fname and Lname 
            string fullName = appointment.CustomerName;
            string[] names = fullName.Split(' ');
            string customer_Fname = names[0];
            string customer_Lname = names[1];

            // Get the technicans Fname and Lname 
            string techFullName = appointment.SelectedTechnician;
            string[] techNames = techFullName.Split(' ');
            string technician_Fname = techNames[0];
            string technician_Lname = techNames[1];

            // Convert bool to bit 

            // Have user confirm before saving
            DialogResult result = MessageBox.Show("Insert Appointment into Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string p_insert_appointment = @"dbo.[insert_appointment]";

                SqlCommand command = new SqlCommand(p_insert_appointment, connection);
                command.CommandType = CommandType.StoredProcedure;

                // Set SQL Parameters
                command.Parameters.Clear();
                SqlParameter p_serviceDate = new("@p_serviceDate", appointment.ServiceDate);
                SqlParameter p_serviceTime = new("@p_serviceTime", appointment.ServiceTime);
                SqlParameter p_customerFName = new("@p_customerFName", customer_Fname);
                SqlParameter p_customerLName = new("@p_customerLName", customer_Lname);
                SqlParameter p_customerCar = new("@p_customerCar", appointment.CustomerCar);
                SqlParameter p_selectedService = new("@p_selectedService", appointment.SelectedService);
                SqlParameter p_TechnicianFName = new("@p_TechnicianFName", technician_Fname);
                SqlParameter p_TechnicianLName = new("@p_TechnicianLName", technician_Lname);
                SqlParameter p_Status = new("@p_Status", appointment.Status);

                // Add the parameters to the SqlCommand Object
                command.Parameters.Add(p_serviceDate);
                command.Parameters.Add(p_serviceTime);
                command.Parameters.Add(p_customerFName);
                command.Parameters.Add(p_customerLName);
                command.Parameters.Add(p_customerCar);
                command.Parameters.Add(p_selectedService);
                command.Parameters.Add(p_TechnicianFName);
                command.Parameters.Add(p_TechnicianLName);
                command.Parameters.Add(p_Status);

                // EXEC the procedure
                command.ExecuteNonQuery();

                DialogResult result1 = MessageBox.Show("Would you like to add another service or technician?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result1 == DialogResult.No)
                {
                    this.Close();
                }
            }
        }

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
