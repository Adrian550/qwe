using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace WindowsFormsApp1.database
{
    public static class Database
    {
        private static string host = "185.17.0.136";
        private static string database = "test";
        private static string username = "withay";
        private static string password = "5506078QwQ123";

        private static string connectionString = $"Host={host};Database={database};Username={username};Password={password}";

        public static DataTable ExecuteQuery(string query)
        {
            DataTable resultTable = new DataTable();

            try
            {
                using (NpgsqlConnection connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    using (NpgsqlCommand command = new NpgsqlCommand(query, connection))
                    {
                        using (NpgsqlDataAdapter adapter = new NpgsqlDataAdapter(command))
                        {

                            adapter.Fill(resultTable);
                        }
                    }
                }
            }
            catch (Exception)
            {
            }

            return resultTable;
        }

    }

}
