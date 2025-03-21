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
    public partial class FormCarregamento: Form
    {
        public FormCarregamento()
        {
            InitializeComponent();
            Pbar.Value = 0;
            Pbar.Maximum = 104;
        }

        private void circularProgressBar1_Click(object sender, EventArgs e)
        {

        }

        private void FormCarregamento_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (Pbar.Value < Pbar.Maximum)
            {
                Pbar.Value += 2;
            }

            if (Pbar.Value == 100 )
            {
                FormLogin Login = new FormLogin();
                Login.Show();
                this.Hide();
                timer1.Stop();
            }
        }
    }
}
