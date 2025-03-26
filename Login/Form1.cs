using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1: Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // Chama o método para carregar o FormInicio assim que o Form1 for carregado
            CarregarFormInicio();
        }

        private void CarregarFormInicio()
        {
            // Cria uma instância do FormInicio
            FormInicio formInicio = new FormInicio();

            // Define as propriedades para que o FormInicio ocupe o espaço todo no painel pSol
            formInicio.TopLevel = false;
            formInicio.FormBorderStyle = FormBorderStyle.None;
            formInicio.Dock = DockStyle.Fill;

            // Limpa o painel pSol antes de adicionar o novo formulário
            pSol.Controls.Clear();

            // Adiciona o FormInicio ao painel pSol
            pSol.Controls.Add(formInicio);
            formInicio.Dock = DockStyle.Fill;

            // Exibe o FormInicio
            formInicio.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormSolicitacao formSolicitacao = new FormSolicitacao();

            formSolicitacao.TopLevel = false;  
            formSolicitacao.FormBorderStyle = FormBorderStyle.None; 
            formSolicitacao.Dock = DockStyle.Fill;  

            pSol.Controls.Clear();  
            pSol.Controls.Add(formSolicitacao);  
            formSolicitacao.Dock = DockStyle.Fill;

            formSolicitacao.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }


        private void pSol_Paint(object sender, PaintEventArgs e)
        {
            pSol.Dock = DockStyle.Fill;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIni_Click(object sender, EventArgs e)
        {
            FormInicio formInicio = new FormInicio();

            formInicio.TopLevel = false;
            formInicio.FormBorderStyle = FormBorderStyle.None;
            formInicio.Dock = DockStyle.Fill;

            pSol.Controls.Clear();
            pSol.Controls.Add(formInicio);
            formInicio.Dock = DockStyle.Fill;

            formInicio.Show();
        }

        private void btnFunc_Click(object sender, EventArgs e)
        {
            FormFuncionario formFuncionario = new FormFuncionario();

            formFuncionario.TopLevel = false;
            formFuncionario.FormBorderStyle = FormBorderStyle.None;
            formFuncionario.Dock = DockStyle.Fill;

            pSol.Controls.Clear();
            pSol.Controls.Add(formFuncionario);
            formFuncionario.Dock = DockStyle.Fill;

            formFuncionario.Show();
        }


        private void btnLogout(object sender, EventArgs e)
        {
            DialogResult Logout;
            Logout = MessageBox.Show("Deseja mesmo sair?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Logout.Equals(DialogResult.No))
            {

            }
            else
            {
                Application.Exit();
            }
        }
    }
}
