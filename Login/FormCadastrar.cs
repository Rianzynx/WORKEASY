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
            string fname = txtNome.Text;
            string lname = txtSobrenome.Text;
            string tel = txtTel.Text;
            DateTime dataNascimento = DNascimento.Value;
            string genero = rBtnMasc.Checked ? "Masculino" : "Feminino";
            string endereco = txtEndereco.Text;

            MemoryStream ms = new MemoryStream();
            pbFuncionario.Image.Save(ms, pbFuncionario.Image.RawFormat);
            byte[] foto = ms.ToArray();

            int born_year = DNascimento.Value.Year;
            int this_year = DateTime.Now.Year;
            if ((this_year - born_year) < 18 || (this_year - born_year) > 100)
            {
                MessageBox.Show("Coloque um idade entre 18 e 100", "Data Invalida", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (verify())
            {
                // Chama o método para inserir no banco
                bool insert = funcionario.insertFuncionario(fname, lname, tel, dataNascimento, genero, endereco, foto);

                if (insert)
                {
                    MessageBox.Show("Funcionário cadastrado com sucesso!", "Cadastro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnLimpar.PerformClick();
                }
                else
                {
                    MessageBox.Show("Erro ao cadastrar funcionário.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Preencha todos os campos obrigatórios!", "Campos Vazios", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        bool verify()
        {
            if ((txtNome.Text == "") || (txtSobrenome.Text == "") || (txtTel.Text == "")
            || (txtEndereco.Text == "") || (pbFuncionario.Image == null))
            {
                return false;
            }
            else
            {
                return true;
            }

        }


        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNome.Clear();
            txtSobrenome.Clear();
            txtTel.Clear();
            txtEndereco.Clear();
            DNascimento.Value = DateTime.Now;
            rBtnMasc.Checked = false;
            rBtnFem.Checked = false;
            pbFuncionario.Image = null;
        }

        private void btnFoto_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Arquivos de Imagem|*.jpg;*.jpeg;*.png;*.bmp;*.gif";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                pbFuncionario.Image = Image.FromFile(openFileDialog.FileName);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
        }

        private void FormCadastrar_Load(object sender, EventArgs e)
        {
            showTable();
        }

        public void showTable()
        {
           
            dataGridView_funcionarios.DataSource = funcionario.getFuncionarioList();

            if (dataGridView_funcionarios.Columns.Count > 0)
            {
               
                dataGridView_funcionarios.Columns[0].Visible = false;

                
                dataGridView_funcionarios.RowTemplate.Height = 40;
                dataGridView_funcionarios.AllowUserToResizeColumns = false;
                dataGridView_funcionarios.AllowUserToResizeRows = false;


                foreach (DataGridViewColumn col in dataGridView_funcionarios.Columns)
                {
                    if (col is DataGridViewImageColumn)
                    {
                        ((DataGridViewImageColumn)col).ImageLayout = DataGridViewImageCellLayout.Zoom;
                    }
                }

                foreach (DataGridViewColumn col in dataGridView_funcionarios.Columns)
                {
                    // Ignora a coluna de ID (primeira) e a última coluna vazia, se houver
                    if (col.Index == dataGridView_funcionarios.Columns.Count - 1)
                    {
                        col.Visible = false;
                    }
                    else
                    {
                        col.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                    }
                }

                // Ajuste adicional para garantir que a última coluna (se estiver vazia) não seja exibida
                if (dataGridView_funcionarios.Columns.Count > 0)
                {
                    DataGridViewColumn lastColumn = dataGridView_funcionarios.Columns[dataGridView_funcionarios.Columns.Count - 1];
                    if (lastColumn != null && lastColumn.Width == 0)
                    {
                        lastColumn.Visible = false;
                    }
                }

            }
        }

    }
}