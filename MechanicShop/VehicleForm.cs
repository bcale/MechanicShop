using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static MechanicShop.NewCustomerForm;

namespace MechanicShop
{
    public partial class VehicleForm : Form
    {
        private readonly SqlConnection connection;

        public class Vehicle
        {
            public string Customer { get; set; } = string.Empty;
            public string Make { get; set; } = string.Empty;
            public string Model { get; set; } = string.Empty;
            public string Trim { get; set; } = string.Empty;
            public string Year { get; set; } = string.Empty;
            public string LicensePlate { get; set; } = string.Empty;
            public string Color { get; set; } = string.Empty;
            public string VIN { get; set; } = string.Empty;
        }

        public VehicleForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
        }

        private void VehicleForm_Load(object sender, EventArgs e)
        {
            // Retrieve customer names from the database and populate the ComboBox
            PopulateCustomerComboBox();
        }

        // Populate a ComboBox with the first and last names from the mechanicshop database
        // format:{lastName}, {firstName}
        private void PopulateCustomerComboBox()
        { 
            string query = "SELECT customer_Fname, customer_Lname FROM Customers";
            SqlCommand command = new SqlCommand(query, connection);

            // Read the results and add each customer name to the ComboBox
            using (SqlDataReader reader = command.ExecuteReader())
            {
                while (reader.Read())
                {
                    // Get the string (assmued data type is string. Must be in the string format. Use a different Get method for different data types)
                    // The number passed to the method is the index of the column retrieved in the SQL query
                    string firstName = reader.GetString(0);
                    string lastName = reader.GetString(1);

                    string fullName = $"{lastName}, {firstName}";
                    // Add each customer name to the ComboBox
                    cbBox_vehicleCustomer.Items.Add(fullName);
                    // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldatareader.getsqlstring?view=dotnet-plat-ext-8.0
                }
                reader.Close(); // Only one SqlDataReader per associated SqlConnection may be open at a time. Be sure to call Close()
            }
        } // Reference: https://learn.microsoft.com/en-us/dotnet/api/system.data.sqlclient.sqldatareader.read?view=dotnet-plat-ext-8.0

        private void btn_vehicleAdd_Click(object sender, EventArgs e)
        {
            Vehicle vehicle = new Vehicle()
            {
                Customer = cbBox_vehicleCustomer.Text,
                Make = txt_vehicleMake.Text,
                Model = txt_vehicleModel.Text,
                Trim = txt_vehicleTrim.Text,
                Year = txt_vehicleYear.Text,
                LicensePlate = txt_vehicleLicensePlate.Text,
                Color = txt_vehicleColor.Text,
                VIN = txt_vehicleVIN.Text,
            };

            // Have user confirm before saving
            DialogResult result = MessageBox.Show("Insert Vehicle into Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string p_insert_vehicle = @"dbo.[insert_vehicles]";
                SqlCommand command = new SqlCommand(p_insert_vehicle, connection);
                command.CommandType = CommandType.StoredProcedure;

                // Set SQL Parameters
                command.Parameters.Clear();
                SqlParameter p_Customer = new SqlParameter("@p_customer", vehicle.Customer);
                SqlParameter p_Make = new SqlParameter("@p_make", vehicle.Make);
                SqlParameter p_Model = new SqlParameter("@p_model", vehicle.Model);
                SqlParameter p_Trim = new SqlParameter("@p_trim", vehicle.Trim);
                SqlParameter p_Year = new SqlParameter("@p_year", vehicle.Year);
                SqlParameter p_LicensePlate = new SqlParameter("@p_license_plate", vehicle.LicensePlate);
                SqlParameter p_Color = new SqlParameter("@p_color", vehicle.Color);
                SqlParameter p_VIN = new SqlParameter("@p_vin", vehicle.VIN);

                // Add the parameters to the SqlCommand Object
                command.Parameters.Add(p_Customer);
                command.Parameters.Add(p_Make);
                command.Parameters.Add(p_Model);
                command.Parameters.Add(p_Trim);
                command.Parameters.Add(p_Year);
                command.Parameters.Add(p_LicensePlate);
                command.Parameters.Add(p_Color);
                command.Parameters.Add(p_VIN);

                // EXEC the procedure
                command.ExecuteNonQuery();
                this.Close();
            }
        }

        private void btn_vehicleCancel_Click(object sender, EventArgs e)
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
