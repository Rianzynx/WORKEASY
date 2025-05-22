using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace Login
{
    public partial class Form1: Form
    {
        public static Form1 Instance;
        private bool isCollapsed;
        private Form formularioAtual = null;
        bool menuExpandido = false;
        bool expandindoMenu = false;
        bool recolhendoMenu = false;
        int larguraExpandida = 230;
        int larguraRecolhida = 95;


        public Form1()
        {
            InitializeComponent();
            Instance = this;

            this.Click += new EventHandler(Form1_Click);
            this.DoubleBuffered = true;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
            UpdateStyles();
        }

      
        private void Form1_Load(object sender, EventArgs e)
        {

            CarregarFormInicio();
            int minHeight = btnFunc.Bottom + 10;
            menuExpandido = false;


            panelMenu.MouseEnter += panelMenu_MouseEnter;
            panelMenu.MouseLeave += panelMenu_MouseLeave;

            btnIni.IconChar = FontAwesome.Sharp.IconChar.House;
            btnSol.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            btnFunc.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            btnRelat.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            btnOp.IconChar = FontAwesome.Sharp.IconChar.Cog;


            isCollapsed = true;

        }


        private void Form1_Click(object sender, EventArgs e)
        {
            if (!panelMenuFunc.Bounds.Contains(PointToClient(Cursor.Position)) && panelMenuFunc.Visible)
            {
                panelMenuFunc.Visible = false; 
            }
        }



        private void CarregarFormInicio()
        {

            FormInicio formInicio = new FormInicio();

            formInicio.TopLevel = false;
            formInicio.FormBorderStyle = FormBorderStyle.None;
            formInicio.Dock = DockStyle.Fill;

            pSol.Controls.Clear();
            pSol.Controls.Add(formInicio);
            formInicio.Dock = DockStyle.Fill;

            formInicio.Show();

            formularioAtual = formInicio;

        }

        private void panelMenu_MouseEnter(object sender, EventArgs e)
        {
            if (!menuExpandido)
            {
                expandindoMenu = true;
                recolhendoMenu = false;
                timer1.Start();
            }
        }

        private void panelMenu_MouseLeave(object sender, EventArgs e)
        {
            if (menuExpandido && !panelMenu.Bounds.Contains(PointToClient(Cursor.Position)))
            {
                recolhendoMenu = true;
                expandindoMenu = false;
                timer1.Start();
                isCollapsed = false;
                timer2.Start();
            }
        }


        private void btnSol_Click(object sender, EventArgs e)
        {

            RecolherSubMenu();

            if (formularioAtual is FormSolicitacao)
            {
                return;
            }

            FormSolicitacao formSolicitacao = new FormSolicitacao();

            formSolicitacao.Size = pSol.ClientSize;
            formSolicitacao.TopLevel = false;  
            formSolicitacao.FormBorderStyle = FormBorderStyle.None; 


            pSol.Controls.Clear();  
            pSol.Controls.Add(formSolicitacao);  

            formSolicitacao.Show();

            formularioAtual = formSolicitacao;
        }



        private void pSol_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnIni_Click(object sender, EventArgs e)
        {
            RecolherSubMenu();

            if (formularioAtual is FormInicio)
            {
                return;
            }

            FormInicio formInicio = new FormInicio();

            formInicio.TopLevel = false;
            formInicio.FormBorderStyle = FormBorderStyle.None;
            formInicio.Dock = DockStyle.Fill;

            pSol.Controls.Clear();
            pSol.Controls.Add(formInicio);
            formInicio.Dock = DockStyle.Fill;

            formInicio.Show();

            formularioAtual = formInicio;
        }



        private void btnFunc_Click(object sender, EventArgs e)
        {

            if (panelMenuFunc.Visible && panelMenuFunc.Height > 0)
            {
                isCollapsed = false; 
                timer2.Start();
            }
            else
            {
                panelMenuFunc.Visible = true;
                isCollapsed = true; 
                timer2.Start();
            }
        }

        private void btnGeralFunc_Click(object sender, EventArgs e)
        {
            if (!(formularioAtual is FormFuncionario))
            {
                FormFuncionario formFuncionario = new FormFuncionario();

                formFuncionario.TopLevel = false;
                formFuncionario.FormBorderStyle = FormBorderStyle.None;
                formFuncionario.Dock = DockStyle.Fill;

                pSol.Controls.Clear();
                pSol.Controls.Add(formFuncionario);
                formFuncionario.Show();

                formularioAtual = formFuncionario;
            }
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            int step = 10;
            int minHeight = 0;
            int maxHeight = 180;

            if (isCollapsed)
            {
                panelMenuFunc.Height += step;
                if (panelMenuFunc.Height >= maxHeight)
                {
                    panelMenuFunc.Height = maxHeight;
                    isCollapsed = false;  
                    timer2.Stop();  
                }
            }
            else
            {
                panelMenuFunc.Height -= step;
                if (panelMenuFunc.Height <= minHeight)
                {
                    panelMenuFunc.Height = minHeight;
                    panelMenuFunc.Visible = false;  
                    timer2.Stop();  
                }
            }
        }


        private void RecolherSubMenu()
        {
            if (panelMenuFunc.Visible)
            {
                isCollapsed = false;
                timer2.Start(); 
            }
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

 

        private void btnRelat_Click(object sender, EventArgs e)
        {

            RecolherSubMenu();

            if (formularioAtual is FormSolicitacao)
            {
                return;
            }

            FormRelatorio formRelatorio = new FormRelatorio();

            formRelatorio.Size = pSol.ClientSize;
            formRelatorio.TopLevel = false;
            formRelatorio.FormBorderStyle = FormBorderStyle.None;


            pSol.Controls.Clear();
            pSol.Controls.Add(formRelatorio);

            formRelatorio.Show();

            formularioAtual = formRelatorio;
        }

   


        private void timer1_Tick(object sender, EventArgs e)
        {
            panelMenu.BringToFront();
            int step = 20;

            if (expandindoMenu)
            {
                panelMenu.Width += step;
                if (panelMenu.Width >= larguraExpandida)
                {
                    panelMenu.Width = larguraExpandida;
                    expandindoMenu = false;
                    menuExpandido = true;

                    AtualizarBotoesExpandido();
                }
            }
            else if (recolhendoMenu)
            {
                panelMenu.Width -= step;
                if (panelMenu.Width <= larguraRecolhida)
                {
                    panelMenu.Width = larguraRecolhida;
                    recolhendoMenu = false;
                    menuExpandido = false;

                    AtualizarBotoesRecolhido();
                }
            }
        }


        private void AtualizarBotoesExpandido()
        {
            panelMenuFunc.Width = 170;
            btnIni.Width = btnSol.Width = btnFunc.Width = btnRelat.Width = btnOp.Width = 170;


            btnIni.Text = "Início";
            btnSol.Text = "Solicitações";
            btnFunc.Text = "Funcionários";
            btnRelat.Text = "Relatórios";
            btnOp.Text = "Configurações";

            ConfigurarAlinhamentoBotoes(true);
        }

        private void AtualizarBotoesRecolhido()
        {
            btnIni.Width = btnSol.Width = btnFunc.Width = btnRelat.Width = btnOp.Width = 35;

            btnIni.Text = btnSol.Text = btnFunc.Text = btnRelat.Text = btnOp.Text = "";

            ConfigurarAlinhamentoBotoes(false);
        }

        private void ConfigurarAlinhamentoBotoes(bool expandido)
        {
            ContentAlignment align = expandido ? ContentAlignment.MiddleRight : ContentAlignment.MiddleCenter;
            ContentAlignment imgAlign = expandido ? ContentAlignment.MiddleLeft : ContentAlignment.MiddleCenter;
            TextImageRelation rel = expandido ? TextImageRelation.ImageBeforeText : TextImageRelation.Overlay;

            foreach (var btn in new[] { btnIni, btnSol, btnFunc, btnRelat, btnOp })
            {
                btn.TextAlign = align;
                btn.ImageAlign = imgAlign;
                btn.TextImageRelation = rel;
            }
        }



        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            FormCadastrar formCadastrar = new FormCadastrar();

            formCadastrar.TopLevel = false;
            formCadastrar.FormBorderStyle = FormBorderStyle.None;
            formCadastrar.Dock = DockStyle.Fill;

            pSol.Controls.Clear(); 
            pSol.Controls.Add(formCadastrar); 

            formCadastrar.Show();

            formularioAtual = formCadastrar;
            panelMenuFunc.Visible = false;
        }

    
        private void panelMenu_Click(object sender, EventArgs e)
        {
            RecolherSubMenu();
        }

        private void lblNome_Click(object sender, EventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            FormEditar formeditar = new FormEditar();

            formeditar.TopLevel = false;
            formeditar.FormBorderStyle = FormBorderStyle.None;
            formeditar.Dock = DockStyle.Fill;

            pSol.Controls.Clear();
            pSol.Controls.Add(formeditar);

            formeditar.Show();

            formularioAtual = formeditar;
        }
    }
}
