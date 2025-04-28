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
        // Defina a string de conexão
        public static string connectionString = @"Server=localhost\SQLEXPRESS;Database=GestaoRH;Trusted_Connection=True;";

        // Método para criar a conexão com o banco de dados
        public static SqlConnection GetConnection()
        {
            SqlConnection connection = new SqlConnection(connectionString);
            return connection;
        }

        // Método para abrir a conexão
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

        // Método para fechar a conexão
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
