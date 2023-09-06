using layoutsite;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout_site
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {




            //string senha = mtextsenha.Text;
            //string email = texbemial.Text;
            //string nome = texnome.Text;
            //string cpf = texcpf.Text;

            //MessageBox.Show(
            //    "email: " + texbemial.Text
            //    +
            //    "nome: " + texnome.Text
            //    +
            //    "CPF: " + texcpf.Text,


            //    "OLHA AÍ AS INFORMAÇÃO",
            //    MessageBoxButtons.OK,
            //    MessageBoxIcon.Information);

            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"INSERT INTO cliente VALUES (@emailcliente, @nomecliente, @senha, @cpf)";
            sqlCommand.Parameters.AddWithValue("@emailcliente", texbemial.Text);
            sqlCommand.Parameters.AddWithValue("@nomecliente", texnome.Text);
            sqlCommand.Parameters.AddWithValue("@senha", mtextsenha.Text);
            sqlCommand.Parameters.AddWithValue("cpf", texcpf.Text);

            sqlCommand.ExecuteNonQuery();

            MessageBox.Show("Cadastrado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            texbemial.Clear();
            texnome.Clear();
            texcpf.Clear();
            mtextsenha.Clear();
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
    }
}
