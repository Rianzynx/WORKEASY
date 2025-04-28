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
            this.pSol = new System.Windows.Forms.Panel();
            this.panelMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.btnOp = new System.Windows.Forms.Button();
            this.btnRelat = new System.Windows.Forms.Button();
            this.btnFunc = new System.Windows.Forms.Button();
            this.btnSol = new System.Windows.Forms.Button();
            this.btnIni = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.lblNome = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.btnConfig = new System.Windows.Forms.Button();
            this.btnNoti = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panelTop = new System.Windows.Forms.Panel();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelTop.SuspendLayout();
            this.SuspendLayout();
            // 
            // pSol
            // 
            this.pSol.BackColor = System.Drawing.Color.Transparent;
            this.pSol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pSol.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pSol.Location = new System.Drawing.Point(68, 47);
            this.pSol.Name = "pSol";
            this.pSol.Size = new System.Drawing.Size(1298, 698);
            this.pSol.TabIndex = 1;
            this.pSol.Paint += new System.Windows.Forms.PaintEventHandler(this.pSol_Paint);
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.White;
            this.panelMenu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panelMenu.Controls.Add(this.btnOp);
            this.panelMenu.Controls.Add(this.btnRelat);
            this.panelMenu.Controls.Add(this.btnFunc);
            this.panelMenu.Controls.Add(this.btnSol);
            this.panelMenu.Controls.Add(this.btnIni);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 47);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(68, 698);
            this.panelMenu.TabIndex = 0;
            this.panelMenu.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(68, 197);
            this.panelLogo.TabIndex = 0;
            // 
            // btnOp
            // 
            this.btnOp.BackColor = System.Drawing.Color.White;
            this.btnOp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnOp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOp.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnOp.FlatAppearance.BorderSize = 0;
            this.btnOp.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnOp.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnOp.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOp.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnOp.Image = global::Login.Properties.Resources.iconConfiguracao;
            this.btnOp.Location = new System.Drawing.Point(0, 423);
            this.btnOp.Name = "btnOp";
            this.btnOp.Size = new System.Drawing.Size(68, 58);
            this.btnOp.TabIndex = 4;
            this.btnOp.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnOp.UseVisualStyleBackColor = false;
            // 
            // btnRelat
            // 
            this.btnRelat.BackColor = System.Drawing.Color.White;
            this.btnRelat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnRelat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRelat.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnRelat.FlatAppearance.BorderSize = 0;
            this.btnRelat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnRelat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnRelat.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRelat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnRelat.Image = global::Login.Properties.Resources.iconRelatorio;
            this.btnRelat.Location = new System.Drawing.Point(0, 365);
            this.btnRelat.Name = "btnRelat";
            this.btnRelat.Size = new System.Drawing.Size(68, 58);
            this.btnRelat.TabIndex = 3;
            this.btnRelat.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnRelat.UseVisualStyleBackColor = false;
            this.btnRelat.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnFunc
            // 
            this.btnFunc.BackColor = System.Drawing.Color.White;
            this.btnFunc.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnFunc.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFunc.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnFunc.FlatAppearance.BorderSize = 0;
            this.btnFunc.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnFunc.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnFunc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFunc.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnFunc.Image = global::Login.Properties.Resources.iconFuncionarios;
            this.btnFunc.Location = new System.Drawing.Point(0, 307);
            this.btnFunc.Name = "btnFunc";
            this.btnFunc.Size = new System.Drawing.Size(68, 58);
            this.btnFunc.TabIndex = 2;
            this.btnFunc.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnFunc.UseVisualStyleBackColor = false;
            this.btnFunc.Click += new System.EventHandler(this.btnFunc_Click);
            // 
            // btnSol
            // 
            this.btnSol.BackColor = System.Drawing.Color.White;
            this.btnSol.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnSol.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSol.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnSol.FlatAppearance.BorderSize = 0;
            this.btnSol.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnSol.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnSol.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSol.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnSol.Image = global::Login.Properties.Resources.iconSolicitacao;
            this.btnSol.Location = new System.Drawing.Point(0, 249);
            this.btnSol.Name = "btnSol";
            this.btnSol.Size = new System.Drawing.Size(68, 58);
            this.btnSol.TabIndex = 1;
            this.btnSol.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSol.UseVisualStyleBackColor = false;
            this.btnSol.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnIni
            // 
            this.btnIni.BackColor = System.Drawing.Color.White;
            this.btnIni.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnIni.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnIni.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnIni.FlatAppearance.BorderSize = 0;
            this.btnIni.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnIni.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
            this.btnIni.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIni.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnIni.Image = global::Login.Properties.Resources.iconHome2;
            this.btnIni.Location = new System.Drawing.Point(0, 197);
            this.btnIni.Name = "btnIni";
            this.btnIni.Size = new System.Drawing.Size(68, 52);
            this.btnIni.TabIndex = 5;
            this.btnIni.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.toolTip1.SetToolTip(this.btnIni, "INICIO");
            this.btnIni.UseVisualStyleBackColor = false;
            this.btnIni.Click += new System.EventHandler(this.btnIni_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.robogif;
            this.pictureBox1.Location = new System.Drawing.Point(3, -21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(65, 118);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // lblNome
            // 
            this.lblNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.lblNome.Location = new System.Drawing.Point(1281, 10);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(43, 21);
            this.lblNome.TabIndex = 9;
            this.lblNome.Text = "User";
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button1.Image = global::Login.Properties.Resources.iconLua;
            this.button1.Location = new System.Drawing.Point(1076, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(40, 40);
            this.button1.TabIndex = 8;
            this.button1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.button1.UseVisualStyleBackColor = false;
            // 
            // btnConfig
            // 
            this.btnConfig.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnConfig.BackColor = System.Drawing.Color.White;
            this.btnConfig.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnConfig.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfig.FlatAppearance.BorderSize = 0;
            this.btnConfig.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConfig.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfig.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnConfig.Image = global::Login.Properties.Resources.iconConfiguracao1;
            this.btnConfig.Location = new System.Drawing.Point(1169, 1);
            this.btnConfig.Name = "btnConfig";
            this.btnConfig.Size = new System.Drawing.Size(40, 40);
            this.btnConfig.TabIndex = 7;
            this.btnConfig.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnConfig.UseVisualStyleBackColor = false;
            // 
            // btnNoti
            // 
            this.btnNoti.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNoti.BackColor = System.Drawing.Color.White;
            this.btnNoti.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnNoti.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNoti.FlatAppearance.BorderSize = 0;
            this.btnNoti.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnNoti.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnNoti.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNoti.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.btnNoti.Image = global::Login.Properties.Resources.iconNotificacao;
            this.btnNoti.Location = new System.Drawing.Point(1123, 2);
            this.btnNoti.Name = "btnNoti";
            this.btnNoti.Size = new System.Drawing.Size(40, 40);
            this.btnNoti.TabIndex = 6;
            this.btnNoti.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNoti.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Login.Properties.Resources.trabHomemIcon;
            this.pictureBox2.Location = new System.Drawing.Point(1230, 3);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 39);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // panelTop
            // 
            this.panelTop.BackColor = System.Drawing.Color.White;
            this.panelTop.Controls.Add(this.lblNome);
            this.panelTop.Controls.Add(this.button1);
            this.panelTop.Controls.Add(this.btnConfig);
            this.panelTop.Controls.Add(this.btnNoti);
            this.panelTop.Controls.Add(this.pictureBox2);
            this.panelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTop.Location = new System.Drawing.Point(0, 0);
            this.panelTop.Name = "panelTop";
            this.panelTop.Size = new System.Drawing.Size(1366, 47);
            this.panelTop.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1366, 745);
            this.Controls.Add(this.pSol);
            this.Controls.Add(this.panelMenu);
            this.Controls.Add(this.panelTop);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelTop.ResumeLayout(false);
            this.panelTop.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnSol;
        private System.Windows.Forms.Button btnOp;
        private System.Windows.Forms.Button btnRelat;
        private System.Windows.Forms.Button btnFunc;
        private System.Windows.Forms.Panel pSol;
        private System.Windows.Forms.Button btnIni;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.ToolTip toolTip1;
        public System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnConfig;
        private System.Windows.Forms.Button btnNoti;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Panel panelTop;
    }
}

