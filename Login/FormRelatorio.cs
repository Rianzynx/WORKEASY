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
    public partial class FormRelatorio: Form
    {
        public FormRelatorio()
        {
            InitializeComponent();
        }

        private void FormRelatorio_Load(object sender, EventArgs e)
        {
            AjustarPanelPR();
        }


        private void AjustarPanelPR()
        {
            int largura = (int)(panelFundo.Width * 0.98);
            int altura = (int)(panelFundo.Height * 0.98);

            panelPR.Size = new Size(largura, altura);
            panelPR.Location = new Point(
                (panelFundo.Width - panelPR.Width) / 2,
                (panelFundo.Height - panelPR.Height) / 2
            );
        }

        private void panelFundo_Resize(object sender, EventArgs e)
        {
            AjustarPanelPR();
        }

    }
}
