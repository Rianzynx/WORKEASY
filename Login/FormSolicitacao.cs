using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Login.Properties;

namespace Login
{
    public partial class FormSolicitacao : Form
    {
        public FormSolicitacao()
        {
            InitializeComponent();


            if (dataGridView1 == null)
            {
                MessageBox.Show("DataGridView não foi inicializado.");
                return;
            }

            this.Dock = DockStyle.Fill;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("*", typeof(Image));
            dataTable.Columns.Add("Nome", typeof(string));
            dataTable.Columns.Add("Assunto", typeof(string));
            dataTable.Columns.Add("Horario", typeof(string));

            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Carlos Silva", "Solicitação de Aumento", "08:15");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Maria Oliveira", "Solicitação de Férias", "10:45");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Felipe Almeida", "Solicitação de Documentos", "14:30");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Ana Costa", "Solicitação de Aumento", "09:00");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Bruna Souza", "Solicitação de Férias", "12:00");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Eduardo Martins", "Solicitação de Documentos", "15:10");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Lucas Pereira", "Afastamento por Doença", "07:50");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Tatiane Rocha", "Alteração de Dados Cadastrais", "16:25");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Gustavo Fernandes", "Solicitação de Licença-Maternidade", "11:55");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Patrícia Gomes", "Solicitação de Transferência", "13:20");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Roberto Silva", "Solicitação de Férias", "17:00");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Juliana Lima", "Pedido de Reajuste Salarial", "08:40");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Tiago Barbosa", "Solicitação de Afastamento", "10:31");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Tiago Souza", "Solicitação de Afastamento", "10:32");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Tiago Alves", "Solicitação de Afastamento", "10:33");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Larissa Martins", "Solicitação de Reembolso de Despesas", "14:50");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Marcos Pereira", "Solicitação de Documentos", "12:10");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Célia Costa", "Demissão Voluntária", "09:25");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "André Silva", "Solicitação de Férias", "16:00");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Fernanda Alves", "Pedido de Ajuste de Jornada", "11:30");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Ricardo Santos", "Reintegração ao Trabalho", "09:40");
            dataTable.Rows.Add(RedimensionarImagem(Resources.email1, 40, 40), "Sônia Lima", "Solicitação de Benefícios", "13:05");

            // Ordena o DataTable pela coluna "Horario"
            var sortedRows = dataTable.AsEnumerable()
                                      .OrderByDescending(row => TimeSpan.Parse(row.Field<string>("Horario")))
                                      .ToArray();

            DataTable sortedDataTable = dataTable.Clone(); 
            foreach (DataRow row in sortedRows)
            {
                sortedDataTable.ImportRow(row); 
            }


            dataGridView1.DataSource = sortedDataTable;

            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dataGridView1.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridView1.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dataGridView1.RowTemplate.Height = 40;
            dataGridView1.DefaultCellStyle.BackColor = Color.White;
            dataGridView1.ColumnHeadersVisible = false;
            dataGridView1.RowHeadersVisible = false;
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.Dock = DockStyle.Fill;

            dataGridView1.AllowUserToResizeColumns = false;
            dataGridView1.AllowUserToResizeRows = false;

            dataGridView1.CellMouseEnter += dataGridView1_CellMouseEnter;
            dataGridView1.CellMouseLeave += dataGridView1_CellMouseLeave;

            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.Black;


            AjustarLarguraDasColunas();
            AjustarImagemNoDataGridView();
            this.Resize += FormSolicitacao_Resize;


            btnPesquisar.Click += BtnPesquisar_Click;
        }

        private void BtnPesquisar_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txtPesquisa.Text.ToLower(); 

            
            var linhasFiltradas = ((DataTable)dataGridView1.DataSource).AsEnumerable()
                .Where(row => row.Field<string>("Nome").ToLower().Contains(termoPesquisa) ||
                              row.Field<string>("Assunto").ToLower().Contains(termoPesquisa) ||
                              row.Field<string>("Horario").ToLower().Contains(termoPesquisa))
                .ToArray();

           
            DataTable filtroDataTable = ((DataTable)dataGridView1.DataSource).Clone(); 
            foreach (var linha in linhasFiltradas)
            {
                filtroDataTable.ImportRow(linha); 
            }

           
            dataGridView1.DataSource = filtroDataTable;

           
            AjustarLarguraDasColunas();
        } 

      
        private void AjustarLarguraDasColunas()
        {
            int larguraTotal = dataGridView1.ClientSize.Width;

           
            dataGridView1.Columns[0].Width = (int)(larguraTotal * 0.1);
            dataGridView1.Columns[1].Width = (int)(larguraTotal * 0.2);
            dataGridView1.Columns[2].Width = (int)(larguraTotal * 0.5);
            dataGridView1.Columns[3].Width = (int)(larguraTotal * 0.1);


            dataGridView1.Refresh(); 
        }


        private void FormSolicitacao_Resize(object sender, EventArgs e)
        {
            AjustarLarguraDasColunas();
        }


        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
      
        }

        private void button1_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.LightBlue; 
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.White; 
        }

        private void button2_MouseEnter(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.LightBlue; 
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            button.ForeColor = Color.White; 
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!dataGridView1.Rows[e.RowIndex].Selected)
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGray;
                }
            }
        }

        private void dataGridView1_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!dataGridView1.Rows[e.RowIndex].Selected)
                {
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void btnPesquisa_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void AjustarImagemNoDataGridView()
        {
            // Centraliza o conteúdo da célula horizontal e verticalmente para a coluna iconEmail
            dataGridView1.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Definir um tamanho fixo para a célula (ajuste conforme necessário)
            dataGridView1.RowTemplate.Height = 50; // Defina a altura para acomodar a imagem
            dataGridView1.Columns[0].Width = 50;   // Defina a largura para a coluna de ícones

            // Se você precisar garantir que a imagem ocupe o centro da célula sem distorcer
            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                // Acessa a célula da coluna 0 (iconEmail) e define o layout da imagem
                DataGridViewImageCell imageCell = row.Cells[0] as DataGridViewImageCell;
                if (imageCell != null)
                {
                    // Centraliza a imagem (sem distorção)
                    imageCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    imageCell.ImageLayout = DataGridViewImageCellLayout.Zoom; // Ajusta a imagem para caber na célula sem estourar
                }
            }
        }

        private Image RedimensionarImagem(Image imagemOriginal, int largura, int altura)
        {
            Bitmap imagemRedimensionada = new Bitmap(imagemOriginal, new Size(largura, altura));
            return imagemRedimensionada;
        }




    }
}
