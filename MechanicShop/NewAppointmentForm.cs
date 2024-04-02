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
        }

        public NewAppointmentForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
            PopulateSelectCustomerComboBox();
            PopulateSelectServiceComboBox();
        }

        // Populate the Select Customer comboBox using customers table; retrieve First and Last names
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
        } 

        
        // Populate the Select Service comboBox using services table; retrieve service name
        private void PopulateSelectServiceComboBox()
        {
            string query = "SELECT service_name FROM services";
            SqlCommand command = new SqlCommand(query, connection);

            // Read the results and add each service name to the ComboBox
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Get the service names.
                    // The number passed to the method is the index of the column retrieved in the SQL query. 
                    // Note: column count begins with field selected in query above, not necessarily the 1st column in the table
                    string serviceName = reader.GetString(0);


                    //add each service name to comboBox
                    cmbBox_selectServices.Items.Add(serviceName);
                }
                reader.Close(); // Only one SqlDataReader per associated SqlConnection may be open at a time. Be sure to call Close()
            }
        }


        private void btn_confirmAppointment_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Appointment class and populate it with 
            // the data from the NewAppointmentForm
            Appointment appointment = new Appointment
            {
                ServiceDate = calendar_selectDate.Text,
                ServiceTime = calendar_selectTime.Text,
                CustomerName = cmbBox_selectCustomer.Text,
                CustomerCar = cmbBox_selectCustomerCar.Text,
                SelectedService = cmbBox_selectServices.Text
            };

            // Have user confirm before saving
            DialogResult result = MessageBox.Show("Insert Customer into Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string p_insert_appointment = @"dbo.[insert_appointment]";

                SqlCommand command = new SqlCommand(p_insert_appointment, connection);
                command.CommandType = CommandType.StoredProcedure;

                // Set SQL Parameters
                command.Parameters.Clear();
                SqlParameter p_serviceDate = new("@p_serviceDate", appointment.ServiceDate);
                SqlParameter p_serviceTime = new("@p_serviceTime", appointment.ServiceTime);
                SqlParameter p_customerName = new("@p_customerName", appointment.CustomerName);
                SqlParameter p_customerCar = new("@p_customerCar", appointment.CustomerCar);
                SqlParameter p_selectedService = new("@p_selectedService", appointment.SelectedService);


                // Add the parameters to the SqlCommand Object
                command.Parameters.Add(p_serviceDate);
                command.Parameters.Add(p_serviceTime);
                command.Parameters.Add(p_customerName);
                command.Parameters.Add(p_customerCar);
                command.Parameters.Add(p_selectedService);

                // EXEC the procedure
                command.ExecuteNonQuery();
                this.Close();
            }

            // REFERENCE: https://www.mssqltips.com/sqlservertip/5810/working-with-sql-server-stored-procedures-and-net/
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
