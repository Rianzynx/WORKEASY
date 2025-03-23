namespace Login
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pSol = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnOp = new System.Windows.Forms.Button();
            this.btnRelat = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnIni = new System.Windows.Forms.Button();
            this.picLogo = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // pSol
            // 
            this.pSol.BackColor = System.Drawing.Color.White;
            this.pSol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSol.Location = new System.Drawing.Point(200, 0);
            this.pSol.Name = "pSol";
            this.pSol.Size = new System.Drawing.Size(1166, 745);
            this.pSol.TabIndex = 1;
            this.pSol.Paint += new System.Windows.Forms.PaintEventHandler(this.pSol_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(43)))));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMenu.Controls.Add(this.btnIni);
            this.panelMenu.Controls.Add(this.btnOp);
            this.panelMenu.Controls.Add(this.btnRelat);
            this.panelMenu.Controls.Add(this.btnFunc);
            this.panelMenu.Controls.Add(this.btnSol);
            this.panelMenu.Controls.Add(this.picLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 745);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnOp
            // 
            this.btnOp.BackColor = System.Drawing.Color.Transparent;
            this.btnOp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOp.FlatAppearance.BorderSize = 0;
            this.btnOp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.btnOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOp.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOp.ForeColor = System.Drawing.Color.LightGray;
            this.btnOp.Location = new System.Drawing.Point(0, 427);
            this.btnOp.Name = "btnOp";
            this.btnOp.Size = new System.Drawing.Size(200, 50);
            this.btnOp.TabIndex = 4;
            this.btnOp.Text = "OPÇÕES";
            this.btnOp.UseVisualStyleBackColor = false;
            // 
            // btnRelat
            // 
            this.btnRelat.BackColor = System.Drawing.Color.Transparent;
            this.btnRelat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelat.FlatAppearance.BorderSize = 0;
            this.btnRelat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRelat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.btnRelat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelat.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelat.ForeColor = System.Drawing.Color.LightGray;
            this.btnRelat.Location = new System.Drawing.Point(0, 377);
            this.btnRelat.Name = "btnRelat";
            this.btnRelat.Size = new System.Drawing.Size(200, 50);
            this.btnRelat.TabIndex = 3;
            this.btnRelat.Text = "RELATÓRIOS";
            this.btnRelat.UseVisualStyleBackColor = false;
            this.btnRelat.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.Color.Transparent;
            this.btnFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.Color.LightGray;
            this.btnFunc.Location = new System.Drawing.Point(0, 327);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(200, 50);
            this.btnFunc.TabIndex = 2;
            this.btnFunc.Text = "FUNCIONARIOS";
            this.btnFunc.UseVisualStyleBackColor = false;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // btnSol
            // 
            this.btnSol.BackColor = System.Drawing.Color.Transparent;
            this.btnSol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSol.FlatAppearance.BorderSize = 0;
            this.btnSol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.btnSol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSol.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSol.ForeColor = System.Drawing.Color.LightGray;
            this.btnSol.Location = new System.Drawing.Point(0, 277);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(200, 50);
            this.btnSol.TabIndex = 1;
            this.btnSol.Text = "SOLICITAÇÕES";
            this.btnSol.UseVisualStyleBackColor = false;
            this.btnSol.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIni
            // 
            this.btnIni.BackColor = System.Drawing.Color.Transparent;
            this.btnIni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIni.FlatAppearance.BorderSize = 0;
            this.btnIni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.btnIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIni.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIni.ForeColor = System.Drawing.Color.LightGray;
            this.btnIni.Location = new System.Drawing.Point(0, 225);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(200, 50);
            this.btnIni.TabIndex = 5;
            this.btnIni.Text = "INICIO";
            this.btnIni.UseVisualStyleBackColor = false;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // picLogo
            // 
            this.picLogo.BackColor = System.Drawing.Color.Transparent;
            this.picLogo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.picLogo.Image = ((System.Drawing.Image)(resources.GetObject("picLogo.Image")));
            this.picLogo.Location = new System.Drawing.Point(-62, -97);
            this.picLogo.Name = "picLogo";
            this.picLogo.Size = new System.Drawing.Size(355, 387);
            this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picLogo.TabIndex = 1;
            this.picLogo.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.pSol);
            this.Controls.Add(this.panelMenu);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnOp;
        private System.Windows.Forms.Button btnRelat;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.PictureBox picLogo;
        private System.Windows.Forms.Panel pSol;
        private System.Windows.Forms.Button btnIni;
    }
}

