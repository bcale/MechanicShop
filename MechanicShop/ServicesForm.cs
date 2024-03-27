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
    public partial class ServicesForm : Form
    {
        private readonly SqlConnection connection;
        public ServicesForm()
        {
            InitializeComponent();
            connection = DatabaseManager.GetConnection();
        }

        private void txt_ServiceName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_ServicesTitle_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ServiceName_Click(object sender, EventArgs e)
        {

        }

        private void lbl_ServiceDescription_Click(object sender, EventArgs e)
        {

        }

        private void txt_ServiceDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void ServicesForm_Load(object sender, EventArgs e)
        {

        }

        private void txt_ServiceCost_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
