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
using System.IO;

namespace Login
{
    public partial class FormEditar : Form
    {
        funcionariosClass funcionario = new funcionariosClass();
        int funcionarioId;

        public FormEditar()
        {
            InitializeComponent();
            dgvEdicaoFunc.DataSource = null; 
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string cpf = txtBuscarCpf.Text.Trim();
            if (string.IsNullOrWhiteSpace(cpf))
            {
                MessageBox.Show("Por favor, insira um CPF para buscar.", "CPF Vazio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Busca o funcionário pelo CPF
            DataTable funcionarioData = funcionario.getFuncionarioByCpf(cpf);
            if (funcionarioData.Rows.Count == 0)
            {
                MessageBox.Show("Funcionário não encontrado.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DataRow row = funcionarioData.Rows[0];
            funcionarioId = Convert.ToInt32(row["id_funcionario"]);
            txtNome.Text = row["nome"].ToString();
            txtEmail.Text = row["email"].ToString();
            txtTel.Text = row["telefone"].ToString();
            txtEndereco.Text = row["endereco"].ToString();
            txtCpf.Text = row["cpf"].ToString();
            DNascimento.Value = Convert.ToDateTime(row["data_nascimento"]);
            cbSetor.Text = row["setor"].ToString();

            string genero = row["genero"].ToString();
            if (genero == "Masculino") rBtnMasc.Checked = true;
            else if (genero == "Feminino") rBtnFem.Checked = true;

            // Carregando a imagem
            if (row["imagem"] != DBNull.Value)
            {
                byte[] imagemBytes = (byte[])row["imagem"];
                using (MemoryStream ms = new MemoryStream(imagemBytes))
                {
                    pbFuncionario.Image = Image.FromStream(ms);
                }
            }
            else
            {
                pbFuncionario.Image = null;
            }

            // Exibindo os dados no DataGridView
            dgvEdicaoFunc.DataSource = funcionarioData;
            showTable(); // Atualiza a tabela após carregar o funcionário

            MessageBox.Show("Funcionário carregado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            // Verificando se os campos obrigatórios estão preenchidos
            if (string.IsNullOrWhiteSpace(txtNome.Text) ||
                string.IsNullOrWhiteSpace(txtEmail.Text) ||
                string.IsNullOrWhiteSpace(txtTel.Text) ||
                string.IsNullOrWhiteSpace(txtEndereco.Text) ||
                string.IsNullOrWhiteSpace(txtCpf.Text))
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Dados do funcionário
            string nome = txtNome.Text;
            string email = txtEmail.Text;
            string tel = txtTel.Text;
            string endereco = txtEndereco.Text;
            string cpf = txtCpf.Text;
            DateTime dataNascimento = DNascimento.Value;
            string setor = cbSetor.Text;
            string genero = rBtnMasc.Checked ? "Masculino" : "Feminino";

            byte[] imagem = null;
            if (pbFuncionario.Image != null)
            {
                try
                {
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pbFuncionario.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Png);
                        imagem = ms.ToArray();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Erro ao processar a imagem: " + ex.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }


            // Atualizando funcionário
            bool updated = funcionario.updateFuncionario(funcionarioId, nome, email, tel, endereco, cpf, dataNascimento, genero, imagem, setor);

            if (updated)
            {
                MessageBox.Show("Funcionário atualizado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Erro ao atualizar funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showTable()
        {
            if (dgvEdicaoFunc.DataSource == null) return;

            if (dgvEdicaoFunc.Columns.Count > 0)
            {
                dgvEdicaoFunc.Columns["id_funcionario"].Visible = false;
                dgvEdicaoFunc.RowTemplate.Height = 40;
                dgvEdicaoFunc.RowHeadersVisible = false;
                dgvEdicaoFunc.AllowUserToAddRows = false;
                dgvEdicaoFunc.AllowUserToResizeColumns = false;
                dgvEdicaoFunc.AllowUserToResizeRows = false;
                dgvEdicaoFunc.Dock = DockStyle.Fill;
                dgvEdicaoFunc.ColumnHeadersVisible = true;

                // Definindo os textos dos cabeçalhos
                dgvEdicaoFunc.Columns["id_funcionario"].HeaderText = "ID";
                dgvEdicaoFunc.Columns["nome"].HeaderText = "Nome";
                dgvEdicaoFunc.Columns["email"].HeaderText = "Email";
                dgvEdicaoFunc.Columns["telefone"].HeaderText = "Telefone";
                dgvEdicaoFunc.Columns["endereco"].HeaderText = "Endereço";
                dgvEdicaoFunc.Columns["cpf"].HeaderText = "CPF";
                dgvEdicaoFunc.Columns["data_nascimento"].HeaderText = "Nascimento";
                dgvEdicaoFunc.Columns["data_admissao"].HeaderText = "Admissão";
                dgvEdicaoFunc.Columns["data_demissao"].HeaderText = "Demissão";
                dgvEdicaoFunc.Columns["genero"].HeaderText = "Gênero";
                dgvEdicaoFunc.Columns["imagem"].HeaderText = "Foto";
                dgvEdicaoFunc.Columns["setor"].HeaderText = "Setor";
                dgvEdicaoFunc.Columns["status_funcionario"].HeaderText = "Status";

                foreach (DataGridViewColumn col in dgvEdicaoFunc.Columns)
                {
                    if (col is DataGridViewImageColumn imgCol)
                    {
                        imgCol.Width = 80;
                        imgCol.ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                    else
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }
            }
        }
    }
}
