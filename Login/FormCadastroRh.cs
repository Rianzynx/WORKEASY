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
    public partial class FormCadastroRh: Form
    {
        private bool isCollapsed;
        public FormCadastroRh()
        {
            InitializeComponent();
            this.TopLevel = false;
            this.FormBorderStyle = FormBorderStyle.None;
            this.Dock = DockStyle.Fill;
        }


        private void btnSair_Click(object sender, EventArgs e)
        {
            DialogResult Sair;
            Sair = MessageBox.Show("Deseja mesmo sair?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Sair.Equals(DialogResult.No))
            {

            }
            else
            {
                Application.Exit();
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            panelUser.Visible = true;
            isCollapsed = true;
            timer1.Start();
        }


        private void timer1_Tick(object sender, EventArgs e)
        {
            int step = 5;
            int minHeight = 0;
            int maxHeight = 500;

            if (isCollapsed)
            {
                panelUser.Height += step;
                if (panelUser.Height >= maxHeight)
                {
                    panelUser.Height = maxHeight;
                    isCollapsed = false;
                    timer1.Stop();
                }
            }
            else
            {
                panelUser.Height -= step;
                if (panelUser.Height <= minHeight)
                {
                    panelUser.Height = minHeight;
                    panelUser.Visible = false;
                    timer1.Stop();
                }
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            panelUser.Visible = false;
            isCollapsed = false;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            DialogResult Sair;
            Sair = MessageBox.Show("Deseja mesmo sair?", "Pergunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (Sair.Equals(DialogResult.No))
            {

            }
            else
            {
                Application.Exit();
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {
            FormLogin Formlogin = new FormLogin();

            Formlogin.TopLevel = false;
            Formlogin.FormBorderStyle = FormBorderStyle.None;
            Formlogin.Dock = DockStyle.Fill;

            panelFundoCad.Controls.Clear();
            panelFundoCad.Controls.Add(Formlogin);

            Formlogin.Show();
        }
    }
}
