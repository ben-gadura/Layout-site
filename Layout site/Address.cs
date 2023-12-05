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
            UpdateListView();
        }
        private void UpdateListView()
        {
            Adress.Items.Clear();
            EndereçoDAO endereçoDAO = new EndereçoDAO();
            List<Endereço> endereços = endereçoDAO.SelectAddress();



            try
            {
                if (endereços.Count > 0)
                {
                    foreach (Endereço endereço in endereços)
                    {
                        ListViewItem lv = new ListViewItem(endereço.idaddress.ToString());
                        lv.SubItems.Add(endereço.rua);
                        lv.SubItems.Add(endereço.numero);
                        lv.SubItems.Add(endereço.bairro);
                        lv.SubItems.Add(endereço.cidade);
                        lv.SubItems.Add(endereço.estado);
                        lv.SubItems.Add(endereço.telefone);
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


                Endereço endereço = new Endereço(idaddress, 
                    texrua.Text, 
                    texnumero.Text, 
                    texbairro.Text,
                    texcidade.Text, 
                    texestado.Text, 
                    textelefone.Text);



                EndereçoDAO endereçoDAO = new EndereçoDAO();
                endereçoDAO.InsertAddress(endereço);

                MessageBox.Show("Cadastrado com sucesso",
                   "AVISO",
                   MessageBoxButtons.OK,
                   MessageBoxIcon.Information);

                texrua.Clear();
                texnumero.Clear();
                texbairro.Clear();
                texcidade.Clear();
                texestado.Clear();
                textelefone.Clear();
                UpdateListView();
            }
            catch (Exception erro)
            {
                MessageBox.Show(erro.Message);

            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Endereço user = new Endereço(idaddress, texrua.Text, texnumero.Text, texbairro.Text, texcidade.Text
        , texestado.Text
        , textelefone.Text);
            EndereçoDAO nomedoobj = new EndereçoDAO();
            nomedoobj.UpdateAdress(user);

            MessageBox.Show("Atualizado com sucesso",
                "AVISO",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);

            texrua.Clear();
            texnumero.Clear();
            texbairro.Clear();
            texcidade.Clear();
            texestado.Clear();
            textelefone.Clear();
            UpdateListView();
        }

        private void Address_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            EndereçoDAO endereçoDAO = new EndereçoDAO();
            endereçoDAO.DeleteAddress(idaddress);

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
