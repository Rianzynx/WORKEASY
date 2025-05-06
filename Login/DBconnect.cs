using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Login
{
   public class DBconnect
    {

        public static string connectionString = @"Server=DESKTOP-FOIQ8TR\SQLEXPRESS;Database=GestaoRH;Trusted_Connection=True;";

        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        public static void OpenConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Open)
                {
                    connection.Open();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao abrir a conexão: " + ex.Message);
            }
        }

        public static void CloseConnection(SqlConnection connection)
        {
            try
            {
                if (connection.State != System.Data.ConnectionState.Closed)
                {
                    connection.Close();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Erro ao fechar a conexão: " + ex.Message);
            }
        }
    }
}
