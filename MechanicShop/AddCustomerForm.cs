using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MechanicShop
{
    public partial class AddCustomerForm : Form
    {
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

        public AddCustomerForm()
        {
            InitializeComponent();
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

            // TODO: Insert into DB
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
