using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FormCadastrar : Form
    {
        funcionariosClass funcionario = new funcionariosClass();

        public FormCadastrar()
        {
            InitializeComponent();
        }

        private void btnCadFunc_Click(object sender, EventArgs e)
        {
            // Verificando se todos os campos estão preenchidos
            if (!verify())
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
            DateTime dataAdmissao = DateTime.Now;  // Adicione um campo se necessário
            string genero = rBtnMasc.Checked ? "Masculino" : "Feminino";
            string setor = cbSetor.Text;

            // Validando idade
            int idade = DateTime.Now.Year - dataNascimento.Year;
            if (idade < 18 || idade > 100)
            {
                MessageBox.Show("Coloque uma idade entre 18 e 100", "Data Inválida", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Convertendo imagem para byte[]
            byte[] imagem;
            using (MemoryStream ms = new MemoryStream())
            {
                pbFuncionario.Image.Save(ms, pbFuncionario.Image.RawFormat);
                imagem = ms.ToArray();
            }

            // Inserindo funcionário
            bool insert = funcionario.insertFuncionario(nome, email, tel, endereco, cpf, dataNascimento, dataAdmissao, genero, imagem, setor);

            if (insert)
            {
                MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                btnLimpar.PerformClick();
                showTable();  // Atualiza a tabela após o cadastro
            }
            else
            {
                MessageBox.Show("Erro ao cadastrar funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Verificando se todos os campos obrigatórios estão preenchidos
        bool verify()
        {
            return !string.IsNullOrWhiteSpace(txtNome.Text) &&
                   !string.IsNullOrWhiteSpace(txtTel.Text) &&
                   !string.IsNullOrWhiteSpace(txtEndereco.Text) &&
                   pbFuncionario.Image != null;
        }

        // Limpando os campos do formulário
        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtEmail.Clear();
            txtTel.Clear();
            txtEndereco.Clear();
            txtCpf.Clear();
            DNascimento.Value = DateTime.Now;
            rBtnMasc.Checked = false;
            rBtnFem.Checked = false;
            pbFuncionario.Image = null;
        }

        // Carregando a imagem do funcionário
        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbFuncionario.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        // Carregando a tabela de funcionários
        private void FormCadastrar_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
            dataGridView_funcionarios.DataSource = funcionario.getFuncionarioList();

            if (dataGridView_funcionarios.Columns.Count > 0)
            {
                // Ocultando a coluna de ID (se presente)
                dataGridView_funcionarios.Columns[0].Visible = false;

                // Configurando a exibição das imagens
                dataGridView_funcionarios.RowTemplate.Height = 40;
                dataGridView_funcionarios.RowHeadersVisible = false;
                dataGridView_funcionarios.AllowUserToAddRows = false;
                dataGridView_funcionarios.AllowUserToResizeColumns = false;
                dataGridView_funcionarios.AllowUserToResizeRows = false;
                dataGridView_funcionarios.Dock = DockStyle.Fill;
                dataGridView_funcionarios.ColumnHeadersVisible = true;

                // Definindo os textos dos cabeçalhos
                dataGridView_funcionarios.Columns["id_funcionario"].HeaderText = "ID";
                dataGridView_funcionarios.Columns["nome"].HeaderText = "Nome";
                dataGridView_funcionarios.Columns["email"].HeaderText = "Email";
                dataGridView_funcionarios.Columns["telefone"].HeaderText = "Telefone";
                dataGridView_funcionarios.Columns["endereco"].HeaderText = "Endereço";
                dataGridView_funcionarios.Columns["cpf"].HeaderText = "CPF";
                dataGridView_funcionarios.Columns["data_nascimento"].HeaderText = "Nascimento";
                dataGridView_funcionarios.Columns["data_admissao"].HeaderText = "Admissão";
                dataGridView_funcionarios.Columns["data_demissao"].HeaderText = "Demissão";
                dataGridView_funcionarios.Columns["genero"].HeaderText = "Gênero";
                dataGridView_funcionarios.Columns["imagem"].HeaderText = "Foto";
                dataGridView_funcionarios.Columns["setor"].HeaderText = "Setor";
                dataGridView_funcionarios.Columns["status_funcionario"].HeaderText = "Status";

                foreach (DataGridViewColumn col in dataGridView_funcionarios.Columns)
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
