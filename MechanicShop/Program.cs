using System.Data.SqlClient;

namespace MechanicShop
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new HomeForm());
        }
    }
    public static class DatabaseManager
    {
        private static readonly string connectionString = @"Data Source=" + Environment.MachineName + @"\SQLEXPRESS;Initial Catalog=MechanicShop;Integrated Security=True;";
        private static SqlConnection connection;

        // Static constructor to initialize the connection
        static DatabaseManager()
        {
            connection = new SqlConnection(connectionString);
            OpenConnection();
        }

        // Method to open the connection
        private static void OpenConnection()
        {
            try
            {
                connection.Open();
            }
            catch (Exception ex)
            {
                // Handle connection opening errors
                Console.WriteLine("Error opening connection: " + ex.Message);
            }
        }

        // Method to get the connection instance
        public static SqlConnection GetConnection()
        {
            // Ensure connection is open before returning
            if (connection.State != System.Data.ConnectionState.Open)
            {
                OpenConnection();
            }

            return connection;
        }

        // Method to get the connection string
        public static string GetConnectionString()
        {
            return connectionString;
        }
    }
}