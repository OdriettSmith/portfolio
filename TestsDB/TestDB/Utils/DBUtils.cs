using Aquality.Selenium.Browsers;
using MySql.Data.MySqlClient;
using System;
using System.Data;

namespace TestsDB
{
    internal static class DBUtils
    {
        private const string DBConfig = "server=localhost;user=root;database=union_reporting;port=3306;password=admin";
        public static MySqlConnection connection = new MySqlConnection(DBConfig);
        
        public static void Connect()
        {
            try
            {
                AqualityServices.Logger.Info("Connecting to database");
                connection.Open();
            }
            catch (Exception ex)
            {
                AqualityServices.Logger.Error(ex.ToString());
            }
        }

        public static DataTable SendRequest(string sqlRequest)
        {
            using (connection)
            {
                Connect();              
                AqualityServices.Logger.Info($"Sending sql request: {sqlRequest}");
                MySqlCommand command = new MySqlCommand(sqlRequest, connection);
                MySqlDataReader reader = command.ExecuteReader();
                DataTable dataTable = new DataTable();
                dataTable.Load(reader);

                return dataTable;
            }
        }           
    }
}
