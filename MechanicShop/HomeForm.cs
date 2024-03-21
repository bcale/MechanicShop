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
    public static class DatabaseManager
    {
        private static SqlConnection? connection = null;        //https://learn.microsoft.com/en-us/dotnet/csharp/language-reference/compiler-messages/nullable-warnings?f1url=%3FappId%3Droslyn%26k%3Dk(CS8625)#possible-null-assigned-to-a-nonnullable-reference

        public static SqlConnection GetConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                // Connect to the Server
                string computerName = Environment.MachineName;      // Get the name of the computer
                string connetionString = @"Data Source=" + computerName + @"\SQLEXPRESS;Initial Catalog=MechanicShop;Integrated Security=True;";

                try
                {
                    // using will automatically dispose of the object, connection, when its not needed anymore
                    using (connection = new SqlConnection(connetionString))
                    {
                        connection.Open();
                        MessageBox.Show("Connection Open!");
                    }
                }
                catch (Exception ex)
                {
                    // Close the connection and notify user if there is an error
                    if (connection != null && connection.State == ConnectionState.Open)
                    {
                        connection.Close();
                    }

                    MessageBox.Show("Error: " + ex.Message);
                }
            }

            return connection;
        }

        public static void CloseConnection()
        {
            if (connection != null && connection.State == System.Data.ConnectionState.Open)
            {
                connection.Close();
            }
        }
    }

    public partial class HomeForm : Form
    {
        readonly SqlConnection connection = DatabaseManager.GetConnection();

        public HomeForm()
        {
            InitializeComponent();
        }

        private void HomeForm_Load(object sender, EventArgs e)
        {

        }

        private void btn_AddCustomer_Click(object sender, EventArgs e)
        {
            // Create an instance of the form 
            AddCustomerForm addCustomerForm = new AddCustomerForm();
            addCustomerForm.ShowDialog();

        }
    }
}
