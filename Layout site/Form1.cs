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
using System.Xml.Linq;

namespace Layout_site
{
    
    public partial class Form1 : Form
    {
        private int Id;
        public Form1()
        {
            InitializeComponent();
            UpdateListView();
        }
        private void UpdateListView()
        {
            cliente.Items.Clear();

            Connection conn = new Connection();
            SqlCommand sqlCom = new SqlCommand();

            sqlCom.Connection = conn.ReturnConnection();
            sqlCom.CommandText = "SELECT * FROM cliente";

            try
            {
                SqlDataReader dr = sqlCom.ExecuteReader();

                while (dr.Read())
                {
                    Id = (int)dr["Id"];
                    string email = (string)dr["emailcliente"];
                    string name = (string)dr["nomecliente"];
                    string pass = (string)dr["senha"];
                    string cpf = (string)dr["cpf"];

                    ListViewItem lv = new ListViewItem(Id.ToString());


                    lv.SubItems.Add(email);
                    lv.SubItems.Add(name);
                    lv.SubItems.Add(pass);
                    lv.SubItems.Add(cpf);
                    cliente.Items.Add(lv);

                }
                dr.Close();
            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
            finally
            {
                conn.CloseConnection();
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {


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

            UpdateListView();
        }

        private void cliente_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {
            int index;
            index = cliente.FocusedItem.Index;
            Id = int.Parse(cliente.Items[index].SubItems[0].Text);
            texbemial.Text = cliente.Items[index].SubItems[1].Text;
            texnome.Text = cliente.Items[index].SubItems[2].Text;
            mtextsenha.Text = cliente.Items[index].SubItems[3].Text;
            texcpf.Text = cliente.Items[index].SubItems[4].Text;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UpdateListView();
        }


        private void button3_Click(object sender, EventArgs e)
        {
           
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"UPDATE cliente SET 
             emailcliente = @emailcliente, 
             nomecliente = @nomecliente,
             senha = @senha, 
             cpf = @cpf
             WHERE Id   = @id"
            ;

            sqlCommand.Parameters.AddWithValue("@emailcliente", texbemial.Text);
            sqlCommand.Parameters.AddWithValue("@nomecliente", texnome.Text);
            sqlCommand.Parameters.AddWithValue("@senha", mtextsenha.Text);
            sqlCommand.Parameters.AddWithValue("cpf", texcpf.Text);
            sqlCommand.Parameters.AddWithValue("@id", Id);


            sqlCommand.ExecuteNonQuery();

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
            Connection connection = new Connection();
            SqlCommand sqlCommand = new SqlCommand();

            sqlCommand.Connection = connection.ReturnConnection();
            sqlCommand.CommandText = @"DELETE FROM cliente WHERE Id = @Id";
            sqlCommand.Parameters.AddWithValue("@Id", Id);
            try
            {
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception err)
            {
                throw new Exception("Erro: Problemas ao excluir usuário no banco.\n" + err.Message);
            }
            finally
            {
                connection.CloseConnection();

            }

            texbemial.Clear();
            texnome.Clear();
            texcpf.Clear();
            mtextsenha.Clear();

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

        private void Form1_Load_1(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e)
        {

        }

        private void cliente_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

       
    }
}


