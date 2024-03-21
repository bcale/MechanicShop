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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MechanicShop
{
    public partial class HomeForm : Form
    {
        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_NewCustomer_Click(object sender, EventArgs e)
        {
            // Create an instance of the form 
            NewCustomerForm addCustomerForm = new NewCustomerForm();
            addCustomerForm.ShowDialog();
        }

        private void btn_NewVehicle_Click(object sender, EventArgs e)
        {
            // Create an instance of the form 
            NewVehicleForm addVehicleForm = new NewVehicleForm();
            addVehicleForm.ShowDialog();
        }

        private void btn_Management_Click(object sender, EventArgs e)
        {

        }
    }
}
