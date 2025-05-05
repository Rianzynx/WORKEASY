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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pSol = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.lblNome = new System.Windows.Forms.Label();
            this.panelTop = new System.Windows.Forms.Panel();
            this.btnTema = new FontAwesome.Sharp.IconButton();
            this.btnConfigUser = new FontAwesome.Sharp.IconButton();
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuFunc = new System.Windows.Forms.Panel();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.btnGeralFunc = new System.Windows.Forms.Button();
            this.btnOp = new FontAwesome.Sharp.IconButton();
            this.btnRelat = new FontAwesome.Sharp.IconButton();
            this.btnFunc = new FontAwesome.Sharp.IconButton();
            this.btnSol = new FontAwesome.Sharp.IconButton();
            this.btnIni = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.panelTop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelMenuFunc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSol
            // 
            this.pSol.BackColor = System.Drawing.Color.Transparent;
            this.pSol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pSol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSol.Location = new System.Drawing.Point(95, 47);
            this.pSol.Name = "pSol";
            this.pSol.Size = new System.Drawing.Size(1271, 682);
            this.pSol.TabIndex = 1;
            this.pSol.Paint += new System.Windows.Forms.PaintEventHandler(this.pSol_Paint);
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.White;
            this.lblNome.Location = new System.Drawing.Point(1186, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 21);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "User";
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.panelTop.Controls.Add(this.btnTema);
            this.panelTop.Controls.Add(this.btnConfigUser);
            this.panelTop.Controls.Add(this.lblNome);
            this.panelTop.Controls.Add(this.pbUser);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(95, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1271, 47);
            this.panelTop.TabIndex = 5;
            // 
            // btnTema
            // 
            this.btnTema.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnTema.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.btnTema.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTema.FlatAppearance.BorderSize = 0;
            this.btnTema.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTema.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTema.ForeColor = System.Drawing.Color.White;
            this.btnTema.IconChar = FontAwesome.Sharp.IconChar.Moon;
            this.btnTema.IconColor = System.Drawing.Color.White;
            this.btnTema.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnTema.IconSize = 35;
            this.btnTema.Location = new System.Drawing.Point(1029, 3);
            this.btnTema.Name = "btnTema";
            this.btnTema.Size = new System.Drawing.Size(38, 41);
            this.btnTema.TabIndex = 10;
            this.btnTema.UseVisualStyleBackColor = false;
            // 
            // btnConfigUser
            // 
            this.btnConfigUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfigUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.btnConfigUser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfigUser.FlatAppearance.BorderSize = 0;
            this.btnConfigUser.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConfigUser.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfigUser.ForeColor = System.Drawing.Color.White;
            this.btnConfigUser.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnConfigUser.IconColor = System.Drawing.Color.White;
            this.btnConfigUser.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnConfigUser.IconSize = 35;
            this.btnConfigUser.Location = new System.Drawing.Point(1074, 3);
            this.btnConfigUser.Name = "btnConfigUser";
            this.btnConfigUser.Size = new System.Drawing.Size(38, 41);
            this.btnConfigUser.TabIndex = 8;
            this.btnConfigUser.UseVisualStyleBackColor = false;
            // 
            // pbUser
            // 
            this.pbUser.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(1135, 3);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(45, 39);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 1;
            this.pbUser.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.panelMenuFunc);
            this.panelMenu.Controls.Add(this.btnOp);
            this.panelMenu.Controls.Add(this.btnRelat);
            this.panelMenu.Controls.Add(this.btnFunc);
            this.panelMenu.Controls.Add(this.btnSol);
            this.panelMenu.Controls.Add(this.btnIni);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(95, 729);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Click += new System.EventHandler(this.panelMenu_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 100);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Login.Properties.Resources.logoTeste;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(95, 100);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelMenuFunc
            // 
            this.panelMenuFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(12)))), ((int)(((byte)(23)))), ((int)(((byte)(56)))));
            this.panelMenuFunc.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panelMenuFunc.Controls.Add(this.btnExcluir);
            this.panelMenuFunc.Controls.Add(this.btnEditar);
            this.panelMenuFunc.Controls.Add(this.btnCadastrar);
            this.panelMenuFunc.Controls.Add(this.btnGeralFunc);
            this.panelMenuFunc.Location = new System.Drawing.Point(20, 380);
            this.panelMenuFunc.Name = "panelMenuFunc";
            this.panelMenuFunc.Size = new System.Drawing.Size(68, 0);
            this.panelMenuFunc.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluir.FlatAppearance.BorderSize = 0;
            this.btnExcluir.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnExcluir.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.Location = new System.Drawing.Point(0, 135);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(66, 45);
            this.btnExcluir.TabIndex = 5;
            this.btnExcluir.Text = "EXCLUIR";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // btnEditar
            // 
            this.btnEditar.BackColor = System.Drawing.Color.Transparent;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.FlatAppearance.BorderSize = 0;
            this.btnEditar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnEditar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.Location = new System.Drawing.Point(0, 90);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(66, 45);
            this.btnEditar.TabIndex = 4;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.UseVisualStyleBackColor = false;
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BackColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrar.FlatAppearance.BorderSize = 0;
            this.btnCadastrar.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCadastrar.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnCadastrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 45);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(66, 45);
            this.btnCadastrar.TabIndex = 3;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.UseVisualStyleBackColor = false;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnGeralFunc
            // 
            this.btnGeralFunc.BackColor = System.Drawing.Color.Transparent;
            this.btnGeralFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeralFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeralFunc.FlatAppearance.BorderSize = 0;
            this.btnGeralFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.MidnightBlue;
            this.btnGeralFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.MidnightBlue;
            this.btnGeralFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGeralFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeralFunc.ForeColor = System.Drawing.Color.White;
            this.btnGeralFunc.Location = new System.Drawing.Point(0, 0);
            this.btnGeralFunc.Name = "btnGeralFunc";
            this.btnGeralFunc.Size = new System.Drawing.Size(66, 45);
            this.btnGeralFunc.TabIndex = 6;
            this.btnGeralFunc.Text = "VISÃO GERAL";
            this.btnGeralFunc.UseVisualStyleBackColor = false;
            this.btnGeralFunc.Click += new System.EventHandler(this.btnGeralFunc_Click);
            // 
            // btnOp
            // 
            this.btnOp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOp.FlatAppearance.BorderSize = 0;
            this.btnOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOp.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOp.ForeColor = System.Drawing.Color.White;
            this.btnOp.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnOp.IconColor = System.Drawing.Color.White;
            this.btnOp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOp.Location = new System.Drawing.Point(20, 443);
            this.btnOp.Name = "btnOp";
            this.btnOp.Size = new System.Drawing.Size(50, 50);
            this.btnOp.TabIndex = 7;
            this.btnOp.UseVisualStyleBackColor = false;
            // 
            // btnRelat
            // 
            this.btnRelat.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnRelat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelat.FlatAppearance.BorderSize = 0;
            this.btnRelat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelat.ForeColor = System.Drawing.Color.White;
            this.btnRelat.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btnRelat.IconColor = System.Drawing.Color.White;
            this.btnRelat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRelat.Location = new System.Drawing.Point(20, 384);
            this.btnRelat.Name = "btnRelat";
            this.btnRelat.Size = new System.Drawing.Size(50, 50);
            this.btnRelat.TabIndex = 6;
            this.btnRelat.UseVisualStyleBackColor = false;
            this.btnRelat.Click += new System.EventHandler(this.btnRelat_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.Color.White;
            this.btnFunc.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnFunc.IconColor = System.Drawing.Color.White;
            this.btnFunc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFunc.Location = new System.Drawing.Point(20, 324);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(50, 50);
            this.btnFunc.TabIndex = 5;
            this.btnFunc.UseVisualStyleBackColor = false;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // btnSol
            // 
            this.btnSol.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnSol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSol.FlatAppearance.BorderSize = 0;
            this.btnSol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSol.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSol.ForeColor = System.Drawing.Color.White;
            this.btnSol.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnSol.IconColor = System.Drawing.Color.White;
            this.btnSol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSol.Location = new System.Drawing.Point(20, 261);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(50, 50);
            this.btnSol.TabIndex = 0;
            this.btnSol.UseVisualStyleBackColor = false;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnIni
            // 
            this.btnIni.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(17)))), ((int)(((byte)(43)))));
            this.btnIni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIni.FlatAppearance.BorderSize = 0;
            this.btnIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIni.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIni.ForeColor = System.Drawing.Color.White;
            this.btnIni.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnIni.IconColor = System.Drawing.Color.White;
            this.btnIni.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIni.Location = new System.Drawing.Point(20, 201);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(50, 50);
            this.btnIni.TabIndex = 0;
            this.btnIni.UseVisualStyleBackColor = false;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 10;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 15;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 729);
            this.Controls.Add(this.pSol);
            this.Controls.Add(this.panelTop);
            this.Controls.Add(this.panelMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbUser)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelMenuFunc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel pSol;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.PictureBox pbUser;
        private System.Windows.Forms.Panel panelTop;
        public System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelMenuFunc;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnIni;
        private FontAwesome.Sharp.IconButton btnSol;
        private FontAwesome.Sharp.IconButton btnFunc;
        private FontAwesome.Sharp.IconButton btnRelat;
        private FontAwesome.Sharp.IconButton btnOp;
        private FontAwesome.Sharp.IconButton btnTema;
        private FontAwesome.Sharp.IconButton btnConfigUser;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Button btnGeralFunc;
    }
}

