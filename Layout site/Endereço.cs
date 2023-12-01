using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Layout_site
{
    internal class Endereço
    {
        private int _idaddress;
        private string _rua;
        private string _numero;
        private string _bairro;
        private string _cidade;
        private string _estado;
        private string _telefone;


        public Endereço(int idaddress, string rua, string numero, string bairro, string cidade, string estado, string telefone)
        {
            this.idaddress = idaddress;
            this.rua = rua;
            this.numero = numero;
            this.bairro = bairro;
            this.cidade = cidade;
            this.estado = estado;
            this.telefone = telefone;
        }

        public int idaddress {
            get { return _idaddress; }
            set { _idaddress = value; }
        }
        public string rua
        {
            get { return _rua; }
            set { _rua = value; }
        }
        public string numero
        {
            get { return _numero; }
            set { _numero = value; }
        }

        public string bairro
        {
            get { return _bairro; }
            set { _bairro = value; }
        }

        public string cidade { get { return _cidade; }
            set { _cidade = value; } } 


        public string estado  {  get { return _estado; }
            set { _estado = value; }
        }


        public string telefone { get { return _telefone; }
            set
            {
                _telefone = value;
            } }    

     

    }
}
