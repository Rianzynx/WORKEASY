using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using Microsoft.Identity.Client;
using System.Data;

namespace Login
{
    class funcionariosClass
    {

        public bool insertFuncionario(string fnome, string lnome, string tel, DateTime dataNascimento, string genero, string endereco, byte[] foto)
        {
            SqlConnection connection = DBconnect.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO funcionarios (Nome, Sobrenome, Telefone, Data_nascimento, Genero, Endereco, Foto) VALUES (@fn, @ln, @tl, @dn, @gn, @en, @img)", connection);


            command.Parameters.AddWithValue("@fn", fnome);
            command.Parameters.AddWithValue("@ln", lnome);
            command.Parameters.AddWithValue("@tl", tel);
            command.Parameters.AddWithValue("@dn", dataNascimento);
            command.Parameters.AddWithValue("@gn", genero);
            command.Parameters.AddWithValue("@en", endereco);
            command.Parameters.AddWithValue("@img", foto);

            try
            {
                DBconnect.OpenConnection(connection);

                int resultado = command.ExecuteNonQuery();

                return (resultado > 0);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao inserir funcionário: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
            finally
            {
                DBconnect.CloseConnection(connection);
            }

            
        }
        public DataTable getFuncionarioList()
        {

            SqlCommand command = new SqlCommand("SELECT * FROM funcionarios", DBconnect.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
    }
}
