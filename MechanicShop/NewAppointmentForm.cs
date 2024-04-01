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
    public partial class NewAppointmentForm : Form
    {
        private readonly SqlConnection connection;

        //create Appointment class
        public class Appointment
        {
            public string ServiceDate { get; set; } = string.Empty;
            public string ServiceTime { get; set; } = string.Empty;
            public string 
        }

        public NewAppointmentForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
        }





        //Cancel NewAppointment form 
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
