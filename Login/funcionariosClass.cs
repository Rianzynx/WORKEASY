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
using System.Security.Cryptography;
using System.Windows.Media;

namespace Login
{
    class funcionariosClass
    {

        public bool insertFuncionario(string nome, string email, string tel, string endereco, string cpf, DateTime DataNascimento, DateTime DataAdmissao, string genero, byte[] imagem, string setor)
        {
            SqlConnection connection = DBconnect.GetConnection();
            SqlCommand command = new SqlCommand("INSERT INTO FuncionarioEmpresa (nome, email, telefone, endereco, cpf, data_nascimento, data_admissao, genero, imagem, setor)  VALUES(@fn, @em, @tl, @en, @cp, @dtn, @dta, @gen, @img, @str)", connection);

            command.Parameters.AddWithValue("@fn", nome);
            command.Parameters.AddWithValue("@em", email);
            command.Parameters.AddWithValue("@tl", tel);
            command.Parameters.AddWithValue("@en", endereco);
            command.Parameters.AddWithValue("@cp", cpf);
            command.Parameters.AddWithValue("@dtn", DataNascimento);
            command.Parameters.AddWithValue("@dta", DataAdmissao);
            command.Parameters.AddWithValue("@gen", genero);
            command.Parameters.AddWithValue("@img", imagem);
            command.Parameters.AddWithValue("@str", setor);

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

            SqlCommand command = new SqlCommand("SELECT * FROM FuncionarioEmpresa", DBconnect.GetConnection());
            SqlDataAdapter adapter = new SqlDataAdapter(command);
            DataTable table = new DataTable();
            adapter.Fill(table);
            return table;

        }
    }
}
