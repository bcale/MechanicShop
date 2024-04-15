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
            VehicleForm addVehicleForm = new VehicleForm();
            addVehicleForm.ShowDialog();
        }

        private void btn_Management_Click(object sender, EventArgs e)
        {
            //Create an instance of New Appointment Form
            NewAppointmentForm newAppointmentForm = new NewAppointmentForm();
            newAppointmentForm.ShowDialog();
        }

        private void btn_NewService_Click(object sender, EventArgs e)
        {
            // Create an instance of Services form
            ServicesForm servicesForm = new ServicesForm();
            servicesForm.ShowDialog();
        }

        private void btn_NewTechnician_Click(object sender, EventArgs e)
        {
            // Create an instance of Technician form
            NewTechnicianForm addTechnicianForm = new NewTechnicianForm();
            addTechnicianForm.ShowDialog();
        }

        private void btn_NewTechRank_Click(object sender, EventArgs e)
        {
            // Create an instance of Technician rank form
            NewTechRankForm addTechRankForm = new NewTechRankForm();
            addTechRankForm.ShowDialog();
        }

        private void btn_manageServices_Click(object sender, EventArgs e)
        {
            ManagementForm managementForm = new ManagementForm();
            managementForm.ShowDialog();
        }
    }
}
