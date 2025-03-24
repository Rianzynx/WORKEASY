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
            this.pSol = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.btnIni = new System.Windows.Forms.Button();
            this.btnOp = new System.Windows.Forms.Button();
            this.btnRelat = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pSol
            // 
            this.pSol.BackColor = System.Drawing.Color.White;
            this.pSol.Dock = System.Windows.Forms.DockStyle.Bottom;
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
            this.panelMenu.Controls.Add(this.btnOp);
            this.panelMenu.Controls.Add(this.btnRelat);
            this.panelMenu.Controls.Add(this.btnFunc);
            this.panelMenu.Controls.Add(this.btnSol);
            this.panelMenu.Controls.Add(this.btnIni);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Controls.Add(this.button1);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(200, 745);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnIni
            // 
            this.btnIni.BackColor = System.Drawing.Color.Transparent;
            this.btnIni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnIni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIni.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIni.FlatAppearance.BorderSize = 0;
            this.btnIni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.btnIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIni.ForeColor = System.Drawing.Color.LightGray;
            this.btnIni.Location = new System.Drawing.Point(0, 197);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(200, 87);
            this.btnIni.TabIndex = 5;
            this.btnIni.Text = "INICIO";
            this.btnIni.UseVisualStyleBackColor = false;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // btnOp
            // 
            this.btnOp.BackColor = System.Drawing.Color.Transparent;
            this.btnOp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOp.FlatAppearance.BorderSize = 0;
            this.btnOp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.btnOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOp.ForeColor = System.Drawing.Color.LightGray;
            this.btnOp.Location = new System.Drawing.Point(0, 545);
            this.btnOp.Name = "btnOp";
            this.btnOp.Size = new System.Drawing.Size(200, 87);
            this.btnOp.TabIndex = 4;
            this.btnOp.Text = "OPÇÕES";
            this.btnOp.UseVisualStyleBackColor = false;
            // 
            // btnRelat
            // 
            this.btnRelat.BackColor = System.Drawing.Color.Transparent;
            this.btnRelat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelat.FlatAppearance.BorderSize = 0;
            this.btnRelat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRelat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.btnRelat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelat.ForeColor = System.Drawing.Color.LightGray;
            this.btnRelat.Location = new System.Drawing.Point(0, 458);
            this.btnRelat.Name = "btnRelat";
            this.btnRelat.Size = new System.Drawing.Size(200, 87);
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
            this.btnFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.Color.LightGray;
            this.btnFunc.Location = new System.Drawing.Point(0, 371);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(200, 87);
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
            this.btnSol.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSol.FlatAppearance.BorderSize = 0;
            this.btnSol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.btnSol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSol.ForeColor = System.Drawing.Color.LightGray;
            this.btnSol.Location = new System.Drawing.Point(0, 284);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(200, 87);
            this.btnSol.TabIndex = 1;
            this.btnSol.Text = "SOLICITAÇÕES";
            this.btnSol.UseVisualStyleBackColor = false;
            this.btnSol.Click += new System.EventHandler(this.button1_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 197);
            this.panelLogo.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(36)))), ((int)(((byte)(61)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Lucida Sans Unicode", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.LightGray;
            this.button1.Image = global::Login.Properties.Resources.sairIcon;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(0, 709);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 36);
            this.button1.TabIndex = 6;
            this.button1.Text = "SAIR";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.logo;
            this.pictureBox1.Location = new System.Drawing.Point(-54, -100);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(329, 360);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnOp;
        private System.Windows.Forms.Button btnRelat;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Panel pSol;
        private System.Windows.Forms.Button btnIni;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

