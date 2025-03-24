namespace Login
{
    partial class FormFuncionario
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCadastro = new System.Windows.Forms.Button();
            this.btnHoras = new System.Windows.Forms.Button();
            this.btnAtraso = new System.Windows.Forms.Button();
            this.btnSalario = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label8 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label7 = new System.Windows.Forms.Label();
            this.dgvColab = new System.Windows.Forms.DataGridView();
            this.lblColab = new System.Windows.Forms.Label();
            this.txtPesquisarColab = new System.Windows.Forms.TextBox();
            this.panelDados = new System.Windows.Forms.Panel();
            this.btnPesquisarColab = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColab)).BeginInit();
            this.panelDados.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "CONTROLE DE FUNCIONARIOS";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(43)))));
            this.panel2.Controls.Add(this.btnCadastro);
            this.panel2.Controls.Add(this.btnHoras);
            this.panel2.Controls.Add(this.btnAtraso);
            this.panel2.Controls.Add(this.btnSalario);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 45);
            this.panel2.TabIndex = 4;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // btnCadastro
            // 
            this.btnCadastro.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadastro.BackColor = System.Drawing.Color.DimGray;
            this.btnCadastro.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastro.FlatAppearance.BorderSize = 0;
            this.btnCadastro.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnCadastro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastro.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastro.ForeColor = System.Drawing.Color.White;
            this.btnCadastro.Image = global::Login.Properties.Resources.cadastroIcon1;
            this.btnCadastro.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCadastro.Location = new System.Drawing.Point(984, 5);
            this.btnCadastro.Name = "btnCadastro";
            this.btnCadastro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnCadastro.Size = new System.Drawing.Size(132, 33);
            this.btnCadastro.TabIndex = 5;
            this.btnCadastro.Text = "CADASTRAR";
            this.btnCadastro.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCadastro.UseVisualStyleBackColor = false;
            // 
            // btnHoras
            // 
            this.btnHoras.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHoras.BackColor = System.Drawing.Color.DimGray;
            this.btnHoras.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHoras.FlatAppearance.BorderSize = 0;
            this.btnHoras.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnHoras.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHoras.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHoras.ForeColor = System.Drawing.Color.White;
            this.btnHoras.Image = global::Login.Properties.Resources.relogioIcon1;
            this.btnHoras.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnHoras.Location = new System.Drawing.Point(834, 5);
            this.btnHoras.Name = "btnHoras";
            this.btnHoras.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnHoras.Size = new System.Drawing.Size(132, 33);
            this.btnHoras.TabIndex = 4;
            this.btnHoras.Text = "HRS EXTRAS";
            this.btnHoras.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnHoras.UseVisualStyleBackColor = false;
            // 
            // btnAtraso
            // 
            this.btnAtraso.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAtraso.BackColor = System.Drawing.Color.DimGray;
            this.btnAtraso.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAtraso.FlatAppearance.BorderSize = 0;
            this.btnAtraso.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnAtraso.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtraso.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAtraso.ForeColor = System.Drawing.Color.White;
            this.btnAtraso.Image = global::Login.Properties.Resources.alertaIcon1;
            this.btnAtraso.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAtraso.Location = new System.Drawing.Point(684, 5);
            this.btnAtraso.Name = "btnAtraso";
            this.btnAtraso.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnAtraso.Size = new System.Drawing.Size(132, 33);
            this.btnAtraso.TabIndex = 3;
            this.btnAtraso.Text = "FALTAS/ATRASOS";
            this.btnAtraso.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAtraso.UseVisualStyleBackColor = false;
            this.btnAtraso.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnSalario
            // 
            this.btnSalario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalario.BackColor = System.Drawing.Color.DimGray;
            this.btnSalario.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSalario.FlatAppearance.BorderSize = 0;
            this.btnSalario.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Gray;
            this.btnSalario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalario.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalario.ForeColor = System.Drawing.Color.White;
            this.btnSalario.Image = global::Login.Properties.Resources.moedaicon;
            this.btnSalario.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSalario.Location = new System.Drawing.Point(534, 5);
            this.btnSalario.Name = "btnSalario";
            this.btnSalario.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btnSalario.Size = new System.Drawing.Size(132, 33);
            this.btnSalario.TabIndex = 2;
            this.btnSalario.Text = "SALARIOS";
            this.btnSalario.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSalario.UseVisualStyleBackColor = false;
            this.btnSalario.Click += new System.EventHandler(this.btnSalario_Click);
            // 
            // panel1
            // 
            this.panel1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Location = new System.Drawing.Point(111, 76);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(263, 108);
            this.panel1.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(8, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 15);
            this.label2.TabIndex = 6;
            this.label2.Text = "FUNCIONARIOS ATIVOS";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Login.Properties.Resources.funcionariosIcon;
            this.pictureBox1.Location = new System.Drawing.Point(128, 8);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(132, 84);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(20, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 65);
            this.label3.TabIndex = 6;
            this.label3.Text = "56";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(7, 11);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "FUNCIONARIOS NO";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(5, 24);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(122, 50);
            this.label5.TabIndex = 6;
            this.label5.Text = "+12%";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label4);
            this.panel3.Controls.Add(this.pictureBox2);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(419, 76);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(264, 108);
            this.panel3.TabIndex = 7;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(20, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(81, 15);
            this.label8.TabIndex = 7;
            this.label8.Text = "ULTIMO ANO ";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox2.Image = global::Login.Properties.Resources.investimentoIcon;
            this.pictureBox2.Location = new System.Drawing.Point(128, 8);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(132, 84);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 6;
            this.pictureBox2.TabStop = false;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.pictureBox3);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Location = new System.Drawing.Point(730, 76);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(264, 108);
            this.panel4.TabIndex = 8;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(26, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(73, 15);
            this.label6.TabIndex = 6;
            this.label6.Text = "SATISFAÇÃO";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox3.Image = global::Login.Properties.Resources.felicidadeIcon;
            this.pictureBox3.Location = new System.Drawing.Point(128, 8);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(132, 84);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(6, 22);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(126, 65);
            this.label7.TabIndex = 6;
            this.label7.Text = "95%";
            // 
            // dgvColab
            // 
            this.dgvColab.BackgroundColor = System.Drawing.SystemColors.ControlLight;
            this.dgvColab.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvColab.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvColab.ColumnHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvColab.DefaultCellStyle = dataGridViewCellStyle1;
            this.dgvColab.GridColor = System.Drawing.Color.Gray;
            this.dgvColab.Location = new System.Drawing.Point(0, 224);
            this.dgvColab.Name = "dgvColab";
            this.dgvColab.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.dgvColab.Size = new System.Drawing.Size(1138, 337);
            this.dgvColab.TabIndex = 9;
            // 
            // lblColab
            // 
            this.lblColab.AutoSize = true;
            this.lblColab.BackColor = System.Drawing.Color.Transparent;
            this.lblColab.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColab.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(43)))));
            this.lblColab.Location = new System.Drawing.Point(7, 155);
            this.lblColab.Name = "lblColab";
            this.lblColab.Size = new System.Drawing.Size(146, 21);
            this.lblColab.TabIndex = 10;
            this.lblColab.Text = "COLABORADORES";
            this.lblColab.Click += new System.EventHandler(this.lblColab_Click);
            // 
            // txtPesquisarColab
            // 
            this.txtPesquisarColab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPesquisarColab.BackColor = System.Drawing.Color.White;
            this.txtPesquisarColab.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtPesquisarColab.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPesquisarColab.Location = new System.Drawing.Point(901, 192);
            this.txtPesquisarColab.Multiline = true;
            this.txtPesquisarColab.Name = "txtPesquisarColab";
            this.txtPesquisarColab.Size = new System.Drawing.Size(187, 27);
            this.txtPesquisarColab.TabIndex = 11;
            // 
            // panelDados
            // 
            this.panelDados.Controls.Add(this.lblColab);
            this.panelDados.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelDados.Location = new System.Drawing.Point(0, 45);
            this.panelDados.Name = "panelDados";
            this.panelDados.Size = new System.Drawing.Size(1138, 179);
            this.panelDados.TabIndex = 13;
            // 
            // btnPesquisarColab
            // 
            this.btnPesquisarColab.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPesquisarColab.BackColor = System.Drawing.Color.Transparent;
            this.btnPesquisarColab.BackgroundImage = global::Login.Properties.Resources.iconLupa;
            this.btnPesquisarColab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPesquisarColab.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPesquisarColab.FlatAppearance.BorderSize = 0;
            this.btnPesquisarColab.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(43)))));
            this.btnPesquisarColab.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(13)))), ((int)(((byte)(25)))), ((int)(((byte)(43)))));
            this.btnPesquisarColab.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisarColab.Location = new System.Drawing.Point(1071, 188);
            this.btnPesquisarColab.Name = "btnPesquisarColab";
            this.btnPesquisarColab.Size = new System.Drawing.Size(81, 33);
            this.btnPesquisarColab.TabIndex = 12;
            this.btnPesquisarColab.UseVisualStyleBackColor = false;
            // 
            // FormFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(1138, 561);
            this.Controls.Add(this.txtPesquisarColab);
            this.Controls.Add(this.btnPesquisarColab);
            this.Controls.Add(this.dgvColab);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelDados);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormFuncionario";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormFuncionario";
            this.panel2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvColab)).EndInit();
            this.panelDados.ResumeLayout(false);
            this.panelDados.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnSalario;
        private System.Windows.Forms.Button btnCadastro;
        private System.Windows.Forms.Button btnHoras;
        private System.Windows.Forms.Button btnAtraso;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.DataGridView dgvColab;
        private System.Windows.Forms.Label lblColab;
        private System.Windows.Forms.TextBox txtPesquisarColab;
        private System.Windows.Forms.Button btnPesquisarColab;
        private System.Windows.Forms.Panel panelDados;
    }
}