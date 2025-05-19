using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Login
{
    public partial class FormLogin: Form
    {
        private Form formularioAtual = null;
        public FormLogin()
        {
            InitializeComponent();
            txtPass.UseSystemPasswordChar = true;
   

        }



        private void FormLogin_Load(object sender, EventArgs e)
        {
  
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            String User = "admin";
            String Password = "admin";

            if(txtUser.Text == User & txtPass.Text == Password)
            {
                MessageBox.Show("Acesso Liberado!");
                Form1 FormMain = new Form1();
                FormMain.Show();
                this.Hide();
            } else
            {
                MessageBox.Show("Usuario ou senha incorreto!!");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
        }

        
        private void BtnFechar(object sender, EventArgs e)
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

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            if (txtPass.UseSystemPasswordChar)
            {
                pictureBox5.Image = Properties.Resources.passHide;
                txtPass.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBox5.Image = Properties.Resources.passNotHide;
                txtPass.UseSystemPasswordChar = true;
            }
        }

        private void txtPass_TextChanged(object sender, EventArgs e)
        {
          
        }


        private void txtPass_Enter(object sender, EventArgs e)
        {
            if (txtPass.Text == "SENHA")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
            }

        }

        private void txtPass_Leave(object sender, EventArgs e)
        {
            if (txtPass.Text == "")
            {
                txtPass.Text = "";
                txtPass.ForeColor = Color.LightGray;
            }
        }



        private void txtUser_Enter(object sender, EventArgs e)
        {
            if(txtUser.Text == "USUARIO")
            {
                txtUser.Text = "";
                txtUser.ForeColor = Color.LightGray;
               
            }
        }

        private void txtUser_Leave(object sender, EventArgs e)
        {
            if (txtUser.Text == "")
            {
                txtUser.Text = "USUARIO";
                txtUser.ForeColor = Color.LightGray;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {

            FormCadastroRh formcadastroRh = new FormCadastroRh();

            formcadastroRh.TopLevel = false;
            formcadastroRh.FormBorderStyle = FormBorderStyle.None;
            formcadastroRh.Dock = DockStyle.Fill;

            panelFundo.Controls.Clear();
            panelFundo.Controls.Add(formcadastroRh);

            formcadastroRh.Show();

        }
    }
}
