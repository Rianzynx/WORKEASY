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

        public static Form1 Instance;
        public Form1()
        {
            InitializeComponent();
            Instance = this;
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

        private bool estaComLua = true;
        private void btnSolClick(object sender, EventArgs e)
        {
            if (estaComLua)
            {
                // Tema Escuro
                btnSol.Image = Properties.Resources.iconSol;
                this.BackColor = Color.FromArgb(30, 30, 30); // Fundo do formulário
                panelTop.BackColor = Color.FromArgb(45, 45, 48);
                lblNome.ForeColor = Color.White;
                if (Form1.Instance != null)
                {
                    Form1.Instance.PanelMenu.BackColor = Color.FromArgb(50, 50, 50);// muda o panel do Form1 já aberto
                }
                panelTop.ForeColor = Color.White; // Texto do menu
                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = Color.FromArgb(50, 50, 50);
                        btn.ForeColor = Color.White;
                    }
                    if (ctrl is Label lbl)
                    {
                        lbl.ForeColor = Color.White;
                    }
                }

                estaComLua = false;
            }
            else
            {
                // Tema Claro
                btnSol.Image = Properties.Resources.iconLua;
                this.BackColor = Color.White;
                panelTop.BackColor = Color.White;
                lblNome.ForeColor = Color.DarkGray;

                if (Form1.Instance != null)
                {
                    Form1.Instance.PanelMenu.BackColor = Color.White;
                }

                panelTop.ForeColor = Color.Black;

                foreach (Control ctrl in this.Controls)
                {
                    if (ctrl is Button btn)
                    {
                        btn.BackColor = Color.White;
                        btn.ForeColor = Color.Black;
                    }
                    if (ctrl is Label lbl)
                    {
                        lbl.ForeColor = Color.Black;
                    }
                }

                estaComLua = true;
            }

            btnSol.ImageAlign = ContentAlignment.MiddleCenter;
        }

        public Panel PanelMenu
        {
            get { return panelMenu; }
        }
    }
}
