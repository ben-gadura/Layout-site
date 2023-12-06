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
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo rua não esta preenchido corretamente");
                _rua = value;

                _rua = value; }
        }
        public string numero
        {
            get { return _numero; }
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo numero não esta preenchido corretamente");
                _numero = value;
                _numero = value; }
        }

        public string bairro
        {
            get { return _bairro; }
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo bairro não esta preenchido corretamente");
                _bairro = value;

                _bairro = value; }
        }

        public string cidade 
        { 
            get { return _cidade; }
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo cidade não esta preenchido corretamente");
                _cidade = value;

                _cidade = value; } 
        } 


        public string estado  
        {  
            get { return _estado; }
            set {
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo estado não esta preenchido corretamente");
                _estado = value;

                _estado = value; }
        }


        public string telefone 
        { 
            get { return _telefone; }
            set{
                if (string.IsNullOrEmpty(value))
                    throw new Exception("O campo telefone não esta preenchido corretamente");
                _telefone = value;
                _telefone = value;
                } 
        }    

     

    }
}
