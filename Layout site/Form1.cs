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
        private int id;
        public Form1()
        {
            InitializeComponent();
            UpdateListView();
        
        }
        private void UpdateListView()
        {
            cliente.Items.Clear();
            UserDAO userDAO = new UserDAO();
            List<User> users = userDAO.SelectUser();



            try
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
                    mtextsenha.Text,
                    texcpf.Text);

                UserDAO userDAO = new UserDAO();
                userDAO.InsertUser(user);
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);
            }
                

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

            MessageBox.Show("Atualizado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            texbemial.Clear();
            texnome.Clear();
            texcpf.Clear();
            mtextsenha.Clear();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            UserDAO userDAO = new UserDAO();
            userDAO.DeleteUser(id);

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


