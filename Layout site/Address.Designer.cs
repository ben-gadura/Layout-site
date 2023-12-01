namespace Layout_site
{
    partial class Address
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
            this.rua = new System.Windows.Forms.Label();
            this.texrua = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.texnumero = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.texbairro = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.texcidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.texestado = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textelefone = new System.Windows.Forms.TextBox();
            this.Adress = new System.Windows.Forms.ListView();
            this.idadress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.street = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.numero = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.bairro = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.cidade = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.estado = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.telefone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rua
            // 
            this.rua.AutoSize = true;
            this.rua.Location = new System.Drawing.Point(34, 42);
            this.rua.Name = "rua";
            this.rua.Size = new System.Drawing.Size(22, 13);
            this.rua.TabIndex = 9;
            this.rua.Text = "rua";
            this.rua.Click += new System.EventHandler(this.rua_Click);
            // 
            // texrua
            // 
            this.texrua.Location = new System.Drawing.Point(33, 58);
            this.texrua.Name = "texrua";
            this.texrua.Size = new System.Drawing.Size(117, 20);
            this.texrua.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(34, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "numero";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // texnumero
            // 
            this.texnumero.Location = new System.Drawing.Point(33, 109);
            this.texnumero.Name = "texnumero";
            this.texnumero.Size = new System.Drawing.Size(117, 20);
            this.texnumero.TabIndex = 10;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 140);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "bairro";
            // 
            // texbairro
            // 
            this.texbairro.Location = new System.Drawing.Point(33, 156);
            this.texbairro.Name = "texbairro";
            this.texbairro.Size = new System.Drawing.Size(117, 20);
            this.texbairro.TabIndex = 12;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(34, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "cidade";
            // 
            // texcidade
            // 
            this.texcidade.Location = new System.Drawing.Point(33, 210);
            this.texcidade.Name = "texcidade";
            this.texcidade.Size = new System.Drawing.Size(117, 20);
            this.texcidade.TabIndex = 14;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 251);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(39, 13);
            this.label4.TabIndex = 17;
            this.label4.Text = "estado";
            // 
            // texestado
            // 
            this.texestado.Location = new System.Drawing.Point(37, 267);
            this.texestado.Name = "texestado";
            this.texestado.Size = new System.Drawing.Size(117, 20);
            this.texestado.TabIndex = 16;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(34, 299);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(45, 13);
            this.label5.TabIndex = 19;
            this.label5.Text = "telefone";
            // 
            // textelefone
            // 
            this.textelefone.Location = new System.Drawing.Point(37, 315);
            this.textelefone.Name = "textelefone";
            this.textelefone.Size = new System.Drawing.Size(117, 20);
            this.textelefone.TabIndex = 18;
            // 
            // Adress
            // 
            this.Adress.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.idadress,
            this.street,
            this.numero,
            this.bairro,
            this.cidade,
            this.estado,
            this.telefone});
            this.Adress.HideSelection = false;
            this.Adress.LabelEdit = true;
            this.Adress.Location = new System.Drawing.Point(338, 109);
            this.Adress.Name = "Adress";
            this.Adress.Size = new System.Drawing.Size(364, 109);
            this.Adress.TabIndex = 20;
            this.Adress.UseCompatibleStateImageBehavior = false;
            this.Adress.View = System.Windows.Forms.View.Details;
            this.Adress.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.cliente_MouseDoubleClick);
            // 
            // idadress
            // 
            this.idadress.Text = "id";
            this.idadress.Width = 0;
            // 
            // street
            // 
            this.street.Text = "rua";
            // 
            // numero
            // 
            this.numero.Text = "numero";
            // 
            // bairro
            // 
            this.bairro.Text = "bairro";
            // 
            // cidade
            // 
            this.cidade.Text = "cidade";
            // 
            // estado
            // 
            this.estado.Text = "estado";
            // 
            // telefone
            // 
            this.telefone.Text = "telefone";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(477, 242);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(84, 31);
            this.button3.TabIndex = 23;
            this.button3.Text = "editar";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 242);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(84, 32);
            this.button2.TabIndex = 22;
            this.button2.Text = "excluir";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(387, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(84, 34);
            this.button1.TabIndex = 21;
            this.button1.Text = "Clique aqui";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Address
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.Adress);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textelefone);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.texestado);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.texcidade);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.texbairro);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.texnumero);
            this.Controls.Add(this.rua);
            this.Controls.Add(this.texrua);
            this.Name = "Address";
            this.Text = "address";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rua;
        private System.Windows.Forms.TextBox texrua;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox texnumero;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox texbairro;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox texcidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox texestado;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textelefone;
        private System.Windows.Forms.ListView Adress;
        private System.Windows.Forms.ColumnHeader idadress;
        private System.Windows.Forms.ColumnHeader street;
        private System.Windows.Forms.ColumnHeader numero;
        private System.Windows.Forms.ColumnHeader bairro;
        private System.Windows.Forms.ColumnHeader cidade;
        private System.Windows.Forms.ColumnHeader estado;
        private System.Windows.Forms.ColumnHeader telefone;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
    }
}