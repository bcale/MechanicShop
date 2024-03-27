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
    public partial class NewCustomerForm : Form
    {
        private readonly SqlConnection connection;

        public class Customer
        {
            public string FirstName { get; set; } = string.Empty;
            public string LastName { get; set; } = string.Empty;
            public string Phone { get; set; } = string.Empty;
            public string City { get; set; } = string.Empty;
            public string Street { get; set; } = string.Empty;
            public string ApartmentNumber { get; set; } = string.Empty;
            public string State { get; set; } = string.Empty;
            public string Zip { get; set; } = string.Empty;
            public string Email { get; set; } = string.Empty;
        }

        public NewCustomerForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
        }

        private void AddCustomer_Load(object sender, EventArgs e)
        {

        }

        private void btn_customerSave_Click(object sender, EventArgs e)
        {
            // Create a new instance of the Customer class and populate it with the data from the text boxes
            Customer customer = new Customer
            {
                FirstName = txt_customerFname.Text,
                LastName = txt_customerLname.Text,
                Phone = txt_customerPhone.Text,
                City = txt_customerCity.Text,
                Street = txt_customerStreet.Text,
                ApartmentNumber = txt_customerAptNumber.Text,
                State = txt_customerState.Text,
                Zip = txt_customerZip.Text,
                Email = txt_customerEmail.Text
            };

            // Have user confirm before saving
            DialogResult result = MessageBox.Show("Insert Customer into Database?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                string p_insert_customer = @"dbo.[insert_customer]";

                SqlCommand command = new SqlCommand(p_insert_customer, connection);
                command.CommandType = CommandType.StoredProcedure;

                // Set SQL Parameters
                command.Parameters.Clear();
                SqlParameter p_FirstName = new("@p_fname", customer.FirstName);
                SqlParameter p_LastName = new("@p_lname", customer.LastName);
                SqlParameter p_Phone = new("@p_phone", customer.Phone);
                SqlParameter p_City = new("@p_city", customer.City);
                SqlParameter p_Street = new("@p_street", customer.Street);
                SqlParameter p_ApartmentNumber = new("@p_apartment_number", customer.ApartmentNumber);
                SqlParameter p_State = new("@p_state", customer.State);
                SqlParameter p_Zip = new("@p_zip", customer.Zip);
                SqlParameter p_Email = new("@p_email", customer.Email);

                // Add the parameters to the SqlCommand Object
                command.Parameters.Add(p_FirstName);
                command.Parameters.Add(p_LastName);
                command.Parameters.Add(p_Phone);
                command.Parameters.Add(p_City);
                command.Parameters.Add(p_Street);
                command.Parameters.Add(p_ApartmentNumber);
                command.Parameters.Add(p_State);
                command.Parameters.Add(p_Zip);
                command.Parameters.Add(p_Email);


                // EXEC the procedure
                command.ExecuteNonQuery();
                this.Close();
            }

            // REFERENCE: https://www.mssqltips.com/sqlservertip/5810/working-with-sql-server-stored-procedures-and-net/
        }

        private void btn_customerCancel_Click(object sender, EventArgs e)
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
