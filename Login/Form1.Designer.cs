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
            this.pbUser = new System.Windows.Forms.PictureBox();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelMenuFunc = new Guna.UI2.WinForms.Guna2Panel();
            this.btnExcluir = new Guna.UI2.WinForms.Guna2Button();
            this.btnEditar = new Guna.UI2.WinForms.Guna2Button();
            this.btnCadastrar = new Guna.UI2.WinForms.Guna2Button();
            this.btnGeralFunc = new Guna.UI2.WinForms.Guna2Button();
            this.btnOp = new FontAwesome.Sharp.IconButton();
            this.btnRelat = new FontAwesome.Sharp.IconButton();
            this.btnFunc = new FontAwesome.Sharp.IconButton();
            this.btnSol = new FontAwesome.Sharp.IconButton();
            this.btnIni = new FontAwesome.Sharp.IconButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
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
            this.pSol.Dock = System.Windows.Forms.DockStyle.Right;
            this.pSol.Location = new System.Drawing.Point(95, 0);
            this.pSol.Name = "pSol";
            this.pSol.Size = new System.Drawing.Size(1271, 729);
            this.pSol.TabIndex = 1;
            this.pSol.Paint += new System.Windows.Forms.PaintEventHandler(this.pSol_Paint);
            // 
            // pbUser
            // 
            this.pbUser.BackColor = System.Drawing.Color.Transparent;
            this.pbUser.Dock = System.Windows.Forms.DockStyle.Top;
            this.pbUser.Image = ((System.Drawing.Image)(resources.GetObject("pbUser.Image")));
            this.pbUser.Location = new System.Drawing.Point(0, 0);
            this.pbUser.Name = "pbUser";
            this.pbUser.Size = new System.Drawing.Size(95, 41);
            this.pbUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbUser.TabIndex = 1;
            this.pbUser.TabStop = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(5)))), ((int)(((byte)(4)))), ((int)(((byte)(30)))));
            this.panelMenu.Controls.Add(this.panel1);
            this.panelMenu.Controls.Add(this.pictureBox1);
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
            this.panel1.Controls.Add(this.pbUser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 664);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(95, 65);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
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
            this.panelMenuFunc.Controls.Add(this.btnExcluir);
            this.panelMenuFunc.Controls.Add(this.btnEditar);
            this.panelMenuFunc.Controls.Add(this.btnCadastrar);
            this.panelMenuFunc.Controls.Add(this.btnGeralFunc);
            this.panelMenuFunc.Location = new System.Drawing.Point(21, 380);
            this.panelMenuFunc.Name = "panelMenuFunc";
            this.panelMenuFunc.Size = new System.Drawing.Size(70, 0);
            this.panelMenuFunc.TabIndex = 0;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BorderColor = System.Drawing.Color.White;
            this.btnExcluir.BorderThickness = 1;
            this.btnExcluir.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExcluir.CustomBorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnExcluir.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluir.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnExcluir.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnExcluir.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnExcluir.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnExcluir.FillColor = System.Drawing.Color.Transparent;
            this.btnExcluir.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.Color.White;
            this.btnExcluir.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnExcluir.Location = new System.Drawing.Point(0, 135);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(70, 45);
            this.btnExcluir.TabIndex = 3;
            this.btnExcluir.Text = "EXCLUIR";
            // 
            // btnEditar
            // 
            this.btnEditar.BorderColor = System.Drawing.Color.White;
            this.btnEditar.BorderThickness = 1;
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.CustomBorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnEditar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEditar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEditar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEditar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnEditar.FillColor = System.Drawing.Color.Transparent;
            this.btnEditar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.Color.White;
            this.btnEditar.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnEditar.Location = new System.Drawing.Point(0, 90);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(70, 45);
            this.btnEditar.TabIndex = 2;
            this.btnEditar.Text = "EDITAR";
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.BorderColor = System.Drawing.Color.White;
            this.btnCadastrar.BorderThickness = 1;
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.CustomBorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnCadastrar.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCadastrar.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCadastrar.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCadastrar.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnCadastrar.FillColor = System.Drawing.Color.Transparent;
            this.btnCadastrar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.ForeColor = System.Drawing.Color.White;
            this.btnCadastrar.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnCadastrar.Location = new System.Drawing.Point(0, 45);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(70, 45);
            this.btnCadastrar.TabIndex = 1;
            this.btnCadastrar.Text = "CADASTRAR";
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // btnGeralFunc
            // 
            this.btnGeralFunc.BorderColor = System.Drawing.Color.White;
            this.btnGeralFunc.BorderThickness = 1;
            this.btnGeralFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnGeralFunc.CustomBorderColor = System.Drawing.Color.LightSeaGreen;
            this.btnGeralFunc.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnGeralFunc.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnGeralFunc.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnGeralFunc.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnGeralFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnGeralFunc.FillColor = System.Drawing.Color.Transparent;
            this.btnGeralFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGeralFunc.ForeColor = System.Drawing.Color.White;
            this.btnGeralFunc.HoverState.BorderColor = System.Drawing.Color.Cyan;
            this.btnGeralFunc.Location = new System.Drawing.Point(0, 0);
            this.btnGeralFunc.Name = "btnGeralFunc";
            this.btnGeralFunc.Size = new System.Drawing.Size(70, 45);
            this.btnGeralFunc.TabIndex = 0;
            this.btnGeralFunc.Text = "VISÂO GERAL";
            this.btnGeralFunc.Click += new System.EventHandler(this.btnGeralFunc_Click);
            // 
            // btnOp
            // 
            this.btnOp.BackColor = System.Drawing.Color.Transparent;
            this.btnOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOp.FlatAppearance.BorderSize = 0;
            this.btnOp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(41)))), ((int)(((byte)(78)))));
            this.btnOp.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOp.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOp.ForeColor = System.Drawing.Color.White;
            this.btnOp.IconChar = FontAwesome.Sharp.IconChar.Cog;
            this.btnOp.IconColor = System.Drawing.Color.White;
            this.btnOp.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnOp.IconSize = 35;
            this.btnOp.Location = new System.Drawing.Point(21, 446);
            this.btnOp.Margin = new System.Windows.Forms.Padding(0);
            this.btnOp.Name = "btnOp";
            this.btnOp.Size = new System.Drawing.Size(50, 50);
            this.btnOp.TabIndex = 7;
            this.btnOp.UseVisualStyleBackColor = false;
            // 
            // btnRelat
            // 
            this.btnRelat.BackColor = System.Drawing.Color.Transparent;
            this.btnRelat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelat.FlatAppearance.BorderSize = 0;
            this.btnRelat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRelat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(41)))), ((int)(((byte)(78)))));
            this.btnRelat.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelat.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelat.ForeColor = System.Drawing.Color.White;
            this.btnRelat.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            this.btnRelat.IconColor = System.Drawing.Color.White;
            this.btnRelat.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRelat.IconSize = 35;
            this.btnRelat.Location = new System.Drawing.Point(21, 387);
            this.btnRelat.Margin = new System.Windows.Forms.Padding(0);
            this.btnRelat.Name = "btnRelat";
            this.btnRelat.Size = new System.Drawing.Size(50, 50);
            this.btnRelat.TabIndex = 6;
            this.btnRelat.UseVisualStyleBackColor = false;
            this.btnRelat.Click += new System.EventHandler(this.btnRelat_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.Color.Transparent;
            this.btnFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(41)))), ((int)(((byte)(78)))));
            this.btnFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.Color.White;
            this.btnFunc.IconChar = FontAwesome.Sharp.IconChar.UserGroup;
            this.btnFunc.IconColor = System.Drawing.Color.White;
            this.btnFunc.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnFunc.IconSize = 35;
            this.btnFunc.Location = new System.Drawing.Point(21, 327);
            this.btnFunc.Margin = new System.Windows.Forms.Padding(0);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(50, 50);
            this.btnFunc.TabIndex = 5;
            this.btnFunc.UseVisualStyleBackColor = false;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // btnSol
            // 
            this.btnSol.BackColor = System.Drawing.Color.Transparent;
            this.btnSol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSol.FlatAppearance.BorderSize = 0;
            this.btnSol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(41)))), ((int)(((byte)(78)))));
            this.btnSol.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSol.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSol.ForeColor = System.Drawing.Color.White;
            this.btnSol.IconChar = FontAwesome.Sharp.IconChar.Clipboard;
            this.btnSol.IconColor = System.Drawing.Color.White;
            this.btnSol.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSol.IconSize = 35;
            this.btnSol.Location = new System.Drawing.Point(21, 264);
            this.btnSol.Margin = new System.Windows.Forms.Padding(0);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(50, 50);
            this.btnSol.TabIndex = 0;
            this.btnSol.UseVisualStyleBackColor = false;
            this.btnSol.Click += new System.EventHandler(this.btnSol_Click);
            // 
            // btnIni
            // 
            this.btnIni.BackColor = System.Drawing.Color.Transparent;
            this.btnIni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIni.FlatAppearance.BorderSize = 0;
            this.btnIni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(20)))), ((int)(((byte)(41)))), ((int)(((byte)(78)))));
            this.btnIni.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnIni.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIni.ForeColor = System.Drawing.Color.White;
            this.btnIni.IconChar = FontAwesome.Sharp.IconChar.House;
            this.btnIni.IconColor = System.Drawing.Color.White;
            this.btnIni.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnIni.IconSize = 35;
            this.btnIni.Location = new System.Drawing.Point(21, 204);
            this.btnIni.Margin = new System.Windows.Forms.Padding(0);
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
            this.AllowDrop = true;
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 729);
            this.Controls.Add(this.pSol);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
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
        private System.Windows.Forms.PictureBox pbUser;
        public System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Timer timer1;
        private FontAwesome.Sharp.IconButton btnIni;
        private FontAwesome.Sharp.IconButton btnSol;
        private FontAwesome.Sharp.IconButton btnFunc;
        private FontAwesome.Sharp.IconButton btnRelat;
        private FontAwesome.Sharp.IconButton btnOp;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer2;
        private Guna.UI2.WinForms.Guna2Panel panelMenuFunc;
        private Guna.UI2.WinForms.Guna2Button btnExcluir;
        private Guna.UI2.WinForms.Guna2Button btnEditar;
        private Guna.UI2.WinForms.Guna2Button btnCadastrar;
        private Guna.UI2.WinForms.Guna2Button btnGeralFunc;
        private System.Windows.Forms.Panel panel1;
    }
}

