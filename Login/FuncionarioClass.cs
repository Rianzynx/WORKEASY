using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;

namespace Login
{
    class FuncionarioClass
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Sobrenome { get; set; }
        public string Telefone { get; set; }
        public DateTime DataNascimento { get; set; }
        public string Genero { get; set; }
        public string Endereco { get; set; }
        public byte[] Imagem { get; set; }

        // Método para inserir o funcionário no banco de dados
        public bool InserirFuncionario(FuncionarioClass funcionario)
        {
            try
            {
                // Criar a conexão com o banco de dados
                using (SqlConnection conn = DBconnect.GetConnection())
                {
                    // Definir o comando SQL para inserir os dados
                    string query = "INSERT INTO Funcionarios (nome, sobrenome, telefone, dataNascimento, genero, endereco, imagem) " +
                                   "VALUES (@nome, @sobrenome, @telefone, @dataNascimento, @genero, @endereco, @imagem)";

                    using (SqlCommand cmd = new SqlCommand(query, conn))
                    {
                        // Definir os parâmetros da consulta
                        cmd.Parameters.AddWithValue("@nome", funcionario.Nome);
                        cmd.Parameters.AddWithValue("@sobrenome", funcionario.Sobrenome);
                        cmd.Parameters.AddWithValue("@telefone", funcionario.Telefone);
                        cmd.Parameters.AddWithValue("@dataNascimento", funcionario.DataNascimento);
                        cmd.Parameters.AddWithValue("@genero", funcionario.Genero);
                        cmd.Parameters.AddWithValue("@endereco", funcionario.Endereco);
                        cmd.Parameters.AddWithValue("@imagem", funcionario.Imagem ?? (object)DBNull.Value);

                        // Abrir a conexão
                        conn.Open();

                        // Executar a consulta
                        int resultado = cmd.ExecuteNonQuery();

                        // Retornar true se a operação foi bem-sucedida
                        return resultado > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                // Caso haja um erro, exibir a mensagem de erro
                Console.WriteLine("Erro ao inserir: " + ex.Message);
                return false;
            }
        }
    }
}
