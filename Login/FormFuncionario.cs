using Login.Properties;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Login
{
    public partial class FormFuncionario : Form
    {
        public FormFuncionario()
        {
            InitializeComponent();


            if (dgvColab == null)
            {
                MessageBox.Show("DataGridView não foi inicializado.");
                return;
            }

            this.Dock = DockStyle.Fill;

            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("*", typeof(Image));
            dataTable.Columns.Add("Nome", typeof(string));
            dataTable.Columns.Add("Assunto", typeof(string));
            dataTable.Columns.Add("Data", typeof(string));

            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Carlos Silva", "Férias Programadas", "10/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Maria Oliveira", "Em Licença Maternidade", "11/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Felipe Almeida", "Afastado por Doença", "12/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Ana Costa", "Em Treinamento", "13/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Bruna Souza", "Férias Programadas", "14/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Eduardo Martins", "Afastamento Temporário", "15/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Lucas Pereira", "Solicitação de Remanejamento de Tarefa", "16/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Tatiane Rocha", "Em Reunião Externa", "17/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Gustavo Fernandes", "Em Licença Paternidade", "18/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Patrícia Gomes", "Em Afastamento Médico", "19/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Roberto Silva", "Férias Programadas", "20/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Juliana Lima", "Afastamento por Motivo Pessoal", "21/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Tiago Barbosa", "Solicitação de Ajuste de Jornada", "22/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Tiago Souza", "Afastado por Doença", "23/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Tiago Alves", "Participando de Workshop", "24/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Larissa Martins", "Em Férias", "25/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Marcos Pereira", "Em Licença Maternidade", "26/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Célia Costa", "Afastada por Doença", "27/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "André Silva", "Solicitação de Transferência de Setor", "28/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Fernanda Alves", "Em Treinamento", "29/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Ricardo Santos", "Férias Programadas", "30/03/2025");
            dataTable.Rows.Add(RedimensionarImagem(Resources.trabHomemIcon, 40, 40), "Sônia Lima", "Afastada por Motivo Pessoal", "31/03/2025");



            var sortedRows = dataTable.AsEnumerable()
                                       .OrderByDescending(row => DateTime.Parse(row.Field<string>("Data")))
                                       .ToArray();

            DataTable sortedDataTable = dataTable.Clone();
            foreach (DataRow row in sortedRows)
            {
                sortedDataTable.ImportRow(row);
            }


            dgvColab.DataSource = sortedDataTable;

            dgvColab.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvColab.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            dgvColab.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvColab.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;

            dgvColab.RowTemplate.Height = 40;
            dgvColab.DefaultCellStyle.BackColor = Color.White;
            dgvColab.ColumnHeadersVisible = false;
            dgvColab.RowHeadersVisible = false;
            dgvColab.AllowUserToAddRows = false;
            dgvColab.Dock = DockStyle.Fill;

            dgvColab.AllowUserToResizeColumns = false;
            dgvColab.AllowUserToResizeRows = false;

            dgvColab.CellMouseEnter += dgvColab_CellMouseEnter;
            dgvColab.CellMouseLeave += dgvColab_CellMouseLeave;

            dgvColab.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            AjustarLarguraDasColunas();
            AjustarImagemNoDataGridView();
            this.Resize += FormSolicitacao_Resize;


            btnPesquisarColab.Click += BtnPesquisarColab_Click;
        }

        private void BtnPesquisarColab_Click(object sender, EventArgs e)
        {
            string termoPesquisa = txtPesquisarColab.Text.ToLower();

            var linhasFiltradas = ((DataTable)dgvColab.DataSource).AsEnumerable()
                .Where(row => row.Field<string>("Nome").ToLower().Contains(termoPesquisa) ||
                              row.Field<string>("Assunto").ToLower().Contains(termoPesquisa) ||
                              row.Field<string>("Data").ToLower().Contains(termoPesquisa))  
                .ToArray();

            DataTable filtroDataTable = ((DataTable)dgvColab.DataSource).Clone();
            foreach (var linha in linhasFiltradas)
            {
                filtroDataTable.ImportRow(linha);
            }

            dgvColab.DataSource = filtroDataTable;
            AjustarLarguraDasColunas();
        }

        private void AjustarLarguraDasColunas()
        {
            int larguraTotal = dgvColab.ClientSize.Width;

            if (larguraTotal > 0)
            {
                dgvColab.Columns[0].Width = (int)(larguraTotal * 0.10);  
                dgvColab.Columns[1].Width = (int)(larguraTotal * 0.30);  
                dgvColab.Columns[2].Width = (int)(larguraTotal * 0.45);  
                dgvColab.Columns[3].Width = (int)(larguraTotal * 0.15);  
            }

            dgvColab.Refresh();
        }



        private void FormSolicitacao_Resize(object sender, EventArgs e)
        {
            AjustarLarguraDasColunas();
        }

        private void AjustarImagemNoDataGridView()
        {
            dgvColab.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            dgvColab.RowTemplate.Height = 50;
            dgvColab.Columns[0].Width = 50;

            foreach (DataGridViewRow row in dgvColab.Rows)
            {
                DataGridViewImageCell imageCell = row.Cells[0] as DataGridViewImageCell;
                if (imageCell != null)
                {
                    imageCell.Style.Alignment = DataGridViewContentAlignment.MiddleCenter;
                    imageCell.ImageLayout = DataGridViewImageCellLayout.Zoom;
                }
            }
        }

        private Image RedimensionarImagem(Image imagemOriginal, int largura, int altura)
        {
            Bitmap imagemRedimensionada = new Bitmap(imagemOriginal, new Size(largura, altura));
            return imagemRedimensionada;
        }


        private void dgvColab_CellMouseEnter(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!dgvColab.Rows[e.RowIndex].Selected)
                {
                    dgvColab.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.SkyBlue;
                }
            }
        }

        private void dgvColab_CellMouseLeave(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                if (!dgvColab.Rows[e.RowIndex].Selected)
                {
                    dgvColab.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.WhiteSmoke;
                }
            }
        }

        private void FormFuncionario_Load(object sender, EventArgs e)
        {
            panel3.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            panel3.Height = panelDados.Height;
            panel3.Location = new System.Drawing.Point(
                (panelDados.Width - panel2.Width - panel2.Width) / 2,  
                0
            );
            panelDados.Controls.Add(panel2);
        }
        private void label1_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
         
        }

        private void btnSalario_Click(object sender, EventArgs e)
        {
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void lblColab_Click(object sender, EventArgs e)
        {

        }
    }
}
