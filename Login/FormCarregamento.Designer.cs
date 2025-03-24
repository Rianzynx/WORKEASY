namespace Login
{
    partial class FormCarregamento
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
            this.components = new System.ComponentModel.Container();
            this.Pbar = new CircularProgressBar.CircularProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Pbar
            // 
            this.Pbar.AnimationFunction = WinFormAnimation.KnownAnimationFunctions.Liner;
            this.Pbar.AnimationSpeed = 500;
            this.Pbar.BackColor = System.Drawing.Color.Transparent;
            this.Pbar.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Bold);
            this.Pbar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Pbar.InnerColor = System.Drawing.Color.Transparent;
            this.Pbar.InnerMargin = 2;
            this.Pbar.InnerWidth = -1;
            this.Pbar.Location = new System.Drawing.Point(201, 308);
            this.Pbar.MarqueeAnimationSpeed = 2000;
            this.Pbar.Name = "Pbar";
            this.Pbar.OuterColor = System.Drawing.Color.Gray;
            this.Pbar.OuterMargin = -25;
            this.Pbar.OuterWidth = 26;
            this.Pbar.ProgressColor = System.Drawing.Color.White;
            this.Pbar.ProgressWidth = 2;
            this.Pbar.SecondaryFont = new System.Drawing.Font("Microsoft Sans Serif", 36F);
            this.Pbar.Size = new System.Drawing.Size(81, 81);
            this.Pbar.StartAngle = 270;
            this.Pbar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.Pbar.SubscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Pbar.SubscriptMargin = new System.Windows.Forms.Padding(10, -35, 0, 0);
            this.Pbar.SubscriptText = "";
            this.Pbar.SuperscriptColor = System.Drawing.Color.FromArgb(((int)(((byte)(166)))), ((int)(((byte)(166)))), ((int)(((byte)(166)))));
            this.Pbar.SuperscriptMargin = new System.Windows.Forms.Padding(10, 35, 0, 0);
            this.Pbar.SuperscriptText = "";
            this.Pbar.TabIndex = 0;
            this.Pbar.TextMargin = new System.Windows.Forms.Padding(8, 8, 0, 0);
            this.Pbar.Value = 68;
            this.Pbar.Click += new System.EventHandler(this.circularProgressBar1_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 150;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // FormCarregamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Login.Properties.Resources.WORKEASY1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(500, 510);
            this.Controls.Add(this.Pbar);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FormCarregamento";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            this.Load += new System.EventHandler(this.FormCarregamento_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CircularProgressBar.CircularProgressBar Pbar;
        private System.Windows.Forms.Timer timer1;
    }
}