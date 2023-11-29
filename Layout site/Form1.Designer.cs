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
            this.lblemial = new System.Windows.Forms.Label();
            this.lblNome = new System.Windows.Forms.Label();
            this.lblSenha = new System.Windows.Forms.Label();
            this.lblCPF = new System.Windows.Forms.Label();
            this.mtextsenha = new System.Windows.Forms.MaskedTextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.cliente = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.nome = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.senha = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cpf = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.texcpf = new System.Windows.Forms.MaskedTextBox();
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
            this.texnome.Location = new System.Drawing.Point(15, 98);
            this.texnome.Name = "texnome";
            this.texnome.Size = new System.Drawing.Size(117, 20);
            this.texnome.TabIndex = 3;
            this.texnome.TextChanged += new System.EventHandler(this.texnome_TextChanged);
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
            this.mtextsenha.Size = new System.Drawing.Size(117, 20);
            this.mtextsenha.TabIndex = 11;
            this.mtextsenha.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.mtextsenha_MaskInputRejected);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Layout_site.Properties.Resources.bd6784eeaf9a9ea5e1ce19b1f8c575d82;
            this.pictureBox1.Location = new System.Drawing.Point(322, 151);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(475, 368);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 12;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click_1);
            // 
            // cliente
            // 
            this.cliente.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.email,
            this.nome,
            this.senha,
            this.cpf});
            this.cliente.HideSelection = false;
            this.cliente.LabelEdit = true;
            this.cliente.Location = new System.Drawing.Point(12, 272);
            this.cliente.Name = "cliente";
            this.cliente.Size = new System.Drawing.Size(304, 109);
            this.cliente.TabIndex = 13;
            this.cliente.UseCompatibleStateImageBehavior = false;
            this.cliente.View = System.Windows.Forms.View.Details;
            this.cliente.SelectedIndexChanged += new System.EventHandler(this.cliente_SelectedIndexChanged);
            this.cliente.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cliente_MouseDoubleClick_1);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "id";
            // 
            // email
            // 
            this.email.Text = "email";
            // 
            // nome
            // 
            this.nome.Text = "nome";
            // 
            // senha
            // 
            this.senha.Text = "senha";
            // 
            // cpf
            // 
            this.cpf.Text = "cpf";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(19, 424);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(121, 32);
            this.button2.TabIndex = 14;
            this.button2.Text = "excluir";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_2);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(165, 424);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 15;
            this.button3.Text = "editar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // texcpf
            // 
            this.texcpf.Location = new System.Drawing.Point(14, 210);
            this.texcpf.Mask = "000,000,000-00";
            this.texcpf.Name = "texcpf";
            this.texcpf.Size = new System.Drawing.Size(117, 20);
            this.texcpf.TabIndex = 17;
            this.texcpf.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.textcpf_MaskInputRejected);
            this.texcpf.Leave += new System.EventHandler(this.texcpf_Leave);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Layout_site.Properties.Resources.Captura_de_tela_2023_11_08_1519301;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(792, 512);
            this.Controls.Add(this.texcpf);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.cliente);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.mtextsenha);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.lblSenha);
            this.Controls.Add(this.lblNome);
            this.Controls.Add(this.lblemial);
            this.Controls.Add(this.texnome);
            this.Controls.Add(this.texbemial);
            this.Controls.Add(this.button1);
            this.DoubleBuffered = true;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
           
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox texbemial;
        private System.Windows.Forms.TextBox texnome;
        private System.Windows.Forms.Label lblemial;
        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblSenha;
        private System.Windows.Forms.Label lblCPF;
        private System.Windows.Forms.MaskedTextBox mtextsenha;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader email;
        private System.Windows.Forms.ColumnHeader nome;
        private System.Windows.Forms.ColumnHeader senha;
        private System.Windows.Forms.ColumnHeader cpf;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ListView cliente;
        private System.Windows.Forms.MaskedTextBox texcpf;
    }
}

