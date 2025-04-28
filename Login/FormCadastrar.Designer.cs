namespace Login
{
    partial class FormCadastrar
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtSobrenome = new System.Windows.Forms.TextBox();
            this.txtEndereco = new System.Windows.Forms.TextBox();
            this.DNascimento = new System.Windows.Forms.DateTimePicker();
            this.pbFuncionario = new System.Windows.Forms.PictureBox();
            this.btnFoto = new System.Windows.Forms.Button();
            this.rBtnMasc = new System.Windows.Forms.RadioButton();
            this.rBtnFem = new System.Windows.Forms.RadioButton();
            this.txtTel = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnCadFunc = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView_funcionarios = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funcionarios)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(121, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(55, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Nome:";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label2.Location = new System.Drawing.Point(367, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 8;
            this.label2.Text = "Sobrenome:";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label3.Location = new System.Drawing.Point(25, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Data de Nascimento:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label4.Location = new System.Drawing.Point(474, 91);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Genero:";
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label5.Location = new System.Drawing.Point(97, 156);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 20);
            this.label5.TabIndex = 11;
            this.label5.Text = "Endereço:";
            // 
            // txtNome
            // 
            this.txtNome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtNome.Location = new System.Drawing.Point(182, 21);
            this.txtNome.Multiline = true;
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(172, 28);
            this.txtNome.TabIndex = 12;
            // 
            // txtSobrenome
            // 
            this.txtSobrenome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtSobrenome.Location = new System.Drawing.Point(465, 21);
            this.txtSobrenome.Multiline = true;
            this.txtSobrenome.Name = "txtSobrenome";
            this.txtSobrenome.Size = new System.Drawing.Size(172, 28);
            this.txtSobrenome.TabIndex = 13;
            // 
            // txtEndereco
            // 
            this.txtEndereco.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtEndereco.Location = new System.Drawing.Point(180, 160);
            this.txtEndereco.Multiline = true;
            this.txtEndereco.Name = "txtEndereco";
            this.txtEndereco.Size = new System.Drawing.Size(475, 53);
            this.txtEndereco.TabIndex = 14;
            // 
            // DNascimento
            // 
            this.DNascimento.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.DNascimento.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DNascimento.Location = new System.Drawing.Point(182, 90);
            this.DNascimento.Name = "DNascimento";
            this.DNascimento.Size = new System.Drawing.Size(257, 25);
            this.DNascimento.TabIndex = 15;
            // 
            // pbFuncionario
            // 
            this.pbFuncionario.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.pbFuncionario.BackColor = System.Drawing.Color.White;
            this.pbFuncionario.Location = new System.Drawing.Point(958, 14);
            this.pbFuncionario.Name = "pbFuncionario";
            this.pbFuncionario.Size = new System.Drawing.Size(133, 123);
            this.pbFuncionario.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbFuncionario.TabIndex = 16;
            this.pbFuncionario.TabStop = false;
            // 
            // btnFoto
            // 
            this.btnFoto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFoto.BackColor = System.Drawing.Color.LimeGreen;
            this.btnFoto.FlatAppearance.BorderSize = 0;
            this.btnFoto.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFoto.ForeColor = System.Drawing.Color.White;
            this.btnFoto.Location = new System.Drawing.Point(958, 144);
            this.btnFoto.Name = "btnFoto";
            this.btnFoto.Size = new System.Drawing.Size(133, 47);
            this.btnFoto.TabIndex = 17;
            this.btnFoto.Text = "CARREGAR";
            this.btnFoto.UseVisualStyleBackColor = false;
            this.btnFoto.Click += new System.EventHandler(this.btnFoto_Click);
            // 
            // rBtnMasc
            // 
            this.rBtnMasc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rBtnMasc.AutoSize = true;
            this.rBtnMasc.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnMasc.ForeColor = System.Drawing.Color.Black;
            this.rBtnMasc.Location = new System.Drawing.Point(548, 89);
            this.rBtnMasc.Name = "rBtnMasc";
            this.rBtnMasc.Size = new System.Drawing.Size(99, 25);
            this.rBtnMasc.TabIndex = 18;
            this.rBtnMasc.TabStop = true;
            this.rBtnMasc.Text = "Masculino";
            this.rBtnMasc.UseVisualStyleBackColor = true;
            // 
            // rBtnFem
            // 
            this.rBtnFem.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.rBtnFem.AutoSize = true;
            this.rBtnFem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rBtnFem.ForeColor = System.Drawing.Color.Black;
            this.rBtnFem.Location = new System.Drawing.Point(549, 114);
            this.rBtnFem.Name = "rBtnFem";
            this.rBtnFem.Size = new System.Drawing.Size(93, 25);
            this.rBtnFem.TabIndex = 19;
            this.rBtnFem.TabStop = true;
            this.rBtnFem.Text = "Feminino";
            this.rBtnFem.UseVisualStyleBackColor = true;
            // 
            // txtTel
            // 
            this.txtTel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTel.Location = new System.Drawing.Point(743, 23);
            this.txtTel.Multiline = true;
            this.txtTel.Name = "txtTel";
            this.txtTel.Size = new System.Drawing.Size(185, 28);
            this.txtTel.TabIndex = 21;
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label6.Location = new System.Drawing.Point(659, 21);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(71, 20);
            this.label6.TabIndex = 20;
            this.label6.Text = "Telefone:";
            // 
            // btnCadFunc
            // 
            this.btnCadFunc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCadFunc.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.btnCadFunc.FlatAppearance.BorderSize = 0;
            this.btnCadFunc.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadFunc.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadFunc.ForeColor = System.Drawing.Color.White;
            this.btnCadFunc.Location = new System.Drawing.Point(1015, 207);
            this.btnCadFunc.Name = "btnCadFunc";
            this.btnCadFunc.Size = new System.Drawing.Size(107, 47);
            this.btnCadFunc.TabIndex = 22;
            this.btnCadFunc.Text = "CADASTRAR";
            this.btnCadFunc.UseVisualStyleBackColor = false;
            this.btnCadFunc.Click += new System.EventHandler(this.btnCadFunc_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnLimpar.BackColor = System.Drawing.Color.Orange;
            this.btnLimpar.FlatAppearance.BorderSize = 0;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpar.ForeColor = System.Drawing.Color.White;
            this.btnLimpar.Location = new System.Drawing.Point(902, 207);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(107, 47);
            this.btnLimpar.TabIndex = 23;
            this.btnLimpar.Text = "LIMPAR";
            this.btnLimpar.UseVisualStyleBackColor = false;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.dataGridView_funcionarios);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1138, 516);
            this.panel1.TabIndex = 25;
            // 
            // dataGridView_funcionarios
            // 
            this.dataGridView_funcionarios.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_funcionarios.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView_funcionarios.Location = new System.Drawing.Point(0, 0);
            this.dataGridView_funcionarios.Name = "dataGridView_funcionarios";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView_funcionarios.RowHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView_funcionarios.Size = new System.Drawing.Size(1138, 516);
            this.dataGridView_funcionarios.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pbFuncionario);
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.btnCadFunc);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.txtTel);
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.rBtnFem);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.rBtnMasc);
            this.panel2.Controls.Add(this.txtNome);
            this.panel2.Controls.Add(this.btnFoto);
            this.panel2.Controls.Add(this.txtSobrenome);
            this.panel2.Controls.Add(this.txtEndereco);
            this.panel2.Controls.Add(this.DNascimento);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 212);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1138, 304);
            this.panel2.TabIndex = 26;
            // 
            // FormCadastrar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1138, 516);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCadastrar";
            this.Text = "FormCadastrar";
            this.Load += new System.EventHandler(this.FormCadastrar_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbFuncionario)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_funcionarios)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtSobrenome;
        private System.Windows.Forms.TextBox txtEndereco;
        private System.Windows.Forms.DateTimePicker DNascimento;
        private System.Windows.Forms.PictureBox pbFuncionario;
        private System.Windows.Forms.Button btnFoto;
        private System.Windows.Forms.RadioButton rBtnMasc;
        private System.Windows.Forms.RadioButton rBtnFem;
        private System.Windows.Forms.TextBox txtTel;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnCadFunc;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView_funcionarios;
    }
}