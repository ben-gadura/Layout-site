namespace Layout_site
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
            this.button1 = new System.Windows.Forms.Button();
            this.texbemial = new System.Windows.Forms.TextBox();
            this.texnome = new System.Windows.Forms.TextBox();
            this.texcpf = new System.Windows.Forms.TextBox();
            this.lblemial = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mtextsenha = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 476);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 34);
            this.button1.TabIndex = 0;
            this.button1.Text = "Clique aqui";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // texbemial
            // 
            this.texbemial.Location = new System.Drawing.Point(15, 45);
            this.texbemial.Name = "texbemial";
            this.texbemial.Size = new System.Drawing.Size(117, 20);
            this.texbemial.TabIndex = 2;
            this.texbemial.TextChanged += new System.EventHandler(this.texbemial_TextChanged);
            // 
            // texnome
            // 
            this.texnome.Location = new System.Drawing.Point(16, 98);
            this.texnome.Name = "texnome";
            this.texnome.Size = new System.Drawing.Size(117, 20);
            this.texnome.TabIndex = 3;
            this.texnome.TextChanged += new System.EventHandler(this.texnome_TextChanged);
            // 
            // texcpf
            // 
            this.texcpf.Location = new System.Drawing.Point(15, 210);
            this.texcpf.Name = "texcpf";
            this.texcpf.Size = new System.Drawing.Size(117, 20);
            this.texcpf.TabIndex = 5;
            // 
            // lblemial
            // 
            this.lblemial.AutoSize = true;
            this.lblemial.Location = new System.Drawing.Point(16, 29);
            this.lblemial.Name = "lblemial";
            this.lblemial.Size = new System.Drawing.Size(35, 13);
            this.lblemial.TabIndex = 7;
            this.lblemial.Text = "E-mail";
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Location = new System.Drawing.Point(12, 82);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(35, 13);
            this.lblNome.TabIndex = 8;
            this.lblNome.Text = "Nome";
            // 
            // lblSenha
            // 
            this.lblSenha.AutoSize = true;
            this.lblSenha.Location = new System.Drawing.Point(16, 135);
            this.lblSenha.Name = "lblSenha";
            this.lblSenha.Size = new System.Drawing.Size(38, 13);
            this.lblSenha.TabIndex = 9;
            this.lblSenha.Text = "Senha";
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Location = new System.Drawing.Point(16, 194);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 10;
            this.lblCPF.Text = "CPF";
            // 
            // mtextsenha
            // 
            this.mtextsenha.Location = new System.Drawing.Point(15, 151);
            this.mtextsenha.Name = "mtextsenha";
            this.mtextsenha.PasswordChar = '*';
            this.mtextsenha.Size = new System.Drawing.Size(114, 20);
            this.mtextsenha.TabIndex = 11;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Layout_site.Properties.Resources.ddfc87fa1fcb7f8fdf1e240327cc643b;
            this.pictureBox1.Location = new System.Drawing.Point(327, 29);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(535, 481);
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Layout_site.Properties.Resources.Captura_de_tela_2023_09_06_124508;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(864, 551);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtextsenha);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblemial);
            this.Controls.Add(this.texcpf);
            this.Controls.Add(this.texnome);
            this.Controls.Add(this.texbemial);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox texbemial;
        private System.Windows.Forms.TextBox texnome;
        private System.Windows.Forms.TextBox texcpf;
        private System.Windows.Forms.Label lblemial;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mtextsenha;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

