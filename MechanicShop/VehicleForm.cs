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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MechanicShop
{
    public partial class VehicleForm : Form
    {
        private readonly SqlConnection connection;

        public class Vehicle
        {
            public int CustomerID { get; set; } = 0;
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

        }

        private void btn_vehicleAdd_Click(object sender, EventArgs e)
        {
            // Make sure the user entered an integer for the customerID
            if (int.TryParse(txt_customerID.Text, out int int_customerID) && int_customerID != 0)
            {
                Vehicle vehicle = new Vehicle()
                {
                    CustomerID = int_customerID,
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
                    SqlParameter p_Customer = new SqlParameter("@p_customer_id", vehicle.CustomerID);
                    SqlParameter p_Make = new SqlParameter("@p_vehicle_make", vehicle.Make);
                    SqlParameter p_Model = new SqlParameter("@vehicle_model", vehicle.Model);
                    SqlParameter p_Trim = new SqlParameter("@p_vehicle_trim", vehicle.Trim);
                    SqlParameter p_Year = new SqlParameter("@p_vehicle_year", vehicle.Year);
                    SqlParameter p_LicensePlate = new SqlParameter("@p_vehicle_license_plate", vehicle.LicensePlate);
                    SqlParameter p_Color = new SqlParameter("@p_vehicle_color", vehicle.Color);
                    SqlParameter p_VIN = new SqlParameter("@p_vehicle_vin", vehicle.VIN);

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
            else
            {
                MessageBox.Show("Customer ID must be a non 0 number!", "Bad Value", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
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

        // Use the given First and Last names to search for customers in the DataBase
        private void btn_customer_search_Click(object sender, EventArgs e)
        {
            string FirstName = txt_customer_firstName.Text;
            string LastName = txt_customer_lastName.Text;

            string functionName = @"dbo.[search_customer_byName]";

            using (SqlCommand command = new SqlCommand($"SELECT * FROM {functionName}(@p_customer_Fname, @p_customer_Lname)", connection))
            {

                // Set SQL Parameters
                command.Parameters.Clear();
                SqlParameter p_FirstName = new SqlParameter("@p_customer_Fname", FirstName);
                SqlParameter p_LastName = new SqlParameter("@p_customer_Lname", LastName);

                // Add the parameters to the SqlCommand Object
                command.Parameters.Add(p_FirstName);
                command.Parameters.Add(p_LastName);



                SqlDataAdapter adapter = new SqlDataAdapter(command);
                DataTable dataTable = new DataTable();

                try
                {
                    // Fill the data grid
                    adapter.Fill(dataTable);
                    dataGrid_customer_search_results.DataSource = dataTable;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}
