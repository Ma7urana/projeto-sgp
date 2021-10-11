using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
 using MySql.Data.MySqlClient;

namespace projeto_sgp_WPFversion.DataBase
{
    class Conexao
    {
        private static string host = "localhost";

        private static string port = "3306";

        private static string user = "root";

        private static string password = "root";

        private static string dbname = "FAD";

        private static MySqlConnection connection;

        private static MySqlCommand command;

        public Conexao()
        {
            try
            {
                connection = new MySqlConnection($"server={host}; user={user}; database={dbname}; port={port}");
                connection.Open();
            }
            catch
            {
                throw;
            }
        }

        public void close()
        {
            connection.Close();
        }
    }
}
