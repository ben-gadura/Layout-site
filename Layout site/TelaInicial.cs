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
    public partial class TelaInicial : Form
    {
        public TelaInicial()
        {
            InitializeComponent();

        }

        private void TelaInicial_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = textBox1.Text;
            string senha = Util.CalculateMD5Hash(textBox2.Text);

            UserDAO user = new UserDAO();


            if (user.LoginUser(nome, senha))
            {
                Cardapio telas = new Cardapio();
                telas.ShowDialog();
            }

            else 
            {
                MessageBox.Show("Voce não tem uma conta ou preencheu algum campo incorretamente", "AVISO",
                MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }

            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 tela = new Form1();
            tela.ShowDialog();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            
        }
    }
    }

