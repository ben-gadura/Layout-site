using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Layout_site
{
    public partial class Address : Form
    {
        private int idaddress;
        public Address()
        {

            InitializeComponent();
        }
        private void UpdateListView()
        {
            Adress.Items.Clear();
            EndereçoDAO userDAO = new EndereçoDAO();
            List<Endereço> users = userDAO.SelectAddress();



            try
            {
                if (users.Count > 0)
                {
                    foreach (Endereço user in users)
                    {
                        ListViewItem lv = new ListViewItem(user.idaddress.ToString());
                        lv.SubItems.Add(user.rua);
                        lv.SubItems.Add(user.numero);
                        lv.SubItems.Add(user.bairro);
                        lv.SubItems.Add(user.cidade);
                        lv.SubItems.Add(user.estado);
                        lv.SubItems.Add(user.telefone);
                        Adress.Items.Add(lv);
                    }

                }

            }
            catch (Exception err)
            {
                MessageBox.Show(err.Message);
            }
        }


        private void rua_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void cliente_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index;
            index = Adress.FocusedItem.Index;
            idaddress = int.Parse(Adress.Items[index].SubItems[0].Text);
            texrua.Text = Adress.Items[index].SubItems[1].Text;
            texnumero.Text = Adress.Items[index].SubItems[2].Text;
            texbairro.Text = Adress.Items[index].SubItems[3].Text;
            texcidade.Text = Adress.Items[index].SubItems[4].Text;
            texestado.Text = Adress.Items[index].SubItems[5].Text;
            textelefone.Text = Adress.Items[index].SubItems[6].Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {


                Endereço user = new Endereço(idaddress, 
                    texrua.Text, 
                    texnumero.Text, 
                    texbairro.Text,
                    texcidade.Text, 
                    texestado.Text, 
                    textelefone.Text);



                EndereçoDAO userDAO = new EndereçoDAO();
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





            texrua.Clear();
            texnumero.Clear();
            texbairro.Clear();
            texcidade.Clear();
            texestado.Clear();
            textelefone.Clear();
            UpdateListView();

        }
    }
}
