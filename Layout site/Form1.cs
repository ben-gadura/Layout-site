﻿using iTextSharp.text.pdf;
using iTextSharp.text;
using layoutsite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Deployment.Internal;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;

namespace Layout_site
{

    public partial class Form1 : Form
    {
        private int id;
        public Form1()
        {

            InitializeComponent();


        }
        private void UpdateListView()
        {
            cliente.Items.Clear();
            UserDAO userDAO = new UserDAO();
            List<User> users = userDAO.SelectUser();



            try
            {
                if (users.Count > 0)
                {
                    foreach (User user in users)
                    {
                        ListViewItem lv = new ListViewItem(user.id.ToString());
                        lv.SubItems.Add(user.email);
                        lv.SubItems.Add(user.nome);
                        lv.SubItems.Add(user.senha);
                        lv.SubItems.Add(user.CPF);
                        cliente.Items.Add(lv);
                    }

                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {

            try
            {


                User user = new User(id, texbemial.Text,
                    texnome.Text,
                    Util.CalculateMD5Hash(mtextsenha.Text),
                    texcpf.Text.Replace(".", "").Replace("-", ""));



                UserDAO userDAO = new UserDAO();
                userDAO.InsertUser(user);

                MessageBox.Show("Cadastrado com sucesso",
                   "AVISO",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }





            texbemial.Clear();
            texnome.Clear();
            texcpf.Clear();
            mtextsenha.Clear();
            UpdateListView();


        }




        private void cliente_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            int index;
            index = cliente.FocusedItem.Index;
            id = int.Parse(cliente.Items[index].SubItems[0].Text);
            texbemial.Text = cliente.Items[index].SubItems[1].Text;
            texnome.Text = cliente.Items[index].SubItems[2].Text;
            mtextsenha.Text = cliente.Items[index].SubItems[3].Text;
            texcpf.Text = cliente.Items[index].SubItems[4].Text;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }


        private void button3_Click(object sender, EventArgs e)
        {

            User user = new User(id, texbemial.Text,
        texnome.Text,
        Util.CalculateMD5Hash(mtextsenha.Text),
        texcpf.Text.Replace(".", "").Replace("-", ""));
            UserDAO nomedoobj = new UserDAO();
            nomedoobj.UpdateUser(user);

            MessageBox.Show("Atualizado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            texbemial.Clear();
            texnome.Clear();
            texcpf.Clear();
            mtextsenha.Clear();

            UpdateListView();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            userDAO.DeleteUser(id);

            texbemial.Clear();
            texnome.Clear();
            texcpf.Clear();
            mtextsenha.Clear();

            UpdateListView();
        }

        private void texcpf_Leave(object sender, EventArgs e)
        {

            if (CPF.ValidateCpf(texcpf.Text.Replace(".", "").Replace("-", "")))
            {

            }
            else
            {
                MessageBox.Show("Campo cpf não valido",
               "AVISO",
               MessageBoxButtons.OK,
               MessageBoxIcon.Information);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(texnome.Text))
                {
                    MessageBox.Show(
                        "Insira o Nome para gerar o relatório",
                        "ATENÇÂO",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);
                    texnome.Clear();
                }
                //define os campos do relatório
                string nome, email, cpf;

                //realiza a conexão e resgata os dados do banco de dados
                Connection connection = new Connection();
                SqlCommand sqlCommand = new SqlCommand();
                sqlCommand.Connection = connection.ReturnConnection();
                sqlCommand.CommandText = "SELECT * FROM cliente WHERE nomecliente = @nome";
                sqlCommand.Parameters.AddWithValue("@nome", texnome.Text);

                //faz a leitura e o armazenamento desses dados
                using (SqlDataReader reader1 = sqlCommand.ExecuteReader())
                {
                    reader1.Read();

                    nome = (string)reader1["nomecliente"];
                    email = (string)reader1["emailcliente"];
                    cpf = (string)reader1["cpf"];
                }

                //define o caminho que o arquivo ficará salvo
                string Caminho = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                string NomeArquivo = "relatorio_" + texnome.Text + ".pdf";
                string CaminhoCompleto = Path.Combine(Caminho, NomeArquivo);
                FileStream ArquivoPDF = new FileStream(CaminhoCompleto, FileMode.Create);
                Document Documento = new Document(PageSize.A4);
                PdfWriter pdfwriter = PdfWriter.GetInstance(Documento, ArquivoPDF);

                string dados = "";

                //define o texto e a formatação do primeiro paragrafo
                Paragraph Paragrafo1 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, (int)System.Drawing.FontStyle.Bold));
                Paragrafo1.Alignment = Element.ALIGN_CENTER;
                Paragrafo1.Add("CAFETERIA");

                //define o texto e a formatação do segundo paragrafo
                Paragraph Paragrafo2 = new Paragraph(dados, new iTextSharp.text.Font(iTextSharp.text.Font.FontFamily.HELVETICA, 12, (int)System.Drawing.FontStyle.Regular));
                Paragrafo2.Alignment = Element.ALIGN_LEFT;
                Paragrafo2.Add("Dados do Usuário:\n" + "Nome: " + nome + "\nEmail: " + email + "\nCPF: " + cpf);

                //cria o documento
                Documento.Open();
                Documento.Add(Paragrafo1);
                Documento.Add(Paragrafo2);
                Documento.Close();

                //exibe que deu tudo certo
                MessageBox.Show(
                "O relatório foi criado com sucesso",
                "ATENÇÃO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Erro ao criar o relatório");
            }

        }


        private void texcpf_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            UpdateListView();
        }

        private void texbemial_TextChanged(object sender, EventArgs e)
        {

        }

        private void texnome_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }



        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void cliente_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void mtextsenha_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {



        }


        private void textcpf_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            Address tela = new Address();
            tela.ShowDialog();
        }
    }
}



